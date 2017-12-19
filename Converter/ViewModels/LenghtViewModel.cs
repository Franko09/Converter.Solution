using Converter.Models;
using Converter.ViewModels.Base;
using System.Collections.Generic;

namespace Converter.ViewModels
{
    /// <summury>
    /// 
    /// </summury>
    public class LenghtViewModel : ObservableObject, IConversion
    {
        private Unit from;

        private Unit to;

        private double convertFrom;

        private double convertTo;

        #region Public Properties

        public Unit From
        {
            get
            {
                return from;
            }
            set
            {
                SetAndNotify(ref from, value, () => from);
                ConvertTo = Convert(this.from, this.to, this.convertFrom);
            }
        }

        public Unit To
        {
            get { return to; }
            set
            {
                SetAndNotify(ref to, value, () => to);
                ConvertTo = Convert(this.from, this.to, this.convertFrom);
            }
        }

        public double ConvertFrom
        {
            get
            {
                return convertFrom;
            }
            set
            {
                SetAndNotify(ref convertFrom, value, () => convertFrom);
                ConvertTo = Convert(this.from, this.to, this.convertFrom);
            }
        }

        public double ConvertTo
        {
            get
            {
                return convertTo;
            }
            set
            {
                SetAndNotify(ref convertTo, value, () => convertTo);
            }
        }

        public List<Unit> UnitTypes { get; set; } = new List<Unit>
        {
            new Unit { Type = "Meters", Rate = 1 },
            new Unit { Type = "Centimeters", Rate = 100 },
            new Unit { Type = "Feet", Rate = 3.280839895013123 },
            new Unit { Type = "Inches", Rate = 39.37007874015748 },
        };

        #endregion

        #region Constructor

        /// <summury>
        /// Default Constructor
        /// </summury>
        public LenghtViewModel()
        {
            from = UnitTypes[0];
            to = UnitTypes[0];
        }

        #endregion


        public double Convert(Unit from, Unit to, double valueFrom)
        {
            double valueToWorkIn = 0;

            if (from.Type == "Meters")
            {
                valueToWorkIn = valueFrom;
            }
            else
            {
                valueToWorkIn = valueFrom / from.Rate;
            }
            if (to.Type != "Meters")
            {
                valueToWorkIn = valueFrom * to.Rate;
            }

            return valueToWorkIn;
        }
    }
}

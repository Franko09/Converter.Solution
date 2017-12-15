using Converter.Models;
using System.Collections.Generic;

namespace Converter.ViewModels
{
    /// <summury>
    /// 
    /// </summury>
    public class LenghtViewModel
    {
        #region Public Properties

        public decimal ConvertFrom { get; set; }

        public decimal ConvertTo { get; set; }

        public List<Lenght> UniteTypes { get; set; } = new List<Lenght>
        {
            new Lenght { Type = "Meters", Rate = 1 },
            new Lenght { Type = "Centimeters", Rate = 100 },
            new Lenght { Type = "Centimeters", Rate = 100 },
            new Lenght { Type = "Centimeters", Rate = 100 },
        };

        #endregion

        #region Constructor

        /// <summury>
        /// Default Constructor
        /// </summury>
        public LenghtViewModel()
        {
            
        }       

        #endregion

        private void Convert()
        {
            decimal ValueToWorkIn;

            if (true)
            {

            }
        }

    }
}

using Converter.DataModels;

namespace Converter.ViewModels
{
    /// <summury>
    /// 
    /// </summury>
    public class MainViewModel
    {
        #region Public Properties

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Lenght;

        public int WindowHeight { get; set; } = 250;

        public int WindowWidth { get; set; } = 300;

        #endregion

        #region Commands


        #endregion

        #region Constructor

        /// <summury>
        /// Default Constructor
        /// </summury>
        public MainViewModel()
        {

        }

        #endregion
    }
}

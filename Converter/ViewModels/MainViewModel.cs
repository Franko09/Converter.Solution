using Converter.DataModels;

namespace Converter.ViewModels
{
    /// <summury>
    /// 
    /// </summury>
    public class MainViewModel
    {
        #region Public Properties

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
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

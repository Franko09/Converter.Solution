using Converter.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.ViewModels
{
    class MainViewModel
    {
        #region Private Properties

        #endregion

        #region Public Properties 

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Lenght;

        /// <summary>
        /// Get the Width of the Window
        /// </summary>
        public int Width { get; } = 250;

        /// <summary>
        /// Get's the Height of the window
        /// </summary>
        public int Height { get; } = 150;

        #endregion

    }
}

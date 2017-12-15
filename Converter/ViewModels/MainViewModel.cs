using Converter.Models;
using Converter.ViewModels.Base;
using Converter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Converter.ViewModels
{
    /// <summury>
    /// 
    /// </summury>
    public class MainViewModel : ObservableObject
    {
        #region Private Properties

        private Category category;

        private Page currentPage;

        #endregion

        #region Public Properties

        /// <summary>
        /// Set's the Height of the Window
        /// </summary>
        public double WindowHeight { get; set; } = 250;

        /// <summary>
        /// Set's the Width of the Window
        /// </summary>
        public double WindowWidth { get; set; } = 400;

        public Page CurrentPage
        {
            get
            {
                return currentPage;
            }
            set
            {
                this.SetAndNotify(ref this.currentPage, value, () => this.currentPage);
            }
        }

        /// <summary>
        /// Get's or Set's the current category
        /// </summary>
        public Category Category
        {
            get
            {
                return category;
            }
            set
            {
                this.SetAndNotify(ref this.category, value, () => this.category);
            }
        }

        public List<Category> Categories { get; set; } = new List<Category>()
        {
            new Category { Name = "Lenght", Factor = 3.280839895013123f },
            new Category { Name = "Area", Factor = 10.763910416709722f},
        };

        #endregion

        #region Commands

        public ICommand QuiteCommand => new RelayCommand(x => Application.Current.MainWindow.Close());

        public ICommand SelectViewCommand { get; set; }

        private void SetView()
        {
            switch (Category.Name)
            {
                case "Lenght":
                    //return new LenghtView();
                    CurrentPage = new LenghtView();
                    break;
                case "Area":
                    //return new AreaView();
                    CurrentPage = new AreaView();
                    break;
                default:
                    //return new LenghtView();
                    CurrentPage = new LenghtView();
                    break;
            }
        }

        #endregion

        #region Constructor

        /// <summury>
        /// Default Constructor
        /// </summury>
        public MainViewModel()
        {
            Category = Categories.FirstOrDefault();
            SelectViewCommand = new RelayCommand(x => SetView());
        }

        #endregion


    }
}

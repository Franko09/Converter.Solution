using Converter.ViewModels;
using System.Windows.Controls;


namespace Converter.Views
{
    /// <summary>
    /// Interaction logic for LenghtView.xaml
    /// </summary>
    public partial class LenghtView : Page
    {
        public LenghtView()
        {
            InitializeComponent();

            this.DataContext = new LenghtViewModel();
        }
    }
}

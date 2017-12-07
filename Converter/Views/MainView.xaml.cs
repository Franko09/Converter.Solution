using Converter.ViewModels;

namespace Converter.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();
        }
    }
}

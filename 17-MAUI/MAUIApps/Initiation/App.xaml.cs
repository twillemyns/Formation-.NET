using Initiation.Layouts;
using Initiation.Pages;

namespace Initiation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoAbsoluteLayout();
        }
    }
}

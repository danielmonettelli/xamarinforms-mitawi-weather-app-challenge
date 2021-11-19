using Mitawi.Models;
using Mitawi.Services;
using Mitawi.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mitawi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}
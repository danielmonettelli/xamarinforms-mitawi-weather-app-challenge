using Mitawi.Utility;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mitawi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeDetailPage : ContentPage
    {
        public HomeDetailPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.HomeDetailViewModel;
        }
    }
}
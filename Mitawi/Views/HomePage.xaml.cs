using FFImageLoading.Forms;
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

        private void SelectedWeather_Tapped(object sender, System.EventArgs e)
        {
            VisualElement surfaceWeather = sender as VisualElement;
            StackLayout parent = surfaceWeather.Parent as StackLayout;

            foreach (View child in parent.Children)
            {
                VisualStateManager.GoToState(child, "Normal");
                ChangeSurfaceControls(child, false);
            }
            VisualStateManager.GoToState(surfaceWeather, "Selected");
            ChangeSurfaceControls(surfaceWeather, true);
        }

        private void ChangeSurfaceControls(VisualElement child, bool isSelected)
        {
            Label labelTemperature = child.FindByName<Label>("labelTemperature");
            CachedImage imageSmallWeather = child.FindByName<CachedImage>("imageSmallWeather");
            Label labelHour = child.FindByName<Label>("labelHour");

            string visualState = isSelected ? "Selected" : "Normal";
            VisualStateManager.GoToState(labelTemperature, visualState);
            VisualStateManager.GoToState(imageSmallWeather, visualState);
            VisualStateManager.GoToState(labelHour, visualState);
        }
    }
}
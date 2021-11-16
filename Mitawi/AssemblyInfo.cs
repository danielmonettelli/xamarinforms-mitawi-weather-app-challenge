using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

#region FontIcons Embedded
// CUSTOM FONT ICONS WITH "IcoMoon" and "Fontello"
[assembly: ExportFont("customfonticons.ttf", Alias = "CustomFontIcons")]
#endregion

#region FontFamily Embedded 
#region FONTFAMILY [Roboto]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "Roboto#700")]
[assembly: ExportFont("Roboto-Medium.ttf", Alias = "Roboto#500")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "Roboto#400")]
#endregion
#endregion
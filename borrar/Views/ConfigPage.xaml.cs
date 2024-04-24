using borrar.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace borrar.Views;

public sealed partial class ConfigPage : Page
{
    public ConfigViewModel ViewModel
    {
        get;
    }

    public ConfigPage()
    {
        ViewModel = App.GetService<ConfigViewModel>();
        InitializeComponent();
    }
}

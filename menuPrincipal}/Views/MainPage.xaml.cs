using menuPrincipal_.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace menuPrincipal_.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}

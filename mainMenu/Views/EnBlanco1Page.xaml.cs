using mainMenu.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace mainMenu.Views;

public sealed partial class EnBlanco1Page : Page
{
    public EnBlanco1ViewModel ViewModel
    {
        get;
    }

    public EnBlanco1Page()
    {
        ViewModel = App.GetService<EnBlanco1ViewModel>();
        InitializeComponent();
    }
}

using mainMenu.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace mainMenu.Views;

public sealed partial class EnBlanco2Page : Page
{
    public EnBlanco2ViewModel ViewModel
    {
        get;
    }

    public EnBlanco2Page()
    {
        ViewModel = App.GetService<EnBlanco2ViewModel>();
        InitializeComponent();
    }
}

using menuPrincipal_.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace menuPrincipal_.Views;

public sealed partial class EnBlancoPage : Page
{
    public EnBlancoViewModel ViewModel
    {
        get;
    }

    public EnBlancoPage()
    {
        ViewModel = App.GetService<EnBlancoViewModel>();
        InitializeComponent();
    }
}

using borrar.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace borrar.Views;

public sealed partial class UsuariosPage : Page
{
    public UsuariosViewModel ViewModel
    {
        get;
    }

    public UsuariosPage()
    {
        ViewModel = App.GetService<UsuariosViewModel>();
        InitializeComponent();
    }
}

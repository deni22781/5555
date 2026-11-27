using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace SPOUno;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnGreetClick(object sender, RoutedEventArgs e)
    {
        var name = NameInput.Text.Trim();
        ResultText.Text = name.Length == 0 ? "Введите имя." : $"Привет, {name}!";
    }
}

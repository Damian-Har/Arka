using Avalonia.Controls;
using Avalonia;

namespace Arka;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        var mainMenu = new StackPanel
        {
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
        };

        var playButton = new Button { Content = "Graj", Margin = new Thickness(7) };
        var optionsButton = new Button { Content = "Opcje", Margin = new Thickness(7) };
        var hallOfFameButton = new Button { Content = "Hala S³aw", Margin = new Thickness(7) };

        optionsButton.Click += OptionsButton_Click;
        hallOfFameButton.Click += HallOfFameButton_Click;

        mainMenu.Children.Add(playButton);
        mainMenu.Children.Add(optionsButton);
        mainMenu.Children.Add(hallOfFameButton);

        ContentArea.Content = mainMenu;
    }

    private void OptionsButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new OptionsView(this);
    }

    private void HallOfFameButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ContentArea.Content = new HallOfFameView(this);
    }

    public void GoBack()
    {
        ShowMainMenu();
    }
}
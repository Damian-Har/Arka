using Avalonia.Controls;

namespace Arka;

public partial class OptionsView : UserControl
{
    private readonly MainWindow _mainWindow;

    public OptionsView(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
    }

    private void BackButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _mainWindow.GoBack();
    }
}
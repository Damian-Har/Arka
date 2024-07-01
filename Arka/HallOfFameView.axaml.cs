using Avalonia.Controls;

namespace Arka;

public partial class HallOfFameView : UserControl
{
    private readonly MainWindow _mainWindow;

    public HallOfFameView(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
    }

    private void BackButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _mainWindow.GoBack();
    }
}
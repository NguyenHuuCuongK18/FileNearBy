using System.Windows;
using FileNearBy.Host.ViewModels;

namespace FileNearBy.Host.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new ShellViewModel();
    }
}

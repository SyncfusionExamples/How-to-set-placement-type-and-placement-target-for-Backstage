using Syncfusion.Windows.Tools.Controls;
using System.Windows;

namespace BackStage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ribbonBackStage.PlacementTarget = backstageGrid;
        }
    }
}

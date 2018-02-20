using MovementEllipse.Model;
using MovementEllipse.View;
using MovementEllipse.ViewModel;
using System.Windows;


namespace MovementEllipse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent( );

            var point = new MyPoint( );
            DataContext = new MainWindowViewModel(point);
            GraphicObject go = new GraphicObject(point);
            go.Show( );
        }
    }
}

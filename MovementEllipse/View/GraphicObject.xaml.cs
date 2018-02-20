using MovementEllipse.Model;
using MovementEllipse.ViewModel;
using System.Windows;


namespace MovementEllipse.View
{
    /// <summary>
    /// Логика взаимодействия для GraphicObject.xaml
    /// </summary>
    public partial class GraphicObject : Window
    {
        public GraphicObject(MyPoint point)
        {
            InitializeComponent( );

            DataContext = new GraphicObjectViewModel(point);
        }
    }
}

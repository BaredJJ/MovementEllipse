using MovementEllipse.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace MovementEllipse.ViewModel
{
    class GraphicObjectViewModel : INotifyPropertyChanged
    {
        readonly MyPoint _point;

        private event EventHandler myEvent;

        public double X
        {
            get { return _point.X; }
            set { _point.X = value; onPropertyChanged( ); }
        }

        public double Y
        {
            get { return _point.Y; }
            set { _point.Y = value; onPropertyChanged( ); }
        }

        public GraphicObjectViewModel(MyPoint point)
        {
            if (point == null)
                throw new ArgumentNullException("point");

            _point = point;
            _point.PropertyChanged += _point_PropertyChanged;
        }

        public ICommand EllipseMove
        {
            get
            {
                return new MyCommand(obj =>
                {
                    FrameworkElement element = obj as FrameworkElement;
                    Point point = Mouse.GetPosition(element);
                    X = point.X;
                    Y = point.Y;
                });
            }
        }

        private void _point_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            onPropertyChanged("X");
            onPropertyChanged("Y");
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged([CallerMemberName]string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

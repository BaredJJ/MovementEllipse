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

        /// <summary>
        /// Top property
        /// </summary>
        public double X
        {
            get { return _point.X; }
            set {
                if (value < 0)
                    _point.X = 0;
                else if (value > 300)
                    _point.X = 300;
                else _point.X = value;
                onPropertyChanged( );
            }
        }

        /// <summary>
        /// Left propery
        /// </summary>
        public double Y
        {
            get { return _point.Y; }
            set {
                if (value < 0)
                    _point.Y = 0;
                else if (value > 300)
                    _point.Y = 300;
                else _point.Y = value;
                onPropertyChanged( );
                }
        }

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="point">Model point instance</param>
        public GraphicObjectViewModel(MyPoint point)
        {
            if (point == null)
                throw new ArgumentNullException("point");

            _point = point;
            _point.PropertyChanged += _point_PropertyChanged;
        }

        /// <summary>
        /// Move command
        /// </summary>
        public ICommand EllipseMove
        {
            get
            {
                return new MyCommand(obj =>
                {
                    FrameworkElement element = obj as FrameworkElement;
                    Point point = Mouse.GetPosition(element);
                    X = point.X - 35;
                    Y = point.Y - 35;
                });
            }
        }

        /// <summary>
        /// Call back handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _point_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            onPropertyChanged("X");
            onPropertyChanged("Y");
        }

        /// <summary>
        /// NotifyPropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// NotifyPropertyChanged handler
        /// </summary>
        /// <param name="prop"></param>
        public void onPropertyChanged([CallerMemberName]string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

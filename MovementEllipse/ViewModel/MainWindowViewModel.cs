using MovementEllipse.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovementEllipse.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private MyPoint _point;

        public double X
        {
            get { return  _point.X; }
            set
            {
                _point.X = value;
                onPropertyChanged( );
            }
        }

        public double Y
        {
            get { return _point.Y; }
            set
            {
                _point.Y = value;
                onPropertyChanged( );
            }
        }

        public MainWindowViewModel(MyPoint point)
        {
            if (point == null)
                throw new ArgumentNullException("point");

            _point = point;
            _point.PropertyChanged += _point_PropertyChanged;
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

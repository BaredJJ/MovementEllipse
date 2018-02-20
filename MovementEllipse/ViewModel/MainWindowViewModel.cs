using MovementEllipse.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovementEllipse.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private MyPoint _point;

        /// <summary>
        /// X slider property
        /// </summary>
        public double X
        {
            get { return  _point.X; }
            set
            {
                _point.X = value;
                onPropertyChanged( );
            }
        }

        /// <summary>
        /// Y slider property
        /// </summary>
        public double Y
        {
            get { return _point.Y; }
            set
            {
                _point.Y = value;
                onPropertyChanged( );
            }
        }

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="point">Point instance</param>
        public MainWindowViewModel(MyPoint point)
        {
            if (point == null)
                throw new ArgumentNullException("point");

            _point = point;
            _point.PropertyChanged += _point_PropertyChanged;
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged([CallerMemberName]string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

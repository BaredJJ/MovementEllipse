using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MovementEllipse.Model
{
    public class MyPoint : INotifyPropertyChanged
    {
        private double _x;//Axis of abscissa
        private double _y;//Axis of ordinates

        /// <summary>
        /// Call back evant
        /// </summary>
        public EventHandler ChangeProperty;

        /// <summary>
        /// Adsciss property
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                onPropertyChanged( );
                Change( );
            }
        }

        /// <summary>
        /// Ordinate property
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                onPropertyChanged( );
                Change( );
            }
        }

        /// <summary>
        /// Call back function
        /// </summary>
        public void Change()
        {
            RaiseCnageProperty( );
        }

        /// <summary>
        /// Invoke method
        /// </summary>
        protected virtual void RaiseCnageProperty()
        {
            ChangeProperty?.Invoke(this, EventArgs.Empty);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged([CallerMemberName]string prop = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

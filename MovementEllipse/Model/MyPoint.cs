using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MovementEllipse.Model
{
    public class MyPoint : INotifyPropertyChanged
    {
        private double _x;
        private double _y;

        public EventHandler ChangeProperty;

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

        public void Change()
        {
            RaiseCnageProperty( );
        }


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

using System.ComponentModel;

namespace Ping_Pong
{
    class Player : INotifyPropertyChanged
    {
        private int _yposition;
        
        public int YPosition
        {
            get { return _yposition; }
            set
            {
                _yposition = value;
                OnPropertyChanged("YPosition");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

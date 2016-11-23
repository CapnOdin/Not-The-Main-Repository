namespace TrustedInstaller.Model {
    using System.ComponentModel;
    using System.Windows.Shapes;

    public abstract class Shape : System.Windows.Shapes.Shape, INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        // DEFAULT CONSTRUCTOR
        public Shape() {
            nameable = true;
            connectable = true;
            name = "";
            id = "";
        }

        public Shape(bool nameable = true, bool connectable = true, string name = "", string id = "") {
            if(nameable) {
                this.name = name;
            }
            this.nameable = nameable; this.connectable = connectable; this.id = id;
        }

        private string name {
            get; set;
        }
        private string id {
            get; set;
        }
        private bool nameable {
            get;
        }
        private bool connectable {
            get;
        }

        private void NotifyPropertyChanged(string propertyName) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

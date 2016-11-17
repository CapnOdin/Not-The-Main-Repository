namespace TrustedInstaller.Model {
    using System.ComponentModel;
    using System.Windows.Shapes;

    public abstract class ShapeModel : Shape, INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name {
            get; set;
        }
        private string ID {
            get; set;
        }

        private bool nameable = false;
        private bool connectable = false;

        public ShapeModel(bool nameable, bool connectable, string name = "", string ID = "") {
            if(nameable) {
                this.name = name;
            }
            this.nameable = nameable; this.connectable = connectable; this.ID = ID;
        }

        public bool isConnectable {
            get {
                return connectable;
            }
            set {
                connectable = value;
            }
        }

        public bool isNameable {
            get {
                return nameable;
            }
            set {
                nameable = value;
            }
        }

        private void NotifyPropertyChanged(string propertyName) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

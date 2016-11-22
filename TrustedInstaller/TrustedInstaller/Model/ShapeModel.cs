namespace TrustedInstaller.Model {
    using System.ComponentModel;
    using System.Windows.Shapes;

    public abstract class ShapeModel : Shape, INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public ShapeModel(bool nameable, bool connectable, string name = "", string ID = "") {
            if(nameable) {
                this.name = name;
            }
            this.nameable = nameable; this.connectable = connectable; this.ID = ID;
        }

        private string name {
            get; set;
        }
        private string ID {
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

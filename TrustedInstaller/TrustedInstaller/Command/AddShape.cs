namespace TrustedInstaller.Command {
    using System.Collections.ObjectModel;
    using TrustedInstaller.Model; 

    class AddShape : IUndoRedo {

        private ObservableCollection<Shape> shapes;
        private Shape shape;

        public AddShape(ObservableCollection<Shape> shapes, Shape shape) {
            this.shapes = shapes;
            this.shape = shape;
        }

        public void DoRedo() {
            shapes.Add(shape);
        }

        public void Undo() {
            shapes.Remove(shape);
        }
    }
}

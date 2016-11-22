namespace TrustedInstaller.Command {
    using System.Collections.ObjectModel;
    using TrustedInstaller.Model; 

    class AddShapeCommand : IUndoRedoCommand {

        private ObservableCollection<Shape> shapes;
        private Shape shape;

        public AddShapeCommand(ObservableCollection<Shape> shapes, Shape shape) {
            this.shapes = shapes;
            this.shape = shape;
        }

        public void Execute() {
            shapes.Add(shape);
        }

        public void UnExecute() {
            shapes.Remove(shape);
        }
    }
}

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using TrustedInstaller.Command;
using TrustedInstaller.Model;


namespace TrustedInstaller.ViewModel {
    
    class MainViewModel : ViewModelBase {

        private UndoRedoController undoRedoController = UndoRedoController.Instance;

        //private bool isAddingLine = false;
        //private Shape addingLineFrom;

        private Point initialMousePosition;
        private Point initialShapePosition;

        //public double ModeOpacity => isAddingLine ? 0.4 : 1.0;

        public ObservableCollection<Shape> shapes;

        public ICommand UndoCommand { get; }
        public ICommand RedoCommand { get; }

        // Commands that the UI can be bound to.
        public ICommand MouseDownShapeCommand { get; }
        public ICommand MouseMoveShapeCommand { get; }
        public ICommand MouseUpShapeCommand { get; }

        public MainViewModel() {

        }

    }
}

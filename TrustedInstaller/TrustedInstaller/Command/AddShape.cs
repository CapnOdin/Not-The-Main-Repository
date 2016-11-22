using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrustedInstaller.Command {
    class AddShape : IUndoRedo {

        public AddShape() {
            Console.WriteLine(TrustedInstaller.ViewModel.MainViewModel.kappa);
        }

        public void DoRedo() {
        }

        public void Undo() {
        }
    }
}

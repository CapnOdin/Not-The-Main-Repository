using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrustedInstaller.Command {
    interface IUndoRedoCommand {

        // The "Execute()" function of the example.
        void DoRedo();

        // The "UnExecute()" function of the example.
        void Undo();
    }
}

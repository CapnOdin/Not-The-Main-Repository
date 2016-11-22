using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrustedInstaller.Command {
    interface IUndoRedoCommand {

        // The "Execute()" function of the example.
        void Execute();

        // The "UnExecute()" function of the example.
        void UnExecute();
    }
}

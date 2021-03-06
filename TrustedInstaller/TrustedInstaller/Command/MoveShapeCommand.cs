﻿using System;

namespace TrustedInstaller.Command {
    using TrustedInstaller.Model;

    class MoveShapeCommand : IUndoRedoCommand {

        private Shape shape;

        private double offsetX;
        private double offsetY;

        public MoveShapeCommand(Shape shape, double offsetX, double offsetY) {
            this.shape = shape;
            this.offsetX = offsetX;
            this.offsetY = offsetY;
        }

        public void Execute() {
            throw new NotImplementedException();
        }

        public void UnExecute() {
            throw new NotImplementedException();
        }
    }
}

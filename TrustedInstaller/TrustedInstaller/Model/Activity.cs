namespace TrustedInstaller.Model {
    using System;
    using System.Windows;
    using System.Windows.Media;

    class Activity : ShapeModel {

        private double rectWidth = 60;
        private double rectHeight = 20;

        public Activity(bool nameable, bool connectable, string name = "", string ID = "") : base(nameable, connectable, name, ID) {

        }

        protected override Geometry DefiningGeometry {
            get {
                Rect rect = new Rect(0, 0, this.RectWidth, this.RectHeight);
                Geometry g = new RectangleGeometry(rect);
                return g;
            }
        }

        public double RectWidth {
            get {
                return rectWidth;
            }
            set {
                rectWidth = value;
            }
        }

        public double RectHeight {
            get {
                return rectHeight;
            }
            set {
                rectHeight = value;
            }
        }

    }
}

using System;
using System.Windows;
using System.Windows.Media;

namespace TrustedInstaller.Model {

    class Activity : Shape {

        private string text { get; set; }

        public double activityWidth { get; set; }
        public double activityHeight { get; set; }

        private Rect rect;

        public Activity() {
            activityWidth = 100;
            activityHeight = 100;
            rect = new Rect(0, 0, activityWidth, activityHeight);
        }

        protected override Geometry DefiningGeometry {
            get {
                RectangleGeometry g = new RectangleGeometry(rect);
                g.RadiusX = 20; g.RadiusY = 20;
                return g;
            }
        }
    }
}

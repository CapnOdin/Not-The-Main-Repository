namespace TrustedInstaller.Model {
    using System;
    using System.Windows;
    using System.Windows.Media;

    class Activity : ShapeModel {

        public static readonly DependencyProperty RectWidthProperty = DependencyProperty.Register("Width", typeof(Double), typeof(Activity), new PropertyMetadata(0.0));
        public static readonly DependencyProperty RectHeightProperty = DependencyProperty.Register("Length", typeof(Double), typeof(Activity), new PropertyMetadata(0.0));

        public Activity(bool nameable, bool connectable, string name = "", string ID = "") : base(nameable, connectable, name, ID) {

        }

        protected override Geometry DefiningGeometry {
            get {
                Rect rect = new Rect(0, 0, this.RectWidth, this.RectHeight);
                Geometry g = new RectangleGeometry(rect);
                return g;
            }
        }

        public Double RectHeight {
            get {
                return (Double)this.GetValue(RectHeightProperty);
            }
            set {
                this.SetValue(RectHeightProperty, value);
            }
        }

        public Double RectWidth {
            get {
                return (Double)this.GetValue(RectWidthProperty);
            }
            set {
                this.SetValue(RectWidthProperty, value);
            }
        }

    }
}

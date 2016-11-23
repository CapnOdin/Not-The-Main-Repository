namespace TrustedInstaller.Model {
	using System.Windows;
	using System.Windows.Media;
    using System.Windows.Shapes;
    

	class Activity : Shape {

        private Rectangle rect = new Rectangle();

        public Activity() {
            rect.Stroke = System.Windows.Media.Brushes.Black;
            rect.Fill = System.Windows.Media.Brushes.SkyBlue;
            rect.HorizontalAlignment = HorizontalAlignment.Center;
            rect.VerticalAlignment = VerticalAlignment.Center;
            rect.RadiusX = 5;
            rect.RadiusY = 5;
            rect.Height = 50;
            rect.Width = 100;
        }

		public Activity(bool nameable, bool connectable, string name = "", string ID = "") : base(nameable, connectable, name, ID) {

		}

		protected override Geometry DefiningGeometry {
			get {
                
				Geometry g = new RectangleGeometry(rect);
				return g;
			}
		}

		public double RectX {
			get { return rect.X; }
			set { rect.X = value; }
		}

		public double RectY {
			get { return rect.Y; }
			set { rect.Y = value; }
		}

		public double RectWidth {
			get { return rect.Width; }
			set { rect.Width = value; }
		}

		public double RectHeight {
			get { return rect.Height; }
			set { rect.Height = value; }
		}

	}
}

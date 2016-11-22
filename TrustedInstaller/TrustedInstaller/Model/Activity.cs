namespace TrustedInstaller.Model {
	using System.Windows;
	using System.Windows.Media;

	class Activity : Shape {

		private double rectWidth = 60;
		private double rectHeight = 20;

		private Rect rect = new Rect(0, 0, 0, 0);

		public Activity(bool nameable, bool connectable, string name = "", string ID = "") : base(nameable, connectable, name, ID) {

		}

		protected override Geometry DefiningGeometry {
			get {
				Geometry g = new RectangleGeometry(rect);
				return g;
			}
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

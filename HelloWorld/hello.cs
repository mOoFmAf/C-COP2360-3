
using System;
using System.Windows.Forms;

namespace Hi {
	class Hello {

		public static int square(int a) {
			return a * a;
		}

		public static void Main(string[] args) {
			Console.WriteLine("Hello, World: " + square(2));
			square(100);
			
			Form form = new Form();
			Button b = new Button()
			{
				Text = "Hello",
				Location = new System.Drawing.Point(10, 10)
			};
			b.Click += (o, s) => {
				MessageBox.Show("World");
			};
			
			form.Controls.Add(b);
			form.ShowDialog();
			
			while(form.Created) {
				
			}
		}
	}
}

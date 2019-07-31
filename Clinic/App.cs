using System;
using System.Threading.Tasks;
using Clinic.windows.mainWindow;

namespace Clinic {
	public class App {
		public static bool exit = false;

		private static void Main(string[] args) {
//			log("Yo");
			new CustomView().Show();

			Task.Factory.StartNew(() => {
															while (Console.ReadKey().Key != ConsoleKey.Escape) ;
															exit = true;
														});
			while (!exit) { }
		}
	}
}
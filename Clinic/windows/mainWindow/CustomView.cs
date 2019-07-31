using System;
using Clinic.utils;

namespace Clinic.windows.mainWindow {
	public class CustomView : ICustomView {
		private readonly CustomViewController controller;

		public CustomView() {
			controller = new CustomViewController(this);
			var handler = new CustomEventHandler();
			handler.onAPressed += ShowAnalyzes;
			handler.onLPressed += ShowLabs;
			handler.startHandle();
		}

		public void Show() { controller.showData(); }

		public void ShowAnalyzes() { controller.ShowAnalyzes(); }

		public void ShowLabs() { controller.ShowLabs(); }

		public void print(string text) { Console.WriteLine(text); }

		public void clear() { Console.Clear(); }
	}
}
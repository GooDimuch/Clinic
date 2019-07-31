using System;
using System.Threading.Tasks;

namespace Clinic.utils {
	public class CustomEventHandler {
		public delegate void OnAPressed();

		public event OnAPressed onAPressed;

		public delegate void OnLPressed();

		public event OnLPressed onLPressed;

		public CustomEventHandler() { }

		public void startHandle() {
			Task.Run(() => {
								while (!App.exit) {
									var temp = Console.ReadKey().Key;

									switch (temp) {
										case ConsoleKey.A:
											onAPressed?.Invoke();
											break;

										case ConsoleKey.L:
											onLPressed?.Invoke();
											break;
									}
								}
							});
		}
	}
}
using System.Diagnostics;

namespace Clinic.utils {
	public class Utils {
		private static void log(object message = null) { Debug.Write($"{message ?? "\n"}"); }
	}
}
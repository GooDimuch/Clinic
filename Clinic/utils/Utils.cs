using System.Diagnostics;

namespace Clinic.utils {
	public static class Utils {
		public static void log(object message = null) { Debug.WriteLine($"{message ?? "\n"}"); }
	}
}
using System;
using Newtonsoft.Json;

namespace Clinic.utils {
	public static class JsonHelper {
		public static T DeserializeObject<T>(string json) {
			T lab = default;
			try { lab = JsonConvert.DeserializeObject<T>(json); } catch (Exception e) { Utils.log(e); }
			return lab;
		}
	}
}
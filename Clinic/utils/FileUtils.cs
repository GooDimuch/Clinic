using System;
using System.IO;
using Newtonsoft.Json;

namespace Clinic.utils {
	public static class FileUtils {
		public static string GetStringFromFile(string filePath) {
			string content = string.Empty;
			try { content = File.ReadAllText(filePath); } catch (Exception e) { Console.WriteLine(e); }
			return content;
		}

		public static T GetModelFromFile<T>(string localPath) {
			try {
				string json = GetStringFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, localPath));
				var result = JsonHelper.DeserializeObject<T>(json);
				return result;
			} catch (Exception e) {
				Utils.log(e);
				return default;
			}
		}
	}
}
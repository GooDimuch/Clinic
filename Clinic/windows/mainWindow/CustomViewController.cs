using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.dataModels;
using Clinic.utils;

namespace Clinic.windows.mainWindow {
	public class CustomViewController {
		private readonly ICustomView view;
		private List<Analyze> _analyzes;
		private readonly List<Lab> _labs;

		public CustomViewController(ICustomView customView) {
			view = customView;
			_analyzes = FileUtils.GetModelFromFile<Analyze[]>(Constants.FilePath.LAB_PATH).ToList();
			_labs = FileUtils.GetModelFromFile<Lab[]>(Constants.FilePath.LAB_PATH).ToList();
		}

		public void method() { }

		public void showData() {
			var sb = new StringBuilder();
			_labs.ForEach((lab => { sb.AppendLine(lab.phone.phone_1); }));
			view.print(sb.ToString());
		}

		public void ShowAnalyzes() {
			var sb = new StringBuilder();
			_analyzes.ForEach((analyze => { sb.AppendLine(analyze.ToString()); }));
			view.clear();
			view.print(sb.ToString());
		}

		public void ShowLabs() {
			var sb = new StringBuilder();
			_labs.ForEach((lab => { sb.AppendLine(lab.ToString()); }));
			view.clear();
			view.print(sb.ToString());
		}
	}
}
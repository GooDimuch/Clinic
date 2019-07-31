using System.Text;

namespace Clinic.dataModels {
	public class Lab {
		public Address address { get; set; }
		public bool enabled { get; set; }
		public bool deleted { get; set; }
		public bool is_kiev { get; set; }
		public Phone phone { get; set; }
		public object pos_created { get; set; }
		public Schedule schedule { get; set; }
		public int id { get; set; }
		public int company_id { get; set; }
		public string zip { get; set; }
		public double gps_lat { get; set; }
		public double gps_long { get; set; }
		public string city { get; set; }
		public string region_name { get; set; }
		public bool is_open { get; set; }
		public double km { get; set; }

		public override string ToString() {
			var sb = new StringBuilder();
			sb.AppendLine($"address {address}");
			sb.AppendLine($"enabled {enabled}");
			sb.AppendLine($"deleted {deleted}");
			sb.AppendLine($"is_kiev {is_kiev}");
			sb.AppendLine($"phone {phone}");
			sb.AppendLine($"pos_created {pos_created}");
			sb.AppendLine($"schedule {schedule}");
			sb.AppendLine($"id {id}");
			sb.AppendLine($"company_id {company_id}");
			sb.AppendLine($"zip {zip}");
			sb.AppendLine($"gps_lat {gps_lat}");
			sb.AppendLine($"gps_long {gps_long}");
			sb.AppendLine($"city {city}");
			sb.AppendLine($"region_name {region_name}");
			sb.AppendLine($"is_open {is_open}");
			sb.AppendLine($"km {km}");
			sb.AppendLine();
			return sb.ToString();
		}
	}
}
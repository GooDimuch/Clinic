using System.Text;

namespace Clinic.dataModels {
	public class Analyze {
		public bool is_kiev { get; set; }
		public bool urgent { get; set; }
		public int price { get; set; }
		public int company_id { get; set; }
		public int sale_price { get; set; }
		public string currency { get; set; }
		public bool partner { get; set; }
		public int id { get; set; }
		public string name { get; set; }
		public string short_name { get; set; }

		public override string ToString() {
			var sb = new StringBuilder();
			sb.AppendLine($"is_kiev {is_kiev}");
			sb.AppendLine($"urgent {urgent}");
			sb.AppendLine($"price {price}");
			sb.AppendLine($"company_id {company_id}");
			sb.AppendLine($"sale_price {sale_price}");
			sb.AppendLine($"currency {currency}");
			sb.AppendLine($"partner {partner}");
			sb.AppendLine($"id {id}");
			sb.AppendLine($"name {name}");
			sb.AppendLine($"short_name {short_name}");
			sb.AppendLine();
			return sb.ToString();
		}
	}
}
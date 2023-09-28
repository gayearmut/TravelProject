using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Classes
{
	public class AdresBlog
	{
		[Key]
		public int ID { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
		public string Adres { get; set; }
		public string Email { get; set;}
		public string Telefon { get;set; }
		public string Konum { get; set; }

	}
}

using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Classes
{
	public class Contact
	{
		[Key]
		public int ID { get; set; }
		public string AdSoyad { get; set; }
		public string Email { get; set; }
		public string Konu { get; set; }
		public string Mesaj { get; set; }

	}
}

using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Classes
{
	public class Hakkimizda
	{
		[Key]
		public int ID { get; set; }
		public string FotoUrl { get; set; }
		public string Aciklama { get; set; }
	}
}

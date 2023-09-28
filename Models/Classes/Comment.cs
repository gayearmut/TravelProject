using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Classes
{
	public class Comment
	{
		[Key]
		public int ID { get; set; }
		public string KullaniciAdi { get; set; }
		public string Email { get; set; }
		public string Yorum { get; set; }
		public int Blogid { get; set; }
		public virtual Blog Blog { get; set; }

	}
}

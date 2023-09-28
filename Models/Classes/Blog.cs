﻿using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Classes
{
	public class Blog
	{
		[Key]
		public int ID { get; set; }
        public string Baslik { get; set; }
		public DateTime Tarih { get; set; }
		public string Aciklama { get; set; }
		public string BlogImage { get; set;}
		public ICollection <Comment> Comments { get; set; }


	}
}

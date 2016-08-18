namespace Zelda.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public enum Categories {
		Sotsiaalmeedia,
		Sport,
		Huumor,
		Uudised,
		Muu
	}

	[Table("Website")]
	public partial class Website {

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public short Id { get; set; }

		[StringLength(50, ErrorMessage = "V�li ei tohi �letada 50 karakterit")]
		[DisplayName("Omanik")]
		public String Owner { get; set; }

		[Required(ErrorMessage = "V�li ei tohi olla t�hi")]
		[StringLength(50, ErrorMessage = "V�li ei tohi �letada 50 karakterit")]
		[DataType(DataType.Url, ErrorMessage = "Antud v�li peab sisaldama URL-i")]
		[DisplayName("URL")]
		[Url(ErrorMessage = "N�ide: http://foo.bar")]
		public string URL { get; set; }

		[DisplayName("Kirjeldus")]
		[MaxLength(250, ErrorMessage = "V�li ei tohi olla pikem kui 250 karakterit")]
		public string Description { get; set; }

		[Required(ErrorMessage = "V�li ei tohi olla t�hi")]
		[Range(1, 10, ErrorMessage = "Skoor peab j��ma 1 ja 10 vahele")]
		[DisplayName("Skoor")]
		public int Score { get; set; }

		[Required(ErrorMessage = "V�li ei tohi olla t�hi")]
		[StringLength(50, ErrorMessage = "V�li ei tohi �letada 50 karakterit")]
		[DisplayName("Pealkiri")]
		public string Title { get; set; }

		[Required(ErrorMessage = "V�li ei tohi olla t�hi")]
		[DisplayName("Kategooria")]
		public Categories? Category { get; set; }
	}
}

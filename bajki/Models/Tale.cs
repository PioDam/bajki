using System.ComponentModel.DataAnnotations;

namespace bajki.Models
{
    public class Tale
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
		
        public string? Title { get; set; }

        [StringLength(2000)]
        public string? Description { get; set; }

		[StringLength(2000)]
		public string? Miniature { get; set; }

		[StringLength(2000)]
		public string? Picture { get; set; }

		[StringLength(2000)]
		public string? Paragraph1 { get; set; }

		[StringLength(2000)]
		public string? Paragraph2 { get; set; }

		[StringLength(2000)]
		public string? Paragraph3 { get; set; }

		[StringLength(2000)]
		public string? Paragraph4 { get; set; }

		[StringLength(2000)]
		public string? Paragraph5 { get; set; }

		[StringLength(2000)]
		public string? Paragraph6 { get; set; }

		[StringLength(2000)]
		public string? Paragraph7 { get; set; }

		[StringLength(2000)]
		public string? Paragraph8 { get; set; }

		[StringLength(2000)]
		public string? Paragraph9 { get; set; }

		public int OrderID {get; set;}

        public DateTime CreateTime { get; set;}





    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2
{
    public class Post
    {
        public int id { get; set; }

        [StringLength(50)]
        public string title { get; set; }

		[StringLength(50)]
		public string? breif { get; set; }

		[StringLength(50)]
		public string? desc { get; set; }

		[Column(TypeName = "date")]
		public DateTime? date { get; set; }

		public TimeSpan? time { get; set; }

		[ForeignKey("Author")]
        public int? AuthorID { get; set; }
        public virtual Author Author { get; set; }

        [ForeignKey("Catalog")]
        public int? CatID { get; set; }
        public virtual Catalog Catalog { get; set; }
    }
}

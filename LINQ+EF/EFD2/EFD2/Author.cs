using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2
{
    public class Author
    {
        public int id { get; set; }

		[StringLength(50)]
		public string username { get; set; }

		[StringLength(50)]
		public string password { get; set; }

		[StringLength(50)]
		public string? email { get; set; }
        public int? age { get; set; }

        public virtual List<Post> posts { get; set; } = new List<Post>();

    }
}

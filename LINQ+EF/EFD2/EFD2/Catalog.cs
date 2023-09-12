using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2
{
    public class Catalog
    {
        public int id { get; set; }

		[StringLength(50)]
		public string name { get; set; }

        [StringLength(50)]
		public string? desc { get; set; }
        public virtual List<Post> posts { get; set; } = new List<Post>();

    }
}

using System.ComponentModel.DataAnnotations;

namespace MVCPRO.VwModels
{
    public class RoleViewModel
    {
        [Required]
        public string role { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MVCPRO.VwModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool rememberMe { get; set; }
    }
}

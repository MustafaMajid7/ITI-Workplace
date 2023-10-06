using System.ComponentModel.DataAnnotations;

namespace MVCPRO.VwModels
{
	public class RegisterModel
	{
        [Required]
        public string UserName { get; set; }

        [Required]
		[DataType(dataType: DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password")]
        [DataType(dataType:DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Address { get; set; }
    }
}

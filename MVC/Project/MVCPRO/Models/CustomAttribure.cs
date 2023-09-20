using System.ComponentModel.DataAnnotations;

namespace MVCPRO.Models
{
    public class CustomAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string name = (string)value;
            InstituteCTX instituteCTX = new InstituteCTX();
            return !instituteCTX.Courses.Any(x => x.name == name);
        }
    }
}

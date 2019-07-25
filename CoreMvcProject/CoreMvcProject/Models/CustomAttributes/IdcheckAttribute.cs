using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProject.Models.CustomAttributes
{
    public class IdcheckAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value,ValidationContext validationContext)
        {
            var _context = (CoreMvcProjectContext)validationContext.GetService(typeof(CoreMvcProjectContext));
            var user =_context.User.FirstOrDefault(u => u.UserId.Equals(value));

            if (user != null)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
        public string GetErrorMessage()
        {
            return $"이미존재하는 아이디입니다.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProject.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="ID는 필수 값 입니다.")]
        [Display(Name ="ID")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "ID는 필수 값 입니다.")]
        [Display(Name ="PW")]
        [DataType(DataType.Password)]
        public string UserPw { get; set; }

        [Required(ErrorMessage = "ID는 필수 값 입니다.")]
        [Display(Name ="Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "ID는 필수 값 입니다.")]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime UserRegisterDate { get; set; }
        
    }
}

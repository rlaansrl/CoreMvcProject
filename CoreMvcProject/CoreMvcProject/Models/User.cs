using CoreMvcProject.Models.CustomAttributes;
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

        [Required(ErrorMessage ="아이디 필수 값 입니다.")]
        [Display(Name ="ID")]
        [IdcheckAttribute]
        public string UserId { get; set; }

        [Required(ErrorMessage = "패스워드 필수 값 입니다.")]
        [Display(Name ="PW")]
        [DataType(DataType.Password)]
        public string UserPw { get; set; }

        [Required(ErrorMessage = "이름 필수 값 입니다.")]
        [Display(Name ="Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "이메일은 필수 값 입니다.")]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime UserRegisterDate { get; set; }
        
    }
}

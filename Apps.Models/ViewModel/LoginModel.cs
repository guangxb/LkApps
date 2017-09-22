using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.ViewModel
{
    public class LoginModel
    {
        [DisplayName("用户名"),Required(ErrorMessage ="用户名为空")]
        public string LoginName { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("密码"), Required(ErrorMessage = "密码为空")]
        public string Password { get; set; }
        [DisplayName("验证码"), Required(ErrorMessage = "验证码为空")]
        public string LoginCode { get; set; }
    }
}

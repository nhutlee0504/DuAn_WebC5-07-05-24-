using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA_WebC5.Models
{
    public class Account
    {
        [Key, Column(TypeName = "varchar(20)"), Required(ErrorMessage = "Vui lòng nhập tên tài khoản")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu"), Column(TypeName = "varchar(50)")]
        [MinLength(8, ErrorMessage = "Mật khẩu phải chứa ít nhất 8 kí tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email"), EmailAddress(ErrorMessage = "Email không đúng định dạng"), Column(TypeName = "varchar(150)")]
        public string Email { get; set; }

        [Required, Column(TypeName = "nvarchar(20)")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn giới tính"), Column(TypeName = "nvarchar(3)")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại"), Column(TypeName = "varchar(12)"), MaxLength(10)]
        [Phone(ErrorMessage = "Số điện thoại không đúng định dạng"), RegularExpression(@"^(0\d{9}|84\d{9})$", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ"), Column(TypeName = "ntext")]
        public string Address { get; set; }

        public ICollection<Cart> carts { get; set; }

        public ICollection<History> histories { get; set; }

        public ICollection<Bill> bills { get; set; }

        public ICollection<SaleDetails> SaleDetails { get; set; }
        public ICollection<Evaluate> evaluates { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCLAB5.Models
{
    public class MbaAccount : Controller
    {
        [Key]
        public int Id { get; set; }

        [
        Display(Name = "Họ và tên"),
        Required(ErrorMessage = "Họ không được để trống"),
        MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự"),
        MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")
        ]

        public string FullName { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng")]
        [DataType(DataType.EmailAddress)]
        public string MbaEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string MbaPhone { get; set; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [MaxLength(100, ErrorMessage = "Địa chỉ tối đa 100 ký tự")]
        public string MbaAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string MbaAvatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string MbaGender { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MinLength(6, ErrorMessage = "Mật khẩu ít nhất là 6 ký tự")]
        [DataType(DataType.Password)]
        public string MbaPassword { get; set; }

        [Display(Name = "Facebook")]
        [Url(ErrorMessage = "Đường dẫn Facebook không hợp lệ")]
        public string MbaFacebook { get; set; }




    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace MaiBinhAn_2310900001.Models
{
    public class MbaEmployee
    {
        [Key]
        public int MbaEmpId { get; set; }

        [Required(ErrorMessage = "Tên không được bỏ trống")]
        [Display(Name = "Tên nhân viên")]
        public string MbaEmpName { get; set; }

        [Display(Name = "Cấp bậc")]
        public string MbaEmpLevel { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày bắt đầu")]
        public DateTime MbaEmpStartDate { get; set; }

        [Display(Name = "Trạng thái")]
        public bool MbaEmpStatus { get; set; }
    }
}

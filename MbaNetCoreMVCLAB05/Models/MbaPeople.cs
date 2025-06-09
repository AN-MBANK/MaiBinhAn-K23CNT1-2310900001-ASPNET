namespace MbaNetCoreMVCLAB05.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MbaPeople
    {
        public int MbaID { get; set; }

        [Display(Name = "Họ và tên")]
        public string MbaName { get; set; }

        [Display(Name = "Địa chỉ email")]
        public string MbaEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        public string MbaPhone { get; set; }

        [Display(Name = "Địa chỉ")]
        public string MbaAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string MbaAvatar { get; set; }

        [Display(Name = "Ngày sinh nhật")]
        public DateTime MbaBirthday { get; set; }

        [Display(Name = "Giới thiệu")]
        public string MbaBio { get; set; }

        [Display(Name = "Giới tính")]
        public byte MbaGender { get; set; }
    }
}

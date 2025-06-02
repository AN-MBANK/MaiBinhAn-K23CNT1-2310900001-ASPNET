namespace MbaLesson07.Models
{
    public class MbaEmployee
    {
        public int MbaId { get; set; }              // Mã nhân viên
        public string MbaName { get; set; }         // Họ tên
        public DateTime MbaBirthDay { get; set; }   // Ngày sinh
        public string MbaEmail { get; set; }        // Email
        public string MbaPhone { get; set; }        // Số điện thoại
        public decimal MbaSalary { get; set; }      // Lương
        public bool MbaStatus { get; set; }         // Trạng thái (true = đang làm việc, false = nghỉ việc)
    }
}

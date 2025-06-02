using System.ComponentModel.DataAnnotations;

namespace MbaLesson07.Models
{
    public class MbaMember
    {
        public int mbaId { get; set; }
        public string mbaName { get; set; }
        public string mbaUserName { get; set; }
        public string mbaPassword { get; set; } // Add this property to fix the error  
        public string mbaEmail { get; set; }
        public bool mbaStatus { get; set; }
    }
}

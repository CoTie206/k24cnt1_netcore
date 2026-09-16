using System.ComponentModel;

namespace HctLesson08Models.Models
{
    public class HctMember
    {
        public string HctMemberId { get; set; }
        public string HctUserName { get;set; }
        public string HctPassword { get; set; }

        [DisplayName("Họ và tên")]
        public string HctFullName { get; set; }
        public string HctEmail { get; set; }
    }

}

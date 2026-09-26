using System;
using System.Collections.Generic;
namespace HoangCongTien2410900073_exam.Models
{
    public class HctStudent
    {
        public long Id { get; set; }
        public string HctName { get; set; }
        public string HctGender { get; set; }
        public DateTime HctBirthDay { get; set; }
        public string HctEmail { get; set; }
        public string HctPhone { get; set; }
        public bool HctActive { get; set; }
    }
}

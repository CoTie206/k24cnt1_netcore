using Microsoft.AspNetCore.Mvc;
using HctLession04Lab.Models;

namespace HctLession04Lab.Controllers
{
    public class HctAccountController : Controller
    {
        private readonly List<HctAccount> hctAccounts = new()
        {
            new HctAccount
            {
                Id = 1,
                Name = "Nguyễn Văn An",
                Email = "nguyenvanan@gmail.com",
                Phone = "0912345678",
                Avatar = "/images/1.jpg",
                Address = "Hà Nội",
                Bio = "Sinh viên ngành Công nghệ thông tin",
                Gender = 1,
                Birthday = new DateTime(2004, 5, 12)
            },

            new HctAccount
            {
                Id = 2,
                Name = "Trần Thị Mai",
                Email = "tranthimai@gmail.com",
                Phone = "0987654321",
                Avatar = "/images/2.png",
                Address = "Hải Phòng",
                Bio = "Yêu thích thiết kế và nhiếp ảnh",
                Gender = 0,
                Birthday = new DateTime(2003, 8, 25)
            },

            new HctAccount
            {
                Id = 3,
                Name = "Lê Minh Tuấn",
                Email = "leminhtuan@gmail.com",
                Phone = "0901234567",
                Avatar = "/images/3.jpg",
                Address = "Đà Nẵng",
                Bio = "Lập trình viên .NET",
                Gender = 1,
                Birthday = new DateTime(2000, 3, 18)
            },

            new HctAccount
            {
                Id = 4,
                Name = "Phạm Ngọc Linh",
                Email = "phamngoclinh@gmail.com",
                Phone = "0934567890",
                Avatar = "/images/4.jpg",
                Address = "Hồ Chí Minh",
                Bio = "Quan tâm đến công nghệ và kinh doanh",
                Gender = 0,
                Birthday = new DateTime(2002, 11, 7)
            }
        };
        public IActionResult HctIndex()
        {
           ViewBag.HctAccounts = hctAccounts;
            return View();
        }
        [Route("ho-so-cua-toi",Name ="HctProfile")]
        public IActionResult HctProfile(int? id)
        {

            HctAccount hctAccount = new HctAccount
            {
                Id = 4,
                Name = "Phạm Ngọc Linh",
                Email = "phamngoclinh@gmail.com",
                Phone = "0934567890",
                Avatar = "/images/4.jpg",
                Address = "Hồ Chí Minh",
                Bio = "Quan tâm đến công nghệ và kinh doanh",
                Gender = 0,
                Birthday = new DateTime(2002, 11, 7)
            };
            if (id !=null)
                hctAccount=hctAccounts.FirstOrDefault(x=>x.Id == id);

            ViewBag.HctAccount = hctAccount;
            return View();
        }
    }
}

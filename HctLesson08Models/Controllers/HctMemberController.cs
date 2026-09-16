using Microsoft.AspNetCore.Mvc;
using HctLesson08Models.Models;

namespace HctLesson08Models.Controllers
{
    public class HctMemberController : Controller
    {
        // Mock data - HctMember
        private static List<HctMember> _members = new List<HctMember>()
        {
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "hctien",
                HctPassword = "Password123!",
                HctFullName = "Hoàng Công Tiến",
                HctEmail = "hctien@example.com"
            },
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "tranthib",
                HctPassword = "SecurePass456#",
                HctFullName = "Trần Thị B",
                HctEmail = "tranthib@outlook.com"
            },
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "levanc",
                HctPassword = "MyPassword789$",
                HctFullName = "Lê Văn C",
                HctEmail = "levanc@company.com"
            }
        };

        // GET: Danh sách thành viên
        public IActionResult Index()
        {
            return View(_members);
        }

        [HttpGet]
        public IActionResult HctCreate()
        {
            var member = new HctMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult HctCreate(HctMember hctMember)
        {
            hctMember.HctMemberId = Guid.NewGuid().ToString();
            _members.Add(hctMember);

            return RedirectToAction("Index");
            //return View(hctMember);
        }

        [HttpGet]
        public IActionResult HctEdit(string id)
        {
            var member = _members.Where(x=>x.HctMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult HctEdit(string id, HctMember hctMember)
        {
            // var member = _members.Where(x => x.HctMemberId.Equals(id)).FirstOrDefault();
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].HctMemberId == id)
                {
                    _members[i].HctUserName = hctMember.HctUserName;
                    _members[i].HctPassword = hctMember.HctPassword;
                    _members[i].HctFullName= hctMember.HctFullName;
                    _members[i].HctEmail=   hctMember.HctEmail;

                    return RedirectToAction("Index");
                }
           
            }
            return View();
        }

        [HttpGet]
        public IActionResult HctDetails(string id)
        {
            var member = _members.Where(x => x.HctMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult HctDelete(string id)
        {
            var member = _members.Where(x => x.HctMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult HctDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.HctMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("HctDelete");
        }
    }
}

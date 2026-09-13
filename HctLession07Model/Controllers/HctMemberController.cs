using Microsoft.AspNetCore.Mvc;
using HctLession07Model.Models.DataModels;
namespace HctLession07Model.Controllers
{
    public class HctMemberController : Controller
    {
        //mock data
        protected static List<HctMember> _members = new List<HctMember>
        {
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "tienhc",
                HctPassword = "123456",
                HctFullName = "Hoàng Công Tiến",
                HctEmail = "tienhc@gmail.com"
            },
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "toinn",
                HctPassword = "123456",
                HctFullName = "Nguyễn Như Tới",
                HctEmail = "toinn@gmail.com"
            },
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "trongnv",
                HctPassword = "123456",
                HctFullName = "Nghiêm Văn Trọng",
                HctEmail = "trongnv@gmail.com"
            },
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "minhnguyen",
                HctPassword = "123456",
                HctFullName = "Nguyễn Quang Minh",
                HctEmail = "minhnguyen@gmail.com"
            },
            new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "linhtran",
                HctPassword = "123456",
                HctFullName = "Trần Khánh Linh",
                HctEmail = "linhtran@gmail.com"
            }
        };
        public IActionResult Index()
        {

            return View(_members);
        }
        public IActionResult GetMember()
        {
            var member = new HctMember
            {
                HctMemberId = Guid.NewGuid().ToString(),
                HctUserName = "HcTien",
                HctPassword = "password123",
                HctFullName = "Hoàng Công Tiến",
                HctEmail = "th103826@gmail.com"
            };
            ViewBag.Member = member;
            return View();
        }
        //đưa dữ liệu dạng list ra view
        public IActionResult GetMembers()
        {
            //lấy từ mock data
            ViewBag.Members = _members;
            return View();
        }
        // GET: Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public IActionResult Create(HctMember member)
        {
            member.HctMemberId = Guid.NewGuid().ToString();

            ModelState.Remove(nameof(HctMember.HctMemberId));

            if (ModelState.IsValid)
            {
                _members.Add(member);

                return RedirectToAction(nameof(Index));
            }

            return View(member);
        }
    }
}

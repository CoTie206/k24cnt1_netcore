using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using hctLesson09Annotation.Models.DataModel;
using hctLesson09Annotation.Models.DataViewModels;

namespace hctLesson09Annotation.Controllers
{
	public class hctMemberController : Controller
	{
		private static List<hctMember> hctMembers = new List<hctMember>();

		// GET: hctMember
		public ActionResult Index()
		{
			return View(hctMembers);
		}

		// GET: hctMember/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: hctMember/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(hctMemberRegister hctMember)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return View(hctMember);
				}

				hctMember newMember = new hctMember
				{
					hctMemberId = hctMembers.Count + 1,
					hctUserName = hctMember.hctUserName,
					hctPassword = hctMember.hctPassword,
					hctEmail = hctMember.hctEmail,
					hctPhoneNumber = hctMember.hctPhoneNumber,
					hctFullName = hctMember.hctFullName,
					hctBirthday = hctMember.hctBirthday
				};

				hctMembers.Add(newMember);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View(hctMember);
			}
		}
	


		// GET: hctMemberController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: hctMemberController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: hctMemberController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: hctMemberController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}

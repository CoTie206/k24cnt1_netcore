using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hctLesson09Annotation.Models.DataViewModels
{
	/// <summary>
	/// Data Annotation - Validation
	/// </summary>
	public class hctMemberRegister
	{
		public int hctMemberId { get; set; }

		[DisplayName("Tên đăng nhập")]
		[Required(ErrorMessage ="Tên đăng nhập không để trống")]
		[StringLength(20,MinimumLength =3,ErrorMessage ="Tên đăng nhập có độ dài khoảng 3-20 ký tự !")]
		public string hctUserName { get; set; }

		[DisplayName("Mật khẩu")]
		[Required(ErrorMessage = "Mật khẩu không để trống")]
		[DataType(DataType.Password)]
		public string hctPassword { get; set; }
		public string hctEmail { get; set; }
		public string hctPhoneNumber { get; set; }
		public string hctFullName { get; set; }
		public DateTime hctBirthday { get; set; }
	}
}

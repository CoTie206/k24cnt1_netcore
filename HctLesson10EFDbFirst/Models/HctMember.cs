using System;
using System.Collections.Generic;

namespace HctLesson10EFDbFirst.Models;

public partial class HctMember
{
    public long Id { get; set; }

    public string HctName { get; set; } = null!;

    public bool? HctGender { get; set; }

    public DateTime? HctBirthDay { get; set; }

    public string? HctEmail { get; set; }

    public string? HctPhone { get; set; }

    public bool HctActive { get; set; }
}

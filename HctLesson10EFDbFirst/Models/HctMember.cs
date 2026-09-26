using System;
using System.Collections.Generic;

namespace HctLesson10EFDbFirst.Models;

public partial class HctMember
{
    public long Id { get; set; }

    public string? HctUserName { get; set; }

    public string? HctPassword { get; set; }

    public string? HctFullName { get; set; }

    public string? HctEmail { get; set; }

    public string? HctPhone { get; set; }

    public bool? HctStatus { get; set; }
}

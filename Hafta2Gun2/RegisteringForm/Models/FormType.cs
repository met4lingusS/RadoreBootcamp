using System;
using System.Collections.Generic;

namespace RegisteringForm.Models;

public partial class FormType
{
    public int FormId { get; set; }

    public string? FClassName { get; set; }

    public string? FDisplayName { get; set; }
}

using System;
using System.Collections.Generic;

namespace OdemeFormuV3.Models;

public partial class FormType
{
    public int FormId { get; set; }

    public string? FClassName { get; set; }

    public string? FDisplayName { get; set; }
}

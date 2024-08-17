using System;
using System.Collections.Generic;

namespace OdemeFormuV2.Models;

public partial class FormQuestion
{
    public int QuestionId { get; set; }

    public int? FormId { get; set; }

    public string? QuestionClassName { get; set; }

    public string? QuestionDisplayValue { get; set; }
}

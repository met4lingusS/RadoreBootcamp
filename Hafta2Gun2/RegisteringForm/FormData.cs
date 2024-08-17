using RegisteringClassLibrary.AttributeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringForm
{
    [Serializable]
    public class FormData
    {
        [RegisteringRequirements]
        public string answer1 { get; set; }
        [RegisteringRequirements]
        public string answer2 { get; set; }
        [RegisteringRequirements]
        public string answer3 { get; set; }

    }
}

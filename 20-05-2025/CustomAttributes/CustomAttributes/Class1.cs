using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class|
        AttributeTargets.Method,AllowMultiple =true,Inherited =true)]
    public class DebugInfoAttr : Attribute
    {
        public string BugInfo { get; set; }
        public int LineNumber { get; set; }
        public string Description;
        public DebugInfoAttr(string bugInfo, int lineNo)
        {
            BugInfo = bugInfo;
            LineNumber = lineNo;
            Description = String.Empty;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    [Silencer(Mode = SilencerMode.Strict)]
    public class External:Bulletin
    {
        public External()
        {
            Description = "外部";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace MvcApplication1.Models
{
    [Silencer(Mode=SilencerMode.Normal)]
    public class Internal:Bulletin
    {
        public Internal()
        {
            Description = "內部";
        }
    }
}
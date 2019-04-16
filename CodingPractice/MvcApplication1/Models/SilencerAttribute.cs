using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class SilencerAttribute:Attribute
    {
        public SilencerMode Mode { get; set; }
    }

    public enum SilencerMode
    {
        Normal,
        Strict
    }
}
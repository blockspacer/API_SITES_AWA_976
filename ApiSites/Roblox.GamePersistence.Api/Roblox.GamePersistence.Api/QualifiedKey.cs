using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api
{
    public class QualifiedKey
    {
        public string Scope { get; set; }
        public string Target { get; set; }
        public string Key { get; set; }
    }
}
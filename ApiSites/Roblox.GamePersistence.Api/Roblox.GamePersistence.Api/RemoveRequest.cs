using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api
{
    public class RemoveRequest
    {
        public string type { get; set; }
        public string scope { get; set; }
        public string target { get; set; }
        public string key { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api.Models.V1
{
    public class QualifiedKey
    {
        public string scope { get; set; }
        public string target { get; set; }
        public string key { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api.Models.V1
{
    /// <summary>
    /// <c>{Roblox.GamePersistence.Api.Models.V1.QualifiedEntry}</c>
    /// </summary>
    public class QualifiedEntry
    {
        public string scope { get; set; }
        public string target { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        public string usn { get; set; }
    }
}
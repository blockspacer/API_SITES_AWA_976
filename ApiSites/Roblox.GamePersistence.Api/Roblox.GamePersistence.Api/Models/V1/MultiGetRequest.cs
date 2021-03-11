using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api.Models.V1
{
    public class MultiGetRequest
    {
        public QualifiedKey[] keys { get; set; }
    }
}
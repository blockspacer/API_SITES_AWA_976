using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api.Models.V1
{
    public class MultiGetResponse
    {
        public QualifiedEntry[] entries { get; set; }
    }
}
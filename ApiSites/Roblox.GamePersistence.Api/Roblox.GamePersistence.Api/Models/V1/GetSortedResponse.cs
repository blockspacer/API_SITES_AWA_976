using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api.Models.V1
{
    public class GetSortedResponse
    {
        public TargetValuePair[] entries { get; set; }
        public string lastEvaluatedKey { get; set; }
    }
}
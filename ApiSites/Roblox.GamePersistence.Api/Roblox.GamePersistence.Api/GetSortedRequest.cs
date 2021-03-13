using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.GamePersistence.Api
{
    public class GetSortedRequest
    {
        public string scope { get; set; }
        public string key { get; set; }
        public string exclusiveStartKey { get; set; }
        public int pageSize { get; set; }
        public bool isAscending { get; set; }
        public long inclusiveMinValue { get; set; }
        public long inclusiveMaxValue { get; set; }
    }
}
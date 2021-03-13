using System;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;
using Roblox.Platform.GamePersistence;

namespace Roblox.GamePersistence.Api.Controllers
{
    [RoutePrefix("persistence")]
    public class PersistenceController : Controller
    {

        [Route("GetSortedValues")]
        [HttpGet]
        public async Task<IResponseBase> GetSortedValuesWithFetch(GetSortedRequest request)
        {
            DataStore dataStore = new DataStore();
            await dataStore.GetSortedValues();
            return await Task.FromResult<IResponseBase>(result: new ResponseBase());
        }

        [Route("GetSortedValues")]
        [HttpPost]
        public IResponseBase GetSortedValuesWithPost(GetSortedRequest request)
        {
            return default;
        }

        [Route("GetV2")]
        public IResponseBase GetV2(string type, GetRequest request)
        {
            return default;
        }

        [Route("Increment")]
        public IResponseBase Increment(IncrementRequest request)
        {
            return default;
        }

        [Route("Remove")]
        public IResponseBase Remove(RemoveRequest request)
        {
            return default;
        }

        [Route("Set")]
        public IResponseBase Set(SetRequest request, ValueRequest valueRequest) 
        {
            throw new Exception("Test");
            
        }
    }
}
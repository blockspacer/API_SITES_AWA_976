namespace Roblox.GamePersistence.Api
{
    // This exists because GamePersistence used to be MVC and returned custom JSON built in the response methods. We do NOT want to follow this pattern. Response methods should be of the type of the response model being returned.
    public interface IResponseBase
    {
    }
}

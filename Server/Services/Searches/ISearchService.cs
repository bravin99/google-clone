using GoogleClone.Shared.Models;

namespace GoogleClone.Server.Services
{
    public interface ISearchService
    {
        Task<IEnumerable<ResultObject>> GoogleSearch(string searchString);
    }
}
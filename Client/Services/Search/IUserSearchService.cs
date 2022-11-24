using GoogleClone.Shared.Models;
using System.Threading.Tasks;

namespace GoogleClone.Client.Services
{
    public interface IUserSearchService
    {
        public Task<ResultObject[]?> GetSearchResults(string searchkey);
    }
}
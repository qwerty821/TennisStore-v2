using OnlineStore.Models.RacketsModels;

namespace TennisStoreApi.Abstractions
{
    public interface IRacketService
    {
        Racket? Get(Guid id);
    }
}
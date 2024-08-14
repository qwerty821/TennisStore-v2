using OnlineShop.Models;
using OnlineStore.Abstractions;
using OnlineStore.Contracts;
using OnlineStore.Models.RacketsModels;
using OnlineStore.Models.RacketsModels;
using TennisStoreApi.Abstractions;

namespace OnlineStore.Services
{
    public class RacketService : IRacketService
    {
        private readonly IRacketRepository _racketRepository;

        public RacketService(IRacketRepository racketRepository)
        {
            _racketRepository = racketRepository;
        }


        public Racket? Get(Guid id)
        {
            return _racketRepository.Get(id);
        }

        public async Task<List<Racket>?> GetAll(FilterOptions? filterOptions)
        {
            return await _racketRepository.GetAll(filterOptions);
        }
    }
}

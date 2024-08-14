using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;
using OnlineStore.Contracts;
using OnlineStore.Models.RacketsModels;
using OnlineStore.Models.RacketsModels;

namespace OnlineStore.Abstractions
{
    public interface IRacketRepository
    {
  
        Racket? Get(Guid id);
        Task<List<Racket>>? GetAll(FilterOptions? filterOptions);
    }
}

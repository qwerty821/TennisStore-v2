using Microsoft.EntityFrameworkCore;

using OnlineStore.Abstractions;
using OnlineStore.Contracts;
using OnlineStore.Models.DbModels;
using OnlineStore.Models.RacketsModels;
using System.IO;
using TennisStoreApi.Models.DbModels;

namespace OnlineStore.Repositories
{
    public class RacketRepository : IRacketRepository
    {
        private OnlineStoreContext _context;

        public RacketRepository(OnlineStoreContext context)
        {
            _context = context;
        }

        public Racket? Get(Guid id)
        {
            string s_id = id.ToString().ToUpper();
            var x =  _context.Rackets.Find(id);
            if (x == null)
            {
                return null;
            }
            
            x.Id = new Guid(x.Id.ToString().ToUpper());
            return x;
        }

        public async Task<List<Racket>>? GetAll(FilterOptions? filterOptions)
        {
            if (filterOptions != null)
            {

                string sqlQuery = $@"Select * FROM Rackets 
                                    WHERE r_brand in (
                                        SELECT b_id from Brands 
                ";

                if (filterOptions.Brands?.Count > 0)
                {
                    string brands = "";
                    foreach (string brand in filterOptions.Brands)
                    {
                        brands += $"'{brand}',";
                    }
                    brands = brands.Remove(brands.Length - 1);

                    sqlQuery += $@" WHERE b_name in ({brands}) ";
                }
                sqlQuery += " ) ";
                sqlQuery += " ORDER BY ";
                sqlQuery += filterOptions.Sort switch
                {
                    SortOption.Ascending => " r_price ",
                    SortOption.Descending => "r_price DESC ",
                    SortOption.None => " r_id ",
                    _ => " r_id "
                };

                sqlQuery += ";";
                var list = await _context.Rackets.FromSqlRaw(sqlQuery).ToListAsync();

                return list;
            }
            return new List<Racket>() { };
        }

         
    }
}

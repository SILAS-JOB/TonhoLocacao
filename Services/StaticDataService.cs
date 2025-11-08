using TonhoLocacao.Models;
using System.Linq;
using System.Collections.Generic;

namespace TonhoLocacao.Services
{
    public class StaticDataService
    {
        private readonly List<Products> _allproducts;

        public StaticDataService()
        {
            _allproducts = new List<Products>();
        }


        public List<Products> GetServicesByCategory(string category)
        {
            return [.. _allproducts.Where(s => s.Category.Equals(category, System.StringComparison.OrdinalIgnoreCase))];
        }
        // public List<Products> GetProductsById(int id)
        // {
        //     return _allproducts.FirstOrDefault(s => s.Id == id);
        // }
    }
}
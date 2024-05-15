using System.Collections.Generic;
using System.Linq;
using MyEshop.Models;

namespace MyEshop.Data.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private MyEshopContext _context;

        public GroupRepository(MyEshopContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public IEnumerable<ShowGroupViewModel> GetGroupForShow()
        {
            var res = _context.Categories
               .Select(c => new ShowGroupViewModel()
               {
                   GroupId = c.Id,
                   Name = c.Name,
                   ProductCount = _context.CategoryToProducts.Count(g => g.CategoryId == c.Id)
               }).ToList();

            return res;
        }
    }
}

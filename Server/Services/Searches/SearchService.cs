using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GoogleClone.Shared.Models;
using GoogleClone.Server.Data.Context;

namespace GoogleClone.Server.Services
{
    public class SearchService : ISearchService
    {
        private readonly ApplicationDbContext _context;

        public SearchService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ResultObject>> GoogleSearch(string searchString)
        {
            IQueryable<ResultObject> result = _context.GoogleSets!;

            if (!string.IsNullOrEmpty(searchString))
                result = result.Where(r => r.Title.Contains(searchString) 
                    || r.Url.Contains(searchString));
            
            return await result.ToListAsync();
        }
    }
}
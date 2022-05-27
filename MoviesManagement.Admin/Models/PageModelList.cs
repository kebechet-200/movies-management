using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesManagement.Admin.Models
{
    public class PageModelList<T> : List<T>
    {
        public int PageIndex { get; private set; }

        public int TotalPages { get; set; }

        public PageModelList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }

        public bool PreviousPage
        {
            get => PageIndex > 1;
        }

        public bool NextPage
        {
            get => PageIndex < TotalPages;
        }

        public static PageModelList<T> Create(IEnumerable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PageModelList<T>(items, count, pageIndex, pageSize);
        }
    }
}

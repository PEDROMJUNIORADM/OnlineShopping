using System.Collections.Generic;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.WebUI.Models;

namespace OnlineShoppingStore.WebUI.Controllers
{
    internal class ProductListViewModel
    {
        public PagingInfo PagingInfo { get; internal set; }
        public IEnumerable<Product> Products { get; internal set; }
    }
}
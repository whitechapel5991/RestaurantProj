﻿using Mango.Web.Models.Product;

namespace Mango.Web.Models.ShoppingCart
{
    public class CartDetailsDto
    {
        public int Id { get; set; }
        public int CardHeaderId { get; set; }
        public virtual CartHeaderDto CartHeader { get; set; }
        public int ProductId { get; set; }
        public virtual ProductDto Product { get; set; }
        public int Count { get; set; }
    }
}

﻿using ContosoCrafts.Model;
using ContosoCrafts.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ProductService _productService;

        public IEnumerable<Product>? Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public void OnGet()
        {
            Products = _productService.GetProducts();
        }
    }
}
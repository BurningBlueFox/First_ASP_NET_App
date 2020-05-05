using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CotosoCrafts.Website.Models;
using CotosoCrafts.Website.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CotosoCrafts.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService _productService;
        public IEnumerable<Product> _products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductsService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public void OnGet()
        {
            _products = _productService.GetProducts();
        }
    }
}

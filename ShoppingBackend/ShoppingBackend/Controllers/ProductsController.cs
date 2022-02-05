using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.BuildingBlocks.Controllers;
using System;

namespace ShoppingBackend.Api.Controllers
{
    public class ProductsController : AbstractCRUDController<object>
    {
        [HttpPatch("{id}/disable")]
        public IActionResult DisableProduct(Guid id)
        {
            return new NotFoundResult();
        }
    }
}

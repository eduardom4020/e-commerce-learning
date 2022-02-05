using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.BuildingBlocks.Repository;
using System;

namespace ShoppingBackend.BuildingBlocks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class AbstractCRUDController<T> : ControllerBase where T : class
    {
        private readonly Repository<T> repository;

        public AbstractCRUDController()
        {
            repository = new Repository<T>();
        }

        [HttpGet]
        public virtual IActionResult List() 
        {
            var result = repository.List();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(Guid id)
        {
            var result = repository.Get(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public virtual IActionResult Update(Guid id)
        {
            var result = repository.Update(id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(Guid id)
        {
            var result = repository.Delete(id);
            return Ok(result);
        }
    }
}

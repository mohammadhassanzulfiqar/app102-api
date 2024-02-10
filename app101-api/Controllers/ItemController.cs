using app101_api.Dto;
using Microsoft.AspNetCore.Mvc;

namespace app101_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly string[] ItemCollection = new[]
        {
        "Pen", "Pencil", "Colors", "Cryons", "Sand", "Bottle", "Snakcs", "Chocolate", "Paper", "Box"
    };

        

        [HttpGet]
        public List<ItemDto> Get()
        {
            List<ItemDto> items = new();
            foreach (var item in ItemCollection)
            {
                items.Add(new ItemDto()
                {
                    Id = Guid.NewGuid(),
                    Name = item
                });
            }
            return items;
        }
    }
}
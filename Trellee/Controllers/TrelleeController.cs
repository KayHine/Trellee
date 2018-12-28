using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trellee.Controllers
{
    [Route("api/[controller]")]
    public class TrelleeController : Controller
    {
        private static Card[] Cards = new[]
        {
            new Card
            {
                Id = 1,
                Title = "Make an egg",
                Description = "Crack open the egg first."
            },

            new Card
            {
                Id = 2,
                Title = "Read a book",
                Description = "Read Foundation 2."
            },

            new Card
            {
                Id = 3,
                Title = "Practice Guitar",
                Description = "Memorize the pentatonic scales."
            }
        };

        [HttpGet("[action]")]
        public IEnumerable<Card> ToDoCards()
        {
            return Cards;
        }

        public class Card
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }


}

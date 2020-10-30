using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTfulAPIPractice.Models;

namespace RESTfulAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        List<Quote> quotes = new List<Quote>(){
            new Quote(){Id = 0, Author = "Emily", Description = "The brain is wider than the sky", Title = "書1"},
            new Quote(){Id = 1, Author = "Richard", Description = "True love stories never have endings.", Title = "書2"}
        };
    }
}
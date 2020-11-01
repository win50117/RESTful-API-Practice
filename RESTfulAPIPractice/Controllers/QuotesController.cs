using System.Collections;
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
        //模擬資料庫撈到的資料
        static List<Quote> _quotes = new List<Quote>(){
            new Quote(){Id = 0, Author = "Emily", Description = "The brain is wider than the sky", Title = "書1"},
            new Quote(){Id = 1, Author = "Richard", Description = "True love stories never have endings.", Title = "書2"}
        };

        [HttpGet] //http verbs(http請求方法) Read讀取
        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        [HttpPost] //Create新增
        public void Post(Quote quote)
        {
            _quotes.Add(quote);
        }

        [HttpPut("{id}")] //Update更新
        public void Put(int id, Quote quote)
        {
            _quotes[id] = quote;
        }

        [HttpDelete("{id}")] //Delete刪除
        public void Delete(int id)
        {
            _quotes.RemoveAt(id);
        }
    }
}
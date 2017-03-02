using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/quotes")]
public class QuotesController : Controller
{
    public QuotesController() 
    {
    }

    // POST api/quotes
    [HttpPost]
    public IActionResult Post([FromBody] Quote quote)
    {
        //return Ok(db.CreateQuote(quote));
        return Ok();
    }

    // GET api/quotes/id
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
         //return Ok(db.RetrieveQuote(id));
        return Ok();
    }

    // PUT api/quotes/
    [HttpPut]
    public IActionResult Put([FromBody] Quote quote)
    {
        //return Ok(db.UpdateQuote(quote));
        return Ok();
    }

    // DELETE api/quotes/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        //db.DeleteQuote(id);
        return Ok();
    }

    // GET api/quotes/
    [HttpGet]
    public IActionResult GetQuotes()
    {
        //return Ok(db.RetrieveAllQuotes);
        return Ok();
    }
}
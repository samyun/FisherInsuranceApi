using Microsoft.AspNetCore.Mvc;

[Route("api/claims/claims")]
public class ClaimsController : Controller
{
    // POST api/claims/claims
    [HttpPost]
    public IActionResult Post([FromBody]string value)
    {
        return Created("", value);
    }

    // GET api/claims/claims/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
         return Ok("The id is: " + id);
    }

    // PUT api/claims/claims/id
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]string value)
    {
        return NoContent();
    }

    // DELETE api/claims/claims/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Delete(id);
    }
}
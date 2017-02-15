using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/claims/")]
public class ClaimsController : Controller
{
    private IMemoryStore db; 
    public ClaimsController(IMemoryStore repo) 
    {
        db = repo;
    }
    
    // POST api/claims/
    [HttpPost]
    public IActionResult Post([FromBody]Claim claim)
    {
        return Ok(db.CreateClaim(claim));
    }

    // GET api/claims/id
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
         return Ok(db.RetrieveClaim(id));
    }

    // PUT api/claims/
    [HttpPut]
    public IActionResult Put([FromBody] Claim claim)
    {
        return Ok(db.UpdateClaim(claim));
    }

    // DELETE api/claims/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        db.DeleteClaim(id);
        return Ok();
    }

    // GET api/claims/
    [HttpGet]
    public IActionResult GetClaims()
    {
        return Ok(db.RetrieveAllClaims);
    }
}
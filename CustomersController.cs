using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace WebApplication1;

[ApiController]
[Route("[controller]")]
public class CustomersController : ODataController
{   
    public ActionResult Delete(string key)
    {
        return Ok();
    }
}
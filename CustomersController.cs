using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace WebApplication1;

public class CustomersController : ODataController
{   
    public ActionResult Delete(string key)
    {
        return Ok();
    }
}
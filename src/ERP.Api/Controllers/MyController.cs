using ERP.Practical;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers;

[ApiController]
[Route("mycontroller")]
public class MyController : ControllerBase
{

    private readonly ErpContext _ctx;
    private readonly ILogger<MyController> _anus;
    public MyController(ErpContext ctx, ILogger<MyController> anus)
    {
        _ctx = ctx;
        _anus = anus;
    }
    [HttpGet("allo")]
    [ProducesResponseType<List<string>>(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<string>>> DatController()
    {
        _anus.LogInformation("Hey hey !!!!");
        await Task.Delay(1444);
        return Ok(new List<string>(["1", "2", "3"]));
    }
}
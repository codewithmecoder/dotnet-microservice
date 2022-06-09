using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class PlatformController : ControllerBase
{
  private readonly IPlatformRepo _platform;

  public PlatformController(IPlatformRepo platform)
  {
    _platform = platform;
  }

  [HttpGet]
  public ActionResult<List<Platform>> Get()
  {
    return _platform.GetAllPlatforms();
  }
  [HttpGet("id")]
  public ActionResult<Platform> Get(int id)
  {
    return _platform.GetPlatformById(id);
  }
}
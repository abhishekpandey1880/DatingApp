using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entities;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase
{
  private readonly DataContext _context;

  public UserController(DataContext context)
  {
    _context = context;
  }

  [HttpGet]
  public ActionResult<IEnumerable<AppUser>> GetActionResult()
  {
    return _context.Users.ToList();
  }

  [HttpGet("{id}")]
  public ActionResult<AppUser> GetUser(int id)
  {
    return _context.Users.Find(id);
  }
}
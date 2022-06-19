namespace API.Controllers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Entity;
using BLL;

[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly UserService _userService;
    public IConfiguration Configuration { get; }

    public UserController(IConfiguration configuration)
    {
        Configuration = configuration;
        string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
        _userService = new UserService(connectionString);
    }

    [HttpGet("obtener")]
    public string Get()
    {   
        return "Hola mundo";
    }

    

}




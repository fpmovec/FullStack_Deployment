using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BackendAPI.Controllers;

public class DockerController : Controller
{
    [HttpGet("/api/docker_test_{id}")]
    public IActionResult GetTest_1(int id)
    {
        switch (id)
        {
            case 1:
                return new OkObjectResult(JsonSerializer.Serialize("Docker test 1"));
            case 2:
                return new OkObjectResult(JsonSerializer.Serialize("Docker test 2"));
            default:
                return new OkObjectResult(JsonSerializer.Serialize("Nothing"));
        }
    }
}
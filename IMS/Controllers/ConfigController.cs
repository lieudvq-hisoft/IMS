using Data.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class ConfigController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ConfigController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok(new DocConfig
        {
            QTName = _configuration["Appointment:QtName"],
            Position = _configuration["Appointment:Position"]
        });
    }

    [HttpPut]
    public async Task<ActionResult> ChangeDocumentconfig([FromBody] DocConfig model)
    {
        UpdateAppSetting("Appointment:QtName", model.QTName);
        UpdateAppSetting("Appointment:Position", model.Position);
        return Ok();
    }


    private void UpdateAppSetting(string key, string value)
    {
        var configJson = System.IO.File.ReadAllText("appsettings.json");
        var config = JsonSerializer.Deserialize<Dictionary<string, object>>(configJson);
        config[key] = value;
        var updatedConfigJson = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
        System.IO.File.WriteAllText("appsettings.json", updatedConfigJson);
    }
}

public class DocConfig
{
    [Required]
    public string QTName { get; set; }

    [Required]
    public string Position { get; set; }
}

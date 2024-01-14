using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class UtilController : ControllerBase
{
    [HttpGet("GetBase64File")]
    public async Task<IActionResult> GetBase64File(string fileUrl)
    {
        try
        {
            using (HttpClient httpClient = new HttpClient())
            {
                // Download the file content
                byte[] fileBytes = await httpClient.GetByteArrayAsync(fileUrl);

                // Convert the file content to Base64
                string base64String = Convert.ToBase64String(fileBytes);

                // You can return the Base64 string in the response
                return Ok(new { Base64File = base64String });
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., file not found, network error)
            return BadRequest($"Error: {ex.Message}");
        }
    }
}

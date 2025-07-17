using Microsoft.AspNetCore.Mvc;
using System.IO;

[Route("api/[controller]")]
[ApiController]
public class MusicController : ControllerBase
{
    [HttpGet("files")]
    public IActionResult GetMusicFiles()
    {
        try
        {
            var musicPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "music");
            var mp3Files = Directory.GetFiles(musicPath, "*.mp3")
                                .Select(Path.GetFileName)
                                .ToList();
            return Ok(mp3Files);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
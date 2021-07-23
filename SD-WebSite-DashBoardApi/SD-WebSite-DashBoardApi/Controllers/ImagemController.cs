using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagemController : ControllerBase
    {

        [HttpPost("PostListImagens")]
        public async Task<IActionResult> PostListImagens(List<IFormFile> files)
        {
            List<string> nomeArquivos = new List<string>();
            int arquivosSalvo = files.Count;
            try
            {
                foreach (var file in files)
                {
                    if (Path.GetExtension(file.FileName) == ".jpg" ||
                        Path.GetExtension(file.FileName) == ".png" ||
                        Path.GetExtension(file.FileName) == ".jpeg" ||
                        Path.GetExtension(file.FileName) == ".gif" ||
                        Path.GetExtension(file.FileName) == ".png" ||
                        Path.GetExtension(file.FileName) == ".svg"
                        )
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", fileName);
                        if (System.IO.File.Exists(filePath) != true)
                        {
                            using (var fileStream = new FileStream(filePath, FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                arquivosSalvo--;
                            }
                        }
                    }
                }
                return Ok(new {arquivosSalvos = arquivosSalvo });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

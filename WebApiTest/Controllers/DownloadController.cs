using Microsoft.AspNetCore.Mvc;
using WebApiTest.Service;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadController : ControllerBase  //Controller執行
    {
        public DownloadController() {

        }

        [HttpGet("DownloadFormURL")]
        public IActionResult DownloadFromUrl()
        {
            var result = Downloadfunc.GetUrlContent("https://buzzorange.com/vidaorange/wp-content/uploads/sites/3/2017/12/ka-e1513740156990.png");
            if (result != null)
            {
                return File(result.Result, "image/png", "R.png");
            }
            return Ok("file is not exist");
        }

        [HttpGet("download")]
        public IActionResult Download()
        {
            var filepath = Path.Combine("images", "R.png");
            return File(System.IO.File.ReadAllBytes(filepath), "image/png", System.IO.Path.GetFileName(filepath));
        }
    }
}

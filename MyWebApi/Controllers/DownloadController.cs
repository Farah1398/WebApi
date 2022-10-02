/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        using (WebClient client = new WebClient())
        {
            string HtmlResult = String.Empty;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(remoteFile);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.EnableSsl = false;
            request.Credentials = new NetworkCredential(MyLogin, MyPassword);
            using (FtpWebResponse response = (FtpWebResponse) request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            using (FileStream writer = new FileStream(localFilename, FileMode.Create))
            {
                long length = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[2048];
                readCount = responseStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    writer.Write(buffer, 0, readCount);
                    readCount = responseStream.Read(buffer, 0, bufferSize);
                }
            }
        }
            }
}
*/
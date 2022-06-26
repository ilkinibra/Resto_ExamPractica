using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Resto_Backend.Helpers
{
    public class Helper
    {
        private object _env;

        public static void DeleteFile(IWebHostEnvironment env, string img, string image)
        {
            string path = env.WebRootPath;
            string resulPath = Path.Combine(path, image);

            if (System.IO.File.Exists(resulPath))
            {
                System.IO.File.Delete(resulPath);
            }
        }
    }
}
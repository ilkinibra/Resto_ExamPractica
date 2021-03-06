using Microsoft.AspNetCore.Http;

namespace Resto_Backend.Extentions
{
    public static class Extention
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }
        public static bool ImageSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 > kb;
        }
    }
}
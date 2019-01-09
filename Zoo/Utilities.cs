using System.Web;

namespace Zoo
{
    public static class Utilities
    {
        public static string BuildUrl(string host, string name, string value)
        {
            return $"{host}?{HttpUtility.UrlEncode(name)}={HttpUtility.UrlEncode(value)}";
        }
    }
}
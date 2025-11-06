using System.Text.Json;

using Microsoft.AspNetCore.Mvc.Rendering;

using Org.BouncyCastle.Crypto.Digests;

namespace WFClassic.Web.Logic.Shared
{
    public static class Utils
    {
        public static string GetWhirlpoolHash(string inputString)
        {
            WhirlpoolDigest whirlpool = new WhirlpoolDigest();
            whirlpool.BlockUpdate(System.Text.Encoding.UTF8.GetBytes(inputString));
            var hashOut = new byte[whirlpool.GetDigestSize()];
            whirlpool.DoFinal(hashOut);
            return Convert.ToHexString(hashOut);
        }

        public static T GetRequestObject<T>(HttpContext httpContext)
        {
            return JsonSerializer.Deserialize<T>(Utils.GetRequestObjectAsString(httpContext));
        }

        // used for GetRequestObject and SaveLoadout
        public static string GetRequestObjectAsString(HttpContext httpContext)
        {
            string bodyBytes = null;

            using (StreamReader streamReader = new StreamReader(httpContext.Request.Body))
            {
                bodyBytes = streamReader.ReadToEndAsync().Result;
            }

            int indexOfLastCloseCurlyBrace = bodyBytes.LastIndexOf('}');
            bodyBytes = indexOfLastCloseCurlyBrace > 0 ? bodyBytes.Substring(0, indexOfLastCloseCurlyBrace + 1) : bodyBytes;

            Console.WriteLine(bodyBytes);
            return bodyBytes;
        }


        public static IEnumerable<SelectListItem> GetFlattenedListDictionary(Dictionary<string, List<string>> dict)
        {
            return dict.Select(s => s.Value.Select(s2 => new SelectListItem() { Text = $"{s.Key} - {s2}", Value = s.Key })).SelectMany(s => s);
        }


    }
}
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Utilities;
using System.Text.Json;

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
            return bodyBytes;
        }



    }
}

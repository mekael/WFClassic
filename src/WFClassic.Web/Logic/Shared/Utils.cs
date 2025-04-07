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
    }
}

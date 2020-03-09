using System;

namespace Interview.Web.Weather
{
    public static class Utils
    {
        private const float AbsoluteZeroC = -273.15f;
        
        /// <summary>
        /// Kelvin to Celsius
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int KtoC(this float k)
        {
            return (int)Math.Round(k + AbsoluteZeroC);
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace PcnCrawler.Uteis
{
    public static class UteisExtensions
    {
        public static string LimpaStringParaNumero(this string str)
        {
            return String.Join("", Regex.Split(str, @"[^\d]"));
        }

        public static int ConverteStringParaNumerico(this string str)
        {
            int temp = 0;
            Int32.TryParse(str.LimpaStringParaNumero(), out temp);
            return temp;
        }

        public static decimal ConverteStringParaDeciaml(this string str)
        {
            decimal temp = 0;
            Decimal.TryParse(str.LimpaStringParaNumero(), out temp);
            return temp;
        }

        public static string LimparDelimitadores(this string str)
        {
            return str.Replace("\n", "").Replace("\r", "").Replace("\t", "");
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeExtractor
{
    class Fixer
    {
        internal JObject FixJson(JObject JsonCode)
        {
            try
            {
                string Code = JsonCode.ToString();

                Code = Code.Replace("\\\"", "\"");
                Code = Code.Replace("\"{", "{");
                Code = Code.Replace("}\"", "}");
                Code = Code.Replace("\\\\\"", "\\\\\\\"");

                return JObject.Parse(Code);

            }
            catch
            {
                return null;
            }

        }

        internal string FixURL(JToken URL)
        {
            string URLresult = URL.ToString().Replace(@"\u0026", "&");
            return URLresult;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedelliAskerlikTweeter
{
   public class Util
    {
       public static string GetPost(string post, string additionalString)
       {
           string p = string.Empty;

           if (!string.IsNullOrEmpty(additionalString))
           {
               if (140 - post.Length > additionalString.Length + 1)
                   p = post + " " + additionalString;
               else
                   p = post.Substring(0, post.Length - additionalString.Length + 1) + " " + additionalString;
           }
           return p;
       }
    }
}

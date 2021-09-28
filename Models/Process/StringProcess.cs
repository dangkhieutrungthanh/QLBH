using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace QLBH.Models
{
    public class StringProcess
    {
        public string AutoGennerateKey(string id)
        {
            string numPart, strPart, newKey = "",newNumPart="";
            int intnumber;
            numPart = Regex.Match(id, @"\d+").Value;
            intnumber = Convert.ToInt32(numPart) + 1;
            for (int i =0; i < numPart.Length - intnumber.ToString().Length; i++)
            { newNumPart += "0"; }
            newNumPart += intnumber;
            strPart = numPart = Regex.Match(id, @"\d+").Value;
            newKey += newNumPart;
            return newKey;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI;

namespace GUI.Tools
{
    public static class Check
    {
        public static bool IsValidEmail(string email)
        {
            if (!email.Trim().Equals(""))
            {
                string pattern = @"^(?!\-)(?![0-9])[a-zA-Z0-9\-]{1,63}(\.[a-zA-Z]{2,})+$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email);
            }
            return false;
        }

        public static bool IsValidPhoneNumber(string pn)
        {
            if (pn.Length < 10 || pn.Length > 11)
            {
                return false;
            }
            string pattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(pn);
        }
    }
}

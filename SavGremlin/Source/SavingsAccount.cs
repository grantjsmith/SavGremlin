using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavGremlin.Source
{
    public class SavingsAccount
    {
        public String accountName;
        public double accountValue;

        public static SavingsAccount inflateFromString(String input)
        {
            SavingsAccount result = new SavingsAccount();

            String[] values = input.Split(':');

            result.accountName = values[0];
            result.accountValue = Convert.ToDouble(values[1]);

            return result;
        }

        public String collapseToString()
        {
            String result = "";

            result += accountName + ":";
            result += accountValue;

            return result;
        }
    }
}

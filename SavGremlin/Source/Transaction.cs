using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavGremlin.Source
{
    public class Transaction
    {
        public Decimal value;
        public String note;

        public String collapseToString()
        {
            String result = "";

            result += value + ";";
            result += note;

            return result;
        }

        public static Transaction inflateFromString(String input)
        {
            Transaction result = new Transaction();

            String[] components = input.Split(';');

            result.value = Convert.ToDecimal(components[0]);
            result.note = components[1];

            return result;
        }
    }
}

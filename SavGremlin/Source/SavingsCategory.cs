using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavGremlin.Source
{
    public class SavingsCategory
    {
        public string name;
        public Decimal percentageMonthly;
        public int goal;
        public Decimal currentValue;

        public List<Transaction> transactions;

        public String collapseToString()
        {
            String result = "";

            result += name + ",";
            result += percentageMonthly + ",";
            result += goal + ",";
            result += currentValue + ",";

            foreach(Transaction t in transactions)
            {
                result += t.collapseToString() + ":";
            }

            return result;
        }

        public static SavingsCategory inflateFromString(String input)
        {
            SavingsCategory result = new SavingsCategory();

            String[] values = input.Split(',');

            result.name = values[0];
            result.percentageMonthly = Convert.ToDecimal(values[1]);
            result.goal = Convert.ToInt32(values[2]);
            result.currentValue = Convert.ToDecimal(values[3]);

            String[] transactions = values[4].Split(':');

            result.transactions = new List<Transaction>();

            for (int i = 0; i < (transactions.Length - 1); i++)
            {
               result.transactions.Add(Transaction.inflateFromString(transactions[i]));
            }

            return result;
        }
    }
}

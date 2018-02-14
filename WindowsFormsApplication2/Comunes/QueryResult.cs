using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Comunes
{
    public class QueryResult
    {
        public List<string> Fields { set; get; }
        public List<List<string>> Rows { get; set; }
        public string ErrorMessage { get; set; }

        public QueryResult()
        {
            Fields = new List<string>();
            Rows = new List<List<string>>();
        }

        public QueryResult(List<string> columns)
        {
            Fields = new List<string>(columns);
            Rows = new List<List<string>>();
        }

        public void PrintRow(List<string> row)
        {
            foreach (var elem in row)
            {
                Console.Write(elem + "\t\t");
            }
        }

        public QueryResult(string error)
        {
            ErrorMessage = error;
        }


    }
}

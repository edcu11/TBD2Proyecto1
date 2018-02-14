using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Comunes
{
    public class ConnectionStringConfiguration
    {
        private string v;

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public bool TrustedConnection { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        public ConnectionStringConfiguration()
        {
            TrustedConnection = true;
        }

        public ConnectionStringConfiguration(string connection)
        {
            if (connection.Contains("Trusted_Connection"))
            {
                TrustedConnection = true;
            }

            var splitedd = connection.Split('=', ';');
            ServerName = splitedd.ElementAt(1);
            DatabaseName = splitedd.ElementAt(3);

            if (TrustedConnection)
            {
                UserId = string.Empty;
                Password = string.Empty;
                return;
            }

            UserId = splitedd.ElementAt(5);
            Password = splitedd.ElementAt(7);
        }

        public ConnectionStringConfiguration(string serverN, string databaseN)
        {
            ServerName = serverN;
            DatabaseName = databaseN;
        }

        public string GetConfString()
        {
            string conString = "Server=" + ServerName + ";Database=" + DatabaseName + ";";

            if (TrustedConnection)
            {
                conString += "Trusted_Connection=" + TrustedConnection.ToString()  + ";";
            }
            else
            {
                conString += "User Id=" + UserId + ";Password=" + Password + ";";
            }
            return conString;
        }

    }
}

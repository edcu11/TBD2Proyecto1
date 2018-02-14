using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Comunes
{
    public class ConnectionStorage
    {
        public string path { get; set; }
        public List<ConnectionStringConfiguration> connections;

        public ConnectionStorage()
        {
            path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\";
            path = @"C:\Users\Edgar\Desktop\SharedTBD2\confs.txt";
            connections = new List<ConnectionStringConfiguration>();

            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
        }

        public void SaveConfigurations()
        {
            var fs = File.Create(path);
            fs.Close();

            foreach (var conn in connections)
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(conn.GetConfString());
                }
            }
        }

        public bool AddConnection(ConnectionStringConfiguration connData)
        {
            var savedConnIndex = FindSavedConnection(connData);

            if (savedConnIndex >= 0 && connections[savedConnIndex] != null)
            {
                if (connections[savedConnIndex].TrustedConnection != connData.TrustedConnection)
                {
                    CopyNewConnectionData(connData, savedConnIndex);
                }
                return false;
            }

            connections.Add(connData);
            return true;
        }

        private void CopyNewConnectionData(ConnectionStringConfiguration connData, int savedConn)
        {
            connections[savedConn].TrustedConnection = connData.TrustedConnection;
            connections[savedConn].UserId = connData.UserId;
            connections[savedConn].Password = connData.Password;
        }

        public int FindSavedConnection(ConnectionStringConfiguration connData)
        {
            return connections.FindIndex(x => x.DatabaseName.Equals(connData.DatabaseName) && x.ServerName.Equals(connData.ServerName));
        }

        public void  LoadConfigurations()
        {
            connections.Clear();
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                connections.Add(new ConnectionStringConfiguration(line));
            }
        }

        

    }
}

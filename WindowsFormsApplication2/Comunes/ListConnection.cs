using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Comunes
{
    public class ListConnection
    {
        DBConnection connection;
        public ListConnection(string connectionString)
        {
            connection = new DBConnection(connectionString);
        }


        
        public QueryResult GetDBTables()
        {
            
            string sqlCommand = @"SELECT * FROM INFORMATION_SCHEMA.TABLES 
                                WHERE TABLE_TYPE='BASE TABLE'";

            return connection.ExecuteCommand(sqlCommand, new string[] { "TABLE_NAME", "TABLE_SCHEMA" });
            
        }

        public QueryResult GetDBIndexes()
        {
            string sqlCommand = @"SELECT name as Name, object_id, type_desc 
                                FROM sys.objects
                                WHERE type_desc LIKE '%CONSTRAINT'";

            return connection.ExecuteCommand(sqlCommand, new string[] { "object_Id", "Name", "Type_Desc" });

        }

        public QueryResult GetDBProcedures()
        {
            string sqlCommand = @"SELECT name, type
                                FROM dbo.sysobjects
                                where type = 'P' or type = 'FN'
                                ORDER BY type, name";

            return connection.ExecuteCommand(sqlCommand, new string[] { "name", "type" });
        }

        public QueryResult GetDBTriggers()
        {
            string sqlCommand = @"SELECT  table_name = OBJECT_NAME(parent_object_id) ,
                                        trigger_name = name ,
                                        trigger_owner = USER_NAME(schema_id) ,
                                        OBJECTPROPERTY(object_id, 'ExecIsUpdateTrigger') AS isupdate ,
                                        OBJECTPROPERTY(object_id, 'ExecIsDeleteTrigger') AS isdelete ,
                                        OBJECTPROPERTY(object_id, 'ExecIsInsertTrigger') AS isinsert ,
                                        OBJECTPROPERTY(object_id, 'ExecIsAfterTrigger') AS isafter ,
                                        OBJECTPROPERTY(object_id, 'ExecIsInsteadOfTrigger') AS isinsteadof ,
                                        CASE OBJECTPROPERTY(object_id, 'ExecIsTriggerDisabled')
                                        WHEN 1 THEN 'Disabled'
                                            ELSE 'Enabled'
                                        END AS Enabled
                                FROM    sys.objects
                                where type = 'TR'
                                ORDER BY OBJECT_NAME(parent_object_id)";

            return connection.ExecuteCommand(sqlCommand, new string[] { "table_name", "trigger_name", "isinsert" , "isupdate" ,
                                                                        "isdelete", "isinsteadof", "Enabled" });
        }

        public QueryResult GetDBChecks()
        {
            string sqlCommand = @"SELECT   TABLE_NAME, 
                                        COLUMN_NAME, 
                                        cc.CONSTRAINT_NAME AS CONSTRAINT_NAME
                                FROM INFORMATION_SCHEMA.CHECK_CONSTRAINTS cc 
                                INNER JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE c 
                                ON cc.CONSTRAINT_NAME = c.CONSTRAINT_NAME ";

            return connection.ExecuteCommand(sqlCommand, new string[] { "TABLE_NAME", "COLUMN_NAME", "CONSTRAINT_NAME" });
        }

        public QueryResult GetDBViews()
        {
            string sqlCommand = @"SELECT * FROM INFORMATION_SCHEMA.TABLES 
                                WHERE TABLE_TYPE='VIEW'";

            return connection.ExecuteCommand(sqlCommand, new string[] { "TABLE_NAME", "TABLE_SCHEMA" });
        }
    }
}

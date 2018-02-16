using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Forms.CU_Forms;

namespace WindowsFormsApplication2.Comunes
{
    public abstract class DBManager
    {
        public string DeleteCommand { get; set; }
        public string CreateCommand { get; set; }
        public string UpdateCommand { get; set; }
        public string KeyValue { get; set; }
        public string TypeId { get; set; }
        public Form CreateForm { get; set; }

        public abstract string CreateQuery(List<string> objectId);
        public abstract string UpdateQuery(string objectId);
        public abstract Form StartCreateForm(DBConnection connection);

        public virtual string DeleteQuery(string objectId)
        {
            var query = DeleteCommand.Replace(KeyValue, objectId);
            return query;
        }

    }

    public class TableManager : DBManager
    {
        public string tableName { get; set; }
        public List<string> columnsList { get; set; }
        public string PKquery { get; set; }
        public string FKquery { get; set; }

        public TableManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = "DROP TABLE IF EXISTS [MYOBJECTNAME]";
            CreateCommand = @"CREATE TABLE [TABLENAME](
                            );";
            TypeId = "Table";
            columnsList = new List<string>();
            PKquery = string.Empty;
            FKquery = string.Empty;
        }

        public void AddColum(ColumnData data)
        {
            var columnquery = data.GenerateString();

            if (columnsList.FirstOrDefault() == null)
            {
                columnquery = columnquery.Replace(",", " ");
            }

            columnsList.Add(columnquery);

            if (data.IsPrimary())
            {
                PKquery = data.PrimaryConstraintQuery(PKquery, tableName);
            }

            if (data.IsForeign())
            {
                FKquery = data.ForeignConstraintQuery(FKquery, tableName);
            }

        }


        public override string CreateQuery(List<string> objectId)
        {
            throw new NotImplementedException();
        }

        public string CreateQuery(string tableName)
        {
            var sql = CreateCommand.Replace("[TABLENAME]", tableName);
            var start = sql.IndexOf('(');
            sql = sql.Insert(start + 1, ConcatColumnNames());
            start = sql.LastIndexOf(");");
            sql = sql.Insert(start - 1, AddConstraints());
            return sql;
        }

        private string AddConstraints()
        {
            if (PKquery.Equals(string.Empty))
            {
                return FKquery;
            }

            if (FKquery.Equals(string.Empty))
            {
                return PKquery;
            }

            return PKquery + ", " + FKquery;


        }

        private string ConcatColumnNames()
        {
            var columns = string.Empty;
            foreach (var column in columnsList)
            {
                columns += column;
            }
            return columns;
        }

        public override string DeleteQuery(string objectId)
        {
            var query = DeleteCommand.Replace(KeyValue, objectId);
            return query;
        }

        public override Form StartCreateForm(DBConnection connection)
        {
            return new TableCU(connection);
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }

    public class TriggerManager : DBManager
    {
        
        public TriggerManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = @"IF OBJECT_ID ('MYOBJECTNAME', 'TR') IS NOT NULL  
                            DROP TRIGGER  IF EXISTS MYOBJECTNAME;";
            CreateCommand = @"CREATE TRIGGER TRIGGERNAME ON TABLENAME
                                WHEN ACTIONTRIGGER
                                AS
                                BEGIN
                                 SCRIPT
                                END";
            TypeId = "Trigger";
        }

        public override string CreateQuery(List<string> objectId)
        {
            throw new NotImplementedException();
        }

        public string CreateQuery(TriggerData data)
        {
            var sql = CreateCommand;
            sql =  sql.Replace("TRIGGERNAME", data.Name);
            sql = sql.Replace("TABLENAME", data.Table);
            sql = sql.Replace("WHEN", data.When);
            sql = sql.Replace("ACTIONTRIGGER", data.ActionTrigger);
            sql = sql.Replace("SCRIPT", data.Script);
            return sql;
        }

        public override Form StartCreateForm(DBConnection connection)
        {
            return new TriggerCU(connection);

        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }


    public class IndexManager : DBManager
    {

        public IndexManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = @"ALTER TABLE [TABLENAME]
	                            DROP CONSTRAINT IF EXISTS MYOBJECTNAME";
            TypeId = "Index";

        }

        public override string CreateQuery(List<string> objectId)
        {
            throw new NotImplementedException();
        }

        public override string DeleteQuery(string objectId)
        {
            var values = objectId.Split('|');
            var query = DeleteCommand.Replace(KeyValue, values[0]);
            query = query.Replace("[TABLENAME]", values[1]);
            return query;
        }

        public override Form StartCreateForm(DBConnection connection)
        {
            throw new NotImplementedException();
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }

    public class ViewManager : DBManager
    {

        public ViewManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = @"DROP VIEW IF EXISTS [MYOBJECTNAME]";
            TypeId = "View";

        }

        public override string CreateQuery(List<string> objectId)
        {
            throw new NotImplementedException();
        }

        public override Form StartCreateForm(DBConnection connection)
        {
            throw new NotImplementedException();
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }

    public class CheckManager : DBManager
    {

        public CheckManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = @"ALTER TABLE [TABLENAME]
                            DROP CONSTRAINT [MYOBJECTNAME];";
            CreateCommand = @"ALTER TABLE TABLENAME   
                            ADD CONSTRAINT CHECKNAME
                            CHECK(CONDITION);";
            TypeId = "Check";

        }

        public override string CreateQuery(List<string> objectId)
        {
            throw new NotImplementedException();
        }

        public override string DeleteQuery(string objectId)
        {
            var values = objectId.Split('|');
            var query = DeleteCommand.Replace(KeyValue, values[0]);
            query = query.Replace("TABLENAME", values[1]);
            return query;
        }

        public override Form StartCreateForm(DBConnection connection)
        {
            return new CheckCU(connection);
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }

        public string CreateQuery(CheckData checkHelper)
        {
            var sql = CreateCommand.Replace("TABLENAME", checkHelper.Table);
            sql = sql.Replace("CHECKNAME", checkHelper.Name);
            sql = sql.Replace("CONDITION", checkHelper.Script);
            return sql;
        }
    }


    public class ProcedureManager : DBManager
    {

        public ProcedureManager()
        {
            KeyValue = "MYOBJECTNAME";
            CreateCommand = @"CREATE PROCEDURE [PROCEDURE_NAME]
                                    VARS
                            AS
                            BEGIN
                                SCRIPT                                
                            END";

            DeleteCommand = @"DROP PROCEDURE IF EXISTS [MYOBJECTNAME]";
            TypeId = "Procedure";

        }

        public override string CreateQuery(List<string> objectId)
        {
            throw new NotImplementedException();
        }

        public string CreateQuery(ProcedureData data)
        {
            var sql = CreateCommand.Replace("[PROCEDURE_NAME]", data.Name);
            sql = sql.Replace("VARS", data.Vars);
            sql = sql.Replace("SCRIPT", data.Script);
            return sql;
        }

        public override string DeleteQuery(string objectId)
        {
            objectId = objectId.Split('|')[0];
            return base.DeleteQuery(objectId);
        }

        public override Form StartCreateForm(DBConnection connection)
        {
            return new ProcedureCU(connection);
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }

    public class FunctionManager : DBManager
    {

        public FunctionManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = @"DROP FUNCTION IF EXISTS [MYOBJECTNAME]";
            CreateCommand = @"Create Function FUNCTIONAME()
                            returns RETURNTYPE as
                            Begin
                                SCRIPTO
                            end;";
            TypeId = "Function";

        }

        public override string CreateQuery(List<string> objectId)
        {
            throw new NotImplementedException();
        }

        public string CreateQuery(FunctionData data)
        {
            var sql = CreateCommand.Replace("FUNCTIONAME", data.Name);
            sql = sql.Replace("RETURNTYPE", data.ReturnType);
            sql = sql.Replace("SCRIPTO", data.Script);
            return sql;
        }

        public override string DeleteQuery(string objectId)
        {
            objectId = objectId.Split('|')[0];
            return base.DeleteQuery(objectId);
        }

        public override Form StartCreateForm(DBConnection connection)
        {
            return new FunctionCU(connection);
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }





}

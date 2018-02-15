using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Comunes
{
    public abstract class DBManager
    {
        public string DeleteCommand { get; set; }
        public string UpdateCommand { get; set; }
        public string KeyValue { get; set; }
        public string TypeId { get; set; }


        public abstract string DeleteQuery(string objectId);
        public abstract string UpdateQuery(string objectId);
    }

    public class TableManager : DBManager
    {
        public TableManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = "DROP TABLE IF EXISTS [MYOBJECTNAME]";
            TypeId = "Table";
        }

        public override string DeleteQuery(string objectId)
        {
            var query = DeleteCommand.Replace(KeyValue, objectId);
            return query;
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
            TypeId = "Trigger";

        }

        public override string DeleteQuery(string objectId)
        {
            var query = DeleteCommand.Replace(KeyValue, objectId);
            return query;
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

        public override string DeleteQuery(string objectId)
        {
            var values = objectId.Split('|');
            var query = DeleteCommand.Replace(KeyValue, values[0]);
            query = query.Replace("[TABLENAME]", values[1]);
            return query;
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

        public override string DeleteQuery(string objectId)
        {
            var query = DeleteCommand.Replace(KeyValue, objectId);
            return query;
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
            TypeId = "Check";

        }

        public override string DeleteQuery(string objectId)
        {
            var values = objectId.Split('|');
            var query = DeleteCommand.Replace(KeyValue, values[0]);
            query = query.Replace("TABLENAME", values[1]);
            return query;
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }


    public class ProcedureManager : DBManager
    {

        public ProcedureManager()
        {
            KeyValue = "MYOBJECTNAME";
            DeleteCommand = @"DROP PROCEDURE IF EXISTS [MYOBJECTNAME]";
            TypeId = "Procedure";

        }

        public override string DeleteQuery(string objectId)
        {
            objectId = objectId.Split('|')[0];
            var query = DeleteCommand.Replace(KeyValue, objectId);
            return query;
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
            TypeId = "Function";

        }

        public override string DeleteQuery(string objectId)
        {
            objectId = objectId.Split('|')[0];
            var query = DeleteCommand.Replace(KeyValue, objectId);
            return query;
        }

        public override string UpdateQuery(string objectId)
        {
            throw new NotImplementedException();
        }
    }





}

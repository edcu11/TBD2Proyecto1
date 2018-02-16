using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Comunes
{
    class Tools
    {
    }

    public class ColumnData
    {
        public string name;
        public string type;
        public string notNull;
        public string primary;
        public string foreign;
        public string foreignTable;
        public string foreignColumn;

        public ColumnData(string name, string type, string notNull, string primary, string foreign, string foreignTable, string foreignColumn)
        {
            this.name = name;
            this.type = type;
            this.notNull = notNull;
            this.primary = primary;
            this.foreign = foreign;
            this.foreignTable = foreignTable;
            this.foreignColumn = foreignColumn;
        }

        public ColumnData(string name, string type, string notNull, string primary, string foreign)
        {
            this.name = name;
            this.type = type;
            this.notNull = (notNull.Equals("True"))? string.Empty : "NOT NULL";
            this.primary = primary;
            this.foreign = foreign;
            this.foreignColumn = string.Empty;
            this.foreignTable = string.Empty;
        }

        public string[] ToStringArrya()
        {
            return new string[] {name, type, (notNull.Equals(string.Empty))? "True":"False",
                                primary, foreign, foreignTable, foreignColumn};
        }

        public string GenerateString()
        {
            return ", " + name + " " + type + " " + notNull + " ";
        }

        public bool IsPrimary()
        {
            return primary.Equals("True");
        }

        public bool IsForeign()
        {
            return foreign.Equals("True");
        }

        public string PrimaryConstraintQuery(string primaryKeyQuery, string tableName)
        {
            if (!primaryKeyQuery.Equals(string.Empty))
                return AddASNewPrimaryKey(primaryKeyQuery);

            var sql = "CONSTRAINT PK_TABLENAME PRIMARY KEY(COLUMNAME)";
            sql = sql.Replace("TABLENAME", tableName);
            sql = sql.Replace("COLUMNAME", name);
            return sql;
        }

        private string AddASNewPrimaryKey(string primaryKeyQuery)
        {
            var posStart = primaryKeyQuery.LastIndexOf(')');
            return primaryKeyQuery.Insert(posStart - 1, ", " + name);
        }

        public string ForeignConstraintQuery(string fKquery, string tableName)
        {

            string sql = "CONSTRAINT FK_TABLENAME_RTABLE FOREIGN KEY (COLUMNAME) REFERENCES RTABLE(RCOLUMN)";
            sql = sql.Replace("COLUMNAME", name);
            sql = sql.Replace("TABLENAME", tableName);
            sql = sql.Replace("RTABLE", foreignTable);
            sql = sql.Replace("RCOLUMN", foreignColumn);
            return sql;

        }
    }

    public class TriggerData
    {
        public string Name { get; set; }
        public string Table { get; set; }
        public string When { get; set; }
        public string ActionTrigger { get; set; }
        public string Script { get; set; }

        public TriggerData(string name, string table, string when, string script)
        {
            Name = name;
            Table = table;
            When = when;
            Script = script;
        }

        public void DefineActionTrigger(bool ins, bool del, bool upd)
        {
            ActionTrigger = string.Empty;
            var triggers = new List<string>();
            var comma = ",";
            if (ins)
            {
                triggers.Add("INSERT");
            }

            if (del)
            {
                comma = NeedsComma(triggers);
                triggers.Add(comma + "DELETE");
            }
            if (upd)
            {
                triggers.Add(comma + "UPDATE");
            }

            ActionTrigger = ConcatActions(triggers);

        }

        private string ConcatActions(List<string> triggers)
        {
            var result = string.Empty;
            foreach (var item in triggers)
            {
                result += item;
            }
            return result;
        }

        private string NeedsComma(List<string> triggers)
        {
            return (triggers.FirstOrDefault() == null) ? " " : ",";
        }
    }

    public class CheckData
    {
        public string Name { get; set; }
        public string Table { get; set; }
        public string Script { get; set; }

        public CheckData(string name, string table, string script)
        {
            Name = name;
            Table = table;
            Script = script;
        }
    }

    public class ProcedureData
    {
        public string Name { get; set; }
        public string Vars { get; set; }
        public string Script { get; set; }

        public ProcedureData(string name, string vars, string script)
        {
            Name = name;
            Vars = vars;
            Script = script;
        }
    }

    public class FunctionData
    {
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public string Script { get; set; }

        public FunctionData(string name, string returnType, string script)
        {
            Name = name;
            ReturnType = returnType;
            Script = script;
        }
    }
}

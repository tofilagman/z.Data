using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z.Data
{
    public class Args : Dictionary<string, object>
    {
        public Args(string ColumnName, object Value)
        {
            base.Add(ColumnName, Value);
        }

        public new Args Add(string column, object value)
        {
            base.Add(column, value);
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z.Data
{
    public class SBuilder : IDisposable
    {
        private StringBuilder sb = new StringBuilder();

        public void Append(object str)
        {
            sb.Append(str);
        }

        public void Append(string str, params object[] args)
        {
            this.Append(string.Format(str, args));
        }

        public void AppendLine(string str)
        {
            sb.AppendLine(str);
        }

        public void AppendLine(string str, params object[] args)
        {
            this.AppendLine(string.Format(str, args));
        }

        public override string ToString()
        {
            return sb.ToString();
        }

        public void Dispose()
        {
            sb = null;
            GC.Collect();
        }
    }
}

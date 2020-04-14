using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class ListEventArgs
    {
        private int oldCount;
        private int newCount;
        public ListEventArgs() { }
        public ListEventArgs(int oldCount, int newCount)
        {
            this.oldCount = oldCount;
            this.newCount = newCount;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhannaBeauty
{
    public class Proc
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime recDate { get; set; }
        public string WorkerFIO { get; set; }

        public Proc(int procID, string procName, DateTime procDateTime, string procFIO)
        {
            this.ID = procID;
            this.Name = procName;
            this.recDate = procDateTime;
            this.WorkerFIO = procFIO;
        }
    }
}

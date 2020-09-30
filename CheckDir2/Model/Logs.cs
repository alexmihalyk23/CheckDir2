using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDir2.Model
{
    public class Logs
    {
        public DateTime StartTime { get; set; }
        public string PathToFolder{ get; set; }
        public int NumberOfDeleteFolders { get; set; }
        public override string ToString()
        {
            return $"{StartTime}\t{PathToFolder}\t{NumberOfDeleteFolders}";
        }
    }
}

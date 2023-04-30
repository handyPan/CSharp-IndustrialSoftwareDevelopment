using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCClientApp
{   
    public class OPCItem
    {
        /// <summary>
        /// OPCItem name
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// OPCItem value
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// OPCItem timestamp
        /// </summary>
        public string Time { get; set; }
    }
}

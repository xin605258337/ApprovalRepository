using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval.Entity
{
   public class ApprovalNode
    {
        public int NodeID { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public int UserID { get; set; }
    }
}

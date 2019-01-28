using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval.Entity
{
    /// <summary>
    /// 状态表
    /// </summary>
 public  class ApprovalState
    {
        /// <summary>
        /// id
        /// </summary>
        public int StateID { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string StateName { get; set; }
    }
}

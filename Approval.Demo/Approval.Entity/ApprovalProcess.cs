using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval.Entity
{
    /// <summary>
    /// --审批流程表
    /// </summary>
    public class ApprovalProcess
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ProcessID { get; set; }

        /// <summary>
        /// 审批流程名称
        /// </summary>
        public string ProcessName { get; set; }

    }
}

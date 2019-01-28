using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval.Entity
{
    /// <summary>
    /// --审批条件表
    /// </summary>
    public class ApprovalCondition
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ConditionID { get; set; }
        /// <summary>
        /// 条件名称
        /// </summary>
        public string ConditionName { get; set; }
    }
}

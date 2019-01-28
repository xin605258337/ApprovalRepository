using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval.Entity
{
    /// <summary>
    /// 审批流程配置表
    /// </summary>
    public class ApprovalConfiguration
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ConfigurationID { get; set; }

        /// <summary>
        /// 审批流程ID
        /// </summary>
        public int ProcessID { get; set; }

        /// <summary>
        /// 审批节点ID
        /// </summary>
        public int NodeID { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>

        public int ApprovalUserID { get; set; }

        /// <summary>
        /// 下一步审批人
        /// </summary>
        public int NextApprovalUserID { get; set; }

        /// <summary>
        /// 审批状态
        /// </summary>
        public int StateID { get; set; }

        /// <summary>
        /// 审批条件
        /// </summary>
        public int ConditionID { get; set; }

        /// <summary>
        /// 是否是开头
        /// </summary>
        public int IsFirst { get; set; }

        /// <summary>
        /// 使用用户
        /// </summary>
       public int UseUser { get; set; }

       ///////////

        /// <summary>
        /// 条件名称
        /// </summary>
        public string ConditionName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string StateName { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; }

        /// <summary>
        /// 审批流程名称
        /// </summary>
        public string ProcessName { get; set; }
    }
}

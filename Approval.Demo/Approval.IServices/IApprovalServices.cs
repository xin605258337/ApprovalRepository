using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval.IServices
{
    using Approval.Entity;
    public interface IApprovalServices
    {
        /// <summary>
        /// 添加审批配置
        /// </summary>
        /// <param name="approvalConfiguration"></param>
        /// <returns></returns>
        int Add(ApprovalConfiguration approvalConfiguration);

        /// <summary>
        /// 获取审批配置信息
        /// </summary>
        /// <returns></returns>
        List<ApprovalConfiguration> GetApprovalConfigurations();

        /// <summary>
        /// 删除审批配置信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);

        /// <summary>
        /// 获取审批条件信息
        /// </summary>
        /// <returns></returns>
        List<ApprovalCondition> GetApprovalConditions();

        /// <summary>
        /// 获取审批节点信息
        /// </summary>
        /// <returns></returns>
        List<ApprovalNode> GetApprovalNodes();

        /// <summary>
        /// 获取审批流程信息
        /// </summary>
        /// <returns></returns>
        List<ApprovalProcess> GetApprovalProcesses();

        /// <summary>
        /// 获取审批状态信息
        /// </summary>
        /// <returns></returns>
        List<ApprovalState> GetApprovalStates();

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        List<Users> GetUsers();
    }
}

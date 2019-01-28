using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Approval.Api.Controllers
{
    using Approval.Entity;
    using Approval.Services;
    using Approval.IServices;
    public class ApprovalConfigurationController : ApiController
    {
        public IApprovalServices ApprovalServices { get; set; }

        /// <summary>
        /// 添加审批配置
        /// </summary>
        /// <param name="approvalConfiguration"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")]
        public int Add(ApprovalConfiguration approvalConfiguration)
        {
            return ApprovalServices.Add(approvalConfiguration);
        }
        /// <summary>
        /// 获取审批配置信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalConfigurations")]
        public List<ApprovalConfiguration> GetApprovalConfigurations()
        {
            return ApprovalServices.GetApprovalConfigurations();
        }
        /// <summary>
        /// 删除审批配置信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Delete")]
        public int Delete(int id)
        {
            return ApprovalServices.Delete(id);
        }
        /// <summary>
        /// 获取审批条件信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalConditions")]
        public List<ApprovalCondition> GetApprovalConditions()
        {
            return ApprovalServices.GetApprovalConditions();
        }
        /// <summary>
        /// 获取审批节点信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalNodes")]
        public List<ApprovalNode> GetApprovalNodes()
        {
            return ApprovalServices.GetApprovalNodes();
        }
        /// <summary>
        /// 获取审批流程信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalProcesses")]
        public List<ApprovalProcess> GetApprovalProcesses()
        {
            return ApprovalServices.GetApprovalProcesses();
        }
        /// <summary>
        /// 获取审批状态信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalStates")]
        public List<ApprovalState> GetApprovalStates()
        {
            return ApprovalServices.GetApprovalStates();
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUsers")]
        public List<users> GetUsers()
        {
            return ApprovalServices.GetUsers();
        }
    }
}

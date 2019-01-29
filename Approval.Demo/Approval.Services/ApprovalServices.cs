using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval.Services
{
    using Approval.Entity;
    using System.Data;
    using System.Data.SqlClient;
    using Dapper;
    using Approval.IServices;
    public class ApprovalServices:IApprovalServices
    {
        /// <su添加审批配置mmary>
        /// 
        /// </summary>
        /// <param name="approvalConfiguration"></param>
        /// <returns></returns>
        public int Add(ApprovalConfiguration approvalConfiguration)
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                //string sql = @"insert into ApprovalConfiguration(ProcessID,NodeID,ApprovalUserID,NextApprovalUserID,StateID,ConditionID,IsFirst,UseUser) values(:ProcessID,:NodeID,:ApprovalUserID,:NextApprovalUserID,:StateID,:ConditionID,:IsFirst,:UseUser)";

                string sql = string.Format("insert into ApprovalConfiguration(ProcessID,NodeID,ApprovalUserID,NextApprovalUserID,StateID,ConditionID,IsFirst,UseUser) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", approvalConfiguration.ProcessID, approvalConfiguration.NodeID, approvalConfiguration.ApprovalUserID, approvalConfiguration.NextApprovalUserID, approvalConfiguration.StateID, approvalConfiguration.ConditionID, approvalConfiguration.IsFirst, approvalConfiguration.UseUser);     
                return conn.Execute(sql, null);
            }
        }
        /// <summary>
        /// 获取审批配置信息
        /// </summary>
        /// <returns></returns>
        public List<ApprovalConfiguration> GetApprovalConfigurations()
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "select c.*,a.ConditionName,n.NodeName,n.UserID,d.UserName,p.ProcessName,s.StateName,u.UserName,b.UserName from ApprovalConfiguration c inner join ApprovalCondition a on c.ConditionID = a.ConditionID inner join users d on n.UserID = d.UserID inner join ApprovalProcess p on c.ProcessID = p.ProcessID inner join ApprovalState s on c.StateID = s.StateID inner join users u on c.NextApprovalUserID = u.UserID inner join users b on c.UseUser = b.UserID";
                return conn.Query<ApprovalConfiguration>(sql, null).ToList();
            }
        }
        /// <summary>
        /// 删除审批配置信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "delete from ApprovalConfiguration where ConfigurationID=:ConfigurationID";
                return conn.Execute(sql, new { ConfigurationID =id});
            }
        }
        /// <summary>
        /// 获取审批条件信息
        /// </summary>
        /// <returns></returns>
        public List<ApprovalCondition> GetApprovalConditions()
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "select * from ApprovalCondition";
                return conn.Query<ApprovalCondition>(sql,null).ToList();
            }
        }
        /// <summary>
        /// 获取审批节点信息
        /// </summary>
        /// <returns></returns>
        public List<ApprovalNode> GetApprovalNodes()
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "select * from ApprovalNode";
                return conn.Query<ApprovalNode>(sql, null).ToList();
            }
        }
        /// <summary>
        /// 获取审批流程信息
        /// </summary>
        /// <returns></returns>
        public List<ApprovalProcess> GetApprovalProcesses()
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "select * from ApprovalProcess";
                return conn.Query<ApprovalProcess>(sql, null).ToList();
            }
        }
        /// <summary>
        /// 获取审批状态信息
        /// </summary>
        /// <returns></returns>
        public List<ApprovalState> GetApprovalStates()
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "select * from ApprovalState";
                return conn.Query<ApprovalState>(sql, null).ToList();
            }
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUsers()
        {
            using (SqlConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = "select * from users";
                return conn.Query<Users>(sql, null).ToList();
            }
        }
    }
}

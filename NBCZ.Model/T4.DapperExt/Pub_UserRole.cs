//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2018-08-17 11:06:13
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour CTS
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using DapperExtensions.Mapper;
using Dapper.Contrib.Extensions;
using Newtonsoft.Json;

namespace NBCZ.Model
{	
    [Table("Pub_UserRole")]
[JsonObject(MemberSerialization.OptIn)]

    public  partial class Pub_UserRole
    {
     		 /// <summary>
     	/// 自增主键
     	/// </summary>
		 [ExplicitKey]
		 [JsonProperty]	
		public int Id { get; set; }

		 /// <summary>
     	/// 用户编号
     	/// </summary>
		 [JsonProperty]	
		public string UserCode { get; set; }

		 /// <summary>
     	/// 角色编号
     	/// </summary>
		 [JsonProperty]	
		public string RoleCode { get; set; }

		 /// <summary>
     	/// 最后编辑人
     	/// </summary>
		 [JsonProperty]	
		public string Lmid { get; set; }

		 /// <summary>
     	/// 最后编辑时间
     	/// </summary>
		 [JsonProperty]	
		public DateTime? Lmdt { get; set; }

		 /// <summary>
     	/// 停用状态 默认0 未停用 1 停用
     	/// </summary>
		 [JsonProperty]	
		public bool? StopFlag { get; set; }

		   
    }
}


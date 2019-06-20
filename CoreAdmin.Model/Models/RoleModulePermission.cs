    //----------RoleModulePermission开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class RoleModulePermission//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  Id { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public bool  ? IsDeleted { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  RoleId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ModuleId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? PermissionId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? CreateId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  CreateBy { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? CreateTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? ModifyId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ModifyBy { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? ModifyTime { get; set; }
 

    }
}
    //----------RoleModulePermission结束----------
    
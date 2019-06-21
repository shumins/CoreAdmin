    //----------SysRoleRelation开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysRoleRelation//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  RoleID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  MenuID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? SortIndex { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------SysRoleRelation结束----------
    
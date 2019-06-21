    //----------SysEmplore开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysEmplore//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  EmID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  DeptID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  RoleID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  LoginName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Password { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ChineseName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PhoneNumber { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Sex { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? SortIndex { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? RegisterTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? LoginTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------SysEmplore结束----------
    
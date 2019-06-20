    //----------OperateLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class OperateLog//可以在这里加上基类等
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
      public string  Area { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Controller { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Action { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  IPAddress { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Description { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? LogTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  LoginName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  UserId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? User_uID { get; set; }
 

    }
}
    //----------OperateLog结束----------
    
    //----------User开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class User//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  ID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  LoginName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  LoginPWD { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  RealName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  Status { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Remark { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  CreateTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  UpdateTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  LastErrTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ErrorCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? sex { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? age { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? birth { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  addr { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public bool  ? tdIsDelete { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  HeadImg { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Email { get; set; }
 

    }
}
    //----------User结束----------
    
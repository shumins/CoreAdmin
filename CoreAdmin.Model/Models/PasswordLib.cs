    //----------PasswordLib开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class PasswordLib//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  PLID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public bool  ? IsDeleted { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  plURL { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  plPWD { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  plAccountName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? plStatus { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? plErrorCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  plHintPwd { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  plHintquestion { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? plCreateTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? plUpdateTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? plLastErrTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  test { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  test3 { get; set; }
 

    }
}
    //----------PasswordLib结束----------
    
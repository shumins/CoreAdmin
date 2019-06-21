    //----------PwdInputErrorStatistics开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class PwdInputErrorStatistics//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  LoginDate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  LoginName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? InputErrorNum { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------PwdInputErrorStatistics结束----------
    
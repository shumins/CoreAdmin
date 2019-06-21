    //----------SysHandleDialyLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysHandleDialyLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  HandleType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  HandleUser { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? HandleNum { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? CreateDate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------SysHandleDialyLog结束----------
    
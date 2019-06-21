    //----------ClipClearInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ClipClearInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UnID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  SourceID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  SourceType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FieldName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? ClipType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ClipUrl { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? IsDelete { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------ClipClearInfo结束----------
    
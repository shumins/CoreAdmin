    //----------ClipIdentifyDailyLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ClipIdentifyDailyLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  IdentifyDate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? IdentifyTotalCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? PronoCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? SexyCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? NormalCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? UnPronoCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? UnSexyCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? UnNormalCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? ErrorCount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------ClipIdentifyDailyLog结束----------
    
    //----------ClipIdentifyInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ClipIdentifyInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  BussID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? BussType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  CallType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? Role { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? PronoResult { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ClipDate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Remark { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? Flag { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ClipContent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? HandleBatch { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  HandleContent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  HandleUser { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? HandleTime { get; set; }
 

    }
}
    //----------ClipIdentifyInfo结束----------
    
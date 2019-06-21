    //----------KnowReport开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class KnowReport//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? ReportType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ReportID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? MemberID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? BeMemberID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? ReportFlag { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? ReportTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ReportStep { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ReportText { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? HandleBatch { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  HandleUser { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? HandleTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ReportEntrance { get; set; }
 

    }
}
    //----------KnowReport结束----------
    
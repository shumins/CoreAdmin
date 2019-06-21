    //----------FeedBack开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class FeedBack//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? FB_MemberID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? FB_Time { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_Content { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_Comment { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? FB_Flag { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_ContactTel { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_PhoneOS { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_PhoneModel { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_APPVersion { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_NetSys { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_NetOperator { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_Recorder { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_Type { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_Source { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_IMG1 { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_IMG2 { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_IMG3 { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FB_IMG4 { get; set; }
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
      public byte  ? HandleBatch { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Remark { get; set; }
 

    }
}
    //----------FeedBack结束----------
    
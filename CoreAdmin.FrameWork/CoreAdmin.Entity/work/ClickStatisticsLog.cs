    //----------ClickStatisticsLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ClickStatisticsLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  CreateDate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PageName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? ClickNum { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? SystemType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? RegionType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? IsInviteUrl { get; set; }
 

    }
}
    //----------ClickStatisticsLog结束----------
    
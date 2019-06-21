    //----------ChannelPromoteStatistics开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ChannelPromoteStatistics//可以在这里加上基类等
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
      public string  ChannelCode { get; set; }
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
 

    }
}
    //----------ChannelPromoteStatistics结束----------
    
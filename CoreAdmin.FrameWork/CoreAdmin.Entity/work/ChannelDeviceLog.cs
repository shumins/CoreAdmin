    //----------ChannelDeviceLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ChannelDeviceLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ChannelCode { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  DeviceID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  UserType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  CreateDate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------ChannelDeviceLog结束----------
    
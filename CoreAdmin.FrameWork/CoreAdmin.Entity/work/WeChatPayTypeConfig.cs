    //----------WeChatPayTypeConfig开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WeChatPayTypeConfig//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public byte  AppType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  AppTypeName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? PayType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? IsAllowSDK { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? IsAllowH5 { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------WeChatPayTypeConfig结束----------
    
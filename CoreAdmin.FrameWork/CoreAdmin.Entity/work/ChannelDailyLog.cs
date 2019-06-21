    //----------ChannelDailyLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ChannelDailyLog//可以在这里加上基类等
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
      public string  CreateDate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? RegNum { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? PayMoney { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? NewDevice { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? Active_Next { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? Active_NextPercent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? Buckle { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? MoneyType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? VIPPurchaseAmount { get; set; }
 

    }
}
    //----------ChannelDailyLog结束----------
    
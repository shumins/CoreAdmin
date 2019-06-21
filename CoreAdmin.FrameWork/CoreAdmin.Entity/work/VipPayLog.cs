    //----------VipPayLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class VipPayLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PayType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Out_Trade_No { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  MemberID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? MonthNum { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  Total_Fee { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? TradeTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? PayTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? VipOvertime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  AppType { get; set; }
 

    }
}
    //----------VipPayLog结束----------
    
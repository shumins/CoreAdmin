    //----------BalanceHandleLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BalanceHandleLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  MemberID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  BalanceType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? Balance { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? BalanceFront { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? BalanceBehind { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? AmountType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  NoticeText { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Memo { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  CallID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  SubmitUser { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? SubmitTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? HandleFlag { get; set; }
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
      public DateTime  ? AddTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? MoneyType { get; set; }
 

    }
}
    //----------BalanceHandleLog结束----------
    
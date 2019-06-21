    //----------CurPayHandleLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class CurPayHandleLog//可以在这里加上基类等
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
      public int  ? MemberID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public decimal  ? ChargeAmount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? MoneyType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  OSName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? PayTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PayName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PayAccount { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PayPic { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  FillContent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  AuditContent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Out_Trade_No { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  AuditFlag { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  AddUser { get; set; }
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
      public string  ChargePackageID { get; set; }
 

    }
}
    //----------CurPayHandleLog结束----------
    
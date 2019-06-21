    //----------ClipIdentifyWait开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ClipIdentifyWait//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  CallID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  CallType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? PickerProno { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? DialerProno { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? PickerIsHandle { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? DialerIsHandle { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? PickerHandleTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? DialerHandleTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------ClipIdentifyWait结束----------
    
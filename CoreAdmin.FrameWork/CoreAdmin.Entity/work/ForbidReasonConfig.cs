    //----------ForbidReasonConfig开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ForbidReasonConfig//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ForbidText_SCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ForbidText_TCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ForbidText_ENG { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? ForbidType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? SortIndex { get; set; }
 

    }
}
    //----------ForbidReasonConfig结束----------
    
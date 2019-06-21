    //----------VIPPrivilegeConfig开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class VIPPrivilegeConfig//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  UNID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Title_SCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Title_TCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Title_ENG { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Brief_SCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Brief_TCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Brief_ENG { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Description_SCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Description_TCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Description_ENG { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PrivilegeIMG_SCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PrivilegeIMG_TCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  PrivilegeIMG_ENG { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? ShowType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? PrivilegeType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public byte  ? SortIndex { get; set; }
 

    }
}
    //----------VIPPrivilegeConfig结束----------
    
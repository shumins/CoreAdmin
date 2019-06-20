    //----------Guestbook开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class Guestbook//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  id { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  blogId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  createdate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  username { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  phone { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  QQ { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  body { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ip { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public bool  isshow { get; set; }
 

    }
}
    //----------Guestbook结束----------
    
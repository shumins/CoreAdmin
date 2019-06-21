    //----------AuthorLogin开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class AuthorLogin//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  UUID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? BindID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? ExpiredTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? AuthorType { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------AuthorLogin结束----------
    
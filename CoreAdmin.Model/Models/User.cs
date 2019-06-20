    //----------User开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class User//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// ID
	  /// </summary>
      public int  Id { get; set; }
       /// <summary>
      /// 名称
	  /// </summary>
      public string  Name { get; set; }
       /// <summary>
      /// 密码
	  /// </summary>
      public string  Pwd { get; set; }
 

    }
}
    //----------User结束----------
    
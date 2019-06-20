    //----------Topic开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class Topic//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  Id { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tLogo { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tDetail { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tSectendDetail { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public bool  tIsDelete { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  tRead { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  tCommend { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  tGood { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  tCreatetime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  tUpdatetime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tAuthor { get; set; }
 

    }
}
    //----------Topic结束----------
    
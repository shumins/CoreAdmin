    //----------TopicDetail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class TopicDetail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  Id { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  TopicId { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tdLogo { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tdName { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tdContent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tdDetail { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tdSectendDetail { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public bool  tdIsDelete { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  tdRead { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  tdCommend { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  tdGood { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  tdCreatetime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  tdUpdatetime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  tdTop { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  tdAuthor { get; set; }
 

    }
}
    //----------TopicDetail结束----------
    
    //----------Advertisement开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class Advertisement//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// ID
	  /// </summary>
      public int  Id { get; set; }
       /// <summary>
      /// 创建时间
	  /// </summary>
      public DateTime  Createdate { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ImgUrl { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Title { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Url { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  Remark { get; set; }
 

    }
}
    //----------Advertisement结束----------
    
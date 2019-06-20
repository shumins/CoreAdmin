    //----------BlogArticle开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BlogArticle//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public int  bID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  bsubmitter { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  btitle { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  bcategory { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  bcontent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  btraffic { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  bcommentNum { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  bUpdateTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  bCreateTime { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  bRemark { get; set; }
 

    }
}
    //----------BlogArticle结束----------
    
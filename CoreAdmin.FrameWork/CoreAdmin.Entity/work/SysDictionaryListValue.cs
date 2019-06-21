    //----------SysDictionaryListValue开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysDictionaryListValue//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  MenuID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ParentID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ListID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  MenuNameCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  MenuNameEN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  MenuUrl { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  MenuRemark { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public int  ? SortIndex { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  IsParent { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------SysDictionaryListValue结束----------
    
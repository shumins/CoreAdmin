    //----------SysDictionaryList开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysDictionaryList//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息
       /// <summary>
      /// 
	  /// </summary>
      public string  ListID { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ListNameCN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public string  ListNameEN { get; set; }
       /// <summary>
      /// 
	  /// </summary>
      public DateTime  ? AddTime { get; set; }
 

    }
}
    //----------SysDictionaryList结束----------
    
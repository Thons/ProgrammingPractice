#define PRO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH02CoreCSharp
{
    /*
     * 这是多行注释
     * */
    //这是单行注释

    /// <summary>
    /// 
    /// </summary>
    class UseComment
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        static void Main(string[ ] args)
        {
            Console.WriteLine(/*这还是一个注释*/"这才是真正的字符串");
            string s = "/*这不是注释*/";

#if PRO
            Console.WriteLine("这是专业版");
#elif ENT
            Console.WriteLine("这是企业版");
#else
            Console.WriteLine("这是普遍版");
#endif

            #region 错误条件编译块
#if PRO&&ENT
#error "不能同时编译两个版本！"
#endif
            #endregion

#warning "不要忘了移除下面的这行代码"
            Console.ReadLine();
        }
    }
}
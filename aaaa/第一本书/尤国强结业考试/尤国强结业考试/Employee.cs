using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 尤国强结业考试
{
    public abstract class Employee
    {
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Names { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        public Employee() { }
        public abstract void SayHi();
    }
}

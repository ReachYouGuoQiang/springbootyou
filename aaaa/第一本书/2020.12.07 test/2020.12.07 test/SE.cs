using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._12._07_test
{
    public class SE : Employee
    {
        public int Popularity { get; set; }

        public SE() { }
        public SE(int age, int ID, string name, string sex, int popularity)
        {
            base.Age = age;
            base.ID = ID;
            base.Name = name;
            base.Sex = sex;
            this.Popularity = popularity;
        }

        public override void SayHi()
        {
            string s = string.Format("大家好，我是{0}，今年{1}岁，性别{2}，我的受欢迎指数为{3}",
                this.Name, this.Age, this.Sex, this.Popularity);
            System.Windows.Forms.MessageBox.Show(s);
        }
    }
}

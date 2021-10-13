using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._12._07_test
{
    public class PM : Employee
    {
        public int Experience { get; set; }

        public PM() { }
        public PM(int age, int ID, string name, string sex, int experience)
        {
            base.Age = age;
            base.ID = ID;
            base.Name = name;
            base.Sex = sex;
            this.Experience = experience;
        }

        public override void SayHi()
        {
            string s = string.Format("大家好，我是{0}，今年{1}岁，性别{2}，我拥有{3}年的项目管理经验",
                this.Name, this.Age, this.Sex, this.Experience);
            System.Windows.Forms.MessageBox.Show(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML文件
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第一个上级练习
            ////读取节点
            //XmlDocument xml = new XmlDocument();
            //xml.Load("Student.xml");
            ////获取xml文件的节点
            //XmlNode root = xml.DocumentElement;//DocumentElementht获取的根节点
            ////利用循环遍历全部节点
            //foreach (XmlNode node in root.ChildNodes)//ChildNodes表示子节点
            //{
            //    switch(node.Name)
            //    {
            //        case "ID":
            //            Console.WriteLine("ID:{0}",node.InnerText);//InnerText表示文本里的值
            //            break;
            //        case "Name":
            //            Console.WriteLine("姓名:{0}",node.InnerText);
            //            break;
            //        case "Age":
            //            Console.WriteLine("年龄:{0}",node.InnerText);
            //            break;
            //    }
            //}
            #endregion

            #region 第二个上级练习
            //读取节点
            XmlDocument xml = new XmlDocument();
            xml.Load("Student1.xml");
            //获取xml文件的节点
            XmlNode root = xml.DocumentElement;//DocumentElementht获取的根节点
            string schoolName = root.Attributes["name"].Value;
            Console.WriteLine(schoolName);
            //遍历根节点下的全部子节点-年级节点
            foreach (XmlNode node in root.ChildNodes)
            {
                //获取年级节点里的属性
                string gradeName = node.Attributes["name"].Value;
                Console.WriteLine("\t\t{0}", gradeName);
                //遍历年级节点下的子节点-学生节点
                foreach (XmlNode studentnode in node.ChildNodes)
                {
                    //再次遍历学生节点下的姓名  年龄等子节点
                    foreach (XmlNode allnode in studentnode.ChildNodes)
                    {
                        switch (allnode.Name)
                        {
                            case "Name":
                                Console.WriteLine("\t\t\t{0}", allnode.InnerText);
                                break;
                            case "GradeName":
                                Console.WriteLine("\t\t\t{0}", allnode.InnerText);
                                break;
                            case "Age":
                                Console.WriteLine("\t\t\t{0}", allnode.InnerText);
                                break;
                        }
                    }
                }
            }
            #endregion
            
        }
    }
}
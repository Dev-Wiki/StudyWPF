using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ListViewDemo.Model {
    public class DataProvider {
        public static List<string> GetInfos() {
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++) {
                list.Add($"Test-{i}");
            }
            return list;
        }

        public static List<Person> GetPersons() {
            List<Person> list = new List<Person>();
            Person zhangsan = new Person {Age = 15, Name = "zhangsan"};
            Person lisi = new Person {Age = 16, Name = "lisi"};
            Person wangwu = new Person {Age = 15, Name = "wangwu"};
            Person zhaoliu = new Person {Age = 16, Name = "zhaoliu"};
            list.Add(zhangsan);
            list.Add(lisi);
            list.Add(wangwu);
            list.Add(zhaoliu);
            return list;
        }
    }
}
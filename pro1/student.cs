using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



//namespace pro1
//{ 
//        internal class student
//        {
//            public string name { get; set; }
//            public int mark1;
//            public int mark2;
//            int Total;
//            private int _age;
//            public int Age {

//            get { return _age; }
//            set {
//                if (value < 18 || value > 50)
//                {
//                    Console.WriteLine("invalid age");
//                    return;
//                }
//                _age = value;
//            } }

//}
//}

namespace pro1
{
    internal class employee
    {

        public string fullname { get; set; }
        
        public string    company    { get; set; }

        public int age { get; set; }

        public String email { get; set; }

        public int phone { get; set; }

    }
}
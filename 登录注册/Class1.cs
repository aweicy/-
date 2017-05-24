using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 登录注册
{
    public class Class1
    {
        private string namm;
        private string pass;
        private string styy;
        public string NAMM
        {
            set{ namm = value; }
            get{ return namm; }
            
        }
        string getNAMM()
        {
            return namm;
        }
        void setNAMM(string value)
        {
            namm = value;
        }
    }
}

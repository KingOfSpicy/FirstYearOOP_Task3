using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task_3
{
    class Company
    {
        public Company(string name, Address shippingAddress)
        {
            Name = name;
            ShippingAddress = shippingAddress;
        }

        public string Name { get; set; }//(先輸入pro 自動顯示後，按下Tab兩次，電腦會自動生成properties)
        public Address ShippingAddress { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return "Company: "+ Name +"\nShipping Address: " +ShippingAddress;
        }
        //public Company() 輸入ct Tab 兩次可得，但預期效果不佳
        //{

        //}



    }
}

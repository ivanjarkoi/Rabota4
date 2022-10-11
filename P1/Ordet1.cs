using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace P1
{
    public class Ordet1 : IOrdet1
    {
        private int orderDate;
        private DateTime orderComplete;
        private DateTime sacas;
        public OrderItem OrderItem
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public void SetInfo()
        {
            throw new System.NotImplementedException();
        }

        public void GetInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}
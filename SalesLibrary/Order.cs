using System;
using System.Collections.Generic;
using System.Text;

namespace Ternaryandaccess {
    public class Order {
    //Properties
    public int Id { get; private set; }
    public double Amount { get; set; }
    public Customer customer { get; set; }
        public Customer Customer { get; private set; }

        private static int lastId = 0;

        //Methods

        //Constructor
        static Order() {
          lastId = 0;
        }
        public Order() {
            this.Id = lastId += 7;
        }

            public void SetCustomer(Customer customer) {
            this.Customer = customer;
        }
    }
}

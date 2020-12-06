using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
    class Delivery
    {
        private int stockID;
        private int delivorID;
        private int documentNumber;
        private DateTime deliveryDate;
        private double deliveryAmount;

        public int StockID { get; set; }
        public int DelivorID { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double DeliveryAmount { get; set; }
    }
}

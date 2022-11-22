using ExercicioDeFixacao.Entities.Enums;
using System;
using System.Text;


namespace ExercicioDeFixacao.Entities {
    internal class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem> ();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client cliente) {
            Moment = moment;
            Status = status;
            Client = cliente;
        }

        public void AddItem(OrderItem items) {
            Items.Add(items);
        }
        public void RemoveItem(OrderItem items) {
            Items.Remove(items);
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem item in Items) {
                total += item.SubTotal();
            }
           return total;
        }

        public override string ToString() {
            StringBuilder txt = new StringBuilder();
            txt.AppendLine("ORDER SUMMARY: ");
            txt.Append("Order Moment: ");
            txt.Append(Moment);
            txt.AppendLine();
            txt.AppendLine("Order Status: " + Status);
            txt.Append(Client.Name + " ");
            txt.Append(Client.BirthDate + " ");
            txt.Append(" - ");
            txt.AppendLine(Client.Email);
            txt.AppendLine("Order Items");
            foreach(OrderItem item in Items) {
              txt.AppendLine(item.Product.Name + ", " + "$" + item.Price + ", " + "Quantity: " + item.Quantily + ", " + "SubTotal: " + item.SubTotal() + " ");
                
            }

            txt.AppendLine("\n Total: " + Total().ToString());

               
            return txt.ToString();
        }


    }
}

using System;


namespace ExercicioDeFixacao.Entities {
    internal class OrderItem {
        public int Quantily { get; set; }
        public double Price { get; set; }

        public Product Product = new Product();

        public OrderItem() { }

        public OrderItem(int quatily, double price , Product product) {
            Quantily = quatily;
            Price = price;
            Product = product;
        }

        public double SubTotal() {
            return Price * Quantily;
        }
    }
}

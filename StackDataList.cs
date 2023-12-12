using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopManager
{
    class Node
    {
        public Node Next;
        public Product Data;
    }
    internal class StackDataList
    {
        private Node Top;
        private int id = 1111110;
        public bool IsEmpty()
        {
            if (Top == null)
                return true;
            else return false;
        }

        public void PushNewProduct(string name, string category, int quantity, double cost, double profit)
        {
            Node prodNode = new Node();
            prodNode.Data = new Product(name, category, quantity, id, cost, profit);
            prodNode.Next = Top;
            Top = prodNode;
            id++;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            Node current = Top;
            while (current != null)
            {
                products.Add(current.Data);
                current = current.Next;
            }

            return products;
        }

        public Product GetSpecificProductById(int id)
        {
            Node current = Top;
            while (current != null)
            {
                if (current.Data.ID == id)
                    return current.Data;
                current = current.Next;
            }
            return null;
        }

        public void RemovedSpesProduct(int id)
        {
            Node p = Top;
            if (p.Data.ID == id)
            {
                Top = Top.Next;
                return;
            }
            while (p.Next.Data.ID != id)
                p = p.Next;
            p.Next = p.Next.Next;
        }
    }
}

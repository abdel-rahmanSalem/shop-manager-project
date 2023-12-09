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
        private Node top;
        private int id = 1111110;
        public bool IsEmpty()
        {
            if (top == null)
                return true;
            else return false;
        }
        public void PushNewProduct(string name, string category, int quantity, double cost, double profit)
        {
            Node prodNode = new Node();
            prodNode.Data = new Product(name, category, quantity, id, cost, profit);
            prodNode.Next = top;
            top = prodNode;
            id++;
        }
    }
}

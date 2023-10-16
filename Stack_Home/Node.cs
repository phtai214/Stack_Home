﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Home
{
    class Node
    {
        private int data;
        private Node next;
        public int Data { get { return data; } set { data = value; } }
        internal Node Next { get => next; set => next = value; }

        public Node(int x=0)
        {
            data = x;
            next = null;
        }
    }
}

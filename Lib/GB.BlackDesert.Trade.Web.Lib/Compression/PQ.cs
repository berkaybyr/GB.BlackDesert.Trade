// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.Compression.PQ
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Collections.Generic;

namespace BlackDesert.TradeMarket.Lib.Compression
{
    public class PQ
    {
        public static PriorityQueue PQ_Create(int initialSize)
        {
            PriorityQueue priorityQueue = new PriorityQueue();
            priorityQueue._capacity = initialSize;
            priorityQueue._usedSize = 0;
            priorityQueue._nodes = new List<PQNode>();
            for (int index = 0; index < priorityQueue._capacity; ++index)
                priorityQueue._nodes.Add(new PQNode());
            return priorityQueue;
        }

        public static void PQ_Enqueue(ref PriorityQueue pq, PQNode newData)
        {
            int num = pq._usedSize;
            int parent = PQ_GetParent(num);
            if (pq._usedSize == pq._capacity)
            {
                if (pq._capacity == 0)
                    pq._capacity = 1;
                pq._capacity *= 2;
                for (int index = 0; index < pq._capacity - pq._usedSize; ++index)
                    pq._nodes.Add(new PQNode());
            }
            pq._nodes[num] = newData;
            for (; num > 0 && pq._nodes[num]._priority < pq._nodes[parent]._priority; parent = PQ_GetParent(num))
            {
                PQ_SwapNodes(pq, num, parent);
                num = parent;
            }
            ++pq._usedSize;
        }

        public static void PQ_Dequeue(PriorityQueue pq, ref PQNode root)
        {
            int num1 = 0;
            root = pq._nodes[0];
            pq._nodes[0] = null;
            --pq._usedSize;
            PQ_SwapNodes(pq, 0, pq._usedSize);
            int leftChild = PQ_GetLeftChild(0);
            int index = leftChild + 1;
            while (true)
            {
                if (leftChild < pq._usedSize)
                {
                    int num2 = index < pq._usedSize ? pq._nodes[leftChild]._priority <= pq._nodes[index]._priority ? leftChild : index : leftChild;
                    if (pq._nodes[num2]._priority < pq._nodes[num1]._priority)
                    {
                        PQ_SwapNodes(pq, num1, num2);
                        num1 = num2;
                        leftChild = PQ_GetLeftChild(num1);
                        index = leftChild + 1;
                    }
                    else
                        break;
                }
                else
                    break;
            }
            if (pq._usedSize >= pq._capacity / 2)
                return;
            pq._capacity /= 2;
            pq._nodes.RemoveRange(pq._usedSize, pq._capacity);
        }

        public static int PQ_GetParent(int index) => (index - 1) / 2;

        public static int PQ_GetLeftChild(int index) => 2 * index + 1;

        public static void PQ_SwapNodes(PriorityQueue pq, int index1, int index2)
        {
            PQNode pqNode = new PQNode();
            PQNode node = pq._nodes[index1];
            pq._nodes[index1] = pq._nodes[index2];
            pq._nodes[index2] = node;
        }

        public static bool PQ_IsEmpty(PriorityQueue pq) => pq._usedSize == 0;

        public class PQNode
        {
            public int _priority;
            public object _data;

            public PQNode()
            {
                _priority = 0;
                _data = null;
            }

            public PQNode(int priority, object data)
            {
                _priority = priority;
                _data = data;
            }
        }

        public class PriorityQueue
        {
            public List<PQNode> _nodes;
            public int _capacity;
            public int _usedSize;

            public PriorityQueue()
            {
                _nodes = new List<PQNode>();
                _capacity = 0;
                _usedSize = 0;
            }
        }
    }
}

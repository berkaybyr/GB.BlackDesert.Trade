// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.Compression.PQ
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Lib.Common.Compression
{
    public class PQ
    {
        public static PQ.PriorityQueue PQ_Create(int initialSize)
        {
            PQ.PriorityQueue priorityQueue = new PQ.PriorityQueue();
            priorityQueue._capacity = initialSize;
            priorityQueue._usedSize = 0;
            priorityQueue._nodes = new List<PQ.PQNode>();
            for (int index = 0; index < priorityQueue._capacity; ++index)
                priorityQueue._nodes.Add(new PQ.PQNode());
            return priorityQueue;
        }

        public static void PQ_Enqueue(ref PQ.PriorityQueue pq, PQ.PQNode newData)
        {
            int num = pq._usedSize;
            int parent = PQ.PQ_GetParent(num);
            if (pq._usedSize == pq._capacity)
            {
                if (pq._capacity == 0)
                    pq._capacity = 1;
                pq._capacity *= 2;
                for (int index = 0; index < pq._capacity - pq._usedSize; ++index)
                    pq._nodes.Add(new PQ.PQNode());
            }
            pq._nodes[num] = newData;
            for (; num > 0 && pq._nodes[num]._priority < pq._nodes[parent]._priority; parent = PQ.PQ_GetParent(num))
            {
                PQ.PQ_SwapNodes(pq, num, parent);
                num = parent;
            }
            ++pq._usedSize;
        }

        public static void PQ_Dequeue(PQ.PriorityQueue pq, ref PQ.PQNode root)
        {
            int num1 = 0;
            root = pq._nodes[0];
            pq._nodes[0] = (PQ.PQNode)null;
            --pq._usedSize;
            PQ.PQ_SwapNodes(pq, 0, pq._usedSize);
            int leftChild = PQ.PQ_GetLeftChild(0);
            int index = leftChild + 1;
            while (true)
            {
                if (leftChild < pq._usedSize)
                {
                    int num2 = index < pq._usedSize ? (pq._nodes[leftChild]._priority <= pq._nodes[index]._priority ? leftChild : index) : leftChild;
                    if (pq._nodes[num2]._priority < pq._nodes[num1]._priority)
                    {
                        PQ.PQ_SwapNodes(pq, num1, num2);
                        num1 = num2;
                        leftChild = PQ.PQ_GetLeftChild(num1);
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

        public static void PQ_SwapNodes(PQ.PriorityQueue pq, int index1, int index2)
        {
            PQ.PQNode pqNode = new PQ.PQNode();
            PQ.PQNode node = pq._nodes[index1];
            pq._nodes[index1] = pq._nodes[index2];
            pq._nodes[index2] = node;
        }

        public static bool PQ_IsEmpty(PQ.PriorityQueue pq) => pq._usedSize == 0;

        public class PQNode
        {
            public int _priority;
            public object _data;

            public PQNode()
            {
                this._priority = 0;
                this._data = (object)null;
            }

            public PQNode(int priority, object data)
            {
                this._priority = priority;
                this._data = data;
            }
        }

        public class PriorityQueue
        {
            public List<PQ.PQNode> _nodes;
            public int _capacity;
            public int _usedSize;

            public PriorityQueue()
            {
                this._nodes = new List<PQ.PQNode>();
                this._capacity = 0;
                this._usedSize = 0;
            }
        }
    }
}

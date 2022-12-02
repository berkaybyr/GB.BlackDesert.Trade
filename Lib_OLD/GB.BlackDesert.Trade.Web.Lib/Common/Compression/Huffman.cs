// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.Compression.Huffman
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Lib.Common.Compression
{
    public class Huffman
    {
        public const int MAX_CHAR = 256;
        public const byte MAX_BIT = 8;

        public static int Huffman_GetTreeSize() => 0;

        public static Huffman.HuffmanNode Huffman_CreateNode(Huffman.SymbolInfo newData) => new Huffman.HuffmanNode()
        {
            _data = newData
        };

        public static void Huffman_DestroyNode(ref Huffman.HuffmanNode node) => node = (Huffman.HuffmanNode)null;

        public static void Huffman_DestroyTree(ref Huffman.HuffmanNode node)
        {
            if (node == null)
                return;
            Huffman.Huffman_DestroyTree(ref node._left);
            Huffman.Huffman_DestroyTree(ref node._right);
            Huffman.Huffman_DestroyNode(ref node);
        }

        public static void Huffman_AddBit(Huffman.BitBuffer buffer, byte value)
        {
            byte num1 = 128;
            if (buffer._size % 8 == 0)
            {
                if (buffer._size == 0)
                    buffer._buffer = new List<byte>();
                buffer._buffer.Add((byte)0);
            }
            byte eight = 8;
            byte num2 = (byte)((uint)num1 >> buffer._size % eight);
            if (value == (byte)1)
                buffer._buffer[buffer._size / eight] |= num2;
            else
            {
                byte divide = Convert.ToByte(buffer._size / eight);
                buffer._buffer[divide] &= (byte)(~num2);

            }
            ++buffer._size;
        }

        public static void Huffman_Encode(
          ref Huffman.HuffmanNode tree,
          byte[] source,
          Huffman.BitBuffer encoded,
          Huffman.HuffmanCode[] codeTable,
          ref Huffman.SymbolInfo[] symbolInfoTable)
        {
            byte[] code = new byte[8];
            for (int index = 0; index < 256; ++index)
            {
                symbolInfoTable[index] = new Huffman.SymbolInfo();
                symbolInfoTable[index]._symbol = (byte)index;
                symbolInfoTable[index]._frequency = 0;
            }
            int num = 0;
            while (num < source.Length)
                ++symbolInfoTable[(int)source[num++]]._frequency;
            Huffman.Huffman_BuildPrefixTree(ref tree, symbolInfoTable);
            Huffman.Huffman_BuildCodeTable(ref tree, codeTable, code, 0);
            for (int index1 = 0; index1 < source.Length; ++index1)
            {
                int size = codeTable[(int)source[index1]]._size;
                for (int index2 = 0; index2 < size; ++index2)
                    Huffman.Huffman_AddBit(encoded, codeTable[(int)source[index1]]._code[index2]);
            }
        }

        public static void Huffman_Decode(
          ref Huffman.HuffmanNode tree,
          Huffman.BitBuffer encode,
          byte[] decoded)
        {
            int num1 = 0;
            Huffman.HuffmanNode huffmanNode = tree;
            for (int index = 0; index <= encode._size; ++index)
            {
                byte num2 = 128;
                if (huffmanNode._left == null && huffmanNode._right == null)
                {
                    decoded[num1++] = huffmanNode._data._symbol;
                    huffmanNode = tree;
                }
                byte num3 = (byte)((uint)num2 >> index % 8);
                if (encode._buffer.Count == index / 8)
                    break;
                huffmanNode = ((int)encode._buffer[index / 8] & (int)num3) == (int)num3 ? huffmanNode._right : huffmanNode._left;
            }
        }

        public static void Huffman_BuildPrefixTree(
          ref Huffman.HuffmanNode tree,
          Huffman.SymbolInfo[] symbolInfoTable)
        {
            PQ.PQNode root1 = new PQ.PQNode();
            PQ.PriorityQueue pq = PQ.PQ_Create(0);
            for (int index = 0; index < 256; ++index)
            {
                if (symbolInfoTable[index]._frequency > 0)
                {
                    Huffman.HuffmanNode node = Huffman.Huffman_CreateNode(symbolInfoTable[index]);
                    PQ.PQ_Enqueue(ref pq, new PQ.PQNode()
                    {
                        _priority = symbolInfoTable[index]._frequency,
                        _data = (object)node
                    });
                }
            }
            while (pq._usedSize > 1)
            {
                Huffman.HuffmanNode node = Huffman.Huffman_CreateNode(new Huffman.SymbolInfo());
                PQ.PQNode root2 = new PQ.PQNode();
                PQ.PQNode root3 = new PQ.PQNode();
                PQ.PQNode newData = new PQ.PQNode();
                PQ.PQ_Dequeue(pq, ref root2);
                PQ.PQ_Dequeue(pq, ref root3);
                Huffman.HuffmanNode data1 = (Huffman.HuffmanNode)root2._data;
                Huffman.HuffmanNode data2 = (Huffman.HuffmanNode)root3._data;
                node._data._symbol = (byte)0;
                node._data._frequency = data1._data._frequency + data2._data._frequency;
                node._left = data1;
                node._right = data2;
                newData._priority = node._data._frequency;
                newData._data = (object)node;
                PQ.PQ_Enqueue(ref pq, newData);
            }
            PQ.PQ_Dequeue(pq, ref root1);
            tree = (Huffman.HuffmanNode)root1._data;
        }

        public static void Huffman_BuildCodeTable(
          ref Huffman.HuffmanNode tree,
          Huffman.HuffmanCode[] codeTable,
          byte[] code,
          int size)
        {
            if (tree == null)
                return;
            if (tree._left != null)
            {
                code[size] = (byte)0;
                Huffman.Huffman_BuildCodeTable(ref tree._left, codeTable, code, size + 1);
            }
            if (tree._right != null)
            {
                code[size] = (byte)1;
                Huffman.Huffman_BuildCodeTable(ref tree._right, codeTable, code, size + 1);
            }
            if (tree._left != null || tree._right != null)
                return;
            for (int index = 0; index < size; ++index)
                codeTable[(int)tree._data._symbol]._code[index] = code[index];
            codeTable[(int)tree._data._symbol]._size = size;
        }

        public class SymbolInfo
        {
            public byte _symbol;
            public int _frequency;

            public SymbolInfo()
            {
                this._symbol = (byte)0;
                this._frequency = 0;
            }
        }

        public class HuffmanNode
        {
            public Huffman.SymbolInfo _data;
            public Huffman.HuffmanNode _left;
            public Huffman.HuffmanNode _right;

            public HuffmanNode()
            {
                this._data = new Huffman.SymbolInfo();
                this._left = (Huffman.HuffmanNode)null;
                this._right = (Huffman.HuffmanNode)null;
            }
        }

        public class BitBuffer
        {
            public int _size;
            public List<byte> _buffer;

            public BitBuffer()
            {
                this._size = 0;
                this._buffer = new List<byte>();
            }
        }

        public class HuffmanCode
        {
            public byte[] _code;
            public int _size;

            public HuffmanCode()
            {
                this._code = new byte[8];
                this._size = 0;
            }
        }
    }
}

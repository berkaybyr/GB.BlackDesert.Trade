// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.Compression.CompressionModule
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.Collections.Generic;
using System.Text;

namespace GB.BlackDesert.Trade.Web.Lib.Common.Compression
{
    public class CompressionModule
    {
        public static byte[] HaffmanCompression(string source)
        {
            List<byte> byteList = new List<byte>();
            Huffman.BitBuffer encoded = new Huffman.BitBuffer();
            List<Huffman.SymbolInfo> symbolInfoList = new List<Huffman.SymbolInfo>();
            Huffman.HuffmanNode tree = (Huffman.HuffmanNode)null;
            Huffman.HuffmanCode[] codeTable = new Huffman.HuffmanCode[256];
            for (int index = 0; index < codeTable.Length; ++index)
                codeTable[index] = new Huffman.HuffmanCode();
            byte[] bytes1 = Encoding.UTF8.GetBytes(source);
            Huffman.SymbolInfo[] symbolInfoTable = new Huffman.SymbolInfo[256];
            Huffman.Huffman_Encode(ref tree, bytes1, encoded, codeTable, ref symbolInfoTable);
            int num1 = 0;
            for (int index = 0; index < symbolInfoTable.Length; ++index)
            {
                if (0 < symbolInfoTable[index]._frequency)
                {
                    symbolInfoList.Add(new Huffman.SymbolInfo()
                    {
                        _frequency = symbolInfoTable[index]._frequency,
                        _symbol = symbolInfoTable[index]._symbol
                    });
                    ++num1;
                }
            }
            int[] numArray1 = new int[num1 * 2 + 6];
            int num2 = 0;
            int[] numArray2 = numArray1;
            int index1 = num2;
            int num3 = index1 + 1;
            int num4 = encoded._buffer.Count + (num1 * 2 + 6) * 4;
            numArray2[index1] = num4;
            int[] numArray3 = numArray1;
            int index2 = num3;
            int num5 = index2 + 1;
            numArray3[index2] = 0;
            int[] numArray4 = numArray1;
            int index3 = num5;
            int num6 = index3 + 1;
            int num7 = num1;
            numArray4[index3] = num7;
            foreach (Huffman.SymbolInfo symbolInfo in symbolInfoList)
            {
                numArray1[num6++] = symbolInfo._frequency;
                numArray1[num6++] = (int)symbolInfo._symbol;
            }
            int[] numArray5 = numArray1;
            int index4 = num6;
            int num8 = index4 + 1;
            int size = encoded._size;
            numArray5[index4] = size;
            int[] numArray6 = numArray1;
            int index5 = num8;
            int num9 = index5 + 1;
            int count = encoded._buffer.Count;
            numArray6[index5] = count;
            int[] numArray7 = numArray1;
            int index6 = num9;
            int num10 = index6 + 1;
            int length = source.Length;
            numArray7[index6] = length;
            byte[] numArray8 = new byte[num10 * 4];
            for (int index7 = 0; index7 < num10; ++index7)
            {
                byte[] bytes2 = BitConverter.GetBytes(numArray1[index7]);
                numArray8[index7 * 4] = bytes2[0];
                numArray8[index7 * 4 + 1] = bytes2[1];
                numArray8[index7 * 4 + 2] = bytes2[2];
                numArray8[index7 * 4 + 3] = bytes2[3];
            }
            for (int index8 = 0; index8 < numArray8.Length; ++index8)
                byteList.Add(numArray8[index8]);
            byteList.AddRange((IEnumerable<byte>)encoded._buffer);
            return byteList.ToArray();
        }
    }
}

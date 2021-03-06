using System;
using System.Collections.Generic;
using System.Linq;

// What is the greatest product of four adjacent numbers
// in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?

namespace PE_Problem_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[,] indices = new long[20, 20] {
                        {  00,  01,  02,  03,  04,  05,  06,  07,  08,  09,  010,  011,  012,  013,  014,  015,  016,  017,  018,  019},
                        {  10,  11,  12,  13,  14,  15,  16,  17,  18,  19,  110,  111,  112,  113,  114,  115,  116,  117,  118,  119},
                        {  20,  21,  22,  23,  24,  25,  26,  27,  28,  29,  210,  211,  212,  213,  214,  215,  216,  217,  218,  219},
                        {  30,  31,  32,  33,  34,  35,  36,  37,  38,  39,  310,  311,  312,  313,  314,  315,  316,  317,  318,  319},
                        {  40,  41,  42,  43,  44,  45,  46,  47,  48,  49,  410,  411,  412,  413,  414,  415,  416,  417,  418,  419},
                        {  50,  51,  52,  53,  54,  55,  56,  57,  58,  59,  510,  511,  512,  513,  514,  515,  516,  517,  518,  519},
                        {  60,  61,  62,  63,  64,  65,  66,  67,  68,  69,  610,  611,  612,  613,  614,  615,  616,  617,  618,  619},
                        {  70,  71,  72,  73,  74,  75,  76,  77,  78,  79,  710,  711,  712,  713,  714,  715,  716,  717,  718,  719},
                        {  80,  81,  82,  83,  84,  85,  86,  87,  88,  89,  810,  811,  812,  813,  814,  815,  816,  817,  818,  819},
                        {  90,  91,  92,  93,  94,  95,  96,  97,  98,  99,  910,  911,  912,  913,  914,  915,  916,  917,  918,  919},
                        { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019},
                        { 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119},
                        { 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219},
                        { 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319},
                        { 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419},
                        { 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519},
                        { 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619},
                        { 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 1710, 1711, 1712, 1713, 1714, 1715, 1716, 1717, 1718, 1719},
                        { 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819},
                        { 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917, 1918, 1919} };

            long[,] grid = new long[20,20] {  
                        { 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08 },
                        { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00 },
                        { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65 },
                        { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91 },
                        { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 },
                        { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 },
                        { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 },
                        { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21 },
                        { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 },
                        { 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95 },
                        { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92 },
                        { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57 },
                        { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 },
                        { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40 },
                        { 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 },
                        { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 },
                        { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36 },
                        { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16 },
                        { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54 },
                        { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48 } };

            Console.WriteLine("Hello world!");
            List<long> listOfProducts = new List<long>();
            long product = 1;
            long n = 4;
            // first we get products in horizontal direction
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(0) - n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        product *= grid[i, j + k];
                    }
                    listOfProducts.Add(product);
                    product = 1;
                }
            }
            // second we get products in vertical direction
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(0) - n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        product *= grid[j + k,i];
                    }
                    listOfProducts.Add(product);
                    product = 1;
                }
            }
            
            
            // thirdly we get products diagonally to left
            for (int k = 1; k < grid.GetLength(0) - 1; k++)
            {
                for (int j = 1;j < grid.GetLength(0) - 3; j++)
                {
                    int i = 0;
                    product *= grid[i, j];
                    listOfProducts.Add(product);
                    product = 1;
                }
            }

            listOfProducts.ForEach(x => Console.Write("{0}, ", x));
            Console.WriteLine("------------\n");
            Console.WriteLine(listOfProducts.Max());
            Console.ReadLine();
        }
    }
}

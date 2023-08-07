using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.modData.Drivers
{
    class SheetHead
    {
        private int row { get; set; }
        public SheetHead(int headHeigh) 
        {
            row = headHeigh;
        }
        public int getHeigh()
        {
            return row;
        }
    }
    internal class Grid
    {
        private Dictionary<string, List<string>> _data;
        private SheetHead _head;
        private SheetHead _foot;

        public class CustomObject
        {
            public string ColumnHeader { get; set; }
            public int ValueOne { get; set; }
            public int ValueTwo { get; set; }
            public int ValueThree { get; set; }
        }

        public Grid(string template, string head, string foot)
        {
            IWorkbook wb = ReoGridControl.CreateMemoryWorkbook();
            // wb.CopyWorksheet
            
            object[,] array = new object[,]
            {
                {"columnHeader1", 1, 2, 3},
                {"columnHeader2", 4, 5, 6},
                {"columnHeader3", 7, 8, 9}
            };

            int i, maxI = array.GetLength(0);

            List<CustomObject> output = new List<CustomObject>();
      
            for (i = 0; i < maxI; i++)
            {
                var obj = new CustomObject
                {
                    ColumnHeader = (string)array[i, 0],
                    ValueOne = (int)array[i, 1],
                    ValueTwo = (int)array[i, 2],
                    ValueThree = (int)array[i, 3]
                };
                output.Add(obj);
            }

        }
        public static IWorkbook CreateMemoryWorkbook()
        {
            return ReoGridControl.CreateMemoryWorkbook(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestThuatToan
{
    public class Bai2
    {
        public Human[] SortingHuman(Human[] humans)
        {
            var temp = humans.ToList().OrderBy(s => s.height).ToArray();

            var afterSort = new Human[temp.Length];
            for (int i = 0; i < afterSort.Length; i++)
            {
                afterSort[i] = new Human
                {
                    index = -1
                };
            }

            for (int i = 0; i < temp.Length; i++)
            {
                var pos = GetRightPos(afterSort, temp[i]);
                afterSort[pos] = temp[i];
            }

            return afterSort;
        }
        
        private int GetRightPos(Human[] temp, Human h)
        {
            var pos = h.index;
            for (int i = 0; i < temp.Length; i++)
            {
                if(temp[i].index == -1)
                {
                    pos--;
                    if(pos < 0)
                    {
                        return i;
                    }
                }
            }
            return pos;
        }
    }

    public struct Human
    {
        public Human(int height, int index){
            this.index = index;
            this.height = height;
        }
        public int height;
        public int index; 
    }
}
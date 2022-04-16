using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoTasks
{
    class OldWatch
    {
        
        static string l1 = "####", l2 = "#   #", l3 = "   #", l4 = "#   ";
        string [,] nums= { 
                            {l1,l2,l2,l2,l1 },//0
                            {l3,l3,l3,l3,l3 },//1
                            {l1,l3,l1,l4,l1 },//2
                            {l1,l3,l1,l3,l1 },//3
                            {l2,l2,l1,l3,l3 },//4
                            {l1,l4,l1,l3,l1 },//5
                            {l1,l4,l1,l2,l1 },//6
                            {l1,l3,l3,l3,l3 },//7
                            {l1,l2,l1,l2,l1 },//8 
                            {l1,l2,l1,l3,l3 } //9
        };

        public OldWatch()
        {
            string t=DateTime.Now.ToShortTimeString().Replace(":","");

            for (int i=0;i<5;i++)
            {
                Console.WriteLine(nums[int.Parse(t.Substring(0,1)),i]+" "+ 
                    nums[int.Parse(t.Substring(1, 1)), i] + "  |  "+ 
                    nums[int.Parse(t.Substring(2, 1)), i] + " "+ 
                    nums[int.Parse(t.Substring(3, 1)), i]);
            }
            
        }
    }
}

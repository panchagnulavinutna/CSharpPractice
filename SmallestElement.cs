using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class SmallestElement
    {
        public int Smallest(int[] arr)
        {
            int mini = arr[0];
            for (int i = 0; i < arr.Length; i++){
                if(mini > arr[i])
                {
                    mini = arr[i];
                }
            }
            return mini;
        }
    }
}

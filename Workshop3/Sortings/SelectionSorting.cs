using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    internal class SelectionSorting
    {
        public void SelctionSortTechnoque(int[] arr)
        {
            int n=arr.Length;
            for(int i = 0; i < n; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}

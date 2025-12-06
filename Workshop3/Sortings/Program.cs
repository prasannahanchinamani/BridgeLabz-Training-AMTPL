using Sortings;

BubbleSort sort = new BubbleSort();
SelectionSorting sorting = new SelectionSorting();
int[] arr = { 1, 5, 4, 3, 1 };
sort.PrintArray(arr);
//sort.BubbleSortTechnique(arr);
sorting.SelctionSortTechnoque(arr);
Console.WriteLine("After sorting");
sort.PrintArray(arr);

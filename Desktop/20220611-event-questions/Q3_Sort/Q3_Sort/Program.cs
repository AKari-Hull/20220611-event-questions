using System.Linq;

public class Sort
{
    public static void Main()
    {
        // ランダムに並べられた重複のない整数の配列
        var array = new int[] { 5, 4, 6, 2, 1, 9, 8, 3, 7, 10 };
        // ソート実行
        var sortedArray = new Sort().SortArray(array);
        // 結果出力
        foreach (int i in sortedArray)
        {
            System.Console.WriteLine(i);
        }
    }

    public int[] SortArray(int[] array)
    {
        // 要素が一つの場合はソートの必要がないので、そのまま返却
        if (array.Length == 1)
        {
            return array;
        }

        // 配列の先頭を基準値とする
        var pivot = array[0];

        // ここから記述

        //実行結果:スタックオーバフローを起こす
        //考えられる改善点: 記述前の基準値を使用, IFの分岐条件を変更
        

        array = QuickSort(array, 0, array.Length - 1);
        return array;
    }

    public int[] QuickSort(int[] array, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = array[left];

        if (left >= right)
        {
            return array;
        }

        while (true)
        {
            while (array[i] < pivot)
            {
                i++;
            }
                
            while (array[j] >= pivot)
            {
                j--;
            }

            if (i >= j)
            {
                break;
            }

            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;     
            
        }

        if (left < j)
        {
            QuickSort(array, left, i-1);
        }

        if (right >= j+1)
        {
            QuickSort(array, j+1, right);
        }
        
        return array;       

    // ここまで記述

    }
}

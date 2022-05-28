public class Search
{
    public static void Main()
    {
        // 昇順にソートされた配列
        var sortedArray = new int[] { 1, 2, 3, 5, 12, 7890, 12345 };
        // 探索対象の番号
        var targetNumber = 7890;
        // 探索実行
        var targetIndex = new Search().SearchIndex(sortedArray, targetNumber);
        // 結果出力
        System.Console.WriteLine(targetIndex);
    }

    private int SearchIndex(int[] sortedArray, int targetNumber)
    {

        // ここから記述

        //二分探索アルゴリズムを使用

        int low = 0;
        int high = sortedArray.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if(sortedArray[mid]==targetNumber)
            {
                return mid;
            }

            if(sortedArray[mid] < targetNumber)
            {
                low = mid + 1;
            }

            else
            {
                high = mid - 1;
            }
        }

        // ここまで記述

        // 探索対象がない場合、-1を返す
        return -1;
    }
}

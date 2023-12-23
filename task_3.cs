/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/

void PrintArray(int[] arr) {
        if (arr.Length == 0) return;
        else {
        Console.WriteLine(arr[arr.Length - 1]);
        int[] newNums = new int[arr.Length - 1];
        Array.Copy(arr, 0, newNums, 0, arr.Length - 1);
        PrintArray(newNums);
        }
}

void Main() {
        Random rand = new Random();
        int[] nums = new int[rand.Next(20)];
        for (int i = 0; i < nums.Length; i++)
          {
              nums[i] = rand.Next(20);
          }
       
        var str = string.Join(" ", nums);
        Console.WriteLine(str);
        
        PrintArray(nums);
}

Main();

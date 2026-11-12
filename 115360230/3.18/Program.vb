Module Module1
    Sub Main()
        Dim sales As Double

        ' 提示使用者輸入銷售額，若輸入 -1 則結束迴圈
        Console.Write("Enter sales in dollars (-1 to end): ")
        sales = Convert.ToDouble(Console.ReadLine())

        While sales <> -1
            ' 計算薪資公式：底薪 200 加上銷售額的 9%
            Dim salary As Double = 200 + (sales * 0.09)

            ' 顯示計算後的薪資結果
            Console.WriteLine($"Salary is: ${salary:F2}")
            Console.WriteLine() ' 空行

            ' 再次讀取銷售額以供下一次迴圈判斷
            Console.Write("Enter sales in dollars (-1 to end): ")
            sales = Convert.ToDouble(Console.ReadLine())
        End While

    End Sub
End Module
Module Module1
    Sub Main()
        Dim principal As Double
        Dim rate As Double
        Dim days As Integer
        Dim interest As Double

        ' 提示使用者輸入本金，若輸入 -1 則結束迴圈
        Console.Write("Enter loan principal (-1 to end): ")
        principal = Convert.ToDouble(Console.ReadLine())

        While principal <> -1
            ' 輸入年利率
            Console.Write("Enter interest rate: ")
            rate = Convert.ToDouble(Console.ReadLine())

            ' 輸入借款天數
            Console.Write("Enter term of the loan in days: ")
            days = Convert.ToInt32(Console.ReadLine())

            ' 計算利息公式：本金 × 年利率 × 天數 / 365
            interest = principal * rate * days / 365

            ' 顯示計算後的利息金額[cite: 3]
            Console.WriteLine($"The interest charge is ${interest:F2}")
            Console.WriteLine() ' 空行

            ' 再次讀取本金以供下一次迴圈判斷
            Console.Write("Enter loan principal (-1 to end): ")
            principal = Convert.ToDouble(Console.ReadLine())
        End While

    End Sub
End Module
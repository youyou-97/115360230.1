Module Module1
    Sub Main()
        Dim hours As Double
        Dim hourlyRate As Double
        Dim grossPay As Double

        ' 提示使用者輸入工作時數，若輸入 -1 則結束迴圈
        Console.Write("Enter # of hours worked (-1 to end): ")
        hours = Convert.ToDouble(Console.ReadLine())

        While hours <> -1
            ' 輸入每小時薪資
            Console.Write("Enter hourly rate of the worker ($00.00): ")
            hourlyRate = Convert.ToDouble(Console.ReadLine())

            ' 計算薪資：若超過 40 小時，前 40 小時領原薪，超過部分領 1.5 倍（time-and-a-half）
            If hours <= 40 Then
                grossPay = hours * hourlyRate
            Else
                grossPay = (40 * hourlyRate) + ((hours - 40) * hourlyRate * 1.5)
            End If

            ' 顯示計算後的總薪資
            Console.WriteLine($"Salary is ${grossPay:F2}")
            Console.WriteLine() ' 空行

            ' 再次讀取工作時數以供下一次迴圈判斷
            Console.Write("Enter # of hours worked (-1 to end): ")
            hours = Convert.ToDouble(Console.ReadLine())
        End While

    End Sub
End Module

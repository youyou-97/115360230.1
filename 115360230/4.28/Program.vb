Module Module1
    Sub Main()
        Dim payCode As Integer

        Console.WriteLine("Enter employee's pay code (-1 to end): ")
        payCode = Convert.ToInt32(Console.ReadLine())

        While payCode <> -1
            Dim weeklyPay As Double = 0.0

            Select Case payCode
                Case 1 ' 經理 (Managers): 固定週薪
                    Console.Write("Enter manager's fixed weekly salary: ")
                    weeklyPay = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine($"Manager's weekly pay is ${weeklyPay:F2}")

                Case 2 ' 計時人員 (Hourly workers): 40小時內基本薪，超過1.5倍
                    Console.Write("Enter hourly rate: ")
                    Dim hourlyRate As Double = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Enter hours worked: ")
                    Dim hours As Double = Convert.ToDouble(Console.ReadLine())

                    If hours <= 40 Then
                        weeklyPay = hours * hourlyRate
                    Else
                        weeklyPay = (40 * hourlyRate) + ((hours - 40) * hourlyRate * 1.5)
                    End If
                    Console.WriteLine($"Hourly worker's weekly pay is ${weeklyPay:F2}")

                Case 3 ' 佣金人員 (Commission workers): 固定 $250 加上銷售額的 5.7%
                    Console.Write("Enter gross weekly sales: ")
                    Dim sales As Double = Convert.ToDouble(Console.ReadLine())
                    weeklyPay = 250 + (sales * 0.057)
                    Console.WriteLine($"Commission worker's weekly pay is ${weeklyPay:F2}")

                Case 4 ' 計件人員 (Pieceworkers): 每件固定金額 × 生產數量
                    Console.Write("Enter fixed amount per piece: ")
                    Dim wagePerPiece As Double = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Enter number of pieces produced: ")
                    Dim pieces As Integer = Convert.ToInt32(Console.ReadLine())
                    weeklyPay = wagePerPiece * pieces
                    Console.WriteLine($"Pieceworker's weekly pay is ${weeklyPay:F2}")

                Case Else
                    Console.WriteLine("Invalid pay code entered.")
            End Select

            Console.WriteLine()
            Console.Write("Enter employee's pay code (-1 to end): ")
            payCode = Convert.ToInt32(Console.ReadLine())
        End While

    End Sub
End Module
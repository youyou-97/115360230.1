Module Module1
    Sub Main()
        Dim principal As Decimal = 5000D

        ' 使用 For 迴圈變動利率從 10.0% 到 12.0%，每次遞增 0.5% (0.005)
        For rate As Double = 0.1 To 12.0 / 100.0 Step 0.005
            Console.WriteLine($"Interest Rate: {rate * 100.0:F1}%")
            Console.WriteLine("Year" & vbTab & "Amount on deposit")

            ' 內部迴圈計算 1 年到 15 年的複利結餘
            For year As Integer = 1 To 15
                Dim amount As Decimal = principal * CDec(Math.Pow(1.0 + rate, year))
                Console.WriteLine($"{year,4}{amount,18:F2}")
            Next

            Console.WriteLine() ' 空行隔開不同利率的結果
        Next

    End Sub
End Module
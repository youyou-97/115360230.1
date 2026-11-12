Module Module1
    Sub Main()
        Dim length As Integer
        Dim breadth As Integer

        ' 輸入矩形的長與寬
        Console.Write("Enter length: ")
        length = Convert.ToInt32(Console.ReadLine())

        Console.Write("Enter breadth: ")
        breadth = Convert.ToInt32(Console.ReadLine())

        ' 外層迴圈控制行數 (length)
        For i As Integer = 1 To length
            ' 內層迴圈控制每行的列數 (breadth)
            For j As Integer = 1 To breadth
                ' 判斷是否為邊界（第一行、最後一行、第一列、最後一列）
                If i = 1 OrElse i = length OrElse j = 1 OrElse j = breadth Then
                    Console.Write("+")
                Else
                    Console.Write(" ") ' 內部印出空白
                End If
            Next
            Console.WriteLine() ' 換行
        Next

    End Sub
End Module
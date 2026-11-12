Module Module1
    Sub Main()
        Dim totalRows As Integer = 9
        Dim mid As Integer = (totalRows + 1) \ 2 ' 計算中間行數 (第 5 行)

        ' --- 上半部（包含最寬的中間行） ---
        For i As Integer = 1 To mid
            ' 印出前置空白
            For s As Integer = 1 To (mid - i)
                Console.Write(" ")
            Next
            ' 印出星號 (數量依序為 1, 3, 5, 7, 9)
            For j As Integer = 1 To (2 * i - 1)
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

        ' --- 下半部 ---
        For i As Integer = (mid - 1) To 1 Step -1
            ' 印出前置空白
            For s As Integer = 1 To (mid - i)
                Console.Write(" ")
            Next
            ' 印出星號 (數量依序為 7, 5, 3, 1)
            For j As Integer = 1 To (2 * i - 1)
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

    End Sub
End Module
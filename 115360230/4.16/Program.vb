Module Module1
    Sub Main()
        Dim n As Integer = 10 ' 控制三角形的大小 (10行)

        ' --- (A) 靠左遞增三角形 ---
        Console.WriteLine("(A)")
        For i As Integer = 1 To n
            For j As Integer = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()

        ' --- (B) 靠左遞減三角形 ---
        Console.WriteLine("(B)")
        For i As Integer = n To 1 Step -1
            For j As Integer = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()

        ' --- (C) 靠右遞減三角形 ---
        Console.WriteLine("(C)")
        For i As Integer = 0 To n - 1
            ' 先印空格
            For s As Integer = 1 To i
                Console.Write(" ")
            Next
            ' 再印星號
            For j As Integer = 1 To (n - i)
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()

        ' --- (D) 靠右遞增三角形 ---
        Console.WriteLine("(D)")
        For i As Integer = 1 To n
            ' 先印空格
            For s As Integer = 1 To (n - i)
                Console.Write(" ")
            Next
            ' 再印星號
            For j As Integer = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

    End Sub
End Module

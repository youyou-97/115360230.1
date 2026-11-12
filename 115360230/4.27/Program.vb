Module Module1
    Sub Main()
        Console.WriteLine("Pythagorean Triples (sides <= 500):")
        Console.WriteLine("Side1" & vbTab & "Side2" & vbTab & "Hypotenuse")

        ' 使用三層巢狀 For 迴圈窮舉所有不大於 500 的可能組合
        For side1 As Integer = 1 To 500
            For side2 As Integer = 1 To 500
                For hypotenuse As Integer = 1 To 500
                    ' 檢查是否符合畢氏定理公式：side1^2 + side2^2 = hypotenuse^2
                    If (side1 * side1) + (side2 * side2) = (hypotenuse * hypotenuse) Then
                        Console.WriteLine($"{side1,5}{side2,5}{hypotenuse,12}")
                    End If
                Next
            Next
        Next
    End Sub
End Module
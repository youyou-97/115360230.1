Module Module1
    Sub Main()
        Dim accountNumber As Integer
        Dim beginningBalance As Decimal
        Dim totalCharges As Decimal
        Dim totalCredits As Decimal
        Dim allowedCreditLimit As Decimal
        Dim newBalance As Decimal

        ' 提示使用者輸入帳號，若輸入 -1 則結束迴圈
        Console.Write("Enter account number (-1 to end): ")
        accountNumber = Convert.ToInt32(Console.ReadLine())

        While accountNumber <> -1
            ' 輸入其他相關數據
            Console.Write("Enter beginning balance: ")
            beginningBalance = Convert.ToDecimal(Console.ReadLine())

            Console.Write("Enter total charges: ")
            totalCharges = Convert.ToDecimal(Console.ReadLine())

            Console.Write("Enter total credits: ")
            totalCredits = Convert.ToDecimal(Console.ReadLine())

            Console.Write("Enter credit limit: ")
            allowedCreditLimit = Convert.ToDecimal(Console.ReadLine())

            ' 計算新結餘：期初結餘 + 本月消費 - 本月還款
            newBalance = beginningBalance + totalCharges - totalCredits

            ' 檢查是否超過信用額度[cite: 1]
            If newBalance > allowedCreditLimit Then
                Console.WriteLine($"Account: {accountNumber}")
                Console.WriteLine($"Credit limit: {allowedCreditLimit:F2}")
                Console.WriteLine($"Balance: {newBalance:F2}")
                Console.WriteLine("Credit Limit Exceeded.")
            End If

            Console.WriteLine() ' 空行

            ' 再次讀取帳號以供下一次迴圈判斷
            Console.Write("Enter account number (-1 to end): ")
            accountNumber = Convert.ToInt32(Console.ReadLine())
        End While

    End Sub
End Module

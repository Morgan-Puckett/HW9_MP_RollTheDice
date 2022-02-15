
Option Strict On
Option Explicit On
Module HW9_MP_RollTheDice

    Sub main()
        Dim rndNumbers(7) As Integer
        Dim temp As String
        For i = 1 To 1000
            rndNumbers(GetRandomInteger()) += 1
        Next

        For i = 0 To 7
            temp = CStr(i) & "  |"
            temp = temp.PadLeft(6)
            Console.Write(temp)
        Next
        Console.WriteLine()

        Console.WriteLine(StrDup(48, "="))

        For i = 0 To 7
            temp = CStr(rndNumbers(i)) & " |"
            temp = temp.PadLeft(6)
            Console.Write(temp)
        Next

        Console.WriteLine()

        Console.WriteLine(StrDup(48, "="))

        Console.ReadLine()
    End Sub

    Function GetRandomInteger() As Integer

        Randomize()
        'generates value between 1-6
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))


        Return value
    End Function

End Module
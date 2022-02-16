'Morgan Puckett
'RCET0265
'Spring 2022
'Roll the Dice

Option Strict On
Option Explicit On
Module HW9_MP_RollTheDice
    'this varible is used in a function outside of the main and therefor must be kept as a field varible
    Dim arrayLength As Integer = 7
    Sub main()
        'these varibles allow for easy access to edit the front panel of this program 
        Dim rndNumbers(arrayLength) As Integer
        Dim temp As String
        Dim separator As String = "="
        Dim lineSeparator As String = "|"
        Dim padLength As Integer = 6
        Dim lineLength = padLength * ((UBound(rndNumbers)) + 1)

        'runs 10000 random number generators
        For i = 1 To 10000
            rndNumbers(GetRandomInteger()) += 1
        Next

        For i = LBound(rndNumbers) To (UBound(rndNumbers))
            temp = CStr(i) & lineSeparator
            temp = temp.PadLeft(padLength)
            Console.Write(temp)
        Next
        Console.WriteLine()
        'separates the first row from the second 
        Console.WriteLine(StrDup(lineLength, separator))

        For i = LBound(rndNumbers) To (UBound(rndNumbers))
            temp = CStr(rndNumbers(i)) & lineSeparator
            temp = temp.PadLeft(padLength)
            Console.Write(temp)
        Next

        Console.WriteLine()

        Console.WriteLine(StrDup(lineLength, separator))

        Console.ReadLine()
    End Sub
    'this function allows a random number to be chosen between the upper and lower bounds of the array length
    Function GetRandomInteger() As Integer
        Dim value As Integer

        Dim temp As Single
        Randomize()
        temp = Rnd() * arrayLength
        value = CInt(System.Math.Floor(CDbl(temp)))
        'generates value between 1-chosen array length
        Return value
    End Function

End Module
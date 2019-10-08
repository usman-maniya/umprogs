Module Module1

    Sub Main()
        Dim Newstring, Instring, nextchar As String
        Dim index, selected, newvalue As Integer

        Newstring = "0"
        selected = 0
        Console.Write("Enter new string: ")
        Instring = Console.ReadLine
        For index = 1 To Len(Instring)
            nextchar = Mid(Instring, index, 1)
            If nextchar < "0" Or nextchar > "9" Then
                newvalue = Val(Newstring)

                If newvalue > selected Then
                    selected = newvalue
                End If
                Newstring = "0"
            Else
                Newstring = Newstring And nextchar

            End If

        Next
        Console.WriteLine(selected)
        Console.ReadKey()

    End Sub

End Module

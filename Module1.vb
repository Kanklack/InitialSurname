Module Module1

    Sub Main()

        Dim FullName, surnameStarts, numChars, initial, surname As String

        Console.WriteLine("Please enter your first name and surname, seperated by space: ")

        FullName = Console.ReadLine()

        surnameStarts = FullName.IndexOf(" ")

        surnameStarts = surnameStarts + 1

        numChars = FullName.Length()

        initial = FullName.Substring(0, 1)

        surname = FullName.Substring(surnameStarts)

        Console.WriteLine(initial & " " & surname)

        Console.Read()

    End Sub

End Module

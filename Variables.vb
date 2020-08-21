Option Strict On
Option Explicit Off




Module Variables

    Sub Main()
        Dim myFirstNumber As Integer
        Dim mySecondNumber As Integer
        Dim aLittleString As String
        Dim someSortOfTest As Boolean
        Dim result As Integer

        myFirstNumber = 42
        Console.WriteLine(myFirstNumber)
        Console.ReadLine()

        aLittleString = "some text"

        Console.WriteLine(aLittleString)
        Console.ReadLine()

        'someSortOfTest = True

        Console.WriteLine(someSortOfTest)
        Console.ReadLine()

        ''break it with wrong data type 
        'mySecondNumber = "5"

        'x = 7
        'Console.WriteLine(x)
        'Console.ReadLine()

        'do math

        myFirstNumber = 42
        mySecondNumber = 8

        'myFirstNumber +mySecondNumber 
        Console.WriteLine(myFirstNumber + mySecondNumber)
        Console.ReadLine()

        result = myFirstNumber + mySecondNumber
        Console.WriteLine(result)
        Console.ReadLine()





    End Sub

End Module

'Option Strict On
'Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Roll of the Dice
'https://github.com/dylannelson58/ShuffleTheDeck

Module ShuffleTheDeck

    Sub Main()
        Dim deck(12, 3) As String                                              'assigns an array with dimensions of 4 and 13, suites and card variants
        Dim result As String
        Dim suit As String
        Dim value As String
        Dim userInput As String
        Dim repeat As Boolean
        Dim another As Boolean
        Dim check(12, 3) As String
        repeat = True
        another = True

        suit = CStr(DealCardRandom(3))
        value = CStr(DealCardRandomTwo(12))

        For j = 0 To 3
            If j = 0 Then suit = " of Clubs"
            If j = 1 Then suit = " of Hearts"
            If j = 2 Then suit = " of Diamonds"
            If j = 3 Then suit = " of Spades"
            For i = 0 To 12
                If i > 2 Or i < 10 Then value = CStr(i)
                If i = 0 Then value = "Ace"
                If i = 1 Then value = "Jack"
                If i = 11 Then value = "Queen"
                If i = 12 Then value = "King"
                result = (value & suit)
                deck(i, j) = result

            Next i
        Next j

        Console.WriteLine("Press Enter to draw random card, ""shuffle"" to shuffle the deck, ""q"" to exit")

        While repeat = True
            userInput = Console.ReadLine()

            Select Case userInput
                Case ""

                    Console.WriteLine($"{deck((DealCardRandomTwo(12)), (DealCardRandom(3)))}")

                    While another = True
                        If deck Is check Then
                            Console.WriteLine($"{deck((DealCardRandomTwo(12)), (DealCardRandom(3)))}")
                            another = False
                        End If

                    End While

                Case "shuffle"
                    Console.Clear()
                    Console.WriteLine("Deck has been shuffled.")
                    Console.WriteLine("Press Enter to draw random card, ""shuffle"" to shuffle the deck, ""q"" to exit")

                Case "q"
                    Console.Clear()
                    repeat = False

                Case Else
                    Console.WriteLine($"Please enter 1, 2 or 3")

            End Select
        End While

        Console.Read()

    End Sub
    Private Function DealCardRandom(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber)))
    End Function

    Private Function DealCardRandomTwo(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber)))
    End Function
End Module

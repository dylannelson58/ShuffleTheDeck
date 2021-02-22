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
        Dim suite As String
        Dim value As String
        Dim userInput As String
        Dim repeat As Boolean
        repeat = True

        result = CStr(deck(DealCardRandom(12), (DealCardRandomTwo(3))))
        suite = CStr(DealCardRandom(12))
        value = CStr(DealCardRandomTwo(3))

        For i = LBound(deck(12, 3)) To UBound(deck(12, 3))
            deck(i, 0) = ($" of Clubs")
            deck(i, 1) = ($" of Hearts")
            deck(i, 2) = ($" of Diamonds")
            deck(i, 3) = ($" of Spades")
            deck(0, i) = ($"Ace")
            deck(1, i) = ($"2")
            deck(2, i) = ($"3")
            deck(3, i) = ($"4")
            deck(4, i) = ($"5")
            deck(5, i) = ($"6")
            deck(6, i) = ($"7")
            deck(7, i) = ($"8")
            deck(8, i) = ($"9")
            deck(9, i) = ($"10")
            deck(10, i) = ($"Jack")
            deck(11, i) = ($"Queen")
            deck(12, i) = ($"King")
        Next


        Console.WriteLine($"Press 1 to draw random card, 2 to shuffle the deck, 3 to exit")


        While repeat = True
            userInput = Console.ReadLine()
            Select Case userInput
            Case "1"
                Console.WriteLine(result)

            Case "2"
                'Clear(result)

            Case "3"
                Console.Clear()
        End Select
        End While



        For j = LBound(deck) To UBound(deck)

        Next

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

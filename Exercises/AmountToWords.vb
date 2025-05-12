Imports System

Namespace Exercises
    Public Class Converter
        Public Shared Function ConvertToWords(ByVal amount As Decimal) As String
            Dim dollars As Integer = Math.Floor(amount)
            Dim cents As Integer = Math.Round((amount - dollars) * 100)

            Dim dollarsInWords As String = ConvertNumberToWords(dollars)
            Dim centsInWords As String = cents.ToString("00")

            Return dollarsInWords & " and " & centsInWords & "/100 dollars"
        End Function

        Private Shared Function ConvertNumberToWords(ByVal number As Integer) As String
            If number = 0 Then
                Return "zero"
            End If

            Dim words As String = ""

            If (number \ 1000) > 0 Then
                words &= ConvertNumberToWords(number \ 1000) & " thousand "
                number = number Mod 1000
            End If

            If (number \ 100) > 0 Then
                words &= ConvertNumberToWords(number \ 100) & " hundred "
                number = number Mod 100
            End If

            If number > 0 Then
                If words <> "" Then
                    words &= "and "
                End If

                If number < 20 Then
                    words &= GetUnits(number)
                Else
                    words &= GetTens(number \ 10)
                    If (number Mod 10) > 0 Then
                        words &= "-" & GetUnits(number Mod 10)
                    End If
                End If
            End If

            Return words.Trim()
        End Function

        Private Shared Function GetUnits(ByVal number As Integer) As String
            Select Case number
                Case 1 : Return "one"
                Case 2 : Return "two"
                Case 3 : Return "three"
                Case 4 : Return "four"
                Case 5 : Return "five"
                Case 6 : Return "six"
                Case 7 : Return "seven"
                Case 8 : Return "eight"
                Case 9 : Return "nine"
                Case 10 : Return "ten"
                Case 11 : Return "eleven"
                Case 12 : Return "twelve"
                Case 13 : Return "thirteen"
                Case 14 : Return "fourteen"
                Case 15 : Return "fifteen"
                Case 16 : Return "sixteen"
                Case 17 : Return "seventeen"
                Case 18 : Return "eighteen"
                Case 19 : Return "nineteen"
                Case Else : Return ""
            End Select
        End Function

        Private Shared Function GetTens(ByVal number As Integer) As String
            Select Case number
                Case 2 : Return "twenty"
                Case 3 : Return "thirty"
                Case 4 : Return "forty"
                Case 5 : Return "fifty"
                Case 6 : Return "sixty"
                Case 7 : Return "seventy"
                Case 8 : Return "eighty"
                Case 9 : Return "ninety"
                Case Else : Return ""
            End Select
        End Function
    End Class
End Namespace

Namespace AmountToWords
	Public Class PalindromeChecker
		Public Shared Function IsPalindrome(ByVal number As Long) As Boolean
			Dim numberStr As String = number.ToString()

			Dim left As Integer = 0
			Dim right As Integer = numberStr.Length - 1

			While left < right
				If numberStr(left) <> numberStr(right) Then
					Return False
				End If

				left += 1
				right -= 1
			End While

			Return True
		End Function
	End Class
End Namespace
Imports System.Web.UI.WebControls

Namespace AmountToWords
	Partial Class _Default
		Inherits System.Web.UI.Page

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim amount As Decimal

			If Decimal.TryParse(txtAmount.Text, amount) Then
				lblResult.Text = AmountToWords.Converter.ConvertToWords(amount)
			Else
				lblResult.Text = "Please, insert a valid number"
			End If
		End Sub
		
		Protected Sub btnCheckPalindrome_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim number As Long
			
			If Long.TryParse(txtPalindrome.Text, number) Then
				Dim isPalindrome As Boolean = AmountToWords.PalindromeChecker.IsPalindrome(number)

				If isPalindrome Then
					lblPalindromeResult.Text = $"{number} is a palindrome number."
					lblPalindromeBadge.Text = "YES"
					lblPalindromeBadge.CssClass = "ms-2 badge rounded-pill text-bg-success"
				Else
					lblPalindromeResult.Text = $"{number} is not a palindrome number."
					lblPalindromeBadge.Text = "NO"
					lblPalindromeBadge.CssClass = "ms-2 badge rounded-pill text-bg-danger"
				End If
			Else
				lblPalindromeResult.Text = "Please enter a valid whole number."
				lblPalindromeBadge.Text = ""
				lblPalindromeBadge.CssClass = ""
			End If
		End Sub
	End Class
End Namespace

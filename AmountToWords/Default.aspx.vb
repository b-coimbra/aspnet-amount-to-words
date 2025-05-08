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
	End Class
End Namespace

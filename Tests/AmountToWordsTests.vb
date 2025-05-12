Imports Xunit
Imports Subject = Exercises.Exercises

Public Class AmountToWordsTests
	<Theory>
	<InlineData(0, "zero and 00/100 dollars")>
	<InlineData(123, "one hundred and twenty-three and 00/100 dollars")>
	<InlineData(2523.04, "two thousand five hundred and twenty-three and 04/100 dollars")>
	Public Sub Convert_Returns_Number_To_Words(number As Double, convertedWord As String)
		Dim result = Subject.Converter.ConvertToWords(number)

		Assert.Equal(result, convertedWord)
	End Sub

	<Fact>
	Public Sub Convert_Returns_Zero_When_Value_Is_Zero()
		Dim result = Subject.Converter.ConvertToWords(0)

		Assert.Equal("zero and 00/100 dollars", result)
	End Sub
End Class

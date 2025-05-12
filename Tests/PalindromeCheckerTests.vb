Imports Xunit
Imports Subject = Exercises.Exercises;

Public Class PalindromeCheckerTests
	<Fact>
	Public Sub IsPalindrome_Returns_True()
		' Arrange
		Dim value As Integer = 121

		' Act
		Dim result As Boolean = Subject.PalindromeChecker.IsPalindrome(value)

		' Assert
		Assert.Equal(True, result)
	End Sub

	<Fact>
	Public Sub IsPalindrome_Returns_False()
		' Arrange
		Dim value As Integer = 123

		' Act
		Dim result As Boolean = Subject.PalindromeChecker.IsPalindrome(value)

		' Assert
		Assert.Equal(False, result)
	End Sub
End Class

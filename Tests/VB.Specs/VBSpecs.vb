Imports FluentAssertions
Imports FluentAssertions.Execution
Imports FluentAssertions.Primitives
Imports Xunit
Imports Xunit.Sdk

Namespace VB.Specs
    Public Class VBSpecs
        <Fact>
        Public Sub Caller_identification_works_with_parentheses()
            ' Arrange
            Dim subject = False

            ' Act
            Dim act As Action = Sub() subject.Should().BeTrue()

            ' Assert
            act.Should().Throw(Of XunitException).WithMessage("Expected subject to be true, but found false.")
        End Sub

        <Fact>
        Public Sub Caller_identification_works_without_parentheses()
            ' Arrange
            Dim subject = False

            ' Act
            Dim act As Action = Sub() subject.Should.BeTrue()

            ' Assert
            act.Should().Throw(Of XunitException).WithMessage("Expected subject to be true, but found false.")
        End Sub
    End Class
End Namespace


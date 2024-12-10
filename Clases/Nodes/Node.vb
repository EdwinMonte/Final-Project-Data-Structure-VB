Public Class Node
    Public Property Value As Integer
    Public Property NextNode As Node

    Public Sub New()
        Value = 0
        NextNode = Nothing
    End Sub

    Public Sub New(value As Integer)
        Me.Value = value
        Me.NextNode = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return Value.ToString()
    End Function
End Class

Public Class DoubleNode
    Public Property Value As Integer
    Public Property [Next] As DoubleNode
    Public Property Prev As DoubleNode

    Public Sub New()
        Value = 0
        [Next] = Nothing
        Prev = Nothing
    End Sub

    Public Sub New(value As Integer)
        Me.Value = value
        [Next] = Nothing
        Prev = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return Value.ToString()
    End Function
End Class


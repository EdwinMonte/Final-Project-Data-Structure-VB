Public Class Edge
    Public Property ToNode As GraphNode
    Public Property Weight As Integer

    ' Constructor con nodo destino y peso
    Public Sub New(toNode As GraphNode, weight As Integer)
        Me.ToNode = toNode
        Me.Weight = weight
    End Sub

    ' Constructor con solo nodo destino (peso predeterminado)
    Public Sub New(toNode As GraphNode)
        Me.ToNode = toNode
    End Sub
End Class


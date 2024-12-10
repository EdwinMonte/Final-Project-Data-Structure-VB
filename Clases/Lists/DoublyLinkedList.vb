Public Class DoublyLinkedList
    Implements ImethodLists

    Private head As DoubleNode

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub Add(newNode As DoubleNode)
        ' Insertar al inicio si está vacía o el valor es menor
        If head Is Nothing OrElse head.Value >= newNode.Value Then
            newNode.NextNode = head
            If head IsNot Nothing Then head.PrevNode = newNode
            head = newNode
        Else
            Dim current As DoubleNode = head
            While current.NextNode IsNot Nothing AndAlso current.NextNode.Value < newNode.Value
                current = current.NextNode
            End While

            newNode.NextNode = current.NextNode
            If current.NextNode IsNot Nothing Then current.NextNode.PrevNode = newNode
            current.NextNode = newNode
            newNode.PrevNode = current
        End If
    End Sub

    Public Sub Remove(value As Integer) Implements ImethodLists.Remove
        If head Is Nothing Then Return

        ' Si el nodo a eliminar es el head
        If head.Value = value Then
            head = head.NextNode
            If head IsNot Nothing Then head.PrevNode = Nothing
            Return
        End If

        Dim current As DoubleNode = head
        While current.NextNode IsNot Nothing
            If current.NextNode.Value = value Then
                current.NextNode = current.NextNode.NextNode
                If current.NextNode IsNot Nothing Then
                    current.NextNode.PrevNode = current
                End If
                Return
            End If
            current = current.NextNode
        End While
    End Sub

    Public Function Count() As Integer Implements ImethodLists.Count
        Dim count As Integer = 0
        Dim current As DoubleNode = head
        While current IsNot Nothing
            count += 1
            current = current.NextNode
        End While
        Return count
    End Function

    Public Function Contains(value As Integer) As Boolean Implements ImethodLists.Contains
        Dim current As DoubleNode = head
        While current IsNot Nothing
            If current.Value = value Then Return True
            current = current.NextNode
        End While
        Return False
    End Function

    Public Function GetHead() As DoubleNode
        Return head
    End Function
End Class


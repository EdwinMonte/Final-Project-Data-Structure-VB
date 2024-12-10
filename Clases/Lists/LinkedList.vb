Public Class LinkedList
    Implements ImethodLists

    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub Add(newNode As Node)
        ' Si la lista está vacía, el nuevo nodo se convierte en la cabeza
        If head Is Nothing Then
            head = newNode
            Return
        End If

        ' Si el nuevo nodo es menor que la cabeza, se convierte en la nueva cabeza
        If newNode.Value < head.Value Then
            newNode.NextNode = head
            head = newNode
            Return
        End If

        ' Buscar la posición correcta para el nuevo nodo
        Dim current As Node = head
        ' Mientras no sea el último nodo y el valor del siguiente nodo sea menor al valor del nuevo nodo
        While current.NextNode IsNot Nothing AndAlso current.NextNode.Value < newNode.Value
            current = current.NextNode
        End While
        newNode.NextNode = current.NextNode
        current.NextNode = newNode
    End Sub

    Public Sub Remove(value As Integer) Implements ImethodLists.Remove
        If head Is Nothing Then Return

        ' Si el valor a eliminar está en la cabeza
        If head.Value = value Then
            head = head.NextNode
            Return
        End If

        Dim current As Node = head
        While current.NextNode IsNot Nothing
            If current.NextNode.Value = value Then
                current.NextNode = current.NextNode.NextNode
                Return
            End If
            current = current.NextNode
        End While
    End Sub

    Public Function Contains(value As Integer) As Boolean Implements ImethodLists.Contains
        Dim current As Node = head
        While current IsNot Nothing
            If current.Value = value Then Return True
            current = current.NextNode
        End While
        Return False
    End Function

    Public Function Count() As Integer Implements ImethodLists.Count
        Dim count As Integer = 0
        Dim current As Node = head
        While current IsNot Nothing
            count += 1
            current = current.NextNode
        End While
        Return count
    End Function

    Public Overrides Function ToString() As String
        Dim result As String = ""
        Dim current As Node = head
        While current IsNot Nothing
            result &= current.ToString() & " "
            current = current.NextNode
        End While
        Return result.Trim()
    End Function

    Public Function GetHead() As Node
        Return head
    End Function
End Class


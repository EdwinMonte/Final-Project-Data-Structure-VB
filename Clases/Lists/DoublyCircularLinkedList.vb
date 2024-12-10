Public Class DoublyCircularLinkedList
    Implements ImethodLists

    Private head As DoubleNode

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub Add(newNode As DoubleNode)
        ' Si la lista está vacía
        If head Is Nothing Then
            head = newNode
            head.NextNode = head
            head.PrevNode = head
            Return
        End If

        ' Insertar un nodo al inicio
        If newNode.Value < head.Value Then
            newNode.NextNode = head
            newNode.PrevNode = head.PrevNode
            head.PrevNode.NextNode = newNode
            head.PrevNode = newNode
            head = newNode
            Return
        End If

        ' Insertar un nodo al final
        If newNode.Value > head.PrevNode.Value Then
            newNode.NextNode = head
            newNode.PrevNode = head.PrevNode
            head.PrevNode.NextNode = newNode
            head.PrevNode = newNode
            Return
        End If

        ' Encontrar la posición correcta para el nuevo nodo
        Dim current As DoubleNode = head
        While current.NextNode IsNot head AndAlso current.NextNode.Value < newNode.Value
            current = current.NextNode
        End While

        ' Insertar el nuevo nodo
        newNode.NextNode = current.NextNode
        newNode.PrevNode = current
        current.NextNode.PrevNode = newNode
        current.NextNode = newNode
    End Sub

    Public Sub Remove(value As Integer) Implements ImethodLists.Remove
        If head Is Nothing Then Return

        ' Si solo hay un nodo en la lista
        If head.NextNode Is head Then
            head = Nothing
            Return
        End If

        ' Eliminación al inicio
        If head.Value = value Then
            head.PrevNode.NextNode = head.NextNode
            head.NextNode.PrevNode = head.PrevNode
            head = head.NextNode
            Return
        End If

        ' Eliminación al final
        If head.PrevNode.Value = value Then
            head.PrevNode = head.PrevNode.PrevNode
            head.PrevNode.NextNode = head
            Return
        End If

        ' Eliminación de un nodo intermedio
        Dim current As DoubleNode = head
        While current.NextNode IsNot head AndAlso current.Value <> value
            current = current.NextNode
        End While

        If current.Value = value Then
            current.PrevNode.NextNode = current.NextNode
            current.NextNode.PrevNode = current.PrevNode
        End If
    End Sub

    Public Function Contains(value As Integer) As Boolean Implements ImethodLists.Contains
        If head Is Nothing Then Return False

        Dim current As DoubleNode = head
        Do
            If current.Value = value Then Return True
            current = current.NextNode
        Loop While current IsNot head

        Return False
    End Function

    Public Function Count() As Integer Implements ImethodLists.Count
        If head Is Nothing Then Return 0

        Dim count As Integer = 0
        Dim current As DoubleNode = head
        Do
            count += 1
            current = current.NextNode
        Loop While current IsNot head

        Return count
    End Function

    Public Overrides Function ToString() As String
        If head Is Nothing Then Return "The doubly circular linked list is void"

        Dim result As String = ""
        Dim current As DoubleNode = head
        Do
            result &= current.ToString() & " "
            current = current.NextNode
        Loop While current IsNot head

        Return result.Trim()
    End Function

    Public Function GetHead() As DoubleNode
        Return head
    End Function
End Class


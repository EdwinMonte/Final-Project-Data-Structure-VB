Public Class CircularLinkedList


    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub Add(newNode As Node)
        ' Lista vacía
        If head Is Nothing Then
            head = newNode
            head.Next = head
        ElseIf newNode.Value < head.Value Then
            ' Si el valor es menor que el head, el valor será el nuevo head
            Dim current As Node = head
            While current.Next IsNot head
                current = current.Next
            End While
            newNode.Next = head
            current.Next = newNode
            head = newNode
        Else
            ' Buscar la posición correcta en la lista
            Dim current As Node = head
            While current.Next IsNot head AndAlso current.Next.Value < newNode.Value
                current = current.Next
            End While

            ' Verificamos si el valor ya existe
            If current.Next.Value = newNode.Value Then
                Return
            End If
            newNode.Next = current.Next
            current.Next = newNode
        End If
    End Sub

    Public Sub Remove(value As Integer)
        If head Is Nothing Then
            MessageBox.Show("The list is empty, no nodes to remove.")
            Return
        End If

        Dim current As Node = head

        If head.Value = value Then
            If head.Next Is head Then
                head = Nothing
            Else
                While current.Next IsNot head
                    current = current.Next
                End While
                head = head.Next
                current.Next = head
            End If
            MessageBox.Show("Value removed successfully.")
            Return
        End If

        ' El nodo a eliminar no es el head
        current = head

        While current.Next IsNot head
            If current.Next.Value = value Then
                current.Next = current.Next.Next
                MessageBox.Show("Value removed successfully.")
                Return
            End If
            current = current.Next
        End While

        MessageBox.Show("Value not found.")
    End Sub

    Public Function Count() As Integer
        If head Is Nothing Then
            Return 0
        End If

        Dim count As Integer = 1
        Dim current As Node = head
        While current.Next IsNot head
            count += 1
            current = current.Next
        End While
        Return count
    End Function

    Public Function Contains(value As Integer) As Boolean
        If head Is Nothing Then
            Return False
        End If

        Dim current As Node = head
        While current.Next IsNot head
            If current.Value = value Then
                Return True
            End If
            current = current.Next
        End While
        Return current.Value = value
    End Function

    Public Function GetHead() As Node
        Return head
    End Function
End Class


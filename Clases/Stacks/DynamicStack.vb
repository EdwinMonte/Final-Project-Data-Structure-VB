Public Class DynamicStack
    Private top As Node

    ' Constructor que inicializa la pila dinámica
    Public Sub New()
        top = Nothing
    End Sub

    ' Método para insertar un elemento en la pila
    Public Sub Push(ByVal newNode As Node)
        If IsEmpty() Then
            top = newNode
            Exit Sub
        End If

        newNode.Next = top
        top = newNode
    End Sub

    ' Método para eliminar y devolver el elemento en el tope de la pila
    Public Function Pop() As Node
        If Not IsEmpty() Then
            Dim current As Node = top
            top = top.Next
            current.Next = Nothing
            Return current
        End If
        Return Nothing
    End Function

    ' Método para devolver el elemento en el tope de la pila sin eliminarlo
    Public Function Peek() As Node
        If IsEmpty() Then
            Return Nothing
        End If
        Return top
    End Function

    ' Método para verificar si la pila está vacía
    Public Function IsEmpty() As Boolean
        Return top Is Nothing
    End Function

    ' Método para devolver el tamaño de la pila
    Public Function Size() As Integer
        Dim count As Integer = 0
        Dim current As Node = top

        ' Recorre la pila desde el frente hasta el final
        While current IsNot Nothing
            count += 1
            current = current.Next ' Avanza al siguiente nodo
        End While

        Return count ' Devuelve el número total de elementos
    End Function
End Class

' Clase Node utilizada en la pila
Public Class Node
    Public Property Data As Integer
    Public Property [Next] As Node

    Public Sub New(ByVal data As Integer)
        Me.Data = data
        Me.Next = Nothing
    End Sub
End Class


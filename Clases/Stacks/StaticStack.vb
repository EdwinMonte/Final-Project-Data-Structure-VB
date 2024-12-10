Public Class StaticStack
    Private elements() As Integer ' Arreglo para almacenar los elementos
    Private top As Integer         ' Índice del elemento en el tope de la pila

    ' Constructor que inicializa la pila con un tamaño fijo
    Public Sub New()
        ReDim elements(7)          ' Tamaño fijo de 8 elementos
        top = -1                   ' Inicialmente, la pila está vacía
    End Sub

    ' Método para insertar un elemento en la pila
    Public Sub Push(ByVal dato As Integer)
        If IsFull() Then
            MessageBox.Show("La pila está llena.")
            Exit Sub
        End If
        top += 1
        elements(top) = dato ' Incrementar 'top' y agregar el dato
    End Sub

    ' Método para eliminar y devolver el elemento en el tope de la pila
    Public Function Pop() As String
        If IsEmpty() Then
            Return "La pila está vacía."
        End If
        Dim result As Integer = elements(top)
        top -= 1
        Return result.ToString() ' Devolver y decrementar 'top'
    End Function

    ' Método para devolver el elemento en el tope de la pila sin eliminarlo
    Public Function Peek() As String
        If IsEmpty() Then
            Return "La pila está vacía."
        End If
        Return elements(top).ToString() ' Devolver el valor sin modificar 'top'
    End Function

    ' Método para verificar si la pila está vacía
    Public Function IsEmpty() As Boolean
        Return top = -1 ' La pila está vacía si 'top' es -1
    End Function

    ' Método para verificar si la pila está llena
    Public Function IsFull() As Boolean
        Return top = elements.Length - 1 ' La pila está llena si 'top' alcanza el tamaño máximo
    End Function

    ' Método para devolver el tamaño de la pila
    Public Function Size() As Integer
        Return top + 1 ' El tamaño actual es 'top + 1'
    End Function
End Class


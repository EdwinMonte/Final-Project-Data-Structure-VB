Public Class CircularQueue
    Private array() As Integer
    Private front As Integer
    Private rear As Integer
    Private count As Integer

    Public ReadOnly Property Capacity As Integer

    ' Constructor para inicializar la cola circular con un tamaño determinado
    Public Sub New(capacity As Integer)
        Me.Capacity = capacity
        ReDim array(capacity - 1)
        front = 0
        rear = -1
        count = 0
    End Sub

    ' Método para agregar un elemento al final de la cola
    Public Sub Enqueue(value As Integer)
        If count = Capacity Then
            Throw New InvalidOperationException("La cola está llena.")
        End If

        rear = (rear + 1) Mod Capacity ' Mover el índice rear de forma circular
        array(rear) = value
        count += 1
    End Sub

    ' Método para eliminar un elemento del frente de la cola
    Public Function Dequeue() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Dim dequeuedValue As Integer = array(front)
        front = (front + 1) Mod Capacity ' Mover el índice front de forma circular
        count -= 1
        Return dequeuedValue
    End Function

    ' Método para ver el valor del frente de la cola sin eliminarlo
    Public Function Peek() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Return array(front)
    End Function

    ' Método para obtener el número de elementos en la cola
    Public Function Size() As Integer
        Return count
    End Function

    ' Método para verificar si la cola está vacía
    Public Function IsEmpty() As Boolean
        Return count = 0
    End Function

    ' Método para verificar si la cola está llena
    Public Function IsFull() As Boolean
        Return count = Capacity
    End Function
End Class

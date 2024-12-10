Public Class StaticQueue
    Private elements() As Integer ' Arreglo para almacenar elementos de la cola
    Private front As Integer       ' Índice del primer elemento de la cola
    Private rear As Integer        ' Índice del último elemento de la cola
    Private count As Integer       ' Número de elementos en la cola

    Public ReadOnly Property Capacity As Integer ' Capacidad máxima de la cola

    ' Constructor para inicializar la cola con una capacidad fija
    Public Sub New(ByVal capacity As Integer)
        Me.Capacity = capacity
        ReDim elements(capacity - 1)
        front = 0
        rear = -1
        count = 0
    End Sub

    ' Método para agregar un número a la cola
    Public Sub Enqueue(ByVal number As Integer)
        If count = Capacity Then
            Throw New InvalidOperationException("La cola está llena.")
        End If

        rear = (rear + 1) Mod Capacity
        elements(rear) = number
        count += 1
    End Sub

    ' Método para eliminar y devolver el número al frente de la cola
    Public Function Dequeue() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Dim number As Integer = elements(front)
        front = (front + 1) Mod Capacity
        count -= 1
        Return number
    End Function

    ' Método para ver el número al frente de la cola sin eliminarlo
    Public Function Peek() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Return elements(front)
    End Function

    ' Método para verificar si la cola está vacía
    Public Function IsEmpty() As Boolean
        Return count = 0
    End Function

    ' Método para verificar si la cola está llena
    Public Function IsFull() As Boolean
        Return count = Capacity
    End Function

    ' Método para obtener el tamaño actual de la cola
    Public Function Size() As Integer
        Return count
    End Function
End Class


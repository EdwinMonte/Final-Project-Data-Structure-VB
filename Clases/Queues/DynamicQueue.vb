Public Class DynamicQueue
    Private front As Node ' Nodo al frente de la cola
    Private rear As Node  ' Nodo al final de la cola
    Private count As Integer ' Número de elementos en la cola

    ' Propiedad para obtener el tamaño de la cola
    Public ReadOnly Property Count As Integer
        Get
            Return Count
        End Get
    End Property

    Public Sub New()
        front = Nothing
        rear = Nothing
        count = 0
    End Sub

    ' Método para agregar un número a la cola
    Public Sub Enqueue(number As Integer)
        Dim newNode As New Node(number)

        If IsEmpty() Then
            front = newNode
            rear = newNode
        Else
            rear.Next = newNode
            rear = newNode
        End If

        count += 1
    End Sub

    ' Método para eliminar y devolver el número al frente de la cola
    Public Function Dequeue() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Dim data As Integer = front.Value
        front = front.Next

        If front Is Nothing Then
            rear = Nothing ' La cola queda vacía
        End If

        count -= 1
        Return data
    End Function

    ' Método para ver el número al frente de la cola sin eliminarlo
    Public Function Peek() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Return front.Value
    End Function

    ' Método para verificar si la cola está vacía
    Public Function IsEmpty() As Boolean
        Return front Is Nothing
    End Function

    ' Método para obtener el tamaño de la cola
    Public Function Size() As Integer
        Return count
    End Function
End Class

' Clase Node para representar un nodo en la cola
Public Class Node
    Public Property Value As Integer
    Public Property [Next] As Node

    Public Sub New(value As Integer)
        Me.Value = value
        Me.Next = Nothing
    End Sub
End Class


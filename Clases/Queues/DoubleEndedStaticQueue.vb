Public Class DoubleEndedStaticQueue
    Private array() As Integer
    Private front As Integer
    Private rear As Integer
    Private size As Integer
    Private capacity As Integer

    Public Sub New(capacity As Integer)
        Me.capacity = capacity
        ReDim array(capacity - 1)
        front = -1
        rear = -1
        size = 0
    End Sub

    ' Verifica si la cola está vacía
    Public Function IsEmpty() As Boolean
        Return size = 0
    End Function

    ' Verifica si la cola está llena
    Public Function IsFull() As Boolean
        Return size = capacity
    End Function

    ' Inserta un elemento en el frente de la cola
    Public Sub InsertFront(value As Integer)
        If IsFull() Then Throw New InvalidOperationException("La cola está llena.")

        ' Mover todos los elementos una posición hacia atrás
        For i As Integer = size - 1 To 0 Step -1
            array(i + 1) = array(i)
        Next

        ' Insertar el valor al frente
        array(0) = value
        If front = -1 Then front = 0
        rear = (rear + 1) Mod capacity
        size += 1
    End Sub

    ' Inserta un elemento en el final de la cola
    Public Sub InsertRear(value As Integer)
        If IsFull() Then Throw New InvalidOperationException("La cola está llena.")

        If rear = -1 Then ' Si la cola está vacía
            front = 0
            rear = 0
        Else
            rear = (rear + 1) Mod capacity ' Mover el índice del final hacia adelante
        End If

        array(rear) = value
        size += 1
    End Sub

    ' Elimina un elemento del frente de la cola
    Public Function DeleteFront() As Integer
        If IsEmpty() Then
            Console.WriteLine("La cola está vacía.")
            Return -1
        End If

        Dim value As Integer = array(front)
        If front = rear Then ' Si hay un solo elemento
            front = -1
            rear = -1
        Else
            front = (front + 1) Mod capacity ' Mover el índice del frente hacia adelante
        End If

        size -= 1
        Return value
    End Function

    ' Elimina un elemento del final de la cola
    Public Function DeleteRear() As Integer
        If IsEmpty() Then
            Console.WriteLine("La cola está vacía.")
            Return -1
        End If

        Dim value As Integer = array(rear)
        If front = rear Then ' Si hay un solo elemento
            front = -1
            rear = -1
        Else
            rear = (rear - 1 + capacity) Mod capacity ' Mover el índice del final hacia atrás
        End If

        size -= 1
        Return value
    End Function

    ' Ver el valor en el frente sin eliminarlo
    Public Function GetFront() As Integer
        If IsEmpty() Then
            Console.WriteLine("La cola está vacía.")
            Return -1
        End If
        Return array(front)
    End Function

    ' Ver el valor en el final sin eliminarlo
    Public Function GetRear() As Integer
        If IsEmpty() Then
            Console.WriteLine("La cola está vacía.")
            Return -1
        End If
        Return array(rear)
    End Function

    ' Obtener el tamaño actual de la cola
    Public Function Size() As Integer
        Return Size
    End Function

    ' Obtener los elementos de la cola como una lista
    Public Function GetQueueElements() As List(Of Integer)
        Dim elements As New List(Of Integer)()

        If front <> -1 Then
            For i As Integer = front To rear
                elements.Add(array(i))
            Next
        End If

        Return elements
    End Function
End Class


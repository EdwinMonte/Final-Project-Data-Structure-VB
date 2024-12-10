Public Class DoubleEndedDynamicQueue
    Private front As DoubleNode   ' Frente de la cola
    Private back As DoubleNode    ' Final de la cola
    Private size As Integer       ' Tamaño de la cola

    Public Sub New()
        front = Nothing
        back = Nothing
        size = 0
    End Sub

    ' Agregar un elemento al frente de la cola
    Public Sub InsertFront(value As Integer)
        Dim newNode As New DoubleNode(value)

        If IsEmpty() Then
            front = newNode
            back = newNode   ' Si la cola está vacía, el nuevo nodo es tanto el frente como el final
        Else
            newNode.Next = front
            front.Prev = newNode
            front = newNode
        End If

        size += 1
    End Sub

    ' Agregar un elemento al final de la cola
    Public Sub InsertRear(value As Integer)
        Dim newNode As New DoubleNode(value)

        If IsEmpty() Then
            front = newNode
            back = newNode   ' Si la cola está vacía, el nuevo nodo es tanto el frente como el final
        Else
            newNode.Prev = back
            back.Next = newNode
            back = newNode
        End If

        size += 1
    End Sub

    ' Eliminar un elemento del frente de la cola
    Public Function DeleteFront() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Dim frontValue As Integer = front.Value
        front = front.Next

        If front IsNot Nothing Then
            front.Prev = Nothing
        Else
            back = Nothing   ' Si la cola queda vacía, el final también debe ser nulo
        End If

        size -= 1
        Return frontValue
    End Function

    ' Eliminar un elemento del final de la cola
    Public Function DeleteRear() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Dim backValue As Integer = back.Value
        back = back.Prev

        If back IsNot Nothing Then
            back.Next = Nothing
        Else
            front = Nothing   ' Si la cola queda vacía, el frente también debe ser nulo
        End If

        size -= 1
        Return backValue
    End Function

    ' Ver el elemento del frente de la cola sin eliminarlo
    Public Function GetFront() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Return front.Value
    End Function

    ' Ver el elemento del final de la cola sin eliminarlo
    Public Function GetRear() As Integer
        If IsEmpty() Then
            Throw New InvalidOperationException("La cola está vacía.")
        End If

        Return back.Value
    End Function

    ' Obtener el tamaño de la cola
    Public Function Size() As Integer
        Return Size
    End Function

    ' Verificar si la cola está vacía
    Public Function IsEmpty() As Boolean
        Return size = 0
    End Function

    ' Obtener los elementos de la cola como una lista
    Public Function GetQueueElements() As List(Of Integer)
        Dim elements As New List(Of Integer)()
        Dim current As DoubleNode = front

        While current IsNot Nothing
            elements.Add(current.Value)
            current = current.Next
        End While

        Return elements
    End Function
End Class

' Clase DoubleNode para representar los nodos de la cola
Public Class DoubleNode
    Public Property Value As Integer
    Public Property Next As DoubleNode
    Public Property Prev As DoubleNode

    Public Sub New(value As Integer)
        Me.Value = value
        Me.Next = Nothing
        Me.Prev = Nothing
    End Sub
End Class


Public Class PriorityQueues
    Public Class VectorOfVectors_PQ(Of T)
        Private _queue As T()()
        Private _maxPriority As Integer

        ' Constructor, inicializar con el nivel máximo de prioridad
        Public Sub New(maxPriority As Integer)
            _maxPriority = maxPriority
            ReDim _queue(maxPriority)
            For i As Integer = 0 To maxPriority
                _queue(i) = Array.Empty(Of T)()
            Next
        End Sub

        ' Encolar un elemento con una prioridad específica
        Public Sub Enqueue(item As T, priority As Integer)
            If priority < 0 OrElse priority > _maxPriority Then
                Throw New ArgumentException("La prioridad está fuera de rango.")
            End If

            Array.Resize(_queue(priority), _queue(priority).Length + 1)
            _queue(priority)(_queue(priority).Length - 1) = item
        End Sub

        ' Desencolar el elemento con la prioridad más alta
        Public Function Dequeue() As T
            For i As Integer = _maxPriority To 0 Step -1
                If _queue(i).Length > 0 Then
                    Dim item As T = _queue(i)(0)
                    Dim newArray(_queue(i).Length - 2) As T
                    Array.Copy(_queue(i), 1, newArray, 0, newArray.Length)
                    _queue(i) = newArray
                    Return item
                End If
            Next
            Throw New InvalidOperationException("La cola está vacía.")
        End Function

        ' Ver el elemento con la prioridad más alta sin desencolarlo
        Public Function Peek() As T
            For i As Integer = _maxPriority To 0 Step -1
                If _queue(i).Length > 0 Then
                    Return _queue(i)(0)
                End If
            Next
            Throw New InvalidOperationException("La cola está vacía.")
        End Function

        ' Verificar si la cola está vacía
        Public Function IsEmpty() As Boolean
            For i As Integer = 0 To _maxPriority
                If _queue(i).Length > 0 Then
                    Return False
                End If
            Next
            Return True
        End Function

        ' Obtener el número de elementos en la cola
        Public Function Size() As Integer
            Dim size As Integer = 0
            For i As Integer = 0 To _maxPriority
                size += _queue(i).Length
            Next
            Return size
        End Function

        ' Representación de la cola como lista
        Public Function ToList() As List(Of String)
            Dim result As New List(Of String)()
            For i As Integer = _queue.Length - 1 To 0 Step -1
                For Each item In _queue(i)
                    result.Add($"Priority {i}: {item}")
                Next
            Next
            Return result
        End Function
    End Class

    ' Implementación para VectorOfLists_PQ
    Public Class VectorOfLists_PQ(Of T)
        Private _priorityLists As List(Of T)()
        Private _maxPriority As Integer

        ' Constructor
        Public Sub New(maxPriority As Integer)
            If maxPriority < 0 Then
                Throw New ArgumentException("La prioridad máxima debe ser no negativa.")
            End If

            _maxPriority = maxPriority
            _priorityLists = New List(Of T)(maxPriority + 1) {}
            For i As Integer = 0 To maxPriority
                _priorityLists(i) = New List(Of T)()
            Next
        End Sub

        ' Encolar un elemento con prioridad específica
        Public Sub Enqueue(item As T, priority As Integer)
            If priority < 0 OrElse priority > _maxPriority Then
                Throw New ArgumentException("La prioridad está fuera de rango.")
            End If
            _priorityLists(priority).Add(item)
        End Sub

        ' Desencolar el elemento con la prioridad más alta
        Public Function Dequeue() As T
            For i As Integer = _maxPriority To 0 Step -1
                If _priorityLists(i).Count > 0 Then
                    Dim item As T = _priorityLists(i)(0)
                    _priorityLists(i).RemoveAt(0)
                    Return item
                End If
            Next
            Throw New InvalidOperationException("La cola está vacía.")
        End Function

        ' Otros métodos (Peek, IsEmpty, Size, ToList) son similares.
    End Class

    ' Implementación para ListOfLists_PQ y ListOfVectors_PQ puede seguir un patrón similar
End Class


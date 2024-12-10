Friend Class BucketSort
    Public Shared Async Function Sort(array As Integer(), displayCallback As Action(Of Integer(), String)) As Task
        Dim n As Integer = array.Length
        If n <= 1 Then Return

        Dim minValue As Integer = array.Min()
        Dim maxValue As Integer = array.Max()
        Dim bucketCount As Integer = n

        ' Crear los "buckets" vacíos
        Dim buckets As New List(Of List(Of Integer))(bucketCount)
        For i As Integer = 0 To bucketCount - 1
            buckets.Add(New List(Of Integer)())
        Next

        ' Distribuir los elementos en los "buckets"
        displayCallback(array, "Distribuyendo los elementos en los buckets...")
        For i As Integer = 0 To n - 1
            Dim bucketIndex As Integer = (array(i) - minValue) * (bucketCount - 1) \ (maxValue - minValue)
            buckets(bucketIndex).Add(array(i))
        Next

        ' Mostrar los buckets con su rango, incluyendo los vacíos
        For i As Integer = 0 To bucketCount - 1
            If buckets(i).Count > 0 Then
                Dim bucketMin As Integer = buckets(i).Min()
                Dim bucketMax As Integer = buckets(i).Max()
                displayCallback(buckets(i).ToArray(), $"Bucket {i + 1}: Rango: [{bucketMin}, {bucketMax}] - Elementos: {String.Join(", ", buckets(i))}")
            Else
                displayCallback(New Integer() {}, $"Bucket {i + 1}: Vacío")
            End If
        Next

        ' Ordenar los "buckets" individualmente usando InsertionSort
        For i As Integer = 0 To bucketCount - 1
            Await InsertionSort(buckets(i), displayCallback)
        Next

        ' Concatenar los resultados
        Dim index As Integer = 0
        For Each bucket In buckets
            For Each item In bucket
                array(index) = item
                index += 1
            Next
        Next

        ' Mostrar el arreglo final
        displayCallback(array, "Arreglo final ordenado: " & String.Join(", ", array))
    End Function

    ' Método InsertionSort para ordenar cada bucket
    Private Shared Async Function InsertionSort(array As List(Of Integer), displayCallback As Action(Of Integer(), String)) As Task
        Dim n As Integer = array.Count
        For i As Integer = 1 To n - 1
            Dim key As Integer = array(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso array(j) > key
                array(j + 1) = array(j)
                j -= 1
            End While
            array(j + 1) = key

            ' Mostrar el arreglo después de cada paso de InsertionSort
            displayCallback(array.ToArray(), "Paso de InsertionSort: " & String.Join(", ", array))
            Await Task.Delay(500) ' Añadir una pequeña demora para visualizar los pasos
        Next
    End Function
End Class


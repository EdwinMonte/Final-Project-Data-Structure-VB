Public Class MergeAlgorithms
    Public Shared Async Function MergeSort(ByVal array As Integer(), ByVal left As Integer, ByVal right As Integer, ByVal displayCallback As Action(Of Integer(), Integer, Integer)) As Task
        If left < right Then
            Dim mid As Integer = (left + right) \ 2

            ' Ordenar la mitad izquierda
            Await MergeSort(array, left, mid, displayCallback)

            ' Ordenar la mitad derecha
            Await MergeSort(array, mid + 1, right, displayCallback)

            ' Fusionar las dos mitades
            Await Merge(array, left, mid, right, displayCallback)
        End If
    End Function

    Private Shared Async Function Merge(ByVal array As Integer(), ByVal left As Integer, ByVal mid As Integer, ByVal right As Integer, ByVal displayCallback As Action(Of Integer(), Integer, Integer)) As Task
        Dim n1 As Integer = mid - left + 1
        Dim n2 As Integer = right - mid

        Dim leftArray(n1 - 1) As Integer
        Dim rightArray(n2 - 1) As Integer

        ' Copiar los datos a los arrays temporales
        array.Copy(array, left, leftArray, 0, n1)
        array.Copy(array, mid + 1, rightArray, 0, n2)

        Dim i As Integer = 0, j As Integer = 0, k As Integer = left

        ' Mezclar las dos mitades
        While i < n1 AndAlso j < n2
            ' Mostrar la comparación
            displayCallback(array, i, j)
            Await Task.Delay(500) ' Pausa para visualización

            If leftArray(i) <= rightArray(j) Then
                array(k) = leftArray(i)
                i += 1
            Else
                array(k) = rightArray(j)
                j += 1
            End If
            k += 1
        End While

        ' Copiar los elementos restantes si los hay
        While i < n1
            array(k) = leftArray(i)
            i += 1
            k += 1
        End While
        While j < n2
            array(k) = rightArray(j)
            j += 1
            k += 1
        End While

        ' Mostrar el arreglo después de la fusión
        displayCallback(array, left, right)
        Await Task.Delay(500) ' Pausa para visualización
    End Function
End Class


Imports System.Threading.Tasks

Friend Class BubbleSort
    Public Shared Async Function Sort(arr As Integer(), displayCallback As Action(Of Integer(), Integer, Integer)) As Task
        Dim n As Integer = arr.Length
        Dim temp As Integer
        Dim swapped As Boolean

        ' Recorre el arreglo para realizar las comparaciones e intercambios
        For i As Integer = 0 To n - 2
            swapped = False

            For j As Integer = 0 To n - i - 2
                ' Mostrar los números que se están comparando
                displayCallback(arr, j, j + 1)

                ' Esperar para mostrar la comparación
                Await Task.Delay(400)

                If arr(j) > arr(j + 1) Then
                    ' Intercambiar los elementos
                    temp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp

                    swapped = True ' Incrementa el contador de intercambios

                    ' Mostrar los números después de intercambiarlos
                    displayCallback(arr, j, j + 1)
                    Await Task.Delay(400)
                End If
            Next

            ' Si no se hicieron intercambios, el arreglo está ordenado
            If Not swapped Then
                Exit For
            End If
        Next
    End Function
End Class


Imports System
Imports System.Threading.Tasks

Namespace Final_Project_Data_Structure_and_Sorting_Algorithms
    Friend Class CombSort
        Public Shared Async Function Sort(ByVal array As Integer(), ByVal displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim gap As Integer = array.Length
            Const shrinkFactor As Double = 1.3
            Dim swapped As Boolean = True

            While gap > 1 OrElse swapped
                ' Reduce el gap según el factor de reducción
                gap = CInt(gap / shrinkFactor)
                If gap < 1 Then
                    gap = 1
                End If

                swapped = False

                ' Compara los elementos con el gap actual
                For i As Integer = 0 To array.Length - gap - 1
                    ' Mostrar comparación entre los elementos con el gap
                    displayCallback(array, i, i + gap)
                    Await Task.Delay(500) ' Pausa para visualizar la comparación

                    If array(i) > array(i + gap) Then
                        ' Intercambiar los elementos si están fuera de orden
                        Dim temp As Integer = array(i)
                        array(i) = array(i + gap)
                        array(i + gap) = temp

                        ' Mostrar el intercambio
                        displayCallback(array, i, i + gap)
                        Await Task.Delay(500) ' Pausa para visualizar el intercambio

                        swapped = True
                    End If
                Next
            End While

            ' Visualización final después de ordenar
            displayCallback(array, -1, -1) ' Indica que el proceso ha terminado
        End Function
    End Class
End Namespace


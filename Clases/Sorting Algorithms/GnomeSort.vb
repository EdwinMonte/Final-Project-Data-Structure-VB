Imports System
Imports System.Threading.Tasks

Namespace Final_Project_Data_Structure_and_Sorting_Algorithms
    Friend Module GnomeSort
        Public Async Function Sort(ByVal array As Integer(), ByVal displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            Dim n As Integer = array.Length
            Dim index As Integer = 0

            While index < n
                ' Mostrar los números que estamos comparando
                displayCallback(array, index, index - 1)
                Await Task.Delay(500) ' Pausa para visualizar la comparación

                If index = 0 OrElse array(index) >= array(index - 1) Then
                    index += 1
                Else
                    ' Realizar el intercambio
                    Dim temp As Integer = array(index)
                    array(index) = array(index - 1)
                    array(index - 1) = temp

                    ' Mostrar los números después del intercambio
                    displayCallback(array, index, index - 1)
                    Await Task.Delay(500) ' Pausa para visualizar el intercambio

                    index -= 1 ' Retroceder índice
                End If
            End While

            displayCallback(array, -1, -1) ' Visualización final
        End Function
    End Module
End Namespace

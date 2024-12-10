﻿Imports System
Imports System.Threading.Tasks

Namespace Final_Project_Data_Structure_and_Sorting_Algorithms
    Friend Class QuickSort
        Public Shared Async Function Sort(ByVal array As Integer(), ByVal low As Integer, ByVal high As Integer, ByVal displayCallback As Action(Of Integer(), Integer, Integer)) As Task
            If low < high Then
                ' Encuentra el pivote
                Dim pivotIndex As Integer = Await Partition(array, low, high, displayCallback)

                ' Visualizar la partición actual
                displayCallback(array, low, high)
                Await Task.Delay(500) ' Pausa para visualizar la partición

                ' Ordenar recursivamente las sublistas
                Await Sort(array, low, pivotIndex - 1, displayCallback)
                Await Sort(array, pivotIndex + 1, high, displayCallback)
            End If
        End Function

        Private Shared Async Function Partition(ByVal array As Integer(), ByVal low As Integer, ByVal high As Integer, ByVal displayCallback As Action(Of Integer(), Integer, Integer)) As Task(Of Integer)
            Dim pivot As Integer = array(high)
            Dim i As Integer = low - 1

            For j As Integer = low To high - 1
                ' Mostrar la comparación entre array[j] y el pivote
                displayCallback(array, j, high)
                Await Task.Delay(500) ' Pausa para visualizar la comparación

                If array(j) <= pivot Then
                    i += 1

                    ' Intercambiar array[i] y array[j]
                    Dim temp As Integer = array(i)
                    array(i) = array(j)
                    array(j) = temp

                    ' Mostrar el intercambio
                    displayCallback(array, i, j)
                    Await Task.Delay(500) ' Pausa para visualizar el intercambio
                End If
            Next

            ' Colocar el pivote en su lugar correcto
            Dim pivotIndex As Integer = i + 1
            Dim tempPivot As Integer = array(pivotIndex)
            array(pivotIndex) = array(high)
            array(high) = tempPivot

            ' Mostrar la colocación del pivote
            displayCallback(array, pivotIndex, high)
            Await Task.Delay(500) ' Pausa para visualizar el intercambio del pivote

            Return pivotIndex
        End Function
    End Class
End Namespace

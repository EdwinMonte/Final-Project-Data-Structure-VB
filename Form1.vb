Imports System.Windows.Forms
Imports Final_Project_Data_Structure.Final_Project_Data_Structure_and_Sorting_Algorithms
Imports Final_Project_Data_Structure.PriorityQueues

Partial Public Class Form1
    Private linkedList As LinkedList
    Private doubleLinkedList As DoublyLinkedList
    Private circularLinkedList As CircularLinkedList
    Private doubleCircularLinkedList As DoublyCircularLinkedList
    Private staticStack As StaticStack
    Private dynamicStack As DynamicStack
    Private staticQueue As StaticQueue
    Private dynamicQueue As DynamicQueue
    Private circularQueue As CircularQueue
    Private doubleEndedStaticQueue As DoubleEndedStaticQueue
    Private doubleEndedDynamicQueue As DoubleEndedDynamicQueue
    Private graph As Graph
    Private numbers As Integer()
    Private vectorOfVectorsPQ As VectorOfVectors_PQ(Of Integer)
    Private vectorOfListsPQ As VectorOfLists_PQ(Of Integer)
    Private listOfListsPQ As ListOfLists_PQ(Of Integer)
    Private listOfVectorsPQ As ListOfVectors_PQ(Of Integer)
    Private root As BinaryTree.Node

    Public Sub New()
        InitializeComponent()
        linkedList = New LinkedList()
        doubleLinkedList = New DoublyLinkedList()
        circularLinkedList = New CircularLinkedList()
        doubleCircularLinkedList = New DoublyCircularLinkedList()
        staticStack = New StaticStack()
        dynamicStack = New DynamicStack()
        staticQueue = New StaticQueue(5)
        dynamicQueue = New DynamicQueue()
        circularQueue = New CircularQueue(5)
        doubleEndedStaticQueue = New DoubleEndedStaticQueue(5)
        doubleEndedDynamicQueue = New DoubleEndedDynamicQueue()
        graph = New Graph()
        cmbAlgoritms.Items.AddRange(New String() {"Gnome Sort", "Heap Sort", "Pigeonhole Sort", "Bubble Sort", "Cocktail Sort", "Insertion Sort", "Shell Sort", "Selection Sort", "Quick Sort", "Merge Sort", "Direct Merge", "Natural Merge", "Comb Sort", "Counting Sort", "Bucket Sort"})
        cmbAlgoritms.SelectedIndex = 0
        numbers = New Integer() {}
        vectorOfVectorsPQ = New VectorOfVectors_PQ(Of Integer)(3)
        vectorOfListsPQ = New VectorOfLists_PQ(Of Integer)(3)
        listOfListsPQ = New ListOfLists_PQ(Of Integer)(3)
        listOfVectorsPQ = New ListOfVectors_PQ(Of Integer)(3)
        root = New BinaryTree.Node()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Verificar si el valor ingresado es un número
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            ' Crear un nuevo nodo con el valor ingresado
            Dim newNode As New Node(value)
            Dim newDoubleNode As New DoubleNode(value)

            ' Agregar el nodo a todas las listas
            linkedList.Add(newNode)
            circularLinkedList.Add(New Node(value))
            doubleLinkedList.Add(newDoubleNode)
            doubleCircularLinkedList.Add(New DoubleNode(value))

            ' Limpiar los ListBox
            lstSimpleLinkedList.Items.Clear()
            lstDoubleList.Items.Clear()
            lstCircularList.Items.Clear()
            lstDoubleCircularList.Items.Clear()

            ' Mostrar los valores en los ListBox para cada lista
            ShowListValues(lstSimpleLinkedList, linkedList.GetHead())
            ShowListValues(lstDoubleList, doubleLinkedList.GetHead())
            ShowListValues(lstCircularList, circularLinkedList.GetHead())
            ShowListValues(lstDoubleCircularList, doubleCircularLinkedList.GetHead())

            ' Limpiar el TextBox después de agregar el nodo
            txtValue.Clear()
        Else
            MessageBox.Show("Please enter a valid numeric value.")
        End If
    End Sub
    Private Sub ShowListValues(listBox As ListBox, head As Object)
        listBox.Items.Clear() ' Limpiar la lista antes de mostrar valores

        If TypeOf head Is Node Then
            ' Lista simple o lista simple circular
            Dim headNode As Node = DirectCast(head, Node)
            Dim current As Node = headNode

            Do
                listBox.Items.Add(current.Value)
                current = current.Next
            Loop While current IsNot Nothing AndAlso current IsNot headNode ' Para manejar tanto listas simples como circulares

        ElseIf TypeOf head Is DoubleNode Then
            ' Lista doble o lista doble circular
            Dim headDoubleNode As DoubleNode = DirectCast(head, DoubleNode)
            Dim current As DoubleNode = headDoubleNode

            Do
                listBox.Items.Add(current.Value)
                current = current.Next
            Loop While current IsNot Nothing AndAlso current IsNot headDoubleNode
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            linkedList.Remove(value)
            doubleLinkedList.Remove(value)
            circularLinkedList.Remove(value)
            doubleCircularLinkedList.Remove(value)

            ' Actualizar los ListBox
            ShowListValues(lstSimpleLinkedList, linkedList.GetHead())
            ShowListValues(lstDoubleList, doubleLinkedList.GetHead())
            ShowListValues(lstCircularList, circularLinkedList.GetHead())
            ShowListValues(lstDoubleCircularList, doubleCircularLinkedList.GetHead())

            txtValue.Clear() ' Limpiar el TextBox
        Else
            MessageBox.Show("Please enter a valid numeric value.")
        End If
    End Sub

    Private Sub btnContains_Click(sender As Object, e As EventArgs) Handles btnContains.Click
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            Dim inSimpleList As Boolean = linkedList.Contains(value)
            Dim inDoubleList As Boolean = doubleLinkedList.Contains(value)
            Dim inCircularList As Boolean = circularLinkedList.Contains(value)
            Dim inDoubleCircularList As Boolean = doubleCircularLinkedList.Contains(value)

            Dim message As String = $"Value {value} found in:" & vbCrLf &
                                $"- Simple Linked List: {inSimpleList}" & vbCrLf &
                                $"- Double Linked List: {inDoubleList}" & vbCrLf &
                                $"- Circular Linked List: {inCircularList}" & vbCrLf &
                                $"- Double Circular Linked List: {inDoubleCircularList}"

            MessageBox.Show(message)
        Else
            MessageBox.Show("Please enter a valid numeric value.")
        End If

        txtValue.Clear()
    End Sub
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim countSimple As Integer = linkedList.Count()
        Dim countDouble As Integer = doubleLinkedList.Count()
        Dim countCircular As Integer = circularLinkedList.Count()
        Dim countDoubleCircular As Integer = doubleCircularLinkedList.Count()

        ' Mostrar los resultados en un MessageBox
        Dim message As String = $"Number of nodes in each list:" & vbCrLf &
                            $"- Simple Linked List: {countSimple}" & vbCrLf &
                            $"- Double Linked List: {countDouble}" & vbCrLf &
                            $"- Circular Linked List: {countCircular}" & vbCrLf &
                            $"- Double Circular Linked List: {countDoubleCircular}"

        MessageBox.Show(message)
    End Sub

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        ' Verificar si el valor ingresado es un número
        Dim value As Integer
        If Integer.TryParse(txtStackValue.Text, value) Then
            Dim newNode As New Node(Convert.ToInt32(txtStackValue.Text))
            ' Agregar el valor a ambas pilas
            staticStack.Push(value)
            dynamicStack.Push(newNode)
            UpdateStacks()

            ' Limpiar el TextBox después de agregar el valor
            txtStackValue.Clear()
        Else
            MessageBox.Show("Por favor, ingresa un valor numérico válido.")
        End If
    End Sub

    Private Sub UpdateStacks()
        ' Limpiar las listas antes de actualizar
        lstDynamicStack.Items.Clear()
        lstStaticStack.Items.Clear()

        ' Actualizar la pila dinámica
        Dim currentNode As Node = dynamicStack.Peek()
        While currentNode IsNot Nothing
            lstDynamicStack.Items.Add(currentNode.Value)
            currentNode = currentNode.Next
        End While

        ' Actualizar la pila estática
        Dim temporal As New StaticStack()
        Dim elemento As String

        ' Mostrar los elementos en la pila estática
        While Not staticStack.IsEmpty()
            elemento = staticStack.Pop().ToString()
            lstStaticStack.Items.Add(elemento)
            temporal.Push(Convert.ToInt32(elemento))
        End While

        ' Restaurar los elementos en la pila original
        While Not temporal.IsEmpty()
            staticStack.Push(Convert.ToInt32(temporal.Pop().ToString()))
        End While
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        If Not dynamicStack.IsEmpty() Then
            Dim poppedNode As Node = dynamicStack.Pop()
            MessageBox.Show($"Element removed from the dynamic stack: {poppedNode.Value}" & vbCrLf &
                        $"Element removed from the static stack: {staticStack.Pop()}")
            UpdateStacks()
            Return
        End If

        If dynamicStack.IsEmpty() AndAlso staticStack.IsEmpty() Then
            MessageBox.Show("Both stacks are empty")
        End If
    End Sub
    Private Sub btnPeek_Click(sender As Object, e As EventArgs) Handles btnPeek.Click
        Dim topNode As Node = dynamicStack.Peek()
        If Not dynamicStack.IsEmpty() OrElse Not staticStack.IsEmpty() Then
            MessageBox.Show($"Element on the top of the dynamic stack is: {topNode.Value}" & vbCrLf &
                        $"Element on the top of the static stack is: {staticStack.Peek()}")
            Return
        End If
        MessageBox.Show("Both stacks are empty")
    End Sub

    Private Sub btnSize_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        MessageBox.Show($"Current static stack size is : {staticStack.Size()}" & vbCrLf &
                    $"Current dynamic stack size is: {dynamicStack.Size()}")
    End Sub

    Private Sub btnEnqueue_Click(sender As Object, e As EventArgs) Handles btnEnqueue.Click
        Try
            Dim value As Integer
            If Integer.TryParse(txtValueSimpleQueue.Text, value) Then
                ' Agregar valor a la cola estática
                If Not staticQueue.IsFull() Then
                    staticQueue.Enqueue(value)
                    UpdateQueueDisplay(staticQueue, lstStaticQueue)
                Else
                    MessageBox.Show("Static queue is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Agregar valor a la cola dinámica
                dynamicQueue.Enqueue(value)
                UpdateQueueDisplay(dynamicQueue, lstDynamicQueue)

                ' Agregar valor a la cola circular
                If Not circularQueue.IsFull() Then
                    circularQueue.Enqueue(value)
                    UpdateQueueDisplay(circularQueue, lstCircularQueue)
                Else
                    MessageBox.Show("Circular queue is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Limpiar el TextBox después de insertar
            txtValueSimpleQueue.Clear()
            txtValueSimpleQueue.Focus()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateQueueDisplay(queue As Object, listBox As ListBox)
        listBox.Items.Clear()

        If TypeOf queue Is StaticQueue Then
            Dim staticQueue As StaticQueue = DirectCast(queue, StaticQueue)
            Dim tempQueue As New StaticQueue(staticQueue.Capacity)

            While Not staticQueue.IsEmpty()
                Dim value As Integer = staticQueue.Dequeue()
                listBox.Items.Add(value)
                tempQueue.Enqueue(value)
            End While

            ' Restaurar los elementos a la cola estática
            While Not tempQueue.IsEmpty()
                staticQueue.Enqueue(tempQueue.Dequeue())
            End While

        ElseIf TypeOf queue Is DynamicQueue Then
            Dim dynamicQueue As DynamicQueue = DirectCast(queue, DynamicQueue)
            Dim tempQueue As New DynamicQueue()

            While Not dynamicQueue.IsEmpty()
                Dim value As Integer = dynamicQueue.Dequeue()
                listBox.Items.Add(value)
                tempQueue.Enqueue(value)
            End While

            ' Restaurar los elementos a la cola dinámica
            While Not tempQueue.IsEmpty()
                dynamicQueue.Enqueue(tempQueue.Dequeue())
            End While

        ElseIf TypeOf queue Is CircularQueue Then
            Dim circularQueue As CircularQueue = DirectCast(queue, CircularQueue)
            Dim tempQueue As New CircularQueue(circularQueue.Capacity)

            While Not circularQueue.IsEmpty()
                Dim value As Integer = circularQueue.Dequeue()
                listBox.Items.Add(value)
                tempQueue.Enqueue(value)
            End While

            ' Restaurar los elementos a la cola circular
            While Not tempQueue.IsEmpty()
                circularQueue.Enqueue(tempQueue.Dequeue())
            End While
        End If
    End Sub
    Private Sub btnDequeue_Click(sender As Object, e As EventArgs) Handles btnDequeue.Click
        Try
            Dim message As New Text.StringBuilder()

            ' Eliminar un valor de la cola estática
            If Not staticQueue.IsEmpty() Then
                Dim dequeuedValueStatic As Integer = staticQueue.Dequeue()
                UpdateQueueDisplay(staticQueue, lstStaticQueue)
                message.AppendLine($"Static Queue: {dequeuedValueStatic}")
            Else
                message.AppendLine("Static Queue: Empty")
            End If

            ' Eliminar un valor de la cola dinámica
            If Not dynamicQueue.IsEmpty() Then
                Dim dequeuedValueDynamic As Integer = dynamicQueue.Dequeue()
                UpdateQueueDisplay(dynamicQueue, lstDynamicQueue)
                message.AppendLine($"Dynamic Queue: {dequeuedValueDynamic}")
            Else
                message.AppendLine("Dynamic Queue: Empty")
            End If

            ' Eliminar un valor de la cola circular
            If Not circularQueue.IsEmpty() Then
                Dim dequeuedValueCircular As Integer = circularQueue.Dequeue()
                UpdateQueueDisplay(circularQueue, lstCircularQueue)
                message.AppendLine($"Circular Queue: {dequeuedValueCircular}")
            Else
                message.AppendLine("Circular Queue: Empty")
            End If

            ' Mostrar todos los resultados en un solo MessageBox
            MessageBox.Show(message.ToString(), "Dequeued Values", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPeekQueue_Click(sender As Object, e As EventArgs) Handles btnPeekQueue.Click
        Try
            Dim message As New Text.StringBuilder()

            ' Ver el valor al frente de la cola estática sin eliminarlo
            If Not staticQueue.IsEmpty() Then
                Dim frontValueStatic As Integer = staticQueue.Peek()
                message.AppendLine($"Static Queue: {frontValueStatic}")
            Else
                message.AppendLine("Static Queue: Empty")
            End If

            ' Ver el valor al frente de la cola dinámica sin eliminarlo
            If Not dynamicQueue.IsEmpty() Then
                Dim frontValueDynamic As Integer = dynamicQueue.Peek()
                message.AppendLine($"Dynamic Queue: {frontValueDynamic}")
            Else
                message.AppendLine("Dynamic Queue: Empty")
            End If

            ' Ver el valor al frente de la cola circular sin eliminarlo
            If Not circularQueue.IsEmpty() Then
                Dim frontValueCircular As Integer = circularQueue.Peek()
                message.AppendLine($"Circular Queue: {frontValueCircular}")
            Else
                message.AppendLine("Circular Queue: Empty")
            End If

            ' Mostrar todos los resultados en un solo MessageBox
            MessageBox.Show(message.ToString(), "Peek Values", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSizeQueue_Click(sender As Object, e As EventArgs) Handles btnSizeQueue.Click
        Try
            Dim message As New Text.StringBuilder()

            ' Obtener el tamaño de la cola estática
            Dim staticQueueSize As Integer = staticQueue.Size()
            message.AppendLine($"Static Queue Size: {staticQueueSize}")

            ' Obtener el tamaño de la cola dinámica
            Dim dynamicQueueSize As Integer = dynamicQueue.Size()
            message.AppendLine($"Dynamic Queue Size: {dynamicQueueSize}")

            ' Obtener el tamaño de la cola circular
            Dim circularQueueSize As Integer = circularQueue.Size()
            message.AppendLine($"Circular Queue Size: {circularQueueSize}")

            ' Mostrar todos los tamaños en un solo MessageBox
            MessageBox.Show(message.ToString(), "Queue Sizes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnInsertFront_Click(sender As Object, e As EventArgs) Handles btnInsertFront.Click
        Try
            Dim value As Integer

            If Integer.TryParse(txtQueueDoubleValue.Text, value) Then
                ' Insertar al frente de la cola estática
                If Not doubleEndedStaticQueue.IsFull() Then
                    doubleEndedStaticQueue.InsertFront(value)

                    ' Limpiar y actualizar el ListBox para la cola estática
                    lstQueueDobleVector.Items.Clear()
                    For Each item In doubleEndedStaticQueue.GetQueueElements()
                        lstQueueDobleVector.Items.Add(item)
                    Next
                Else
                    MessageBox.Show("Static double queue is full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Insertar al frente de la cola dinámica
                Try
                    doubleEndedDynamicQueue.InsertFront(value)

                    ' Limpiar y actualizar el ListBox para la cola dinámica
                    lstQueueDoubleList.Items.Clear()
                    For Each item In doubleEndedDynamicQueue.GetQueueElements()
                        lstQueueDoubleList.Items.Add(item)
                    Next
                Catch ex As InvalidOperationException
                    MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Limpiar el TextBox y dar foco de nuevo
            txtQueueDoubleValue.Clear()
            txtQueueDoubleValue.Focus()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInsertRear_Click(sender As Object, e As EventArgs) Handles btnInsertRear.Click
        Try
            Dim value As Integer

            If Integer.TryParse(txtQueueDoubleValue.Text, value) Then
                ' Insertar al final de la cola estática
                If Not doubleEndedStaticQueue.IsFull() Then
                    doubleEndedStaticQueue.InsertRear(value)

                    ' Limpiar y actualizar el ListBox para la cola estática
                    lstQueueDobleVector.Items.Clear()
                    For Each item In doubleEndedStaticQueue.GetQueueElements()
                        lstQueueDobleVector.Items.Add(item)
                    Next
                Else
                    MessageBox.Show("Static double queue is full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Insertar al final de la cola dinámica
                Try
                    doubleEndedDynamicQueue.InsertRear(value)

                    ' Limpiar y actualizar el ListBox para la cola dinámica
                    lstQueueDoubleList.Items.Clear()
                    For Each item In doubleEndedDynamicQueue.GetQueueElements()
                        lstQueueDoubleList.Items.Add(item)
                    Next
                Catch ex As InvalidOperationException
                    MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Limpiar el TextBox y dar foco de nuevo
            txtQueueDoubleValue.Clear()
            txtQueueDoubleValue.Focus()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnDeleteFront_Click(sender As Object, e As EventArgs) Handles btnDeleteFront.Click
        Try
            ' Intentar eliminar el elemento desde el frente de la cola estática
            Try
                If Not doubleEndedStaticQueue.IsEmpty() Then
                    doubleEndedStaticQueue.DeleteFront()

                    ' Limpiar y actualizar el ListBox para la cola estática
                    lstQueueDobleVector.Items.Clear()
                    For Each item In doubleEndedStaticQueue.GetQueueElements()
                        lstQueueDobleVector.Items.Add(item)
                    Next
                Else
                    MessageBox.Show("Static queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Intentar eliminar el elemento desde el frente de la cola dinámica
            Try
                If Not doubleEndedDynamicQueue.IsEmpty() Then
                    doubleEndedDynamicQueue.DeleteFront()

                    ' Limpiar y actualizar el ListBox para la cola dinámica
                    lstQueueDoubleList.Items.Clear()
                    For Each item In doubleEndedDynamicQueue.GetQueueElements()
                        lstQueueDoubleList.Items.Add(item)
                    Next
                Else
                    MessageBox.Show("Dynamic queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteRear_Click(sender As Object, e As EventArgs) Handles btnDeleteRear.Click
        Try
            ' Intentar eliminar el elemento desde el final de la cola estática
            Try
                If Not doubleEndedStaticQueue.IsEmpty() Then
                    doubleEndedStaticQueue.DeleteRear()

                    ' Limpiar y actualizar el ListBox para la cola estática
                    lstQueueDobleVector.Items.Clear()
                    For Each item In doubleEndedStaticQueue.GetQueueElements()
                        lstQueueDobleVector.Items.Add(item)
                    Next
                Else
                    MessageBox.Show("Static queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Intentar eliminar el elemento desde el final de la cola dinámica
            Try
                If Not doubleEndedDynamicQueue.IsEmpty() Then
                    doubleEndedDynamicQueue.DeleteRear()

                    ' Limpiar y actualizar el ListBox para la cola dinámica
                    lstQueueDoubleList.Items.Clear()
                    For Each item In doubleEndedDynamicQueue.GetQueueElements()
                        lstQueueDoubleList.Items.Add(item)
                    Next
                Else
                    MessageBox.Show("Dynamic queue is empty, cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGetFront_Click(sender As Object, e As EventArgs) Handles btnGetFront.Click
        Try
            ' Obtener el primer elemento de la cola estática
            Try
                If Not doubleEndedStaticQueue.IsEmpty() Then
                    Dim frontStatic As Integer = doubleEndedStaticQueue.GetFront()
                    MessageBox.Show($"Front of static queue: {frontStatic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Static queue is empty, cannot get front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Obtener el primer elemento de la cola dinámica
            Try
                If Not doubleEndedDynamicQueue.IsEmpty() Then
                    Dim frontDynamic As Integer = doubleEndedDynamicQueue.GetFront()
                    MessageBox.Show($"Front of dynamic queue: {frontDynamic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Dynamic queue is empty, cannot get front.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGetRear_Click(sender As Object, e As EventArgs) Handles btnGetRear.Click
        Try
            ' Obtener el último elemento de la cola estática
            Try
                If Not doubleEndedStaticQueue.IsEmpty() Then
                    Dim rearStatic As Integer = doubleEndedStaticQueue.GetRear()
                    MessageBox.Show($"Rear of static queue: {rearStatic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Static queue is empty, cannot get rear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Static queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Obtener el último elemento de la cola dinámica
            Try
                If Not doubleEndedDynamicQueue.IsEmpty() Then
                    Dim rearDynamic As Integer = doubleEndedDynamicQueue.GetRear()
                    MessageBox.Show($"Rear of dynamic queue: {rearDynamic}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Dynamic queue is empty, cannot get rear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Dynamic queue error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSizeDoubleQueue_Click(sender As Object, e As EventArgs) Handles btnSizeDoubleQueue.Click
        Try
            ' Obtener el tamaño de la cola estática
            Dim staticQueueSize As Integer = doubleEndedStaticQueue.Size()
            MessageBox.Show($"Size of static queue: {staticQueueSize}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Obtener el tamaño de la cola dinámica
            Dim dynamicQueueSize As Integer = doubleEndedDynamicQueue.Size()
            MessageBox.Show($"Size of dynamic queue: {dynamicQueueSize}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' MÉTODO PARA ENCOLAR EN COLAS DE PRIORIDAD
    Private Sub btnEnqueuePriorityQueue_Click(sender As Object, e As EventArgs) Handles btnEnqueuePriorityQueue.Click
        Try
            ' Validar si los valores son enteros
            Dim value As Integer
            Dim priority As Integer
            If Integer.TryParse(txtQueuePriorityValue.Text, value) AndAlso Integer.TryParse(txtPriorityQueueLevel.Text, priority) Then
                ' Encolar en las diferentes estructuras de prioridad
                vectorOfVectorsPQ.Enqueue(value, priority)
                vectorOfListsPQ.Enqueue(value, priority)
                listOfListsPQ.Enqueue(value, priority)
                listOfVectorsPQ.Enqueue(value, priority)
                UpdateListBoxes()
            Else
                MessageBox.Show("Please enter valid integer values for both value and priority.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As FormatException
            MessageBox.Show($"Invalid format for priority level. Please enter a valid integer. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateListBoxes()
        ' Limpiar los ListBoxes
        lstPriorityQueueVV.Items.Clear()
        lstPriorityQueueVL.Items.Clear()
        lstPriorityQueueLV.Items.Clear()
        lstPriorityQueueLL.Items.Clear()

        ' Actualizar ListBoxes
        UpdateListBox(lstPriorityQueueVV, vectorOfVectorsPQ)
        UpdateListBox(lstPriorityQueueVL, vectorOfListsPQ)
        UpdateListBox(lstPriorityQueueLL, listOfListsPQ)
        UpdateListBox(lstPriorityQueueLV, listOfVectorsPQ)
    End Sub
    Private Sub UpdateListBox(Of T As Class)(listBox As ListBox, queue As T)
        listBox.Items.Clear()
        Dim items = DirectCast(queue, Object).ToList()
        listBox.Items.AddRange(items.ToArray())
    End Sub

    Private Sub btnDequeuePriorityQueue_Click(sender As Object, e As EventArgs) Handles btnDequeuePriorityQueue.Click
        Try
            ' Verificar y desencolar elementos de cada estructura
            If Not vectorOfVectorsPQ.IsEmpty() Then
                Dim dequeuedItem = vectorOfVectorsPQ.Dequeue()
                MessageBox.Show($"Dequeued from vectorOfVectorsPQ: {dequeuedItem}")
            Else
                MessageBox.Show("vectorOfVectorsPQ is empty.")
            End If

            If Not vectorOfListsPQ.IsEmpty() Then
                Dim dequeuedItem = vectorOfListsPQ.Dequeue()
                MessageBox.Show($"Dequeued from vectorOfListsPQ: {dequeuedItem}")
            Else
                MessageBox.Show("vectorOfListsPQ is empty.")
            End If

            If Not listOfListsPQ.IsEmpty() Then
                Dim dequeuedItem = listOfListsPQ.Dequeue()
                MessageBox.Show($"Dequeued from listOfListsPQ: {dequeuedItem}")
            Else
                MessageBox.Show("listOfListsPQ is empty.")
            End If

            If Not listOfVectorsPQ.IsEmpty() Then
                Dim dequeuedItem = listOfVectorsPQ.Dequeue()
                MessageBox.Show($"Dequeued from listOfVectorsPQ: {dequeuedItem}")
            Else
                MessageBox.Show("listOfVectorsPQ is empty.")
            End If

            ' Actualizar ListBoxes después de desencolar
            UpdateListBoxes()
        Catch ex As Exception
            MessageBox.Show($"An error occurred while dequeuing: {ex.Message}")
        End Try
    End Sub

    Private Sub btnPeekPriorityQueue_Click(sender As Object, e As EventArgs) Handles btnPeekPriorityQueue.Click
        Try
            ' Verificar y obtener el siguiente elemento de cada estructura
            If Not vectorOfVectorsPQ.IsEmpty() Then
                Dim peekedItem = vectorOfVectorsPQ.Peek()
                MessageBox.Show($"Next item in vectorOfVectorsPQ: {peekedItem}")
            Else
                MessageBox.Show("vectorOfVectorsPQ is empty.")
            End If

            If Not vectorOfListsPQ.IsEmpty() Then
                Dim peekedItem = vectorOfListsPQ.Peek()
                MessageBox.Show($"Next item in vectorOfListsPQ: {peekedItem}")
            Else
                MessageBox.Show("vectorOfListsPQ is empty.")
            End If

            If Not listOfListsPQ.IsEmpty() Then
                Dim peekedItem = listOfListsPQ.Peek()
                MessageBox.Show($"Next item in listOfListsPQ: {peekedItem}")
            Else
                MessageBox.Show("listOfListsPQ is empty.")
            End If

            If Not listOfVectorsPQ.IsEmpty() Then
                Dim peekedItem = listOfVectorsPQ.Peek()
                MessageBox.Show($"Next item in listOfVectorsPQ: {peekedItem}")
            Else
                MessageBox.Show("listOfVectorsPQ is empty.")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while peeking: {ex.Message}")
        End Try
    End Sub
    Private Sub btnAddNode_Click(sender As Object, e As EventArgs) Handles btnAddNode.Click
        Dim nodeName As String = txtNode.Text.Trim()
        If Not String.IsNullOrEmpty(nodeName) Then
            ' Verificar si el nodo ya existe en el grafo
            If graph.Nodes.Any(Function(node) node.Name = nodeName) Then
                MessageBox.Show($"The node '{nodeName}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Si no existe, añadir el nodo
                Dim newNode As New GraphNode(nodeName)
                graph.AddNode(newNode)
                MessageBox.Show($"Node '{nodeName}' added.", "Success", MessageBoxButtons.OK)
                txtNode.Clear()

                Dim weightText As String = txtWeight.Text.Trim()
                If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                    txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
                Else
                    txtGraphRepresentation.Text = graph.ShowAdjacencyList()
                End If

                txtFrom.Clear()
                txtTo.Clear()
            End If
        End If
    End Sub

    Private Sub btnAddEdge_Click(sender As Object, e As EventArgs) Handles btnAddEdge.Click
        Dim fromNodeName As String = txtFrom.Text.Trim()
        Dim toNodeName As String = txtTo.Text.Trim()
        Dim weightText As String = txtWeight.Text.Trim()

        Dim fromNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = fromNodeName)
        Dim toNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = toNodeName)

        If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
            ' Si se especifica peso
            If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                Dim weight As Integer = Integer.Parse(weightText)

                If chkDirected.Checked Then
                    graph.AddEdge(fromNode, toNode, weight)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                Else
                    graph.AddNoDirectedEdge(fromNode, toNode, weight)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}' with weight {weight}.")
                End If
                txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
            Else
                ' Si no se especifica peso
                If chkDirected.Checked Then
                    graph.AddEdge(fromNode, toNode)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                Else
                    graph.AddNoDirectedEdge(fromNode, toNode)
                    MessageBox.Show($"Edge added from '{fromNodeName}' to '{toNodeName}'.")
                End If
                txtGraphRepresentation.Text = graph.ShowAdjacencyList()
            End If

            txtFrom.Clear()
            txtTo.Clear()
        Else
            MessageBox.Show("One or both nodes do not exist.")
        End If
    End Sub

    Private Sub btnRemoveNode_Click(sender As Object, e As EventArgs) Handles btnRemoveNode.Click
        Dim nodeName As String = txtNode.Text.Trim()
        Dim nodeToRemove As GraphNode = graph.Nodes.Find(Function(n) n.Name = nodeName)

        If nodeToRemove IsNot Nothing Then
            graph.RemoveNode(nodeToRemove)
            MessageBox.Show($"Node '{nodeName}' deleted.", "Success", MessageBoxButtons.OK)
            txtNode.Clear()

            ' Actualizar la representación de la lista de adyacencia
            Dim weightText As String = txtWeight.Text.Trim()
            If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
            Else
                txtGraphRepresentation.Text = graph.ShowAdjacencyList()
            End If

            txtFrom.Clear()
            txtTo.Clear()
        Else
            MessageBox.Show("Node not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnRemoveEdge_Click(sender As Object, e As EventArgs) Handles btnRemoveEdge.Click
        Dim fromNodeName As String = txtFrom.Text.Trim()
        Dim toNodeName As String = txtTo.Text.Trim()
        Dim isDirected As Boolean = chkDirected.Checked ' CheckBox para determinar si la arista es dirigida.

        Dim fromNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = fromNodeName)
        Dim toNode As GraphNode = graph.Nodes.Find(Function(n) n.Name = toNodeName)

        If fromNode IsNot Nothing AndAlso toNode IsNot Nothing Then
            If isDirected Then
                graph.RemoveEdge(fromNode, toNode)
                MessageBox.Show($"Directed edge removed from '{fromNodeName}' to '{toNodeName}'.", "Success", MessageBoxButtons.OK)
            Else
                graph.RemoveEdge(fromNode, toNode)
                graph.RemoveEdge(toNode, fromNode)
                MessageBox.Show($"Undirected edge removed between '{fromNodeName}' and '{toNodeName}'.", "Success", MessageBoxButtons.OK)
            End If

            Dim weightText As String = txtWeight.Text.Trim()
            If Not String.IsNullOrEmpty(weightText) AndAlso Integer.TryParse(weightText, Nothing) Then
                txtGraphRepresentation.Text = graph.ShowAdjacencyListWithWeights()
            Else
                txtGraphRepresentation.Text = graph.ShowAdjacencyList()
            End If

            txtFrom.Clear()
            txtTo.Clear()
        Else
            MessageBox.Show("One or both nodes do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnShowDFS_Click(sender As Object, e As EventArgs) Handles btnShowDFS.Click
        txtGraphRepresentation.Clear()
        ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
        Dim startNodeName As String = txtStartNode.Text

        ' Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
        Dim startNode As GraphNode = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)

        If startNode IsNot Nothing Then
            ' Realizar DFS desde el nodo encontrado
            Dim result As String = graph.DFSIterative(startNode)
            txtGraphRepresentation.Text = result ' Mostrar el resultado en el TextBox
        Else
            ' Si el nodo no existe, mostrar un mensaje de error
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub

    Private Sub btnShowBFS_Click(sender As Object, e As EventArgs) Handles btnShowBFS.Click
        txtGraphRepresentation.Clear()
        ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
        Dim startNodeName As String = txtStartNode.Text

        ' Buscar el nodo en el grafo cuyo nombre coincida con el ingresado
        Dim startNode As GraphNode = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)

        If startNode IsNot Nothing Then
            ' Realizar BFS desde el nodo encontrado
            Dim result As String = graph.BFS(startNode)
            txtGraphRepresentation.Text = result ' Mostrar el resultado en el TextBox
        Else
            ' Si el nodo no existe, mostrar un mensaje de error
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub
    Private Sub btnShowDFSRecursive_Click(sender As Object, e As EventArgs) Handles btnShowDFSRecursive.Click
        txtGraphRepresentation.Clear()
        ' Obtener el nombre del nodo de inicio desde una TextBox (puede ser un número o una palabra)
        Dim startNodeName As String = txtStartNode.Text
        Dim startNode As GraphNode = graph.Nodes.FirstOrDefault(Function(n) n.Name = startNodeName)
        If startNode IsNot Nothing Then
            Dim result As String = graph.DFS(startNode)
            txtGraphRepresentation.Text = result
        Else
            txtGraphRepresentation.Text = "Node not found."
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        ' Validación en inglés
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove all nodes and edges?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            graph.RemoveGraph()
            MessageBox.Show("All nodes and edges removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtGraphRepresentation.Clear()
        End If
    End Sub

    Private Sub btnSetNumbers_Click(sender As Object, e As EventArgs) Handles btnSetNumbers.Click
        Dim random As New Random()
        numbers = Enumerable.Range(0, 10).Select(Function(_) random.Next(1, 100)).ToArray()
        DisplayNumbers(numbers)
    End Sub

    Private Async Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If numbers Is Nothing OrElse numbers.Length = 0 Then
            MessageBox.Show("Please generate the numbers first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedMethod As String = cmbAlgoritms.SelectedItem.ToString()

        Select Case selectedMethod
            Case "Gnome Sort"
                Await GnomeSort.Sort(numbers, AddressOf DisplayNumbers)
            Case "Bubble Sort"
                Await BubbleSort.Sort(numbers, AddressOf DisplayNumbers)
            Case "Comb Sort"
                Await CombSort.Sort(numbers, AddressOf DisplayNumbers)
        'Case "Pigeonhole Sort"
        '    Await PigeonHoleSort.Sort(numbers, AddressOf UpdateCasillasListBox, AddressOf UpdateSortedListBox)
        '    Exit Select
            Case "Cocktail Sort"
                Await CocktailSort.Sort(numbers, AddressOf DisplayNumbers)
            Case "Heap Sort"
                Await HeapSort.Sort(numbers, AddressOf DisplayNumbers)
            Case "Insertion Sort"
                Await InsertionSort.Sort(numbers, AddressOf DisplayNumbers)
            Case "Shell Sort"
                Await ShellSort.Sort(numbers, AddressOf DisplayNumbers)
            Case "Selection Sort"
                Await SelectionSort.Sort(numbers, AddressOf DisplayNumbers)
            Case "Counting Sort"
                Await CountingSort.Sort(numbers, AddressOf DisplayNumbersMerge)
            Case "Bucket Sort"
                Await BucketSort.Sort(numbers, AddressOf DisplayNumbersMerge)
            Case "Merge Sort"
                Await MergeAlgorithms.MergeSort(numbers, 0, numbers.Length - 1, AddressOf DisplayNumbersMerge)
            Case "Natural Merge"
                Await MergeAlgorithms.NaturalMerge(numbers, AddressOf DisplayNumbersMerge)
            Case "Direct Merge"
                Await MergeAlgorithms.DirectMerge(numbers, AddressOf DisplayNumbersMerge)
            Case "Quick Sort"
                Await QuickSort.Sort(numbers, 0, numbers.Length - 1, AddressOf DisplayNumbers)
            Case Else
                MessageBox.Show("Invalid sorting method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        MessageBox.Show("Sorting completed!", selectedMethod, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub DisplayNumbers(array As Integer(), Optional currentIndex As Integer = -1, Optional compareIndex As Integer = -1)
        lstNumbersSort.Items.Clear()
        For i As Integer = 0 To array.Length - 1
            Dim itemText As String = array(i).ToString()
            If i = currentIndex OrElse i = compareIndex Then
                itemText = $"[{itemText}]"
            End If
            lstNumbersSort.Items.Add(itemText)
        Next
    End Sub

    Private Sub DisplayNumbersMerge(array As Integer(), message As String)
        ' Añadir un mensaje y el contenido del arreglo al ListBox
        lstNumbersSort.Items.Add(message)
        lstNumbersSort.Items.Add($"[{String.Join(", ", array)}]")
        lstNumbersSort.Items.Add("") ' Línea en blanco para separar pasos
    End Sub

    Private Sub btnPriorityQueueSize_Click(sender As Object, e As EventArgs) Handles btnPriorityQueueuSize.Click
        Try
            ' Mostrar el tamaño de cada cola
            MessageBox.Show($"vectorOfVectorsPQ size: {vectorOfVectorsPQ.Size()}")
            MessageBox.Show($"vectorOfListsPQ size: {vectorOfListsPQ.Size()}")
            MessageBox.Show($"listOfListsPQ size: {listOfListsPQ.Size()}")
            MessageBox.Show($"listOfVectorsPQ size: {listOfVectorsPQ.Size()}")
        Catch ex As Exception
            ' Manejar cualquier error inesperado
            MessageBox.Show($"An error occurred while retrieving the sizes: {ex.Message}")
        End Try
    End Sub

    Private Sub DrawTree()
        ' Este método será usado para dibujar el árbol en un control como un PictureBox
        Using g As Graphics = panelTree.CreateGraphics()
            g.Clear(Color.White) ' Limpia el panel antes de dibujar

            If root.value IsNot Nothing Then
                DrawNode(g, root, panelTree.Width \ 2, 20, 100) ' Comienza a dibujar desde el centro del Panel
            End If
        End Using
    End Sub

    Private Sub DrawNode(g As Graphics, node As BinaryTree.Node, x As Integer, y As Integer, xOffset As Integer)
        If node Is Nothing Then Return

        ' Limitar la posición dentro del Panel
        Dim panelWidth As Integer = panelTree.Width
        Dim panelHeight As Integer = panelTree.Height

        ' Asegurar que las coordenadas x, y no se salgan del área del Panel
        x = Math.Max(30, Math.Min(panelWidth - 30, x)) ' Limita x entre 30 y panelWidth - 30
        y = Math.Max(30, Math.Min(panelHeight - 30, y)) ' Limita y entre 30 y panelHeight - 30

        ' Dibuja el nodo
        g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30)
        g.DrawString(node.value.ToString(), Me.Font, Brushes.Black, x - 10, y - 10)

        ' Dibuja las aristas
        If node.left IsNot Nothing Then
            Dim leftX As Integer = x - xOffset
            Dim leftY As Integer = y + 60
            g.DrawLine(Pens.Black, x, y, leftX, leftY)
            DrawNode(g, node.left, leftX, leftY, xOffset \ 2)
        End If

        If node.right IsNot Nothing Then
            Dim rightX As Integer = x + xOffset
            Dim rightY As Integer = y + 60
            g.DrawLine(Pens.Black, x, y, rightX, rightY)
            DrawNode(g, node.right, rightX, rightY, xOffset \ 2)
        End If
    End Sub
    Private Sub btnInsertNode_Click(sender As Object, e As EventArgs) Handles btnInsertNode.Click
        Dim value As Integer
        If Integer.TryParse(txtNodeValue.Text, value) Then
            root.Insert(value)
            DrawTree()
            txtNodeValue.Clear()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim value As Integer
        If Integer.TryParse(txtNodeValue.Text, value) Then
            root = root.Delete(root, value) ' Elimina el nodo
            DrawTree()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim value As Integer
        If Integer.TryParse(txtNodeValue.Text, value) Then
            Dim foundNode As BinaryTree.Node = root.Search(value)
            MessageBox.Show(root.GetNodeInfo(foundNode, "Found"))
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        root = New BinaryTree.Node() ' Establece la raíz a null, eliminando todo el árbol
        DrawTree()
    End Sub

    Private Sub btnPreOrder_Click(sender As Object, e As EventArgs) Handles btnPreOrder.Click
        Dim result As String = PreOrderTraversal(root)
        txtOutput.Text = result
    End Sub

    Private Function PreOrderTraversal(node As BinaryTree.Node) As String
        If node Is Nothing Then Return ""
        Return node.value.ToString() & ", " & PreOrderTraversal(node.left) & PreOrderTraversal(node.right)
    End Function

    Private Sub btnInOrder_Click(sender As Object, e As EventArgs) Handles btnInOrder.Click
        Dim result As String = InOrderTraversal(root)
        txtOutput.Text = result
    End Sub

    Private Function InOrderTraversal(node As BinaryTree.Node) As String
        If node Is Nothing Then Return ""
        Return InOrderTraversal(node.left) & node.value.ToString() & ", " & InOrderTraversal(node.right)
    End Function

    Private Sub btnPostOrder_Click(sender As Object, e As EventArgs) Handles btnPostOrder.Click
        Dim result As String = PostOrderTraversal(root)
        txtOutput.Text = result
    End Sub

    Private Function PostOrderTraversal(node As BinaryTree.Node) As String
        If node Is Nothing Then Return ""
        Return PostOrderTraversal(node.left) & PostOrderTraversal(node.right) & node.value.ToString() & ", "
    End Function
End Class


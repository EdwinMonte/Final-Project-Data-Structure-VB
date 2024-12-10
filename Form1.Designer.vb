<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tabControl1 = New TabControl()
        Lists = New TabPage()
        btnCount = New Button()
        btnContains = New Button()
        btnRemove = New Button()
        btnAdd = New Button()
        label5 = New Label()
        txtValue = New TextBox()
        label3 = New Label()
        lstDoubleCircularList = New ListBox()
        label4 = New Label()
        lstCircularList = New ListBox()
        label2 = New Label()
        lstDoubleList = New ListBox()
        label1 = New Label()
        lstSimpleLinkedList = New ListBox()
        tabPage2 = New TabPage()
        btnSize = New Button()
        btnPeek = New Button()
        btnPop = New Button()
        btnPush = New Button()
        label8 = New Label()
        txtStackValue = New TextBox()
        label7 = New Label()
        lstDynamicStack = New ListBox()
        label6 = New Label()
        lstStaticStack = New ListBox()
        tabPage1 = New TabPage()
        tabControl2 = New TabControl()
        tabPage5 = New TabPage()
        label14 = New Label()
        lstCircularQueue = New ListBox()
        btnSizeQueue = New Button()
        btnPeekQueue = New Button()
        btnDequeue = New Button()
        btnEnqueue = New Button()
        label9 = New Label()
        txtValueSimpleQueue = New TextBox()
        label10 = New Label()
        lstDynamicQueue = New ListBox()
        label11 = New Label()
        lstStaticQueue = New ListBox()
        tabPage6 = New TabPage()
        btnGetRear = New Button()
        btnDeleteRear = New Button()
        btnInsertRear = New Button()
        label13 = New Label()
        lstQueueDoubleList = New ListBox()
        label15 = New Label()
        lstQueueDobleVector = New ListBox()
        btnSizeDoubleQueue = New Button()
        btnGetFront = New Button()
        btnDeleteFront = New Button()
        btnInsertFront = New Button()
        label12 = New Label()
        txtQueueDoubleValue = New TextBox()
        tabPage7 = New TabPage()
        label21 = New Label()
        txtPriorityQueueLevel = New TextBox()
        btnPriorityQueueSize = New Button()
        btnPeekPriorityQueue = New Button()
        btnDequeuePriorityQueue = New Button()
        btnEnqueuePriorityQueue = New Button()
        label17 = New Label()
        lstPriorityQueueLL = New ListBox()
        label18 = New Label()
        lstPriorityQueueLV = New ListBox()
        label19 = New Label()
        lstPriorityQueueVL = New ListBox()
        label20 = New Label()
        lstPriorityQueueVV = New ListBox()
        label16 = New Label()
        txtQueuePriorityValue = New TextBox()
        tabPage3 = New TabPage()
        tabPage4 = New TabPage()
        label29 = New Label()
        label28 = New Label()
        label27 = New Label()
        label26 = New Label()
        label25 = New Label()
        label24 = New Label()
        label22 = New Label()
        label23 = New Label()
        btnRemoveAll = New Button()
        btnShowDFSRecursive = New Button()
        btnShowBFS = New Button()
        btnRemoveNode = New Button()
        txtStartNode = New TextBox()
        btnShowDFS = New Button()
        chkDirected = New CheckBox()
        txtWeight = New TextBox()
        txtGraphRepresentation = New TextBox()
        btnRemoveEdge = New Button()
        btnAddEdge = New Button()
        txtTo = New TextBox()
        txtFrom = New TextBox()
        txtNode = New TextBox()
        btnAddNode = New Button()
        tabPage8 = New TabPage()
        lstNumbersSort = New ListBox()
        cmbAlgoritms = New ComboBox()
        btnSort = New Button()
        btnSetNumbers = New Button()
        label30 = New Label()
        txtOutput = New TextBox()
        btnSearch = New Button()
        btnClear = New Button()
        btnInOrder = New Button()
        btnDelete = New Button()
        btnPostOrder = New Button()
        btnPreOrder = New Button()
        btnInsertNode = New Button()
        txtNodeValue = New TextBox()
        panelTree = New Panel()
        tabControl1.SuspendLayout()
        Lists.SuspendLayout()
        tabPage2.SuspendLayout()
        tabPage1.SuspendLayout()
        tabControl2.SuspendLayout()
        tabPage5.SuspendLayout()
        tabPage6.SuspendLayout()
        tabPage7.SuspendLayout()
        tabPage3.SuspendLayout()
        tabPage4.SuspendLayout()
        tabPage8.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabControl1
        ' 
        tabControl1.Controls.Add(Lists)
        tabControl1.Controls.Add(tabPage2)
        tabControl1.Controls.Add(tabPage1)
        tabControl1.Controls.Add(tabPage3)
        tabControl1.Controls.Add(tabPage4)
        tabControl1.Controls.Add(tabPage8)
        tabControl1.Location = New Point(124, 8)
        tabControl1.Margin = New Padding(3, 4, 3, 4)
        tabControl1.Name = "tabControl1"
        tabControl1.SelectedIndex = 0
        tabControl1.Size = New Size(1084, 693)
        tabControl1.TabIndex = 1
        ' 
        ' Lists
        ' 
        Lists.Controls.Add(btnCount)
        Lists.Controls.Add(btnContains)
        Lists.Controls.Add(btnRemove)
        Lists.Controls.Add(btnAdd)
        Lists.Controls.Add(label5)
        Lists.Controls.Add(txtValue)
        Lists.Controls.Add(label3)
        Lists.Controls.Add(lstDoubleCircularList)
        Lists.Controls.Add(label4)
        Lists.Controls.Add(lstCircularList)
        Lists.Controls.Add(label2)
        Lists.Controls.Add(lstDoubleList)
        Lists.Controls.Add(label1)
        Lists.Controls.Add(lstSimpleLinkedList)
        Lists.Location = New Point(4, 29)
        Lists.Margin = New Padding(3, 4, 3, 4)
        Lists.Name = "Lists"
        Lists.Padding = New Padding(3, 4, 3, 4)
        Lists.Size = New Size(1076, 660)
        Lists.TabIndex = 0
        Lists.Text = "Lists"
        Lists.UseVisualStyleBackColor = True
        ' 
        ' btnCount
        ' 
        btnCount.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCount.Location = New Point(235, 297)
        btnCount.Margin = New Padding(3, 4, 3, 4)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(110, 56)
        btnCount.TabIndex = 13
        btnCount.Text = "Count"
        btnCount.UseVisualStyleBackColor = True
        ' 
        ' btnContains
        ' 
        btnContains.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnContains.Location = New Point(235, 211)
        btnContains.Margin = New Padding(3, 4, 3, 4)
        btnContains.Name = "btnContains"
        btnContains.Size = New Size(110, 56)
        btnContains.TabIndex = 12
        btnContains.Text = "Contains"
        btnContains.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.Location = New Point(235, 124)
        btnRemove.Margin = New Padding(3, 4, 3, 4)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(110, 56)
        btnRemove.TabIndex = 11
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(235, 39)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(110, 56)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label5.Location = New Point(93, 43)
        label5.Name = "label5"
        label5.Size = New Size(86, 29)
        label5.TabIndex = 9
        label5.Text = "Value:"
        ' 
        ' txtValue
        ' 
        txtValue.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtValue.Location = New Point(58, 72)
        txtValue.Margin = New Padding(3, 4, 3, 4)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(135, 34)
        txtValue.TabIndex = 8
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label3.Location = New Point(753, 328)
        label3.Name = "label3"
        label3.Size = New Size(243, 29)
        label3.TabIndex = 7
        label3.Text = "Double Circular List"
        ' 
        ' lstDoubleCircularList
        ' 
        lstDoubleCircularList.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstDoubleCircularList.FormattingEnabled = True
        lstDoubleCircularList.ItemHeight = 29
        lstDoubleCircularList.Location = New Point(791, 369)
        lstDoubleCircularList.Margin = New Padding(3, 4, 3, 4)
        lstDoubleCircularList.Name = "lstDoubleCircularList"
        lstDoubleCircularList.Size = New Size(132, 207)
        lstDoubleCircularList.TabIndex = 6
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label4.Location = New Point(544, 328)
        label4.Name = "label4"
        label4.Size = New Size(152, 29)
        label4.TabIndex = 5
        label4.Text = "Circular List"
        ' 
        ' lstCircularList
        ' 
        lstCircularList.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstCircularList.FormattingEnabled = True
        lstCircularList.ItemHeight = 29
        lstCircularList.Location = New Point(555, 369)
        lstCircularList.Margin = New Padding(3, 4, 3, 4)
        lstCircularList.Name = "lstCircularList"
        lstCircularList.Size = New Size(132, 207)
        lstCircularList.TabIndex = 4
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label2.Location = New Point(794, 31)
        label2.Name = "label2"
        label2.Size = New Size(145, 29)
        label2.TabIndex = 3
        label2.Text = "Double List"
        ' 
        ' lstDoubleList
        ' 
        lstDoubleList.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstDoubleList.FormattingEnabled = True
        lstDoubleList.ItemHeight = 29
        lstDoubleList.Location = New Point(791, 72)
        lstDoubleList.Margin = New Padding(3, 4, 3, 4)
        lstDoubleList.Name = "lstDoubleList"
        lstDoubleList.Size = New Size(132, 207)
        lstDoubleList.TabIndex = 2
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label1.Location = New Point(532, 31)
        label1.Name = "label1"
        label1.Size = New Size(221, 29)
        label1.TabIndex = 1
        label1.Text = "Simple LinkedList"
        ' 
        ' lstSimpleLinkedList
        ' 
        lstSimpleLinkedList.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstSimpleLinkedList.FormattingEnabled = True
        lstSimpleLinkedList.ItemHeight = 29
        lstSimpleLinkedList.Location = New Point(555, 72)
        lstSimpleLinkedList.Margin = New Padding(3, 4, 3, 4)
        lstSimpleLinkedList.Name = "lstSimpleLinkedList"
        lstSimpleLinkedList.Size = New Size(132, 207)
        lstSimpleLinkedList.TabIndex = 0
        ' 
        ' tabPage2
        ' 
        tabPage2.Controls.Add(btnSize)
        tabPage2.Controls.Add(btnPeek)
        tabPage2.Controls.Add(btnPop)
        tabPage2.Controls.Add(btnPush)
        tabPage2.Controls.Add(label8)
        tabPage2.Controls.Add(txtStackValue)
        tabPage2.Controls.Add(label7)
        tabPage2.Controls.Add(lstDynamicStack)
        tabPage2.Controls.Add(label6)
        tabPage2.Controls.Add(lstStaticStack)
        tabPage2.Location = New Point(4, 29)
        tabPage2.Margin = New Padding(3, 4, 3, 4)
        tabPage2.Name = "tabPage2"
        tabPage2.Padding = New Padding(3, 4, 3, 4)
        tabPage2.Size = New Size(1076, 660)
        tabPage2.TabIndex = 1
        tabPage2.Text = "Stacks"
        tabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnSize
        ' 
        btnSize.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSize.Location = New Point(221, 332)
        btnSize.Margin = New Padding(3, 4, 3, 4)
        btnSize.Name = "btnSize"
        btnSize.Size = New Size(110, 56)
        btnSize.TabIndex = 15
        btnSize.Text = "Size"
        btnSize.UseVisualStyleBackColor = True
        ' 
        ' btnPeek
        ' 
        btnPeek.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPeek.Location = New Point(221, 247)
        btnPeek.Margin = New Padding(3, 4, 3, 4)
        btnPeek.Name = "btnPeek"
        btnPeek.Size = New Size(110, 56)
        btnPeek.TabIndex = 14
        btnPeek.Text = "Peek"
        btnPeek.UseVisualStyleBackColor = True
        ' 
        ' btnPop
        ' 
        btnPop.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPop.Location = New Point(221, 157)
        btnPop.Margin = New Padding(3, 4, 3, 4)
        btnPop.Name = "btnPop"
        btnPop.Size = New Size(110, 56)
        btnPop.TabIndex = 13
        btnPop.Text = "Pop"
        btnPop.UseVisualStyleBackColor = True
        ' 
        ' btnPush
        ' 
        btnPush.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPush.Location = New Point(221, 72)
        btnPush.Margin = New Padding(3, 4, 3, 4)
        btnPush.Name = "btnPush"
        btnPush.Size = New Size(110, 56)
        btnPush.TabIndex = 12
        btnPush.Text = "Push"
        btnPush.UseVisualStyleBackColor = True
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label8.Location = New Point(66, 45)
        label8.Name = "label8"
        label8.Size = New Size(86, 29)
        label8.TabIndex = 11
        label8.Text = "Value:"
        ' 
        ' txtStackValue
        ' 
        txtStackValue.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStackValue.Location = New Point(31, 75)
        txtStackValue.Margin = New Padding(3, 4, 3, 4)
        txtStackValue.Name = "txtStackValue"
        txtStackValue.Size = New Size(135, 34)
        txtStackValue.TabIndex = 10
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label7.Location = New Point(780, 103)
        label7.Name = "label7"
        label7.Size = New Size(183, 29)
        label7.TabIndex = 5
        label7.Text = "Dynamic Stack"
        ' 
        ' lstDynamicStack
        ' 
        lstDynamicStack.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstDynamicStack.FormattingEnabled = True
        lstDynamicStack.ItemHeight = 29
        lstDynamicStack.Location = New Point(795, 132)
        lstDynamicStack.Margin = New Padding(3, 4, 3, 4)
        lstDynamicStack.Name = "lstDynamicStack"
        lstDynamicStack.Size = New Size(135, 352)
        lstDynamicStack.TabIndex = 4
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label6.Location = New Point(525, 103)
        label6.Name = "label6"
        label6.Size = New Size(149, 29)
        label6.TabIndex = 3
        label6.Text = "Static Stack"
        ' 
        ' lstStaticStack
        ' 
        lstStaticStack.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstStaticStack.FormattingEnabled = True
        lstStaticStack.ItemHeight = 29
        lstStaticStack.Location = New Point(522, 132)
        lstStaticStack.Margin = New Padding(3, 4, 3, 4)
        lstStaticStack.Name = "lstStaticStack"
        lstStaticStack.Size = New Size(135, 352)
        lstStaticStack.TabIndex = 2
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(tabControl2)
        tabPage1.Location = New Point(4, 29)
        tabPage1.Margin = New Padding(3, 4, 3, 4)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3, 4, 3, 4)
        tabPage1.Size = New Size(1076, 660)
        tabPage1.TabIndex = 2
        tabPage1.Text = "Queues"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' tabControl2
        ' 
        tabControl2.Controls.Add(tabPage5)
        tabControl2.Controls.Add(tabPage6)
        tabControl2.Controls.Add(tabPage7)
        tabControl2.Location = New Point(-1, -3)
        tabControl2.Margin = New Padding(3, 4, 3, 4)
        tabControl2.Name = "tabControl2"
        tabControl2.SelectedIndex = 0
        tabControl2.Size = New Size(1041, 657)
        tabControl2.TabIndex = 0
        ' 
        ' tabPage5
        ' 
        tabPage5.Controls.Add(label14)
        tabPage5.Controls.Add(lstCircularQueue)
        tabPage5.Controls.Add(btnSizeQueue)
        tabPage5.Controls.Add(btnPeekQueue)
        tabPage5.Controls.Add(btnDequeue)
        tabPage5.Controls.Add(btnEnqueue)
        tabPage5.Controls.Add(label9)
        tabPage5.Controls.Add(txtValueSimpleQueue)
        tabPage5.Controls.Add(label10)
        tabPage5.Controls.Add(lstDynamicQueue)
        tabPage5.Controls.Add(label11)
        tabPage5.Controls.Add(lstStaticQueue)
        tabPage5.Location = New Point(4, 29)
        tabPage5.Margin = New Padding(3, 4, 3, 4)
        tabPage5.Name = "tabPage5"
        tabPage5.Padding = New Padding(3, 4, 3, 4)
        tabPage5.Size = New Size(1033, 624)
        tabPage5.TabIndex = 0
        tabPage5.Text = "Simple and Circular"
        tabPage5.UseVisualStyleBackColor = True
        ' 
        ' label14
        ' 
        label14.AutoSize = True
        label14.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label14.Location = New Point(834, 87)
        label14.Name = "label14"
        label14.Size = New Size(189, 29)
        label14.TabIndex = 29
        label14.Text = "Circular Queue"
        ' 
        ' lstCircularQueue
        ' 
        lstCircularQueue.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstCircularQueue.FormattingEnabled = True
        lstCircularQueue.ItemHeight = 29
        lstCircularQueue.Location = New Point(846, 116)
        lstCircularQueue.Margin = New Padding(3, 4, 3, 4)
        lstCircularQueue.Name = "lstCircularQueue"
        lstCircularQueue.Size = New Size(135, 352)
        lstCircularQueue.TabIndex = 28
        ' 
        ' btnSizeQueue
        ' 
        btnSizeQueue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSizeQueue.Location = New Point(249, 376)
        btnSizeQueue.Margin = New Padding(3, 4, 3, 4)
        btnSizeQueue.Name = "btnSizeQueue"
        btnSizeQueue.Size = New Size(110, 56)
        btnSizeQueue.TabIndex = 25
        btnSizeQueue.Text = "Size"
        btnSizeQueue.UseVisualStyleBackColor = True
        ' 
        ' btnPeekQueue
        ' 
        btnPeekQueue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPeekQueue.Location = New Point(249, 291)
        btnPeekQueue.Margin = New Padding(3, 4, 3, 4)
        btnPeekQueue.Name = "btnPeekQueue"
        btnPeekQueue.Size = New Size(110, 56)
        btnPeekQueue.TabIndex = 24
        btnPeekQueue.Text = "Peek"
        btnPeekQueue.UseVisualStyleBackColor = True
        ' 
        ' btnDequeue
        ' 
        btnDequeue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDequeue.Location = New Point(249, 201)
        btnDequeue.Margin = New Padding(3, 4, 3, 4)
        btnDequeue.Name = "btnDequeue"
        btnDequeue.Size = New Size(110, 56)
        btnDequeue.TabIndex = 23
        btnDequeue.Text = "Dequeue"
        btnDequeue.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueue
        ' 
        btnEnqueue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnqueue.Location = New Point(249, 116)
        btnEnqueue.Margin = New Padding(3, 4, 3, 4)
        btnEnqueue.Name = "btnEnqueue"
        btnEnqueue.Size = New Size(110, 56)
        btnEnqueue.TabIndex = 22
        btnEnqueue.Text = "Enqueue"
        btnEnqueue.UseVisualStyleBackColor = True
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label9.Location = New Point(58, 43)
        label9.Name = "label9"
        label9.Size = New Size(86, 29)
        label9.TabIndex = 21
        label9.Text = "Value:"
        ' 
        ' txtValueSimpleQueue
        ' 
        txtValueSimpleQueue.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtValueSimpleQueue.Location = New Point(23, 72)
        txtValueSimpleQueue.Margin = New Padding(3, 4, 3, 4)
        txtValueSimpleQueue.Name = "txtValueSimpleQueue"
        txtValueSimpleQueue.Size = New Size(135, 34)
        txtValueSimpleQueue.TabIndex = 20
        ' 
        ' label10
        ' 
        label10.AutoSize = True
        label10.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label10.Location = New Point(630, 87)
        label10.Name = "label10"
        label10.Size = New Size(197, 29)
        label10.TabIndex = 19
        label10.Text = "Dynamic Queue"
        ' 
        ' lstDynamicQueue
        ' 
        lstDynamicQueue.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstDynamicQueue.FormattingEnabled = True
        lstDynamicQueue.ItemHeight = 29
        lstDynamicQueue.Location = New Point(651, 116)
        lstDynamicQueue.Margin = New Padding(3, 4, 3, 4)
        lstDynamicQueue.Name = "lstDynamicQueue"
        lstDynamicQueue.Size = New Size(135, 352)
        lstDynamicQueue.TabIndex = 18
        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label11.Location = New Point(460, 87)
        label11.Name = "label11"
        label11.Size = New Size(163, 29)
        label11.TabIndex = 17
        label11.Text = "Static Queue"
        ' 
        ' lstStaticQueue
        ' 
        lstStaticQueue.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstStaticQueue.FormattingEnabled = True
        lstStaticQueue.ItemHeight = 29
        lstStaticQueue.Location = New Point(457, 116)
        lstStaticQueue.Margin = New Padding(3, 4, 3, 4)
        lstStaticQueue.Name = "lstStaticQueue"
        lstStaticQueue.Size = New Size(135, 352)
        lstStaticQueue.TabIndex = 16
        ' 
        ' tabPage6
        ' 
        tabPage6.Controls.Add(btnGetRear)
        tabPage6.Controls.Add(btnDeleteRear)
        tabPage6.Controls.Add(btnInsertRear)
        tabPage6.Controls.Add(label13)
        tabPage6.Controls.Add(lstQueueDoubleList)
        tabPage6.Controls.Add(label15)
        tabPage6.Controls.Add(lstQueueDobleVector)
        tabPage6.Controls.Add(btnSizeDoubleQueue)
        tabPage6.Controls.Add(btnGetFront)
        tabPage6.Controls.Add(btnDeleteFront)
        tabPage6.Controls.Add(btnInsertFront)
        tabPage6.Controls.Add(label12)
        tabPage6.Controls.Add(txtQueueDoubleValue)
        tabPage6.Location = New Point(4, 29)
        tabPage6.Margin = New Padding(3, 4, 3, 4)
        tabPage6.Name = "tabPage6"
        tabPage6.Padding = New Padding(3, 4, 3, 4)
        tabPage6.Size = New Size(1033, 624)
        tabPage6.TabIndex = 1
        tabPage6.Text = "Double"
        tabPage6.UseVisualStyleBackColor = True
        ' 
        ' btnGetRear
        ' 
        btnGetRear.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGetRear.Location = New Point(215, 335)
        btnGetRear.Margin = New Padding(3, 4, 3, 4)
        btnGetRear.Name = "btnGetRear"
        btnGetRear.Size = New Size(158, 56)
        btnGetRear.TabIndex = 42
        btnGetRear.Text = "Get Rear"
        btnGetRear.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteRear
        ' 
        btnDeleteRear.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteRear.Location = New Point(215, 245)
        btnDeleteRear.Margin = New Padding(3, 4, 3, 4)
        btnDeleteRear.Name = "btnDeleteRear"
        btnDeleteRear.Size = New Size(158, 56)
        btnDeleteRear.TabIndex = 41
        btnDeleteRear.Text = "Delete Rear"
        btnDeleteRear.UseVisualStyleBackColor = True
        ' 
        ' btnInsertRear
        ' 
        btnInsertRear.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertRear.Location = New Point(215, 160)
        btnInsertRear.Margin = New Padding(3, 4, 3, 4)
        btnInsertRear.Name = "btnInsertRear"
        btnInsertRear.Size = New Size(158, 56)
        btnInsertRear.TabIndex = 40
        btnInsertRear.Text = "Insert Rear"
        btnInsertRear.UseVisualStyleBackColor = True
        ' 
        ' label13
        ' 
        label13.AutoSize = True
        label13.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label13.Location = New Point(842, 87)
        label13.Name = "label13"
        label13.Size = New Size(125, 29)
        label13.TabIndex = 39
        label13.Text = "With Lists"
        ' 
        ' lstQueueDoubleList
        ' 
        lstQueueDoubleList.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstQueueDoubleList.FormattingEnabled = True
        lstQueueDoubleList.ItemHeight = 29
        lstQueueDoubleList.Location = New Point(829, 116)
        lstQueueDoubleList.Margin = New Padding(3, 4, 3, 4)
        lstQueueDoubleList.Name = "lstQueueDoubleList"
        lstQueueDoubleList.Size = New Size(135, 352)
        lstQueueDoubleList.TabIndex = 38
        ' 
        ' label15
        ' 
        label15.AutoSize = True
        label15.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label15.Location = New Point(632, 87)
        label15.Name = "label15"
        label15.Size = New Size(159, 29)
        label15.TabIndex = 37
        label15.Text = "With Vectors"
        ' 
        ' lstQueueDobleVector
        ' 
        lstQueueDobleVector.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstQueueDobleVector.FormattingEnabled = True
        lstQueueDobleVector.ItemHeight = 29
        lstQueueDobleVector.Location = New Point(634, 116)
        lstQueueDobleVector.Margin = New Padding(3, 4, 3, 4)
        lstQueueDobleVector.Name = "lstQueueDobleVector"
        lstQueueDobleVector.Size = New Size(135, 352)
        lstQueueDobleVector.TabIndex = 36
        ' 
        ' btnSizeDoubleQueue
        ' 
        btnSizeDoubleQueue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSizeDoubleQueue.Location = New Point(146, 417)
        btnSizeDoubleQueue.Margin = New Padding(3, 4, 3, 4)
        btnSizeDoubleQueue.Name = "btnSizeDoubleQueue"
        btnSizeDoubleQueue.Size = New Size(110, 56)
        btnSizeDoubleQueue.TabIndex = 35
        btnSizeDoubleQueue.Text = "Size"
        btnSizeDoubleQueue.UseVisualStyleBackColor = True
        ' 
        ' btnGetFront
        ' 
        btnGetFront.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGetFront.Location = New Point(31, 335)
        btnGetFront.Margin = New Padding(3, 4, 3, 4)
        btnGetFront.Name = "btnGetFront"
        btnGetFront.Size = New Size(158, 56)
        btnGetFront.TabIndex = 34
        btnGetFront.Text = "Get Front"
        btnGetFront.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteFront
        ' 
        btnDeleteFront.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteFront.Location = New Point(31, 245)
        btnDeleteFront.Margin = New Padding(3, 4, 3, 4)
        btnDeleteFront.Name = "btnDeleteFront"
        btnDeleteFront.Size = New Size(158, 56)
        btnDeleteFront.TabIndex = 33
        btnDeleteFront.Text = "Delete Front"
        btnDeleteFront.UseVisualStyleBackColor = True
        ' 
        ' btnInsertFront
        ' 
        btnInsertFront.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertFront.Location = New Point(31, 160)
        btnInsertFront.Margin = New Padding(3, 4, 3, 4)
        btnInsertFront.Name = "btnInsertFront"
        btnInsertFront.Size = New Size(158, 56)
        btnInsertFront.TabIndex = 32
        btnInsertFront.Text = "Insert Front"
        btnInsertFront.UseVisualStyleBackColor = True
        ' 
        ' label12
        ' 
        label12.AutoSize = True
        label12.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label12.Location = New Point(72, 67)
        label12.Name = "label12"
        label12.Size = New Size(86, 29)
        label12.TabIndex = 31
        label12.Text = "Value:"
        ' 
        ' txtQueueDoubleValue
        ' 
        txtQueueDoubleValue.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQueueDoubleValue.Location = New Point(37, 96)
        txtQueueDoubleValue.Margin = New Padding(3, 4, 3, 4)
        txtQueueDoubleValue.Name = "txtQueueDoubleValue"
        txtQueueDoubleValue.Size = New Size(135, 34)
        txtQueueDoubleValue.TabIndex = 30
        ' 
        ' tabPage7
        ' 
        tabPage7.Controls.Add(label21)
        tabPage7.Controls.Add(txtPriorityQueueLevel)
        tabPage7.Controls.Add(btnPriorityQueueSize)
        tabPage7.Controls.Add(btnPeekPriorityQueue)
        tabPage7.Controls.Add(btnDequeuePriorityQueue)
        tabPage7.Controls.Add(btnEnqueuePriorityQueue)
        tabPage7.Controls.Add(label17)
        tabPage7.Controls.Add(lstPriorityQueueLL)
        tabPage7.Controls.Add(label18)
        tabPage7.Controls.Add(lstPriorityQueueLV)
        tabPage7.Controls.Add(label19)
        tabPage7.Controls.Add(lstPriorityQueueVL)
        tabPage7.Controls.Add(label20)
        tabPage7.Controls.Add(lstPriorityQueueVV)
        tabPage7.Controls.Add(label16)
        tabPage7.Controls.Add(txtQueuePriorityValue)
        tabPage7.Location = New Point(4, 29)
        tabPage7.Margin = New Padding(3, 4, 3, 4)
        tabPage7.Name = "tabPage7"
        tabPage7.Padding = New Padding(3, 4, 3, 4)
        tabPage7.Size = New Size(1033, 624)
        tabPage7.TabIndex = 2
        tabPage7.Text = "Priority"
        tabPage7.UseVisualStyleBackColor = True
        ' 
        ' label21
        ' 
        label21.AutoSize = True
        label21.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label21.Location = New Point(73, 176)
        label21.Name = "label21"
        label21.Size = New Size(83, 29)
        label21.TabIndex = 47
        label21.Text = "Level:"
        ' 
        ' txtPriorityQueueLevel
        ' 
        txtPriorityQueueLevel.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPriorityQueueLevel.Location = New Point(38, 205)
        txtPriorityQueueLevel.Margin = New Padding(3, 4, 3, 4)
        txtPriorityQueueLevel.Name = "txtPriorityQueueLevel"
        txtPriorityQueueLevel.Size = New Size(135, 34)
        txtPriorityQueueLevel.TabIndex = 46
        ' 
        ' btnPriorityQueueSize
        ' 
        btnPriorityQueueSize.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPriorityQueueSize.Location = New Point(257, 364)
        btnPriorityQueueSize.Margin = New Padding(3, 4, 3, 4)
        btnPriorityQueueSize.Name = "btnPriorityQueueSize"
        btnPriorityQueueSize.Size = New Size(110, 56)
        btnPriorityQueueSize.TabIndex = 45
        btnPriorityQueueSize.Text = "Size"
        btnPriorityQueueSize.UseVisualStyleBackColor = True
        ' 
        ' btnPeekPriorityQueue
        ' 
        btnPeekPriorityQueue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPeekPriorityQueue.Location = New Point(257, 279)
        btnPeekPriorityQueue.Margin = New Padding(3, 4, 3, 4)
        btnPeekPriorityQueue.Name = "btnPeekPriorityQueue"
        btnPeekPriorityQueue.Size = New Size(110, 56)
        btnPeekPriorityQueue.TabIndex = 44
        btnPeekPriorityQueue.Text = "Peek"
        btnPeekPriorityQueue.UseVisualStyleBackColor = True
        ' 
        ' btnDequeuePriorityQueue
        ' 
        btnDequeuePriorityQueue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDequeuePriorityQueue.Location = New Point(257, 189)
        btnDequeuePriorityQueue.Margin = New Padding(3, 4, 3, 4)
        btnDequeuePriorityQueue.Name = "btnDequeuePriorityQueue"
        btnDequeuePriorityQueue.Size = New Size(110, 56)
        btnDequeuePriorityQueue.TabIndex = 43
        btnDequeuePriorityQueue.Text = "Dequeue"
        btnDequeuePriorityQueue.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueuePriorityQueue
        ' 
        btnEnqueuePriorityQueue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnqueuePriorityQueue.Location = New Point(257, 104)
        btnEnqueuePriorityQueue.Margin = New Padding(3, 4, 3, 4)
        btnEnqueuePriorityQueue.Name = "btnEnqueuePriorityQueue"
        btnEnqueuePriorityQueue.Size = New Size(110, 56)
        btnEnqueuePriorityQueue.TabIndex = 42
        btnEnqueuePriorityQueue.Text = "Enqueue"
        btnEnqueuePriorityQueue.UseVisualStyleBackColor = True
        ' 
        ' label17
        ' 
        label17.AutoSize = True
        label17.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label17.Location = New Point(739, 335)
        label17.Name = "label17"
        label17.Size = New Size(215, 29)
        label17.TabIndex = 41
        label17.Text = "With Lists of Lists"
        ' 
        ' lstPriorityQueueLL
        ' 
        lstPriorityQueueLL.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstPriorityQueueLL.FormattingEnabled = True
        lstPriorityQueueLL.ItemHeight = 29
        lstPriorityQueueLL.Location = New Point(777, 376)
        lstPriorityQueueLL.Margin = New Padding(3, 4, 3, 4)
        lstPriorityQueueLL.Name = "lstPriorityQueueLL"
        lstPriorityQueueLL.Size = New Size(132, 207)
        lstPriorityQueueLL.TabIndex = 40
        ' 
        ' label18
        ' 
        label18.AutoSize = True
        label18.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label18.Location = New Point(446, 335)
        label18.Name = "label18"
        label18.Size = New Size(249, 29)
        label18.TabIndex = 39
        label18.Text = "With Lists of Vectors"
        ' 
        ' lstPriorityQueueLV
        ' 
        lstPriorityQueueLV.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstPriorityQueueLV.FormattingEnabled = True
        lstPriorityQueueLV.ItemHeight = 29
        lstPriorityQueueLV.Location = New Point(495, 376)
        lstPriorityQueueLV.Margin = New Padding(3, 4, 3, 4)
        lstPriorityQueueLV.Name = "lstPriorityQueueLV"
        lstPriorityQueueLV.Size = New Size(132, 207)
        lstPriorityQueueLV.TabIndex = 38
        ' 
        ' label19
        ' 
        label19.AutoSize = True
        label19.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label19.Location = New Point(732, 37)
        label19.Name = "label19"
        label19.Size = New Size(249, 29)
        label19.TabIndex = 37
        label19.Text = "With Vectors of Lists"
        ' 
        ' lstPriorityQueueVL
        ' 
        lstPriorityQueueVL.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstPriorityQueueVL.FormattingEnabled = True
        lstPriorityQueueVL.ItemHeight = 29
        lstPriorityQueueVL.Location = New Point(777, 79)
        lstPriorityQueueVL.Margin = New Padding(3, 4, 3, 4)
        lstPriorityQueueVL.Name = "lstPriorityQueueVL"
        lstPriorityQueueVL.Size = New Size(132, 207)
        lstPriorityQueueVL.TabIndex = 36
        ' 
        ' label20
        ' 
        label20.AutoSize = True
        label20.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        label20.Location = New Point(446, 37)
        label20.Name = "label20"
        label20.Size = New Size(283, 29)
        label20.TabIndex = 35
        label20.Text = "With Vectors of Vectors"
        ' 
        ' lstPriorityQueueVV
        ' 
        lstPriorityQueueVV.Font = New Font("Microsoft Sans Serif", 14.25F)
        lstPriorityQueueVV.FormattingEnabled = True
        lstPriorityQueueVV.ItemHeight = 29
        lstPriorityQueueVV.Location = New Point(495, 79)
        lstPriorityQueueVV.Margin = New Padding(3, 4, 3, 4)
        lstPriorityQueueVV.Name = "lstPriorityQueueVV"
        lstPriorityQueueVV.Size = New Size(132, 207)
        lstPriorityQueueVV.TabIndex = 34
        ' 
        ' label16
        ' 
        label16.AutoSize = True
        label16.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label16.Location = New Point(73, 49)
        label16.Name = "label16"
        label16.Size = New Size(86, 29)
        label16.TabIndex = 33
        label16.Text = "Value:"
        ' 
        ' txtQueuePriorityValue
        ' 
        txtQueuePriorityValue.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQueuePriorityValue.Location = New Point(38, 79)
        txtQueuePriorityValue.Margin = New Padding(3, 4, 3, 4)
        txtQueuePriorityValue.Name = "txtQueuePriorityValue"
        txtQueuePriorityValue.Size = New Size(135, 34)
        txtQueuePriorityValue.TabIndex = 32
        ' 
        ' tabPage3
        ' 
        tabPage3.Controls.Add(label30)
        tabPage3.Controls.Add(txtOutput)
        tabPage3.Controls.Add(btnSearch)
        tabPage3.Controls.Add(btnClear)
        tabPage3.Controls.Add(btnInOrder)
        tabPage3.Controls.Add(btnDelete)
        tabPage3.Controls.Add(btnPostOrder)
        tabPage3.Controls.Add(btnPreOrder)
        tabPage3.Controls.Add(btnInsertNode)
        tabPage3.Controls.Add(txtNodeValue)
        tabPage3.Controls.Add(panelTree)
        tabPage3.Location = New Point(4, 29)
        tabPage3.Margin = New Padding(3, 4, 3, 4)
        tabPage3.Name = "tabPage3"
        tabPage3.Padding = New Padding(3, 4, 3, 4)
        tabPage3.Size = New Size(1076, 660)
        tabPage3.TabIndex = 3
        tabPage3.Text = "Binary Tree"
        tabPage3.UseVisualStyleBackColor = True
        ' 
        ' tabPage4
        ' 
        tabPage4.Controls.Add(label29)
        tabPage4.Controls.Add(label28)
        tabPage4.Controls.Add(label27)
        tabPage4.Controls.Add(label26)
        tabPage4.Controls.Add(label25)
        tabPage4.Controls.Add(label24)
        tabPage4.Controls.Add(label22)
        tabPage4.Controls.Add(label23)
        tabPage4.Controls.Add(btnRemoveAll)
        tabPage4.Controls.Add(btnShowDFSRecursive)
        tabPage4.Controls.Add(btnShowBFS)
        tabPage4.Controls.Add(btnRemoveNode)
        tabPage4.Controls.Add(txtStartNode)
        tabPage4.Controls.Add(btnShowDFS)
        tabPage4.Controls.Add(chkDirected)
        tabPage4.Controls.Add(txtWeight)
        tabPage4.Controls.Add(txtGraphRepresentation)
        tabPage4.Controls.Add(btnRemoveEdge)
        tabPage4.Controls.Add(btnAddEdge)
        tabPage4.Controls.Add(txtTo)
        tabPage4.Controls.Add(txtFrom)
        tabPage4.Controls.Add(txtNode)
        tabPage4.Controls.Add(btnAddNode)
        tabPage4.Location = New Point(4, 29)
        tabPage4.Margin = New Padding(3, 4, 3, 4)
        tabPage4.Name = "tabPage4"
        tabPage4.Padding = New Padding(3, 4, 3, 4)
        tabPage4.Size = New Size(1076, 660)
        tabPage4.TabIndex = 4
        tabPage4.Text = "Graphs"
        tabPage4.UseVisualStyleBackColor = True
        ' 
        ' label29
        ' 
        label29.AutoSize = True
        label29.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold)
        label29.Location = New Point(171, 469)
        label29.Name = "label29"
        label29.Size = New Size(141, 29)
        label29.TabIndex = 32
        label29.Text = "Traversals"
        ' 
        ' label28
        ' 
        label28.AutoSize = True
        label28.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold)
        label28.Location = New Point(187, 199)
        label28.Name = "label28"
        label28.Size = New Size(90, 29)
        label28.TabIndex = 31
        label28.Text = "Edges"
        ' 
        ' label27
        ' 
        label27.AutoSize = True
        label27.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold)
        label27.Location = New Point(198, 28)
        label27.Name = "label27"
        label27.Size = New Size(91, 29)
        label27.TabIndex = 30
        label27.Text = "Nodes"
        ' 
        ' label26
        ' 
        label26.AutoSize = True
        label26.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label26.Location = New Point(97, 521)
        label26.Name = "label26"
        label26.Size = New Size(122, 25)
        label26.TabIndex = 29
        label26.Text = "Node Start:"
        ' 
        ' label25
        ' 
        label25.AutoSize = True
        label25.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label25.Location = New Point(94, 347)
        label25.Name = "label25"
        label25.Size = New Size(87, 25)
        label25.TabIndex = 28
        label25.Text = "Weight:"
        ' 
        ' label24
        ' 
        label24.AutoSize = True
        label24.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label24.Location = New Point(80, 301)
        label24.Name = "label24"
        label24.Size = New Size(102, 25)
        label24.TabIndex = 27
        label24.Text = "Node To:"
        ' 
        ' label22
        ' 
        label22.AutoSize = True
        label22.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label22.Location = New Point(57, 251)
        label22.Name = "label22"
        label22.Size = New Size(125, 25)
        label22.TabIndex = 26
        label22.Text = "Node From:"
        ' 
        ' label23
        ' 
        label23.AutoSize = True
        label23.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label23.Location = New Point(59, 77)
        label23.Name = "label23"
        label23.Size = New Size(132, 25)
        label23.TabIndex = 25
        label23.Text = "Node Name:"
        ' 
        ' btnRemoveAll
        ' 
        btnRemoveAll.Location = New Point(585, 55)
        btnRemoveAll.Margin = New Padding(3, 4, 3, 4)
        btnRemoveAll.Name = "btnRemoveAll"
        btnRemoveAll.Size = New Size(96, 31)
        btnRemoveAll.TabIndex = 24
        btnRemoveAll.Text = "Remove All"
        btnRemoveAll.UseVisualStyleBackColor = True
        ' 
        ' btnShowDFSRecursive
        ' 
        btnShowDFSRecursive.Location = New Point(275, 553)
        btnShowDFSRecursive.Margin = New Padding(3, 4, 3, 4)
        btnShowDFSRecursive.Name = "btnShowDFSRecursive"
        btnShowDFSRecursive.Size = New Size(86, 52)
        btnShowDFSRecursive.TabIndex = 23
        btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm"
        btnShowDFSRecursive.UseVisualStyleBackColor = True
        ' 
        ' btnShowBFS
        ' 
        btnShowBFS.Location = New Point(90, 553)
        btnShowBFS.Margin = New Padding(3, 4, 3, 4)
        btnShowBFS.Name = "btnShowBFS"
        btnShowBFS.Size = New Size(86, 52)
        btnShowBFS.TabIndex = 21
        btnShowBFS.Text = "Show BFS Algorithm"
        btnShowBFS.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveNode
        ' 
        btnRemoveNode.Location = New Point(304, 117)
        btnRemoveNode.Margin = New Padding(3, 4, 3, 4)
        btnRemoveNode.Name = "btnRemoveNode"
        btnRemoveNode.Size = New Size(86, 31)
        btnRemoveNode.TabIndex = 20
        btnRemoveNode.Text = "Remove"
        btnRemoveNode.UseVisualStyleBackColor = True
        ' 
        ' txtStartNode
        ' 
        txtStartNode.Location = New Point(209, 515)
        txtStartNode.Margin = New Padding(3, 4, 3, 4)
        txtStartNode.Name = "txtStartNode"
        txtStartNode.Size = New Size(118, 27)
        txtStartNode.TabIndex = 17
        ' 
        ' btnShowDFS
        ' 
        btnShowDFS.Location = New Point(183, 553)
        btnShowDFS.Margin = New Padding(3, 4, 3, 4)
        btnShowDFS.Name = "btnShowDFS"
        btnShowDFS.Size = New Size(86, 52)
        btnShowDFS.TabIndex = 16
        btnShowDFS.Text = "Show DFS Algorithm"
        btnShowDFS.UseVisualStyleBackColor = True
        ' 
        ' chkDirected
        ' 
        chkDirected.AutoSize = True
        chkDirected.Location = New Point(177, 385)
        chkDirected.Margin = New Padding(3, 4, 3, 4)
        chkDirected.Name = "chkDirected"
        chkDirected.Size = New Size(88, 24)
        chkDirected.TabIndex = 15
        chkDirected.Text = "Directed"
        chkDirected.UseVisualStyleBackColor = True
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(174, 343)
        txtWeight.Margin = New Padding(3, 4, 3, 4)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(118, 27)
        txtWeight.TabIndex = 13
        ' 
        ' txtGraphRepresentation
        ' 
        txtGraphRepresentation.Font = New Font("Yu Gothic Medium", 11F)
        txtGraphRepresentation.Location = New Point(585, 93)
        txtGraphRepresentation.Margin = New Padding(3, 4, 3, 4)
        txtGraphRepresentation.Multiline = True
        txtGraphRepresentation.Name = "txtGraphRepresentation"
        txtGraphRepresentation.Size = New Size(413, 268)
        txtGraphRepresentation.TabIndex = 12
        ' 
        ' btnRemoveEdge
        ' 
        btnRemoveEdge.Location = New Point(330, 297)
        btnRemoveEdge.Margin = New Padding(3, 4, 3, 4)
        btnRemoveEdge.Name = "btnRemoveEdge"
        btnRemoveEdge.Size = New Size(86, 52)
        btnRemoveEdge.TabIndex = 9
        btnRemoveEdge.Text = "Remove Edge"
        btnRemoveEdge.UseVisualStyleBackColor = True
        ' 
        ' btnAddEdge
        ' 
        btnAddEdge.Location = New Point(330, 247)
        btnAddEdge.Margin = New Padding(3, 4, 3, 4)
        btnAddEdge.Name = "btnAddEdge"
        btnAddEdge.Size = New Size(86, 31)
        btnAddEdge.TabIndex = 8
        btnAddEdge.Text = "Add Edge"
        btnAddEdge.UseVisualStyleBackColor = True
        ' 
        ' txtTo
        ' 
        txtTo.Location = New Point(174, 297)
        txtTo.Margin = New Padding(3, 4, 3, 4)
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(118, 27)
        txtTo.TabIndex = 6
        ' 
        ' txtFrom
        ' 
        txtFrom.Location = New Point(174, 247)
        txtFrom.Margin = New Padding(3, 4, 3, 4)
        txtFrom.Name = "txtFrom"
        txtFrom.Size = New Size(118, 27)
        txtFrom.TabIndex = 4
        ' 
        ' txtNode
        ' 
        txtNode.Location = New Point(184, 73)
        txtNode.Margin = New Padding(3, 4, 3, 4)
        txtNode.Name = "txtNode"
        txtNode.Size = New Size(205, 27)
        txtNode.TabIndex = 2
        ' 
        ' btnAddNode
        ' 
        btnAddNode.Location = New Point(195, 117)
        btnAddNode.Margin = New Padding(3, 4, 3, 4)
        btnAddNode.Name = "btnAddNode"
        btnAddNode.Size = New Size(86, 31)
        btnAddNode.TabIndex = 1
        btnAddNode.Text = "Add Node"
        btnAddNode.UseVisualStyleBackColor = True
        ' 
        ' tabPage8
        ' 
        tabPage8.Controls.Add(lstNumbersSort)
        tabPage8.Controls.Add(cmbAlgoritms)
        tabPage8.Controls.Add(btnSort)
        tabPage8.Controls.Add(btnSetNumbers)
        tabPage8.Location = New Point(4, 29)
        tabPage8.Margin = New Padding(3, 4, 3, 4)
        tabPage8.Name = "tabPage8"
        tabPage8.Padding = New Padding(3, 4, 3, 4)
        tabPage8.Size = New Size(1076, 660)
        tabPage8.TabIndex = 5
        tabPage8.Text = "Sorting Algorithms"
        tabPage8.UseVisualStyleBackColor = True
        ' 
        ' lstNumbersSort
        ' 
        lstNumbersSort.Font = New Font("Segoe UI", 14F)
        lstNumbersSort.FormattingEnabled = True
        lstNumbersSort.ItemHeight = 31
        lstNumbersSort.Location = New Point(27, 129)
        lstNumbersSort.Margin = New Padding(3, 4, 3, 4)
        lstNumbersSort.Name = "lstNumbersSort"
        lstNumbersSort.Size = New Size(149, 469)
        lstNumbersSort.TabIndex = 26
        ' 
        ' cmbAlgoritms
        ' 
        cmbAlgoritms.FormattingEnabled = True
        cmbAlgoritms.Location = New Point(27, 43)
        cmbAlgoritms.Margin = New Padding(3, 4, 3, 4)
        cmbAlgoritms.Name = "cmbAlgoritms"
        cmbAlgoritms.Size = New Size(205, 28)
        cmbAlgoritms.TabIndex = 25
        ' 
        ' btnSort
        ' 
        btnSort.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSort.Location = New Point(513, 27)
        btnSort.Margin = New Padding(3, 4, 3, 4)
        btnSort.Name = "btnSort"
        btnSort.Size = New Size(206, 56)
        btnSort.TabIndex = 24
        btnSort.Text = "Sort"
        btnSort.UseVisualStyleBackColor = True
        ' 
        ' btnSetNumbers
        ' 
        btnSetNumbers.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSetNumbers.Location = New Point(297, 27)
        btnSetNumbers.Margin = New Padding(3, 4, 3, 4)
        btnSetNumbers.Name = "btnSetNumbers"
        btnSetNumbers.Size = New Size(195, 56)
        btnSetNumbers.TabIndex = 23
        btnSetNumbers.Text = "Generate Numbers"
        btnSetNumbers.UseVisualStyleBackColor = True
        ' 
        ' label30
        ' 
        label30.AutoSize = True
        label30.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label30.Location = New Point(171, 51)
        label30.Name = "label30"
        label30.Size = New Size(157, 29)
        label30.TabIndex = 62
        label30.Text = "Node Value:"
        ' 
        ' txtOutput
        ' 
        txtOutput.Font = New Font("Segoe UI", 14F)
        txtOutput.Location = New Point(35, 357)
        txtOutput.Margin = New Padding(3, 4, 3, 4)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(435, 51)
        txtOutput.TabIndex = 61
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(315, 137)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(95, 56)
        btnSearch.TabIndex = 60
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(152, 578)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(158, 56)
        btnClear.TabIndex = 59
        btnClear.Text = "Clear Tree"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnInOrder
        ' 
        btnInOrder.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInOrder.Location = New Point(328, 281)
        btnInOrder.Margin = New Padding(3, 4, 3, 4)
        btnInOrder.Name = "btnInOrder"
        btnInOrder.Size = New Size(123, 56)
        btnInOrder.TabIndex = 58
        btnInOrder.Text = "In Order"
        btnInOrder.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(192, 137)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(95, 56)
        btnDelete.TabIndex = 57
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnPostOrder
        ' 
        btnPostOrder.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPostOrder.Location = New Point(186, 281)
        btnPostOrder.Margin = New Padding(3, 4, 3, 4)
        btnPostOrder.Name = "btnPostOrder"
        btnPostOrder.Size = New Size(123, 56)
        btnPostOrder.TabIndex = 56
        btnPostOrder.Text = "Post Order"
        btnPostOrder.UseVisualStyleBackColor = True
        ' 
        ' btnPreOrder
        ' 
        btnPreOrder.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPreOrder.Location = New Point(45, 281)
        btnPreOrder.Margin = New Padding(3, 4, 3, 4)
        btnPreOrder.Name = "btnPreOrder"
        btnPreOrder.Size = New Size(123, 56)
        btnPreOrder.TabIndex = 55
        btnPreOrder.Text = "Pre Order"
        btnPreOrder.UseVisualStyleBackColor = True
        ' 
        ' btnInsertNode
        ' 
        btnInsertNode.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertNode.Location = New Point(69, 137)
        btnInsertNode.Margin = New Padding(3, 4, 3, 4)
        btnInsertNode.Name = "btnInsertNode"
        btnInsertNode.Size = New Size(95, 56)
        btnInsertNode.TabIndex = 54
        btnInsertNode.Text = "Insert"
        btnInsertNode.UseVisualStyleBackColor = True
        ' 
        ' txtNodeValue
        ' 
        txtNodeValue.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNodeValue.Location = New Point(171, 89)
        txtNodeValue.Margin = New Padding(3, 4, 3, 4)
        txtNodeValue.Name = "txtNodeValue"
        txtNodeValue.Size = New Size(135, 34)
        txtNodeValue.TabIndex = 53
        ' 
        ' panelTree
        ' 
        panelTree.Location = New Point(478, 26)
        panelTree.Margin = New Padding(3, 4, 3, 4)
        panelTree.Name = "panelTree"
        panelTree.Size = New Size(563, 559)
        panelTree.TabIndex = 52
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 708)
        Controls.Add(tabControl1)
        Name = "Form1"
        Text = "Form1"
        tabControl1.ResumeLayout(False)
        Lists.ResumeLayout(False)
        Lists.PerformLayout()
        tabPage2.ResumeLayout(False)
        tabPage2.PerformLayout()
        tabPage1.ResumeLayout(False)
        tabControl2.ResumeLayout(False)
        tabPage5.ResumeLayout(False)
        tabPage5.PerformLayout()
        tabPage6.ResumeLayout(False)
        tabPage6.PerformLayout()
        tabPage7.ResumeLayout(False)
        tabPage7.PerformLayout()
        tabPage3.ResumeLayout(False)
        tabPage3.PerformLayout()
        tabPage4.ResumeLayout(False)
        tabPage4.PerformLayout()
        tabPage8.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents Lists As TabPage
    Private WithEvents btnCount As Button
    Private WithEvents btnContains As Button
    Private WithEvents btnRemove As Button
    Private WithEvents btnAdd As Button
    Private WithEvents label5 As Label
    Private WithEvents txtValue As TextBox
    Private WithEvents label3 As Label
    Private WithEvents lstDoubleCircularList As ListBox
    Private WithEvents label4 As Label
    Private WithEvents lstCircularList As ListBox
    Private WithEvents label2 As Label
    Private WithEvents lstDoubleList As ListBox
    Private WithEvents label1 As Label
    Private WithEvents lstSimpleLinkedList As ListBox
    Private WithEvents tabPage2 As TabPage
    Private WithEvents btnSize As Button
    Private WithEvents btnPeek As Button
    Private WithEvents btnPop As Button
    Private WithEvents btnPush As Button
    Private WithEvents label8 As Label
    Private WithEvents txtStackValue As TextBox
    Private WithEvents label7 As Label
    Private WithEvents lstDynamicStack As ListBox
    Private WithEvents label6 As Label
    Private WithEvents lstStaticStack As ListBox
    Private WithEvents tabPage1 As TabPage
    Private WithEvents tabControl2 As TabControl
    Private WithEvents tabPage5 As TabPage
    Private WithEvents label14 As Label
    Private WithEvents lstCircularQueue As ListBox
    Private WithEvents btnSizeQueue As Button
    Private WithEvents btnPeekQueue As Button
    Private WithEvents btnDequeue As Button
    Private WithEvents btnEnqueue As Button
    Private WithEvents label9 As Label
    Private WithEvents txtValueSimpleQueue As TextBox
    Private WithEvents label10 As Label
    Private WithEvents lstDynamicQueue As ListBox
    Private WithEvents label11 As Label
    Private WithEvents lstStaticQueue As ListBox
    Private WithEvents tabPage6 As TabPage
    Private WithEvents btnGetRear As Button
    Private WithEvents btnDeleteRear As Button
    Private WithEvents btnInsertRear As Button
    Private WithEvents label13 As Label
    Private WithEvents lstQueueDoubleList As ListBox
    Private WithEvents label15 As Label
    Private WithEvents lstQueueDobleVector As ListBox
    Private WithEvents btnSizeDoubleQueue As Button
    Private WithEvents btnGetFront As Button
    Private WithEvents btnDeleteFront As Button
    Private WithEvents btnInsertFront As Button
    Private WithEvents label12 As Label
    Private WithEvents txtQueueDoubleValue As TextBox
    Private WithEvents tabPage7 As TabPage
    Private WithEvents label21 As Label
    Private WithEvents txtPriorityQueueLevel As TextBox
    Private WithEvents btnPriorityQueueSize As Button
    Private WithEvents btnPeekPriorityQueue As Button
    Private WithEvents btnDequeuePriorityQueue As Button
    Private WithEvents btnEnqueuePriorityQueue As Button
    Private WithEvents label17 As Label
    Private WithEvents lstPriorityQueueLL As ListBox
    Private WithEvents label18 As Label
    Private WithEvents lstPriorityQueueLV As ListBox
    Private WithEvents label19 As Label
    Private WithEvents lstPriorityQueueVL As ListBox
    Private WithEvents label20 As Label
    Private WithEvents lstPriorityQueueVV As ListBox
    Private WithEvents label16 As Label
    Private WithEvents txtQueuePriorityValue As TextBox
    Private WithEvents tabPage3 As TabPage
    Private WithEvents tabPage4 As TabPage
    Private WithEvents label29 As Label
    Private WithEvents label28 As Label
    Private WithEvents label27 As Label
    Private WithEvents label26 As Label
    Private WithEvents label25 As Label
    Private WithEvents label24 As Label
    Private WithEvents label22 As Label
    Private WithEvents label23 As Label
    Private WithEvents btnRemoveAll As Button
    Private WithEvents btnShowDFSRecursive As Button
    Private WithEvents btnShowBFS As Button
    Private WithEvents btnRemoveNode As Button
    Private WithEvents txtStartNode As TextBox
    Private WithEvents btnShowDFS As Button
    Private WithEvents chkDirected As CheckBox
    Private WithEvents txtWeight As TextBox
    Private WithEvents txtGraphRepresentation As TextBox
    Private WithEvents btnRemoveEdge As Button
    Private WithEvents btnAddEdge As Button
    Private WithEvents txtTo As TextBox
    Private WithEvents txtFrom As TextBox
    Private WithEvents txtNode As TextBox
    Private WithEvents btnAddNode As Button
    Private WithEvents tabPage8 As TabPage
    Private WithEvents lstNumbersSort As ListBox
    Private WithEvents cmbAlgoritms As ComboBox
    Private WithEvents btnSort As Button
    Private WithEvents btnSetNumbers As Button
    Private WithEvents label30 As Label
    Private WithEvents txtOutput As TextBox
    Private WithEvents btnSearch As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnInOrder As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnPostOrder As Button
    Private WithEvents btnPreOrder As Button
    Private WithEvents btnInsertNode As Button
    Private WithEvents txtNodeValue As TextBox
    Private WithEvents panelTree As Panel

End Class


Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents drawArea2 As KitchenArt.DrawArea
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents stb_MainStb As System.Windows.Forms.StatusBar
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents AddDoor As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents btnAddStove As System.Windows.Forms.Button
    Friend WithEvents btnAddFridge As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents nmuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.drawArea2 = New KitchenArt.DrawArea
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.stb_MainStb = New System.Windows.Forms.StatusBar
        Me.pnlControl = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAddFridge = New System.Windows.Forms.Button
        Me.btnAddStove = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.AddDoor = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.mnuMain = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.nmuOpen = New System.Windows.Forms.MenuItem
        Me.mnuSave = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.sfd = New System.Windows.Forms.SaveFileDialog
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.pnlControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'drawArea2
        '
        Me.drawArea2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drawArea2.BackColor = System.Drawing.Color.White
        Me.drawArea2.gridCellSize = 10
        Me.drawArea2.Location = New System.Drawing.Point(144, 16)
        Me.drawArea2.metricCellSize = 5
        Me.drawArea2.Name = "drawArea2"
        Me.drawArea2.showCross = True
        Me.drawArea2.Size = New System.Drawing.Size(608, 480)
        Me.drawArea2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(24, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Zoom In"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(24, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Zoom Out"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(24, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Rotate"
        Me.ToolTip1.SetToolTip(Me.Button4, "Rotate selected item")
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(8, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "ADD SINK"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(8, 248)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "ADD CABINET"
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(8, 424)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "X"
        Me.ToolTip1.SetToolTip(Me.Button7, "Delete selected item")
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(8, 72)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 23)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "ADD WINDOW"
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(8, 280)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "ADD WASHER"
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(24, 456)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(88, 23)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.Button10, "Exit application")
        '
        'stb_MainStb
        '
        Me.stb_MainStb.Location = New System.Drawing.Point(0, 504)
        Me.stb_MainStb.Name = "stb_MainStb"
        Me.stb_MainStb.Size = New System.Drawing.Size(872, 22)
        Me.stb_MainStb.TabIndex = 11
        '
        'pnlControl
        '
        Me.pnlControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControl.Controls.Add(Me.Label3)
        Me.pnlControl.Controls.Add(Me.Label2)
        Me.pnlControl.Controls.Add(Me.Label1)
        Me.pnlControl.Controls.Add(Me.btnAddFridge)
        Me.pnlControl.Controls.Add(Me.btnAddStove)
        Me.pnlControl.Controls.Add(Me.Button8)
        Me.pnlControl.Controls.Add(Me.Button9)
        Me.pnlControl.Controls.Add(Me.Button19)
        Me.pnlControl.Controls.Add(Me.AddDoor)
        Me.pnlControl.Controls.Add(Me.Button18)
        Me.pnlControl.Controls.Add(Me.Button5)
        Me.pnlControl.Controls.Add(Me.Button6)
        Me.pnlControl.Controls.Add(Me.Button7)
        Me.pnlControl.Location = New System.Drawing.Point(752, 24)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(112, 472)
        Me.pnlControl.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Remove selected:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Kitchen items:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Outline items:"
        '
        'btnAddFridge
        '
        Me.btnAddFridge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddFridge.Location = New System.Drawing.Point(8, 344)
        Me.btnAddFridge.Name = "btnAddFridge"
        Me.btnAddFridge.Size = New System.Drawing.Size(96, 23)
        Me.btnAddFridge.TabIndex = 20
        Me.btnAddFridge.Text = "ADD FRIDGE"
        '
        'btnAddStove
        '
        Me.btnAddStove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddStove.Location = New System.Drawing.Point(8, 312)
        Me.btnAddStove.Name = "btnAddStove"
        Me.btnAddStove.Size = New System.Drawing.Size(96, 23)
        Me.btnAddStove.TabIndex = 19
        Me.btnAddStove.Text = "ADD SVOVE"
        '
        'Button19
        '
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button19.Location = New System.Drawing.Point(8, 152)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(96, 23)
        Me.Button19.TabIndex = 18
        Me.Button19.Text = "ADD CHAIR"
        '
        'AddDoor
        '
        Me.AddDoor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddDoor.Location = New System.Drawing.Point(8, 40)
        Me.AddDoor.Name = "AddDoor"
        Me.AddDoor.Size = New System.Drawing.Size(96, 23)
        Me.AddDoor.TabIndex = 4
        Me.AddDoor.Text = "ADD DOOR"
        '
        'Button18
        '
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button18.Location = New System.Drawing.Point(8, 184)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(96, 23)
        Me.Button18.TabIndex = 17
        Me.Button18.Text = "ADD TABLE"
        '
        'Button16
        '
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button16.Location = New System.Drawing.Point(24, 376)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(88, 23)
        Me.Button16.TabIndex = 18
        Me.Button16.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.Button16, "Save kitchen")
        '
        'Button15
        '
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Location = New System.Drawing.Point(24, 408)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(88, 23)
        Me.Button15.TabIndex = 17
        Me.Button15.Text = "Open"
        Me.ToolTip1.SetToolTip(Me.Button15, "Load kitchen")
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.nmuOpen, Me.mnuSave, Me.MenuItem2})
        Me.MenuItem1.Text = "&File"
        '
        'nmuOpen
        '
        Me.nmuOpen.Index = 0
        Me.nmuOpen.Text = "&Open"
        '
        'mnuSave
        '
        Me.mnuSave.Index = 1
        Me.mnuSave.Text = "&Save"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "E&xit                     "
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        Me.MenuItem3.Text = "&Help"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "&About"
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Location = New System.Drawing.Point(16, 144)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(32, 23)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "<-"
        Me.ToolTip1.SetToolTip(Me.Button11, "Move left")
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Location = New System.Drawing.Point(96, 144)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(32, 23)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "->"
        Me.ToolTip1.SetToolTip(Me.Button12, "Move right")
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Location = New System.Drawing.Point(56, 128)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 23)
        Me.Button13.TabIndex = 15
        Me.Button13.Text = "/\"
        Me.ToolTip1.SetToolTip(Me.Button13, "Move up")
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Location = New System.Drawing.Point(56, 160)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(32, 23)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "\/"
        Me.ToolTip1.SetToolTip(Me.Button14, "Move down")
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(24, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Resize"
        Me.ToolTip1.SetToolTip(Me.Button3, "Resize selected item")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Grid controls:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Item controls:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Kitchen controls:"
        '
        'sfd
        '
        Me.sfd.Filter = "KitchenArt Files (*.ksv)|*.ksv"
        '
        'ofd
        '
        Me.ofd.Filter = "KitchenArt Files (*.ksv)|*.ksv"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(872, 526)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.stb_MainStb)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.drawArea2)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button10)
        Me.Menu = Me.mnuMain
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "Form1"
        Me.Text = "Kitchen Art 2006"
        Me.pnlControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_gr As Graphics

    Private kitchen As KitchenArt.Kitchen

    Private mousePressed, newItemAdded As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        drawArea2.metricCellSize = 10
        drawArea2.gridCellSize = 10

        kitchen = kitchen.Instance()

        kitchen.ApplyNewMectrics(drawArea2.gridCellSize, drawArea2.metricCellSize)
        kitchen.Outline.MetricWallWidth = 10

        'kitchen.Outline.metricX = 70
        'kitchen.Outline.metricY = 70
        kitchen.Outline.SetCoords(70, 70)
        kitchen.Outline.metricLength = 500
        kitchen.Outline.metricWidth = 300


        drawArea2.sbHsb.Maximum = 50 * kitchen.Outline.pixLength / drawArea2.gridCellSize
        drawArea2.sbHsb.SmallChange = drawArea2.gridCellSize * 10
        drawArea2.sbVsb.Maximum = 50 * kitchen.Outline.pixWidth / drawArea2.gridCellSize
        drawArea2.sbVsb.SmallChange = drawArea2.gridCellSize * 10

        mousePressed = False
        newItemAdded = False
    End Sub

    Private Sub DrawArea1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles drawArea2.Paint

        m_gr = drawArea2.graph
        kitchen.Draw(m_gr)

    End Sub

#Region "Mouse events"

    Private Sub DrawArea1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles drawArea2.MouseMove

        Dim selectedItem As KitchenItem
        selectedItem = kitchen.GetSelectedItem()

        kitchen.Items.SetDefaultPenToAllItems()
        kitchen.Outline.OutlineItems.SetDefaultPenToAllItems()
        kitchen.InvalidateAllInCollision()
        If Not selectedItem Is Nothing Then

            Dim oldX As Integer = selectedItem.metricX
            Dim oldY As Integer = selectedItem.metricY
            Dim oldItem As KitchenItem = selectedItem

            'move it
            If mousePressed = True Or newItemAdded = True Then
                Dim curX As Integer = drawArea2.allignXtoGrid(e.X, selectedItem.pixLength)
                Dim curY As Integer = drawArea2.allignYtoGrid(e.Y, selectedItem.pixWidth)

                selectedItem.metricX = selectedItem.pixToMetric(curX)
                selectedItem.metricY = selectedItem.pixToMetric(curY)
            End If

            'check for collision
            If kitchen.IsInCollision(selectedItem) = True Then
                selectedItem.Pen = selectedItem.InvalidPen  'New Pen(Color.Red, 1)
            Else
                'as it's a selected item, hilight it!
                selectedItem.Pen = selectedItem.HighlitedPen
            End If

            'invalidate only if mouse moved with regards to grid cells
            If oldX <> selectedItem.metricX Or _
                oldY <> selectedItem.metricY Then drawArea2.Invalidate()

        Else 'nothing is selected - check for mouse over items
        End If

        'is mouse over any item in kitchen?
        Dim highlitedItem As KitchenItem = kitchen.Items.HighlitedItem(e.X, e.Y)
        If Not highlitedItem Is Nothing And Not highlitedItem Is selectedItem Then _
            highlitedItem.Pen = highlitedItem.HighlitedPen

        'is mouse over any item in the outline?
        highlitedItem = kitchen.Outline.OutlineItems.HighlitedItem(e.X, e.Y)
        If Not highlitedItem Is Nothing And Not highlitedItem Is selectedItem Then _
            highlitedItem.Pen = highlitedItem.HighlitedPen

        'is mouse over outline?
        If kitchen.Outline.IsMouseOverRect(e.X, e.Y) = True Then
            kitchen.Outline.Pen = kitchen.Outline.HighlitedPen
            kitchen.Outline.ShowMetrics = True
        Else
            kitchen.Outline.Pen = kitchen.Outline.DefaultPen
            kitchen.Outline.ShowMetrics = False
        End If
        drawArea2.Invalidate()


    End Sub


    Private Sub drawArea2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles drawArea2.MouseDown
        Dim highlitedItem As KitchenItem = kitchen.GetHighlitedItem(e.X, e.Y)
        Dim selectedItem As KitchenItem = kitchen.GetSelectedItem()

        If e.Button = MouseButtons.Left Then
            kitchen.DisselectAllItems()
            'select highlited
            If Not highlitedItem Is Nothing Then
                highlitedItem.IsSelected = True
                'MsgBox(highlitedItem.metricX & "-" & highlitedItem.OutlineX)
                'selectedItem.Pen = selectedItem.HighlitedPen
            End If
        Else
            'get newly selected item to rotate on right click
            selectedItem = kitchen.GetSelectedItem()
            If Not selectedItem Is Nothing And e.Button = MouseButtons.Right Then
                selectedItem.Rotate()
            End If
        End If
        kitchen.InvalidateAllInCollision()
        mousePressed = True
        drawArea2.Invalidate()
    End Sub

    Private Sub drawArea2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles drawArea2.MouseUp

        Dim highlitedItem As KitchenItem = kitchen.GetHighlitedItem(e.X, e.Y)
        Dim selectedItem As KitchenItem = kitchen.GetSelectedItem()
        If Not selectedItem Is Nothing And Not highlitedItem Is selectedItem Then
            selectedItem.IsSelected = False
        End If
        kitchen.InvalidateAllInCollision()
        mousePressed = False
        newItemAdded = False
        drawArea2.Invalidate()
    End Sub

    Private Sub drawArea2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles drawArea2.MouseLeave
        drawArea2.showCross = False
        drawArea2.Invalidate()
    End Sub

    Private Sub drawArea2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles drawArea2.MouseEnter
        drawArea2.showCross = True
        drawArea2.Invalidate()
    End Sub
    Private Sub drawArea2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles drawArea2.DoubleClick, Button3.Click
        Dim item As KitchenItem = kitchen.GetSelectedItem()
        If Not item Is Nothing Then
            Dim dlg As New ResizeForm
            dlg.txtHeight.Text = item.metricWidth
            dlg.txtWidth.Text = item.metricLength
            If dlg.ShowDialog() = DialogResult.OK Then
                Try
                    item.metricWidth = CType(dlg.txtHeight.Text, Integer)
                    item.metricLength = CType(dlg.txtWidth.Text, Integer)
                Catch ex As Exception
                    MsgBox("Invalid measurements entered", MsgBoxStyle.Information)
                End Try
            End If
        End If

    End Sub
#End Region

#Region "Interface controls: zoom, rotate, remove..."

    Private Sub ZoomIn(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        drawArea2.gridCellSize += 1
        kitchen.ApplyNewMectrics(drawArea2.gridCellSize, drawArea2.metricCellSize)

        drawArea2.sbHsb.Maximum = 50 * kitchen.Outline.pixLength / drawArea2.gridCellSize
        drawArea2.sbHsb.SmallChange = drawArea2.gridCellSize * 10
        drawArea2.sbVsb.Maximum = 50 * kitchen.Outline.pixWidth / drawArea2.gridCellSize
        drawArea2.sbVsb.SmallChange = drawArea2.gridCellSize * 10

        drawArea2.Invalidate()
    End Sub

    Private Sub ZoomOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        drawArea2.gridCellSize -= 1
        kitchen.ApplyNewMectrics(drawArea2.gridCellSize, drawArea2.metricCellSize)

        drawArea2.sbHsb.Maximum = 50 * kitchen.Outline.pixLength / drawArea2.gridCellSize
        drawArea2.sbHsb.SmallChange = drawArea2.gridCellSize * 10
        drawArea2.sbVsb.Maximum = 50 * kitchen.Outline.pixWidth / drawArea2.gridCellSize
        drawArea2.sbVsb.SmallChange = drawArea2.gridCellSize * 10

        drawArea2.Invalidate()
    End Sub

    'Private Sub ShowHideCross_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If drawArea2.showCross = True Then
    '        drawArea2.showCross = False
    '        Button3.Text = "Show Cross"
    '    Else
    '        drawArea2.showCross = True
    '        Button3.Text = "Hide Cross"
    '    End If
    '    drawArea2.Invalidate()
    'End Sub

    Private Sub Rotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim selectedItem As KitchenItem = kitchen.GetSelectedItem()

        If Not selectedItem Is Nothing Then
            selectedItem.Rotate()
            'check for collision
            If kitchen.IsInCollision(selectedItem) = True Then
                selectedItem.Pen = selectedItem.InvalidPen  'New Pen(Color.Red, 1)
            Else
                selectedItem.Pen = selectedItem.HighlitedPen
            End If
        End If

        drawArea2.Invalidate()
    End Sub

    Private Sub RemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Not kitchen.Items.SelectedItem Is Nothing Then
            kitchen.Items.Remove(kitchen.Items.SelectedItem)
        ElseIf Not kitchen.Outline.OutlineItems.SelectedItem Is Nothing Then
            kitchen.Outline.OutlineItems.Remove(kitchen.Outline.OutlineItems.SelectedItem)

        End If
        drawArea2.Invalidate()
    End Sub

    Private Sub Vbs_Scroll(ByVal deltaY As Integer) Handles drawArea2.VsbScroll
        kitchen.Outline.ChangeCoordsBy(0, deltaY)
        drawArea2.Invalidate()
    End Sub
    Private Sub Hbs_Scroll(ByVal deltaX As Integer) Handles drawArea2.HsbScroll
        kitchen.Outline.ChangeCoordsBy(deltaX, 0)
        drawArea2.Invalidate()
    End Sub
#End Region

#Region "Add items butons"

    Private Sub AddSink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        kitchen.DisselectAllItems()
        kitchen.Items.Add(kitchen.Items.NewSink)
        newItemAdded = True
    End Sub

    Private Sub AddWallCabinet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        kitchen.DisselectAllItems()
        kitchen.Items.Add(kitchen.Items.NewWallCabinet)
        newItemAdded = True
    End Sub

    Private Sub AddWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        kitchen.DisselectAllItems()
        kitchen.Outline.OutlineItems.Add(kitchen.Outline.OutlineItems.NewWindow)
        newItemAdded = True
    End Sub

    Private Sub AddWasher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        kitchen.DisselectAllItems()
        kitchen.Items.Add(kitchen.Items.NewDishWasher)
        newItemAdded = True
    End Sub

    Private Sub AddDoor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDoor.Click
        kitchen.DisselectAllItems()
        kitchen.Outline.OutlineItems.Add(kitchen.Outline.OutlineItems.NewDoor)
        newItemAdded = True
    End Sub

    Private Sub Table_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        kitchen.DisselectAllItems()
        kitchen.Items.Add(kitchen.Items.NewTable)
        newItemAdded = True
    End Sub

    Private Sub Chair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        kitchen.DisselectAllItems()
        kitchen.Items.Add(kitchen.Items.NewChair)
        newItemAdded = True
    End Sub

    Private Sub btnAddStove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStove.Click
        kitchen.DisselectAllItems()
        kitchen.Items.Add(kitchen.Items.NewStove)
        newItemAdded = True
    End Sub

    Private Sub btnAddFridge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFridge.Click
        kitchen.DisselectAllItems()
        kitchen.Items.Add(kitchen.Items.NewFridge)
        newItemAdded = True
    End Sub
#End Region


    Private Sub QuitProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        End
    End Sub


    Private Sub GoLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        kitchen.Outline.ChangeCoordsBy(-10, 0)
        drawArea2.Invalidate()
    End Sub

    Private Sub GoRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        kitchen.Outline.ChangeCoordsBy(10, 0)
        drawArea2.Invalidate()
    End Sub

    Private Sub GoUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        kitchen.Outline.ChangeCoordsBy(0, -10)
        drawArea2.Invalidate()
    End Sub

    Private Sub GoDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        kitchen.Outline.ChangeCoordsBy(0, 10)
        drawArea2.Invalidate()
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click, mnuSave.Click
        sfd.ShowDialog()
    End Sub

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click, nmuOpen.Click
        ofd.ShowDialog()
    End Sub

    Private Sub sfd_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk
        Dim res As Boolean = False
        res = kitchen.Save(sfd.FileName)

        If res = True Then
            MsgBox("Your Kitchen has been saved successfully", MsgBoxStyle.Information, "Saving...")
        Else
            MsgBox("There were some problems during saving process", MsgBoxStyle.Critical, "Saving...")
        End If


    End Sub

    Private Sub ofd_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk
        Dim res As Boolean = False

        res = kitchen.Load(ofd.FileName)

        If res = True Then
            kitchen = kitchen.Instance()
            MsgBox("Your Kitchen has been loaded successfully", MsgBoxStyle.Information, "Loading...")
            drawArea2.Invalidate()
        Else
            MsgBox("File is corrupted: kitchen couldn't be loaded", MsgBoxStyle.Critical, "Saving...")
        End If

    End Sub

    Private Sub MenuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim a As New About
        a.ShowDialog()
    End Sub


End Class

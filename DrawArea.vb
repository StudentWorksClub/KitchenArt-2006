Imports System.Drawing
Public Class DrawArea
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.SetStyle(ControlStyles.DoubleBuffer And ControlStyles.AllPaintingInWmPaint, True)


        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents area As System.Windows.Forms.PictureBox
    Friend WithEvents sbVsb As System.Windows.Forms.VScrollBar
    Friend WithEvents sbHsb As System.Windows.Forms.HScrollBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.area = New System.Windows.Forms.PictureBox
        Me.sbVsb = New System.Windows.Forms.VScrollBar
        Me.sbHsb = New System.Windows.Forms.HScrollBar
        Me.SuspendLayout()
        '
        'area
        '
        Me.area.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.area.Location = New System.Drawing.Point(0, 0)
        Me.area.Name = "area"
        Me.area.Size = New System.Drawing.Size(144, 136)
        Me.area.TabIndex = 0
        Me.area.TabStop = False
        '
        'sbVsb
        '
        Me.sbVsb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbVsb.Location = New System.Drawing.Point(128, 0)
        Me.sbVsb.Maximum = 2000
        Me.sbVsb.Name = "sbVsb"
        Me.sbVsb.Size = New System.Drawing.Size(17, 120)
        Me.sbVsb.SmallChange = 10
        Me.sbVsb.TabIndex = 1
        '
        'sbHsb
        '
        Me.sbHsb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbHsb.Location = New System.Drawing.Point(0, 120)
        Me.sbHsb.Maximum = 2000
        Me.sbHsb.Name = "sbHsb"
        Me.sbHsb.Size = New System.Drawing.Size(128, 16)
        Me.sbHsb.SmallChange = 10
        Me.sbHsb.TabIndex = 2
        '
        'DrawArea
        '
        Me.Controls.Add(Me.sbHsb)
        Me.Controls.Add(Me.sbVsb)
        Me.Controls.Add(Me.area)
        Me.Name = "DrawArea"
        Me.Size = New System.Drawing.Size(145, 137)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public im As Bitmap
    Private m_gr As Graphics

    Public i As Integer = 0

    Private m_x, m_y As Integer
    Private m_showCross As Boolean

    Private GRID_CELLSIZE As Integer
    Private METRIC_CELLSIZE As Integer

    Private m_lastX, m_lastY As Integer

    Private m_invRect As Rectangle

    Public Shadows Event MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Public Shadows Event Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Shadows Event MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Public Shadows Event MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Public Shadows Event MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Shadows Event MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Shadows Event DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event HsbScroll(ByVal deltaX As Integer)
    Public Event VsbScroll(ByVal deltaY As Integer)




    Private Sub DrawArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        area.BackColor = Color.White
        GRID_CELLSIZE = 10
        im = New Bitmap(Me.Width, Me.Height)
        m_gr = Graphics.FromImage(im)

        m_lastX = sbHsb.Value
        m_lastY = sbVsb.Value

    End Sub
#Region "All Properties"

    Public Property gridCellSize() As Integer
        Get
            Return GRID_CELLSIZE
        End Get
        Set(ByVal Value As Integer)
            If Not Value < 1 And Not Value > Me.Height Then
                GRID_CELLSIZE = Value
            End If
        End Set
    End Property

    Public Property metricCellSize() As Integer
        Get
            Return METRIC_CELLSIZE
        End Get
        Set(ByVal Value As Integer)
            If Not Value < 1 And Not Value > Me.Height Then
                METRIC_CELLSIZE = Value
            End If
        End Set
    End Property

    Public ReadOnly Property graph() As Graphics
        Get
            Return m_gr
        End Get
    End Property
    Public Property showCross() As Boolean
        Get
            Return m_showCross
        End Get
        Set(ByVal Value As Boolean)
            m_showCross = Value
        End Set
    End Property

#End Region

#Region "All Overloads"

    Protected Overloads Sub OnDoubleClick(ByVal e As System.EventArgs)
        RaiseEvent DoubleClick(Me, e)
    End Sub
    Protected Overloads Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        RaiseEvent MouseMove(Me, e)
    End Sub
    Protected Overloads Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        RaiseEvent MouseUp(Me, e)
    End Sub
    Protected Overloads Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        RaiseEvent MouseDown(Me, e)
    End Sub
    Protected Overloads Sub OnClick(ByVal e As System.EventArgs)
        RaiseEvent Click(Me, e)
    End Sub
    Protected Overloads Sub OnMouseLeave(ByVal e As System.EventArgs)
        RaiseEvent MouseLeave(Me, e)
    End Sub
    Protected Overloads Sub OnMouseEnter(ByVal e As System.EventArgs)
        RaiseEvent MouseEnter(Me, e)
    End Sub
    Protected Overloads Sub OnHsbScroll(ByVal deltaX As Integer)
        RaiseEvent HsbScroll(deltaX)
    End Sub
    Protected Overloads Sub OnVsbScroll(ByVal deltaY As Integer)
        RaiseEvent VsbScroll(deltaY)
    End Sub

#End Region

    Public Function allignXtoGrid(ByVal x As Integer, Optional ByVal width As Integer = 0)
        Return CInt((x - width / 2) / GRID_CELLSIZE) * GRID_CELLSIZE
    End Function

    Public Function allignYtoGrid(ByVal y As Integer, Optional ByVal height As Integer = 0)
        Return CInt((y - height / 2) / GRID_CELLSIZE) * GRID_CELLSIZE
    End Function

    Private Sub drawGrid(ByVal gr As Graphics, ByVal width As Integer, ByVal height As Integer)

        Dim curX, curY As Integer
        curX = 1
        curY = 1
        For curX = 1 To width / GRID_CELLSIZE
            gr.DrawLine(Pens.LightGray, curX * GRID_CELLSIZE, 0, curX * GRID_CELLSIZE, height)
        Next curX
        For curY = 1 To height / GRID_CELLSIZE
            gr.DrawLine(Pens.LightGray, 0, curY * GRID_CELLSIZE, width, curY * GRID_CELLSIZE)
        Next curY


    End Sub

    Private Sub drawCross(ByVal gr As Graphics, ByVal x As Integer, ByVal y As Integer)

        If m_showCross = False Then Exit Sub

        Dim pen As New Pen(Color.Black, 1.5)
        pen.DashStyle = Drawing2D.DashStyle.Dot


        Dim curX As Integer = CInt((x) / GRID_CELLSIZE) * GRID_CELLSIZE
        Dim curY As Integer = CInt((y) / GRID_CELLSIZE) * GRID_CELLSIZE


        gr.DrawLine(pen, curX, 0, curX, Me.Height)
        gr.DrawLine(pen, 0, curY, Me.Width, curY)
    End Sub


    Private Sub MeResize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        im = New Bitmap(Me.Width, Me.Height)
        m_gr = Graphics.FromImage(im)

        ''Me.Invalidate()
    End Sub


    Private Sub DrawArea_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        m_gr.Clear(Me.BackColor)
        drawGrid(m_gr, Me.Width, Me.Height)
        Draw()
        'drawCross(m_gr, m_x, m_y)
        i += 1

    End Sub

    Public Sub Draw()
        area.Image = im
    End Sub

    Private Sub area_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles area.MouseMove
        m_x = e.X
        m_y = e.Y
        OnMouseMove(e)
    End Sub

    Private Sub area_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles area.Click
        OnClick(e)
    End Sub

    Private Sub area_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles area.MouseDown
        OnMouseDown(e)
    End Sub

    Private Sub area_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles area.MouseUp
        OnMouseUp(e)
    End Sub

    Private Sub area_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles area.MouseLeave
        OnMouseLeave(e)
    End Sub

    Private Sub area_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles area.MouseEnter
        OnMouseEnter(e)
    End Sub

    Private Sub DrawArea_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles MyBase.Invalidated
        m_invRect = e.InvalidRect
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sbVsb.Scroll
        'm_gr.TranslateTransform(0, m_lastY - sbVsb.Value)
        Dim deltaY = m_lastY - e.NewValue
        m_lastY = e.NewValue
        Me.Invalidate()
        OnVsbScroll(deltaY)

    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sbHsb.Scroll
        'm_gr.TranslateTransform(m_lastX - sbHsb.Value, 0)
        Dim deltaX = m_lastX - e.NewValue
        m_lastX = e.NewValue
        Me.Invalidate()
        OnHsbScroll(deltaX)
    End Sub

    Private Sub area_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles area.DoubleClick
        OnDoubleClick(e)
    End Sub
End Class

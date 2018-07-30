Imports System.Math
<Serializable()> _
Public Class KitchenOutline
    Inherits Drawable

    Private m_list As OutlineItemList
    Private m_metricWallWidth As Integer
    Private m_IsSelected As Boolean
    Private m_showMetrics As Boolean

    Public Event CoordsChanged(ByVal deltaX As Integer, ByVal deltaY As Integer)

    Public Sub New()

        'set wallWidth first, but it is most probably overridden 
        'in the main - and that is caut by set-property below
        m_metricWallWidth = 10
        'then pass to items container/creator
        m_list = New OutlineItemList(m_metricWallWidth)
        m_IsSelected = True

    End Sub


#Region "All Properties"
    Public ReadOnly Property pixWallWidth() As Integer
        Get
            Return m_metricWallWidth / metricCellSize * gridCellSize
        End Get
    End Property
    Public ReadOnly Property OutlineItems() As OutlineItemList
        Get
            Return m_list
        End Get
    End Property

    Public Property MetricWallWidth() As Integer
        Get
            Return m_metricWallWidth
        End Get
        Set(ByVal Value As Integer)
            m_metricWallWidth = Value
            Pen = New Pen(Color.Gray, pixWallWidth)
            DefaultPen = Pen
            m_list.MetricWallWidth = m_metricWallWidth
        End Set
    End Property

    Public Property IsSelected() As Boolean
        Get
            Return m_IsSelected
        End Get
        Set(ByVal Value As Boolean)
            m_IsSelected = Value
        End Set
    End Property

    Public Property ShowMetrics()
        Get
            Return m_showMetrics
        End Get
        Set(ByVal Value)
            m_showMetrics = Value
        End Set
    End Property

#End Region

#Region "All Members"

    Public Overrides Sub Draw(ByVal gr As Graphics)
        gr.DrawRectangle(Pen, pixX - pixWallWidth \ 2, pixY - pixWallWidth \ 2, _
                    pixLength + pixWallWidth, pixWidth + pixWallWidth)

        If m_showMetrics = True Then
            gr.DrawString(Me.metricLength.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
                Me.pixX + Me.pixLength / 2, Me.pixY - Me.pixWallWidth - 20)
            gr.DrawString(Me.metricLength.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
                    Me.pixX + Me.pixLength / 2, Me.pixY + Me.pixWidth + Me.pixWallWidth + 5)
            gr.DrawString(Me.metricWidth.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
                               Me.pixX - Me.pixWallWidth - 50, Me.pixY + Me.pixWidth / 2)
            gr.DrawString(Me.metricWidth.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
                                           Me.pixX + Me.pixLength + Me.pixWallWidth + 5, Me.pixY + Me.pixWidth / 2)

        End If
    End Sub

    Public Function OutlineRect() As Rectangle
        Dim r As New Rectangle
        r.X = pixX
        r.Y = pixY
        r.Width = pixLength
        r.Height = pixWidth
        Return r
    End Function

    Public Function IsMouseOverRect(ByVal X As Integer, ByVal Y As Integer) As Boolean

        'check if outline items has mouse over
        If Not Me.OutlineItems.HighlitedItem(X, Y) Is Nothing Then Return False

        Dim unitX As Integer = Abs((pixX + pixLength / 2) - X)
        Dim unitY As Integer = Abs((pixY + pixWidth / 2) - Y)

        If (Abs(unitX) > (pixLength / 2) And Abs(unitX) < pixLength / 2 + Me.pixWallWidth) _
            And Abs(unitY) < pixWidth / 2 + Me.pixWallWidth _
                Or _
           (Abs(unitY) > (pixWidth / 2) And Abs(unitY) < pixWidth / 2 + Me.pixWallWidth) _
            And Abs(unitX) < pixLength / 2 + Me.pixWallWidth _
        Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub ApplyNewMectrics(ByVal gridCellSize As Integer, ByVal metricCellSize As Integer)
        'for all items in outline
        m_list.ApplyNewMetricsToAllItems(gridCellSize, metricCellSize)

        'for the outline itself
        MyBase.ApplyNewMectrics(gridCellSize, metricCellSize)
        Pen = New Pen(Color.Gray, pixWallWidth)
        DefaultPen = Pen
        HighlitedPen = New Pen(Color.LightSteelBlue, pixWallWidth)
    End Sub

    Public Sub SetCoords(ByVal _metricX As Integer, ByVal _metricY As Integer)
        Dim oldX, oldY As Integer
        oldX = Me.metricX
        oldY = Me.metricY
        'change in Outline itself
        Me.metricX = _metricX
        Me.metricY = _metricY
        'then pass to its itemList
        Me.OutlineItems.OutlineX = _metricX
        Me.OutlineItems.OutlineY = _metricY
        'pass it UP to the kitchen therought event, so kitchen will spread it it its items
        RaiseEvent CoordsChanged(oldX - _metricX, oldY - _metricY)
    End Sub

    Public Sub ChangeCoordsBy(ByVal deltaX As Integer, ByVal deltaY As Integer)
        'change in Outline itself
        Me.metricX += deltaX
        Me.metricY += deltaY
        'then pass to its itemList
        Me.OutlineItems.OutlineX += deltaX
        Me.OutlineItems.OutlineY += deltaY
        'pass it UP to the kitchen therought event, so kitchen will spread it to its items
        RaiseEvent CoordsChanged(deltaX, deltaY)
    End Sub

#End Region

End Class

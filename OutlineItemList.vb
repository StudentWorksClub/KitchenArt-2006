<Serializable()> _
Public Class OutlineItemList
    Inherits ItemList
    Implements IOutlineItemList


    'this is passed from container (kitchenOutline), so kitcenItemscould be created with
    'this width, as item.width=outlineWallWidth
    Private m_metricWallWidth As Integer

    Public Sub New(ByVal metricWallWidth As Integer)
        m_metricWallWidth = metricWallWidth
    End Sub

    Public Property MetricWallWidth() As Integer
        Get
            Return m_metricWallWidth
        End Get
        Set(ByVal Value As Integer)
            m_metricWallWidth = Value
        End Set
    End Property


    Public ReadOnly Property NewWindow() As Window Implements IOutlineItemList.NewWindow
        Get
            Dim w As New Window(gridCellSize, metricCellSize)
            w.metricWidth = m_metricWallWidth
            w.OutlineX = Me.OutlineX
            w.OutlineY = Me.OutlineY
            Return w
        End Get
    End Property

    Public ReadOnly Property NewDoor() As Door Implements IOutlineItemList.NewDoor
        Get
            Dim d As New Door(gridCellSize, metricCellSize)
            d.metricWidth = m_metricWallWidth
            d.OutlineX = Me.OutlineX
            d.OutlineY = Me.OutlineY
            Return d
        End Get
    End Property

#Region "All Members"



#End Region


End Class

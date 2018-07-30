<Serializable()> _
Public MustInherit Class Drawable
    Implements IDrawable

    'metricWidth, metricHeight - real (cm) dimensions
    Private m_metricX, m_metricY, m_metricWidth, m_metricLength As Integer

    'cellMetricSize - how many units (e.g cm) in cell
    'cellSize - how many pixels in cell
    Public metricCellSize, gridCellSize As Integer


    <NonSerialized()> Private m_pen As Pen
    <NonSerialized()> Private m_defaultPen As Pen
    <NonSerialized()> Private m_highlitedPen As Pen
    <NonSerialized()> Private m_invalidPen As Pen


#Region "All Properties"

    Public Property DefaultPen() As System.Drawing.Pen
        Get
            Return m_defaultPen
        End Get
        Set(ByVal Value As System.Drawing.Pen)
            m_defaultPen = Value
        End Set
    End Property
    Public Property HighlitedPen() As System.Drawing.Pen
        Get
            Return m_highlitedPen
        End Get
        Set(ByVal Value As System.Drawing.Pen)
            m_highlitedPen = Value
        End Set
    End Property
    Public Property InvalidPen() As System.Drawing.Pen
        Get
            Return m_invalidPen
        End Get
        Set(ByVal Value As System.Drawing.Pen)
            m_invalidPen = Value
        End Set
    End Property

    Public Property Pen() As Pen
        Get
            Return m_pen
        End Get
        Set(ByVal Value As Pen)
            m_pen = Value
            If m_defaultPen Is Nothing Then
                m_defaultPen = Value
            End If
        End Set
    End Property

    Public ReadOnly Property pixX() As Integer
        Get
            Return metricX / metricCellSize * gridCellSize
        End Get
    End Property

    Public ReadOnly Property pixY() As Integer
        Get
            Return metricY / metricCellSize * gridCellSize
        End Get
    End Property

    Public ReadOnly Property pixLength() As Integer
        Get
            Return metricLength / metricCellSize * gridCellSize
        End Get
    End Property

    Public ReadOnly Property pixWidth() As Integer
        Get
            Return metricWidth / metricCellSize * gridCellSize
        End Get
    End Property

    Public Property metricX() As Integer
        Get
            Return m_metricX
        End Get
        Set(ByVal Value As Integer)
            m_metricX = Value
        End Set
    End Property

    Public Property metricY() As Integer
        Get
            Return m_metricY
        End Get
        Set(ByVal Value As Integer)
            m_metricY = Value
        End Set
    End Property

    Public Property metricLength() As Integer
        Get
            Return m_metricWidth
        End Get
        Set(ByVal Value As Integer)
            m_metricWidth = Value
        End Set
    End Property

    Public Property metricWidth() As Integer
        Get
            Return m_metricLength
        End Get
        Set(ByVal Value As Integer)
            m_metricLength = Value
        End Set
    End Property

#End Region

#Region "All members"

    'converts pixels to metric units
    Public Function pixToMetric(ByVal val As Integer)
        Return val / gridCellSize * metricCellSize
    End Function

    Public Overridable Sub ApplyNewMectrics(ByVal gridCellSize As Integer, ByVal metricCellSize As Integer)
        Me.gridCellSize = gridCellSize
        Me.metricCellSize = metricCellSize
    End Sub
#End Region

    'That's all the fuss is about, but not for Drawable - for its concrete (not MustInherit) children
    Public MustOverride Sub Draw(ByVal gr As Graphics) Implements IDrawable.Draw

End Class

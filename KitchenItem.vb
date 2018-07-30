Imports System.Math
<Serializable()> _
Public MustInherit Class KitchenItem
    Inherits Drawable
    Implements IRotatable

    Private m_curRotation As Integer
    Private m_IsSelected As Boolean
    Private m_showMetrics As Boolean
    Private m_OutlineX, m_OutlineY As Integer

    Public Sub New()
        Pen = New Pen(Color.Black, 1)
        DefaultPen = Pen
        HighlitedPen = New Pen(Color.LightSteelBlue, DefaultPen.Width + 1)
        InvalidPen = New Pen(Color.Red, 1)
    End Sub

#Region "All Properties"
    Public Property OutlineX() As Integer
        Get
            Return m_OutlineX
        End Get
        Set(ByVal Value As Integer)
            m_OutlineX = Value
        End Set
    End Property
    Public Property OutlineY() As Integer
        Get
            Return m_OutlineY
        End Get
        Set(ByVal Value As Integer)
            m_OutlineY = Value
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
    Public Property IsSelected() As Boolean
        Get
            Return m_IsSelected
        End Get
        Set(ByVal Value As Boolean)
            m_IsSelected = Value
        End Set
    End Property


    Public Property curRotation()
        Get
            Return m_curRotation
        End Get
        Set(ByVal Value)
            m_curRotation = Value
        End Set
    End Property

#End Region

#Region "All overrides"

    'Should be always called in inherited class - basic operations for all objects
    Public Overridable Sub Rotate() Implements IRotatable.Rotate
        Me.metricX = Me.pixToMetric(Me.pixX + Me.pixLength / 2 - Me.pixWidth / 2)
        Me.metricY = Me.pixToMetric(Me.pixY + Me.pixWidth / 2 - Me.pixLength / 2)

        Dim temp As Integer = metricLength
        metricLength = metricWidth
        metricWidth = temp
    End Sub

#End Region

#Region "All members"

    Protected Sub DrawMeasurments(ByVal gr As Graphics)
        'gr.DrawString(Me.metricLength.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
        '    Me.pixX + Me.pixLength / 2, Me.pixY - 20)
        gr.DrawString(Me.metricLength.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
                Me.pixX + Me.pixLength / 2 - 10, Me.pixY + Me.pixWidth + 5)
        'gr.DrawString(Me.metricWidth.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
        '                  Me.pixX - 50, Me.pixY + Me.pixWidth / 2)
        gr.DrawString(Me.metricWidth.ToString() + " cm", New Font("New Roman", 10), Brushes.Black, _
                                       Me.pixX + Me.pixLength + 5, Me.pixY + Me.pixWidth / 2)

        gr.DrawString((Me.metricX - Me.OutlineX).ToString() + "," + (Me.metricY - Me.OutlineY).ToString() + " cm", _
                                                New Font("New Roman", 10), Brushes.Black, _
                                               Me.pixX - 10, Me.pixY - (New Font("New Roman", 10)).Height)
    End Sub

    Public Overridable Function IsMouseOverRect(ByVal X As Integer, ByVal Y As Integer) As Boolean
        Dim unitX As Integer = Abs((pixX + pixLength / 2) - X)
        Dim unitY As Integer = Abs((pixY + pixWidth / 2) - Y)

        If Abs(unitX) < (pixLength / 2) And (Abs(unitY) < (pixWidth / 2)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'check for collision with another object
    Public Overridable Function isCollideWith(ByVal item As KitchenItem) As Boolean

        'if item passed in paremeter is the same as this - exit (it collides with itself)
        If item Is Me Then
            Exit Function
        End If

        Dim bigx As Integer = Abs((pixX + pixLength / 2) - (item.pixX + item.pixLength / 2))
        Dim bigy As Integer = Abs((pixY + pixWidth / 2) - (item.pixY + item.pixWidth / 2))

        If Abs(bigx) < (pixLength + item.pixLength) / 2 And Abs(bigy) < (pixWidth + item.pixWidth) / 2 Then
            Return True
        Else
            Return False
        End If
    End Function

    'check for collision with outline
    Public Overridable Function isOutOfBoundariesOf(ByVal rect As Rectangle, ByVal boundaryWidth As Integer) As Boolean

        Dim bigx As Integer = Abs((pixX + pixLength / 2) - (rect.X + rect.Width / 2))
        Dim bigy As Integer = Abs((pixY + pixWidth / 2) - (rect.Y + rect.Height / 2))

        If Abs(bigx) > (rect.Width / 2 - pixLength / 2) Or Abs(bigy) > (rect.Height / 2 - pixWidth / 2) Then
            Return True
        Else
            Return False
        End If
    End Function


#End Region



End Class

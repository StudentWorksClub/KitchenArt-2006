Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()> _
Public Class Kitchen

    Private WithEvents m_outline As KitchenOutline
    Private m_itemList As KitchenItemList

    Shared m_kitchen As Kitchen

    'returns existing or earlier created instance
    Public Shared Function Instance() As Kitchen
        If m_kitchen Is Nothing Then
            m_kitchen = New Kitchen
            m_kitchen.m_itemList = New KitchenItemList
            m_kitchen.m_outline = New KitchenOutline
        End If
        Return m_kitchen
    End Function

    Public Sub New()
        m_itemList = New KitchenItemList
        m_outline = New KitchenOutline
    End Sub

#Region "All properties"

    Public ReadOnly Property Outline() As KitchenOutline
        Get
            Return m_outline
        End Get
    End Property

    Public ReadOnly Property Items() As KitchenItemList
        Get
            Return m_itemList
        End Get
    End Property

#End Region

#Region "All Members"

    Public Sub Draw(ByVal m_gr As Graphics)

        m_kitchen.Outline.Draw(m_gr)
        For Each item As KitchenItem In m_kitchen.Outline.OutlineItems
            item.Draw(m_gr)
        Next
        For Each item As KitchenItem In m_kitchen.Items
            item.Draw(m_gr)
        Next

    End Sub
    Public Sub ApplyNewMectrics(ByVal gridCellSize As Integer, ByVal metricCellSize As Integer)
        m_outline.ApplyNewMectrics(gridCellSize, metricCellSize)
        m_itemList.ApplyNewMetricsToAllItems(gridCellSize, metricCellSize)
    End Sub

    Public Function IsInCollision(ByVal selectedItem As KitchenItem) As Boolean

        Dim inCollision As Boolean = False

        For Each item As KitchenItem In Items
            'collision with itself checked in isCollideWith() - don't worry
            If selectedItem.isCollideWith(item) = True Or _
                   selectedItem.isOutOfBoundariesOf(Outline.OutlineRect(), _
                                                    Outline.pixWallWidth) = True _
            Then
                inCollision = True
                Exit For
            End If
        Next

        For Each item As KitchenItem In Outline.OutlineItems
            'collision with itself checked in isCollideWith() - don't worry
            If selectedItem.isCollideWith(item) = True Or _
                   selectedItem.isOutOfBoundariesOf(Outline.OutlineRect(), _
                                                    Outline.pixWallWidth) = True _
            Then
                inCollision = True
                Exit For
            End If
        Next
        Return inCollision

    End Function

    Public Function GetSelectedItem() As KitchenItem
        Dim selectedItem As KitchenItem = Nothing
        If Not Items.SelectedItem Is Nothing Then
            selectedItem = Items.SelectedItem
        ElseIf Not Outline.OutlineItems.SelectedItem Is Nothing Then
            selectedItem = Outline.OutlineItems.SelectedItem
        End If
        Return selectedItem
    End Function

    Public Function GetHighlitedItem(ByVal X As Integer, ByVal Y As Integer) As KitchenItem
        Dim highlitedItem As KitchenItem = Nothing
        If Not Items.HighlitedItem(X, Y) Is Nothing Then
            highlitedItem = Items.HighlitedItem(X, Y)
        ElseIf Not Outline.OutlineItems.HighlitedItem(X, Y) Is Nothing Then
            highlitedItem = Outline.OutlineItems.HighlitedItem(X, Y)
        End If
        Return highlitedItem
    End Function

    Public Sub DisselectAllItems()
        Dim selectedItem As KitchenItem = GetSelectedItem()
        'diselect all items
        If Not selectedItem Is Nothing Then
            selectedItem.IsSelected = False
            'selectedItem.Pen = selectedItem.DefaultPen
        End If
    End Sub

    Public Sub InvalidateAllInCollision()
        For Each item As KitchenItem In Items
            If IsInCollision(item) = True Then
                item.Pen = item.InvalidPen
            Else
                item.Pen = item.DefaultPen
            End If
        Next
        For Each item As KitchenItem In Outline.OutlineItems
            If IsInCollision(item) = True Then
                item.Pen = item.InvalidPen
            Else
                item.Pen = item.DefaultPen
            End If
        Next

    End Sub

    'to entire kitchen
    Public Sub ApplyNewPensToItems(ByVal dPen As Pen, ByVal iPen As Pen, ByVal hPen As Pen)
        Dim temp As KitchenItem = m_kitchen.Items.NewSink
        For Each item As KitchenItem In m_kitchen.Items
            item.Pen = dPen
            item.DefaultPen = dPen 'temp.DefaultPen  '
            item.InvalidPen = iPen 'temp.InvalidPen   '
            item.HighlitedPen = hPen 'temp.HighlitedPen  '
        Next
        For Each item As KitchenItem In m_kitchen.Outline.OutlineItems
            item.Pen = dPen
            item.DefaultPen = dPen 'temp.DefaultPen  '
            item.InvalidPen = iPen 'temp.InvalidPen   '
            item.HighlitedPen = hPen 'temp.HighlitedPen  '
        Next



    End Sub

    Public Sub OnOutlineCoordsChanged(ByVal deltaX As Integer, ByVal deltaY As Integer) Handles m_outline.CoordsChanged

        'Items.OutlineX/Y property will set all items' OutlineX/Y  after this 
        m_kitchen.Items.OutlineX = Outline.metricX
        m_kitchen.Items.OutlineY = Outline.metricY
        'but if we moved the outline we want items not only 
        'to know new vars but, be moved with outline
        For Each item As KitchenItem In m_kitchen.Items
            item.metricX += deltaX
            item.metricY += deltaY
        Next
        For Each item As KitchenItem In m_kitchen.Outline.OutlineItems
            item.metricX += deltaX
            item.metricY += deltaY
        Next
    End Sub

    Public Function Save(ByVal fileName As String) As Boolean
        Dim stream As FileStream = New FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write)
        Dim fm As New BinaryFormatter

        'serialize kitchen
        Try
            fm.Serialize(stream, m_kitchen)

            'serialize outline pens, as there're only two of them
            Dim OutlineDPen As New SerialPen(m_kitchen.Outline.DefaultPen.Color.ToArgb, m_kitchen.Outline.DefaultPen.Width)
            Dim OutlineHPen As New SerialPen(m_kitchen.Outline.HighlitedPen.Color.ToArgb, m_kitchen.Outline.HighlitedPen.Width)
            fm.Serialize(stream, OutlineDPen)
            fm.Serialize(stream, OutlineHPen)

            'serialize items' pens
            Dim item As KitchenItem = m_kitchen.Items.NewSink

            Dim dPen As New SerialPen(item.DefaultPen.Color.ToArgb, item.DefaultPen.Width)
            Dim iPen As New SerialPen(item.InvalidPen.Color.ToArgb, item.InvalidPen.Width)
            Dim hPen As New SerialPen(item.HighlitedPen.Color.ToArgb, item.HighlitedPen.Width)

            fm.Serialize(stream, dPen)
            fm.Serialize(stream, iPen)
            fm.Serialize(stream, hPen)
        Catch ex As Exception
            Return False
        End Try
        stream.Close()
        Return True
    End Function

    Public Function Load(ByVal fileName As String) As Boolean
        Dim stream As FileStream = New FileStream(fileName, FileMode.Open)
        Dim fm As New BinaryFormatter

        Try

            m_kitchen = fm.Deserialize(stream)

        'deserialize outine pens
        Dim OutlineDPen, OutlineHPen As SerialPen
        OutlineDPen = fm.Deserialize(stream)
        OutlineHPen = fm.Deserialize(stream)

        Dim ODPen As New Pen(Color.FromArgb(OutlineDPen.Color), OutlineDPen.Width)
        Dim OHPen As New Pen(Color.FromArgb(OutlineHPen.Color), OutlineHPen.Width)

        m_kitchen.Outline.Pen = ODPen
        m_kitchen.Outline.DefaultPen = ODPen
        m_kitchen.Outline.HighlitedPen = OHPen

        'deserialize items' pens
        Dim SdPen, SiPen, ShPen As SerialPen

        SdPen = fm.Deserialize(stream)
        SiPen = fm.Deserialize(stream)
        ShPen = fm.Deserialize(stream)

        Dim dPen As New Pen(Color.FromArgb(SdPen.Color), SdPen.Width)
        Dim iPen As New Pen(Color.FromArgb(SiPen.Color), SiPen.Width)
        Dim hPen As New Pen(Color.FromArgb(ShPen.Color), ShPen.Width)

            m_kitchen.ApplyNewPensToItems(dPen, iPen, hPen)

        Catch ex As Exception
            Return False
        End Try
        stream.Close()
        Return True
    End Function

#End Region

End Class

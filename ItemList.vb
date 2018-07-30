
<Serializable()> _
Public MustInherit Class ItemList
    Inherits CollectionBase
    Protected gridCellSize, metricCellSize As Integer
    Protected m_OutlineX, m_OutlineY As Integer


#Region "All Collection Overrides"

    Default Public Property Item(ByVal index As Integer) As KitchenItem
        Get
            Return CType(List(index), KitchenItem)
        End Get
        Set(ByVal Value As KitchenItem)
            List(index) = Value
        End Set
    End Property


    Public Function Add(ByVal value As KitchenItem) As Integer
        Return List.Add(value)
    End Function 'Add

    Public Function IndexOf(ByVal value As KitchenItem) As Integer
        Return List.IndexOf(value)
    End Function 'IndexOf


    Public Sub Insert(ByVal index As Integer, ByVal value As KitchenItem)
        List.Insert(index, value)
    End Sub 'Insert


    Public Sub Remove(ByVal value As KitchenItem)
        List.Remove(value)
    End Sub 'Remove


    Public Function Contains(ByVal value As KitchenItem) As Boolean
        ' If value is not of type Int16, this will return false.
        Return List.Contains(value)
    End Function 'Contains


    Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal value As [Object])
        ' Insert additional code to be run only when inserting values.
    End Sub 'OnInsert


    Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal value As [Object])
        ' Insert additional code to be run only when removing values.
    End Sub 'OnRemove


    Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldValue As [Object], ByVal newValue As [Object])
        ' Insert additional code to be run only when setting values.
    End Sub 'OnSet


    Protected Overrides Sub OnValidate(ByVal value As [Object])
        If Not value.GetType().BaseType.BaseType Is GetType(KitchenItem) And _
            Not value.GetType().BaseType Is GetType(KitchenItem) And _
            Not value.GetType() Is GetType(KitchenItem) Then
            Throw New ArgumentException("value must be of type " + _
                  GetType(KitchenItem).ToString + "--" & value.GetType().BaseType.ToString, "value")
        End If
    End Sub 'OnValidate 

#End Region

    Public Property OutlineX() As Integer
        Get
            Return m_OutlineX
        End Get
        Set(ByVal Value As Integer)
            m_OutlineX = Value
            For Each item As KitchenItem In Me
                item.OutlineX = m_OutlineX
            Next
        End Set
    End Property

    Public Property OutlineY() As Integer
        Get
            Return m_OutlineY
        End Get
        Set(ByVal Value As Integer)
            m_OutlineY = Value
            For Each item As KitchenItem In Me
                item.OutlineY = m_OutlineY
            Next
        End Set
    End Property

#Region "All Members"

    Public Function SelectedItem() As KitchenItem
        For Each item As KitchenItem In Me
            If item.IsSelected = True Then Return item
        Next
        Return Nothing
    End Function

    Public Function HighlitedItem(ByVal X As Integer, ByVal Y As Integer) As KitchenItem
        For Each item As KitchenItem In Me
            If item.IsMouseOverRect(X, Y) = True Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    Public Sub SetDefaultPenToAllItems()
        For Each item As KitchenItem In Me
            item.Pen = item.DefaultPen
        Next
    End Sub


    Public Function ApplyNewMetricsToAllItems(ByVal _gridCellSize As Integer, ByVal _metricCellSize As Integer)
        gridCellSize = _gridCellSize
        metricCellSize = _metricCellSize

        For Each item As KitchenItem In Me
            item.ApplyNewMectrics(gridCellSize, metricCellSize)
        Next
    End Function

#End Region

End Class

<Serializable()> _
Public Class KitchenItemList
    Inherits ItemList
    Implements IKitchenItemList

    ReadOnly Property NewSink() As Sink Implements IKitchenItemList.NewSink
        Get
            Dim s As New Sink(gridCellSize, metricCellSize)
            s.OutlineX = Me.OutlineX
            s.OutlineY = Me.OutlineY
            Return s
        End Get
    End Property

    ReadOnly Property NewFridge() As Fridge Implements IKitchenItemList.NewFridge
        Get
            Dim f As New Fridge(gridCellSize, metricCellSize)
            f.OutlineX = Me.OutlineX
            f.OutlineY = Me.OutlineY
            Return f
        End Get
    End Property

    ReadOnly Property NewStove() As Stove Implements IKitchenItemList.NewStove
        Get
            Dim s As New Stove(gridCellSize, metricCellSize)
            s.OutlineX = Me.OutlineX
            s.OutlineY = Me.OutlineY
            Return s
        End Get
    End Property

    ReadOnly Property NewChair() As Chair Implements IKitchenItemList.NewChair
        Get
            Dim c As New Chair(gridCellSize, metricCellSize)
            c.OutlineX = Me.OutlineX
            c.OutlineY = Me.OutlineY
            Return c
        End Get
    End Property
    ReadOnly Property NewTable() As Table Implements IKitchenItemList.NewTable
        Get
            Dim t As New Table(gridCellSize, metricCellSize)
            t.OutlineX = Me.OutlineX
            t.OutlineY = Me.OutlineY
            Return t
        End Get
    End Property
    ReadOnly Property NewWallCabinet() As WallCabinet Implements IKitchenItemList.NewWallCabinet
        Get
            Dim wc As New WallCabinet(gridCellSize, metricCellSize)
            wc.OutlineX = Me.OutlineX
            wc.OutlineY = Me.OutlineY
            Return wc
        End Get
    End Property
    ReadOnly Property NewFloorCabinet() As FloorCabinet Implements IKitchenItemList.NewFloorCabinet
        Get
            Dim fc As New FloorCabinet(gridCellSize, metricCellSize)
            fc.OutlineX = Me.OutlineX
            fc.OutlineY = Me.OutlineY
            Return fc
        End Get
    End Property

    ReadOnly Property NewDishWasher() As DishWasher Implements IKitchenItemList.NewDishWasher
        Get
            Dim dw As New DishWasher(gridCellSize, metricCellSize)
            dw.OutlineX = Me.OutlineX
            dw.OutlineY = Me.OutlineY
            Return dw
        End Get
    End Property

#Region "All Members"

#End Region

End Class

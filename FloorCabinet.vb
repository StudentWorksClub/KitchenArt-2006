<Serializable()> _
Public Class FloorCabinet
    Inherits FloorKitchenItem

    Public Sub New()
        MyBase.New()
        metricWidth = 50
        metricLength = 100
        Me.IsSelected = True
    End Sub
    Public Sub New(ByVal gridCellSize As Integer, ByVal metricCellSize As Integer)
        Me.New()
        Me.gridCellSize = gridCellSize
        Me.metricCellSize = metricCellSize
    End Sub

    Public Overrides Sub Draw(ByVal gr As Graphics)
        Dim offset, midPoint As Integer

        'Draw main frame
        gr.FillRectangle(Brushes.White, Me.pixX, Me.pixY, Me.pixLength, Me.pixWidth)
        gr.DrawRectangle(Pen, pixX, pixY, pixLength, pixWidth)

        Select Case Me.curRotation

            Case 0
                offset = pixWidth * 0.9
                midPoint = pixLength / 2

                'Draw door line
                gr.DrawLine(Pen, pixX, pixY + offset, pixX + pixLength, pixY + offset)

                'Draw door seperating line
                gr.DrawLine(Pen, pixX + midPoint, pixY + offset, pixX + midPoint, pixY + pixWidth)
            Case 1
                offset = pixLength * 0.9
                midPoint = pixWidth / 2

                'Draw door line
                gr.DrawLine(Pen, pixX + offset, pixY, pixX + offset, pixY + pixWidth)

                'Draw door seperating line
                gr.DrawLine(Pen, pixX + offset, pixY + midPoint, pixX + pixLength, pixY + midPoint)
            Case 2
                offset = pixWidth * 0.1
                midPoint = pixLength / 2

                'Draw door line
                gr.DrawLine(Pen, pixX, pixY + offset, pixX + pixLength, pixY + offset)

                'Draw door seperating line
                gr.DrawLine(Pen, pixX + midPoint, pixY + offset, pixX + midPoint, pixY)
            Case 3
                offset = pixLength * 0.1
                midPoint = pixWidth / 2

                'Draw door line
                gr.DrawLine(Pen, pixX + offset, pixY, pixX + offset, pixY + pixWidth)

                'Draw door seperating line
                gr.DrawLine(Pen, pixX + offset, pixY + midPoint, pixX, pixY + midPoint)
        End Select
        If IsSelected = True Then
            DrawMeasurments(gr)
        End If
    End Sub

    Public Overrides Sub Rotate()
        If Me.curRotation < 3 Then
            Me.curRotation += 1
        Else
            Me.curRotation = 0
        End If

        MyBase.Rotate()
    End Sub
End Class


<Serializable()> _
Public Class Sink
    Inherits FloorKitchenItem


    Public Sub New()
        MyBase.New()
        metricWidth = 50
        metricLength = 80
        Me.IsSelected = True
    End Sub

    Public Sub New(ByVal gridCellSize As Integer, ByVal metricCellSize As Integer)
        Me.New()
        Me.gridCellSize = gridCellSize
        Me.metricCellSize = metricCellSize
    End Sub

    Public Overrides Sub Draw(ByVal gr As Graphics)

        'temps
        Dim offsetX, offsetY, sL, sW As Integer

        'Draw the border of the sink
        gr.FillRectangle(Brushes.White, Me.pixX, Me.pixY, Me.pixLength, Me.pixWidth)
        gr.DrawRectangle(Pen, pixX, pixY, pixLength, pixWidth)

        'draw inner parts
        Select Case Me.curRotation

            Case 0
                offsetX = pixLength \ 12
                offsetY = pixWidth \ 4
                sL = pixLength * 3 \ 8
                sW = pixWidth * 3 \ 5

                gr.DrawRectangle(Pen, pixX + offsetX, pixY + offsetY, sL, sW)
                gr.DrawRectangle(Pen, pixX + pixLength - offsetX - sL, pixY + offsetY, sL, sW)

                gr.DrawRectangle(Pen, pixX + pixLength \ 2 - sL \ 2, pixY + offsetY \ 4, sL, offsetY \ 3)

                gr.DrawLine(Pen, pixX + pixLength \ 2, pixY + offsetY \ 4 + (offsetY \ 3) \ 2, _
                                pixX + pixLength \ 4, pixY + pixWidth \ 2)
            Case 1
                offsetX = pixLength \ 4 ''pixLength \ 12
                offsetY = pixWidth \ 12 ''pixWidth \ 4
                sL = pixLength * 3 \ 5 ''pixLength * 3 \ 8
                sW = pixWidth * 3 \ 8 ''pixWidth * 3 \ 5

                gr.DrawRectangle(Pen, pixX + pixLength - offsetX - sL, pixY + offsetY, sL, sW)
                gr.DrawRectangle(Pen, pixX + pixLength - offsetX - sL, pixY + pixWidth - offsetY - sW, sL, sW)

                gr.DrawRectangle(Pen, pixX + pixLength - offsetX \ 4 - offsetX \ 3, _
                                        pixY + pixWidth \ 2 - sW \ 2, offsetX \ 3, sW)

                gr.DrawLine(Pen, pixX + pixLength - offsetX \ 4 - (offsetX \ 3) \ 2, _
                                pixY + pixWidth \ 2, pixX + pixLength \ 2, pixY + pixWidth \ 4)
            Case 2
                offsetX = pixLength \ 12
                offsetY = pixWidth \ 4
                sL = pixLength * 3 \ 8
                sW = pixWidth * 3 \ 5

                gr.DrawRectangle(Pen, pixX + offsetX, pixY + pixWidth - offsetY - sW, sL, sW)
                gr.DrawRectangle(Pen, pixX + pixLength - offsetX - sL, pixY + pixWidth - offsetY - sW, sL, sW)

                gr.DrawRectangle(Pen, pixX + pixLength \ 2 - sL \ 2, _
                                    pixY + pixWidth - offsetY \ 4 - offsetY \ 3, sL, offsetY \ 3)

                gr.DrawLine(Pen, pixX + pixLength \ 2, pixY + pixWidth - offsetY \ 4 - (offsetY \ 3) \ 2, _
                                    pixX + pixLength - pixLength \ 4, pixY + pixWidth \ 2)

            Case 3

                offsetX = pixLength \ 4 ''pixLength \ 12
                offsetY = pixWidth \ 12 ''pixWidth \ 4
                sL = pixLength * 3 \ 5 ''pixLength * 3 \ 8
                sW = pixWidth * 3 \ 8 ''pixWidth * 3 \ 5

                gr.DrawRectangle(Pen, pixX + offsetX, pixY + offsetY, sL, sW)
                gr.DrawRectangle(Pen, pixX + offsetX, pixY + pixWidth - offsetY - sW, sL, sW)

                gr.DrawRectangle(Pen, pixX + offsetX \ 4, pixY + pixWidth \ 2 - sW \ 2, offsetX \ 3, sW)

                gr.DrawLine(Pen, pixX + offsetX \ 4 + (offsetX \ 3) \ 2, _
                                pixY + pixWidth \ 2, pixX + pixLength \ 2, pixY + pixWidth - pixWidth \ 4)

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

        'Should always call base class - basic operations for all objects
        MyBase.Rotate()
    End Sub
End Class

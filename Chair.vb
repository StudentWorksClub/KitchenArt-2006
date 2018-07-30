<Serializable()> _
Public Class Chair
    Inherits FloorKitchenItem


    Public Sub New()
        Pen = New Pen(Color.Black, 1)
        metricWidth = 30
        metricLength = 30
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
        'Draw the chair border

        gr.FillRectangle(Brushes.White, Me.pixX, Me.pixY, Me.pixLength, Me.pixWidth)
        gr.DrawRectangle(Pen, pixX, pixY, pixLength, pixWidth)

        'draw inner parts


        Select Case Me.curRotation



            Case 0

                sL = pixLength \ 8
                sW = pixWidth \ 8
                'first rectangle
                gr.DrawRectangle(Pen, pixX, pixY, sL, sW)

                gr.DrawRectangle(Pen, pixX + pixLength - sL, pixY, sL, sW)

                gr.DrawRectangle(Pen, pixX, pixY + pixWidth - sW, pixLength \ 2, sW)

                gr.DrawRectangle(Pen, pixX + (pixLength \ 2), pixY + pixWidth - sW, pixLength \ 2, sW)


            Case 1
                sL = pixLength \ 8
                sW = pixWidth \ 8
                'first rectangle
                gr.DrawRectangle(Pen, pixX + pixLength - sL, pixY, sL, sW)

                gr.DrawRectangle(Pen, pixX + pixLength - sL, pixY + pixWidth - sW, sL, sW)

                gr.DrawRectangle(Pen, pixX, pixY, sL, pixWidth \ 2)

                gr.DrawRectangle(Pen, pixX, pixY + pixWidth \ 2, sL, pixWidth \ 2)

            Case 2

                sL = pixLength \ 8
                sW = pixWidth \ 8
                'first rectangle
                gr.DrawRectangle(Pen, pixX, pixY, pixLength \ 2, sW)

                gr.DrawRectangle(Pen, pixX + pixLength \ 2, pixY, pixLength \ 2, sW)

                gr.DrawRectangle(Pen, pixX, pixY + pixWidth - sW, sL, sW)

                gr.DrawRectangle(Pen, pixX + pixLength - sL, pixY + pixWidth - sW, sL, sW)


            Case 3

                sL = pixLength \ 8
                sW = pixWidth \ 8
                'first rectangle
                gr.DrawRectangle(Pen, pixX, pixY, sL, sW)

                gr.DrawRectangle(Pen, pixX, pixY + pixWidth - sW, sL, sW)

                gr.DrawRectangle(Pen, pixX + pixLength - sL, pixY, sL, pixWidth \ 2)

                gr.DrawRectangle(Pen, pixX + pixLength - sL, pixY + pixWidth \ 2, sL, pixWidth \ 2)

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

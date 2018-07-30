<Serializable()> _
Public Class DishWasher
    Inherits FloorKitchenItem

    Dim dishWasherImg As Image
    Public Sub New()
        MyBase.New()
        dishWasherImg = Image.FromFile("../dishWasher.gif")

        metricWidth = 50
        metricLength = 50
        Me.IsSelected = True
    End Sub
    Public Sub New(ByVal gridCellSize As Integer, ByVal metricCellSize As Integer)
        Me.New()
        Me.gridCellSize = gridCellSize
        Me.metricCellSize = metricCellSize
    End Sub

    Public Overrides Sub Draw(ByVal gr As Graphics)
        Dim boxOffsetX, boxOffsetY, boxSize As Integer
        Dim offsetX, offsetY As Integer
        Dim handleL, handleW As Integer


        boxOffsetX = pixLength / 4
        boxOffsetY = pixWidth / 4

        If pixLength > pixWidth Then
            boxSize = pixLength / 2
            If boxSize > dishWasherImg.Width Then
                boxSize = dishWasherImg.Width
            ElseIf boxSize > dishWasherImg.Height Then
                boxSize = dishWasherImg.Height
            End If
        Else
            boxSize = pixWidth / 2
        End If


        'Draw main frame
        gr.FillRectangle(Brushes.White, Me.pixX, Me.pixY, Me.pixLength, Me.pixWidth)
        gr.DrawRectangle(Pen, pixX, pixY, pixLength, pixWidth)

        'Draw image
        gr.DrawImage(dishWasherImg, pixX + boxOffsetX _
                                    , pixY + boxOffsetY _
                                    , boxSize, boxSize)

       
        'draw inner parts
        Select Case Me.curRotation

            Case 0
                offsetX = pixLength \ 6
                offsetY = pixWidth \ 6
                handleL = pixLength - offsetX * 2
                handleW = offsetY \ 3

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX, pixY + offsetY, pixX + pixLength, pixY + offsetY)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX + offsetX, pixY + pixWidth, handleL, handleW)


            Case 1
                offsetX = pixLength \ 6
                offsetY = pixWidth \ 6
                handleL = offsetX \ 3
                handleW = pixWidth - offsetY * 2

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX + pixLength - offsetX, pixY, pixX + pixLength - offsetX, pixY + pixWidth)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX - offsetX \ 3, pixY + offsetY, handleL, handleW)

            Case 2
                offsetX = pixLength \ 6
                offsetY = pixWidth \ 6
                handleL = pixLength - offsetX * 2
                handleW = offsetY \ 3

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX, pixY + pixWidth - offsetY, pixX + pixLength, pixY + pixWidth - offsetY)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX + offsetX, pixY - offsetY \ 3, handleL, handleW)

            Case 3
                offsetX = pixLength \ 6
                offsetY = pixWidth \ 6
                handleL = offsetX \ 3
                handleW = pixWidth - offsetY * 2

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX + offsetX, pixY, pixX + offsetX, pixY + pixWidth)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX + pixLength, pixY + offsetY, handleL, handleW)

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



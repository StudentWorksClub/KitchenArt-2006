<Serializable()> _
Public Class Stove
    Inherits FloorKitchenItem

    Public Sub New()
        MyBase.New()
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

        'temps
        Dim offsetX, offsetY As Integer
        Dim handleL, handleW As Integer
        Dim intSize As Integer

        offsetX = pixLength \ 6
        offsetY = pixWidth \ 6

        'Draw the border of the sink
        gr.DrawRectangle(Pen, pixX, pixY, pixLength, pixWidth)

        'draw inner parts
        Select Case Me.curRotation

            Case 0
                handleL = pixLength - offsetX * 2
                handleW = offsetY \ 3

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX, pixY + offsetY, pixX + pixLength, pixY + offsetY)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX + offsetX, pixY + pixWidth, handleL, handleW)

                If pixLength >= (pixWidth - offsetY) Then
                    intSize = (pixWidth - offsetY) \ 2
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + 3 * offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + 3 * offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                Else
                    intSize = pixLength \ 2
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + 3 * offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + 3 * offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                End If

            Case 1
                handleL = offsetX \ 3
                handleW = pixWidth - offsetY * 2

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX + pixLength - offsetX, pixY, pixX + pixLength - offsetX, pixY + pixWidth)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX - offsetX \ 3, pixY + offsetY, handleL, handleW)

                If pixLength >= (pixWidth - offsetY) Then
                    intSize = (pixWidth - offsetY) \ 2
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - 3 * offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - 3 * offsetX \ 2, pixY + offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                Else
                    intSize = pixLength \ 2
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - 3 * offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - 3 * offsetX \ 2, pixY + offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                End If

            Case 2
                handleL = pixLength - offsetX * 2
                handleW = offsetY \ 3

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX, pixY + pixWidth - offsetY, pixX + pixLength, pixY + pixWidth - offsetY)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX + offsetX, pixY - offsetY \ 3, handleL, handleW)

                If pixLength >= (pixWidth - offsetY) Then
                    intSize = (pixWidth - offsetY) \ 2
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + pixWidth - 3 * offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + pixWidth - 3 * offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                Else
                    intSize = pixLength \ 2
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + pixWidth - 3 * offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + offsetX \ 2, pixY + pixWidth - 3 * offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                End If

            Case 3
                handleL = offsetX \ 3
                handleW = pixWidth - offsetY * 2

                'draw the panel of the stove
                gr.DrawLine(Pen, pixX + offsetX, pixY, pixX + offsetX, pixY + pixWidth)
                'draw the handle of the stove
                gr.DrawRectangle(Pen, pixX + pixLength, pixY + offsetY, handleL, handleW)

                If pixLength >= (pixWidth - offsetY) Then
                    intSize = (pixWidth - offsetY) \ 2
                    gr.DrawEllipse(Pen, pixX + 3 * offsetX \ 2, pixY + offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + 3 * offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                Else
                    intSize = pixLength \ 2
                    gr.DrawEllipse(Pen, pixX + 3 * offsetX \ 2, pixY + offsetY \ 2, _
                                    intSize - offsetY, intSize - offsetY)
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                   -(intSize - offsetY), -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + 3 * offsetX \ 2, pixY + pixWidth - offsetY \ 2, _
                                    intSize - offsetY, -(intSize - offsetY))
                    gr.DrawEllipse(Pen, pixX + pixLength - offsetX \ 2, pixY + offsetY \ 2, _
                                    -(intSize - offsetY), intSize - offsetY)
                End If

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

<Serializable()> _
Public Class Fridge
    Inherits FloorKitchenItem

    Private m_image As Image

    Public Sub New()
        MyBase.New()
        metricWidth = 50
        metricLength = 50
        m_image = Image.FromFile("../fridge.gif")
        Me.IsSelected = True
    End Sub

    Public Sub New(ByVal gridCellSize As Integer, ByVal metricCellSize As Integer)
        Me.New()
        Me.gridCellSize = gridCellSize
        Me.metricCellSize = metricCellSize
    End Sub

    Public Overrides Sub Draw(ByVal gr As System.Drawing.Graphics)

        Dim offsetX, offsetY, handleL, handleW As Integer
        Dim boxOffsetX, boxOffsetY, boxSize As Integer

        boxOffsetX = pixLength / 4
        boxOffsetY = pixWidth / 4

        If pixLength > pixWidth Then
            boxSize = pixLength / 2
            offsetX = pixLength / 5
            If boxSize > m_image.Width Then
                boxSize = m_image.Width
            ElseIf boxSize > m_image.Height Then
                boxSize = m_image.Height
            End If
        Else
            boxSize = pixWidth / 2
            offsetX = pixWidth / 5
        End If



        gr.FillRectangle(Brushes.White, Me.pixX, Me.pixY, Me.pixLength, Me.pixWidth)
        gr.DrawRectangle(Pen, pixX, pixY, pixLength, pixWidth)
        gr.DrawImage(m_image, pixX + boxOffsetX _
                                    , pixY + boxOffsetY _
                                    , boxSize, boxSize)
        ''draw inner parts
        Select Case Me.curRotation
            Case 0
                offsetX = pixLength \ 10
                offsetY = pixWidth \ 10
                handleL = offsetX \ 2
                handleW = offsetY \ 2

                'draw the door of the fridge
                gr.DrawLine(Pen, pixX, pixY + pixWidth - offsetY, pixX + pixLength, pixY + pixWidth - offsetY)
                'draw the handle of the door of the bridge
                gr.DrawRectangle(Pen, pixX + offsetX \ 2, pixY + pixWidth, handleL, handleW)

            Case 1
                offsetX = pixLength \ 10
                offsetY = pixWidth \ 10
                handleL = offsetX \ 2
                handleW = offsetY \ 2

                'draw the door of the fridge
                gr.DrawLine(Pen, pixX + offsetX, pixY, pixX + offsetX, pixY + pixWidth)
                'draw the handle of the door of the bridge
                gr.DrawRectangle(Pen, pixX - offsetX \ 2, pixY + offsetY \ 2, handleL, handleW)

            Case 2
                offsetX = pixLength \ 10
                offsetY = pixWidth \ 10
                handleL = offsetX \ 2
                handleW = offsetY \ 2

                'draw the door of the fridge
                gr.DrawLine(Pen, pixX, pixY + offsetY, pixX + pixLength, pixY + offsetY)
                'draw the handle of the door of the bridge
                gr.DrawRectangle(Pen, pixX + offsetX \ 2, pixY - offsetY \ 2, handleL, handleW)

            Case 3
                offsetX = pixLength \ 10
                offsetY = pixWidth \ 10
                handleL = offsetX \ 2
                handleW = offsetY \ 2

                'draw the door of the fridge
                gr.DrawLine(Pen, pixX + pixLength - offsetX, pixY, pixX + pixLength - offsetX, pixY + pixWidth)
                'draw the handle of the door of the bridge
                gr.DrawRectangle(Pen, pixX + pixLength, pixY + offsetY \ 2, handleL, handleW)

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

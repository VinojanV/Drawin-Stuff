'Vinojan Veluppilai 
'November 30th, 2015
'Line Drawing and Looping Assignment


Public Class frmLineDrawing

    Private Sub mnuFan_Click(sender As Object, e As EventArgs) Handles mnuFan.Click

        Dim formsurface As Graphics = Me.CreateGraphics
        Dim y2 As Integer

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False
        tmrZeros.Enabled = False

        'Draws fan
        For y2 = 0 To 400 Step 5
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens.Yellow, 0, 25, 400, y2)
        Next

        For y2 = 0 To 400 Step 5
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens.MediumPurple, 400, 25, 0, y2)
        Next

    End Sub

    Private Sub mnuGrid_Click(sender As Object, e As EventArgs) Handles mnuGrid.Click

        Dim formsurface As Graphics = Me.CreateGraphics
        Dim x, y As Integer

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False
        tmrZeros.Enabled = False

        'Draws grid
        For y = 0 To 400 Step 10
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens.Red, 0, y, 400, y)
        Next

        For x = 0 To 400 Step 10
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens.PaleVioletRed, x, 0, x, 400)
        Next

    End Sub

    Private Sub mnuDiamond_Click(sender As Object, e As EventArgs) Handles mnuDiamond.Click

        Dim formsurface As Graphics = Me.CreateGraphics
        Dim a, x2 As Integer
        Dim Pens(1) As System.Drawing.Pen

        'Changes colour in drawing
        Pens(0) = System.Drawing.Pens.Maroon
        Pens(1) = System.Drawing.Pens.Purple

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False
        tmrZeros.Enabled = False

        'Draws diamond
        For x2 = 0 To 400 Step 10
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens(a), 200, 25, x2, 200)

            a = a + 1

            If a = 2 Then
                a = 0
            End If

        Next

        For x2 = 0 To 400 Step 10
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens(a), 200, 400, x2, 200)
            a = a + 1

            If a = 2 Then
                a = 0
            End If

        Next

    End Sub

    Private Sub mnuHalfpipe_Click(sender As Object, e As EventArgs) Handles mnuHalfpipe.Click

        Dim formsurface As Graphics = Me.CreateGraphics
        Dim y As Integer

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False
        tmrZeros.Enabled = False

        'Draws halfpipe
        For y = 0 To 400 Step 10
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens.Magenta, 0, y, y, 400)
        Next

        For y = 0 To 400 Step 10
            System.Threading.Thread.Sleep(1)
            formsurface.DrawLine(Pens.LimeGreen, y, 400, 400, (400 - y))
        Next

    End Sub

    Private Sub mnuWing_Click(sender As Object, e As EventArgs) Handles mnuWing.Click

        Dim formsurface As Graphics = Me.CreateGraphics
        Dim a, y, x2 As Integer
        Dim Pens(2) As System.Drawing.Pen

        'Changes colour in drawing
        Pens(0) = System.Drawing.Pens.Pink
        Pens(1) = System.Drawing.Pens.Blue
        Pens(2) = System.Drawing.Pens.DeepPink

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False
        tmrZeros.Enabled = False

        'Draws wing
        For y = 25 To 95 Step 10

            For x2 = 0 To 400 Step 10
                System.Threading.Thread.Sleep(1)
                formsurface.DrawLine(Pens(a), 0, y, x2, 400)

                a = a + 1

                If a = 3 Then
                    a = 0
                End If

            Next

        Next

    End Sub

    Private Sub mnuTunnel_Click(sender As Object, e As EventArgs) Handles mnuTunnel.Click

        Dim formsurface As Graphics = Me.CreateGraphics
        Dim a, y2 As Integer
        Dim Pens(2) As System.Drawing.Pen

        'Changes colour of drawing
        Pens(0) = System.Drawing.Pens.Lavender
        Pens(1) = System.Drawing.Pens.LightYellow
        Pens(2) = System.Drawing.Pens.MediumTurquoise

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False
        tmrZeros.Enabled = False

        'Draws tunnel
        For y2 = 0 To 379 Step 10
            System.Threading.Thread.Sleep(1)
            formsurface.DrawEllipse(Pens(a), 0, 25, y2, y2)

            a = a + 1

            If a = 3 Then
                a = 0
            End If

        Next

    End Sub

    Private Sub mnuCircle_Click(sender As Object, e As EventArgs) Handles mnuCircle.Click

        Dim formsurface As Graphics = Me.CreateGraphics
        Dim x As Integer

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False
        tmrZeros.Enabled = False

        'Draws circle row
        For x = 50 To 290 Step 30
            System.Threading.Thread.Sleep(1)
            formsurface.DrawEllipse(Pens.MediumTurquoise, x, 90, 60, 60)
        Next

        For x = 50 To 290 Step 30
            System.Threading.Thread.Sleep(1)
            formsurface.DrawEllipse(Pens.MediumTurquoise, x, 270, 60, 60)
        Next
        
    End Sub

    Private Sub mnuLightning_Click(sender As Object, e As EventArgs) Handles mnuLightning.Click

        Dim formsurface As Graphics = Me.CreateGraphics

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = True
        picCloud2.Visible = True
        tmrLightning.Enabled = True
        tmrZeros.Enabled = False


    End Sub

    Private Sub tmrLightning_Tick(sender As Object, e As EventArgs) Handles tmrLightning.Tick

        Dim intCount, x, y, intRain, intRain2, intRain3, intRain4, intRain5, intRain6, intRain7, intRain8, intRain9, intRain10, intRain11, intRain12, intRain13, intRain14, intRain15, intRain16, intRain17, intRain18, intRain19, intRain20 As Integer
        Dim formsurface As Graphics = Me.CreateGraphics
        Dim myBrush As New SolidBrush(Color.Yellow)
        Dim myBrush2 As New SolidBrush(Color.LightSteelBlue)
        Dim myPen As New Pen(myBrush, 15)
        Dim myPen2 As New Pen(myBrush2, 4)

        'Variables for different rain streams
        Randomize()
        intRain = Int(Rnd() * 400 + 1)
        intRain2 = Int(Rnd() * 400 + 1)
        intRain3 = Int(Rnd() * 400 + 1)
        intRain4 = Int(Rnd() * 400 + 1)
        intRain5 = Int(Rnd() * 400 + 1)
        intRain6 = Int(Rnd() * 400 + 1)
        intRain7 = Int(Rnd() * 400 + 1)
        intRain8 = Int(Rnd() * 400 + 1)
        intRain9 = Int(Rnd() * 400 + 1)
        intRain10 = Int(Rnd() * 400 + 1)
        intRain11 = Int(Rnd() * 400 + 1)
        intRain12 = Int(Rnd() * 400 + 1)
        intRain13 = Int(Rnd() * 400 + 1)
        intRain14 = Int(Rnd() * 400 + 1)
        intRain15 = Int(Rnd() * 400 + 1)
        intRain16 = Int(Rnd() * 400 + 1)
        intRain17 = Int(Rnd() * 400 + 1)
        intRain18 = Int(Rnd() * 400 + 1)
        intRain19 = Int(Rnd() * 400 + 1)
        intRain20 = Int(Rnd() * 400 + 1)

        formsurface.Clear(Me.BackColor)
        tmrZeros.Enabled = False

        'Draws lightning and rain
        For x = 0 To 280 Step 70
            System.Threading.Thread.Sleep(300)
            formsurface.DrawBezier(myPen, (x + 40), 120, (x + 15), 220, (x + 115), 190, (x + 70), 300)
            formsurface.DrawBezier(myPen, (x + 40), 120, (x + 25), 190, (x + 135), 160, (x + 70), 300)
        Next

        For y = 10 To 400 Step 30
            System.Threading.Thread.Sleep(50)
            formsurface.DrawEllipse(myPen2, intRain, y, 4, 3)
            formsurface.DrawEllipse(myPen2, intRain2, y, 4, 3)
            formsurface.DrawEllipse(myPen2, intRain3, y, 4, 3)
            formsurface.DrawEllipse(myPen2, intRain4, y, 4, 3)
            formsurface.DrawEllipse(myPen2, intRain5, y, 4, 4)
            formsurface.DrawEllipse(myPen2, intRain6, y, 4, 4)
            formsurface.DrawEllipse(myPen2, intRain7, y, 4, 4)
            formsurface.DrawEllipse(myPen2, intRain8, y, 4, 4)
            formsurface.DrawEllipse(myPen2, intRain9, y, 4, 5)
            formsurface.DrawEllipse(myPen2, intRain10, y, 4, 5)
            formsurface.DrawEllipse(myPen2, intRain11, y, 4, 5)
            formsurface.DrawEllipse(myPen2, intRain12, y, 4, 5)
            formsurface.DrawEllipse(myPen2, intRain13, y, 4, 6)
            formsurface.DrawEllipse(myPen2, intRain14, y, 4, 6)
            formsurface.DrawEllipse(myPen2, intRain15, y, 4, 6)
            formsurface.DrawEllipse(myPen2, intRain16, y, 4, 6)
            formsurface.DrawEllipse(myPen2, intRain17, y, 4, 3)
            formsurface.DrawEllipse(myPen2, intRain18, y, 4, 4)
            formsurface.DrawEllipse(myPen2, intRain19, y, 4, 5)
            formsurface.DrawEllipse(myPen2, intRain20, y, 4, 6)
        Next

        intCount = intCount + 1
        If intCount = 2 Then
            tmrLightning.Enabled = True
            intCount = 0
        End If

        If intCount = 2 Then
            tmrLightning.Enabled = False
        End If

    End Sub

    Private Sub mnuZeros_Click(sender As Object, e As EventArgs) Handles mnuZeros.Click

        Dim formsurface As Graphics = Me.CreateGraphics

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrZeros.Enabled = True
        tmrLightning.Enabled = False

    End Sub

    Private Sub tmrZeros_Tick(sender As Object, e As EventArgs) Handles tmrZeros.Tick

        Dim intCount, x As Integer
        Dim formsurface As Graphics = Me.CreateGraphics
        Dim myBrush As New SolidBrush(Color.LightGreen)
        Dim myPen As New Pen(myBrush, 10)

        'Clears form of other drawings
        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrLightning.Enabled = False

        'Draws zeros
        For x = 0 To 400 Step 30
            System.Threading.Thread.Sleep(100)
            formsurface.DrawEllipse(myPen, x, 0, 5, 2)
            formsurface.DrawEllipse(myPen, x, 25, 5, 2)
            formsurface.DrawEllipse(myPen, x, 50, 5, 2)
            formsurface.DrawEllipse(myPen, x, 75, 5, 2)
            formsurface.DrawEllipse(myPen, x, 100, 5, 2)
            formsurface.DrawEllipse(myPen, x, 125, 5, 2)
            formsurface.DrawEllipse(myPen, x, 150, 5, 2)
            formsurface.DrawEllipse(myPen, x, 175, 5, 2)
            formsurface.DrawEllipse(myPen, x, 200, 5, 2)
            formsurface.DrawEllipse(myPen, x, 225, 5, 2)
            formsurface.DrawEllipse(myPen, x, 250, 5, 2)
            formsurface.DrawEllipse(myPen, x, 275, 5, 2)
            formsurface.DrawEllipse(myPen, x, 300, 5, 2)
            formsurface.DrawEllipse(myPen, x, 325, 5, 2)
            formsurface.DrawEllipse(myPen, x, 350, 5, 2)
            formsurface.DrawEllipse(myPen, x, 375, 5, 2)
            formsurface.DrawEllipse(myPen, x, 400, 5, 2)
        Next

        intCount = intCount + 1
        If intCount = 2 Then
            tmrLightning.Enabled = True
            intCount = 0
        End If

        If intCount = 3 Then
            tmrLightning.Enabled = False
        End If

    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Dim formsurface As Graphics = Me.CreateGraphics

        MessageBox.Show("Select a drawing on one of the two menu bars" & vbNewLine & "[Drawings or My Designs] to see a drawing.", "Instructions")

        formsurface.Clear(Me.BackColor)
        picCloud.Visible = False
        picCloud2.Visible = False
        tmrZeros.Enabled = False
        tmrLightning.Enabled = False

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Me.Close()

    End Sub

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineDrawing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineDrawing))
        Me.mnuDrawingOptions = New System.Windows.Forms.MenuStrip()
        Me.mnuMyDesign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHalfpipe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTunnel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCircle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMyDesigns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWing = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLightning = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZeros = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrLightning = New System.Windows.Forms.Timer(Me.components)
        Me.picCloud = New System.Windows.Forms.PictureBox()
        Me.picCloud2 = New System.Windows.Forms.PictureBox()
        Me.tmrZeros = New System.Windows.Forms.Timer(Me.components)
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDrawingOptions.SuspendLayout()
        CType(Me.picCloud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCloud2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuDrawingOptions
        '
        Me.mnuDrawingOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMyDesign, Me.mnuMyDesigns, Me.mnuHelp, Me.mnuExit})
        Me.mnuDrawingOptions.Location = New System.Drawing.Point(0, 0)
        Me.mnuDrawingOptions.Name = "mnuDrawingOptions"
        Me.mnuDrawingOptions.Size = New System.Drawing.Size(401, 24)
        Me.mnuDrawingOptions.TabIndex = 0
        '
        'mnuMyDesign
        '
        Me.mnuMyDesign.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFan, Me.mnuGrid, Me.mnuDiamond, Me.mnuHalfpipe, Me.mnuTunnel, Me.mnuCircle})
        Me.mnuMyDesign.Name = "mnuMyDesign"
        Me.mnuMyDesign.Size = New System.Drawing.Size(68, 20)
        Me.mnuMyDesign.Text = "Drawings"
        '
        'mnuFan
        '
        Me.mnuFan.Name = "mnuFan"
        Me.mnuFan.Size = New System.Drawing.Size(130, 22)
        Me.mnuFan.Text = "Fan"
        '
        'mnuGrid
        '
        Me.mnuGrid.Name = "mnuGrid"
        Me.mnuGrid.Size = New System.Drawing.Size(130, 22)
        Me.mnuGrid.Text = "Grid"
        '
        'mnuDiamond
        '
        Me.mnuDiamond.Name = "mnuDiamond"
        Me.mnuDiamond.Size = New System.Drawing.Size(130, 22)
        Me.mnuDiamond.Text = "Diamond"
        '
        'mnuHalfpipe
        '
        Me.mnuHalfpipe.Name = "mnuHalfpipe"
        Me.mnuHalfpipe.Size = New System.Drawing.Size(130, 22)
        Me.mnuHalfpipe.Text = "Halfpipe"
        '
        'mnuTunnel
        '
        Me.mnuTunnel.Name = "mnuTunnel"
        Me.mnuTunnel.Size = New System.Drawing.Size(130, 22)
        Me.mnuTunnel.Text = "Tunnel"
        '
        'mnuCircle
        '
        Me.mnuCircle.Name = "mnuCircle"
        Me.mnuCircle.Size = New System.Drawing.Size(130, 22)
        Me.mnuCircle.Text = "Circle Row"
        '
        'mnuMyDesigns
        '
        Me.mnuMyDesigns.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWing, Me.mnuLightning, Me.mnuZeros})
        Me.mnuMyDesigns.Name = "mnuMyDesigns"
        Me.mnuMyDesigns.Size = New System.Drawing.Size(80, 20)
        Me.mnuMyDesigns.Text = "My Designs"
        '
        'mnuWing
        '
        Me.mnuWing.Name = "mnuWing"
        Me.mnuWing.Size = New System.Drawing.Size(152, 22)
        Me.mnuWing.Text = "Wing"
        '
        'mnuLightning
        '
        Me.mnuLightning.Name = "mnuLightning"
        Me.mnuLightning.Size = New System.Drawing.Size(152, 22)
        Me.mnuLightning.Text = "Lightning"
        '
        'mnuZeros
        '
        Me.mnuZeros.Name = "mnuZeros"
        Me.mnuZeros.Size = New System.Drawing.Size(152, 22)
        Me.mnuZeros.Text = "Zeros"
        '
        'tmrLightning
        '
        Me.tmrLightning.Interval = 1000
        '
        'picCloud
        '
        Me.picCloud.BackColor = System.Drawing.SystemColors.WindowText
        Me.picCloud.Image = CType(resources.GetObject("picCloud.Image"), System.Drawing.Image)
        Me.picCloud.Location = New System.Drawing.Point(253, 27)
        Me.picCloud.Name = "picCloud"
        Me.picCloud.Size = New System.Drawing.Size(148, 94)
        Me.picCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCloud.TabIndex = 1
        Me.picCloud.TabStop = False
        Me.picCloud.Visible = False
        '
        'picCloud2
        '
        Me.picCloud2.Image = CType(resources.GetObject("picCloud2.Image"), System.Drawing.Image)
        Me.picCloud2.Location = New System.Drawing.Point(0, 27)
        Me.picCloud2.Name = "picCloud2"
        Me.picCloud2.Size = New System.Drawing.Size(255, 82)
        Me.picCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCloud2.TabIndex = 2
        Me.picCloud2.TabStop = False
        Me.picCloud2.Visible = False
        '
        'tmrZeros
        '
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'frmLineDrawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(401, 402)
        Me.Controls.Add(Me.picCloud2)
        Me.Controls.Add(Me.picCloud)
        Me.Controls.Add(Me.mnuDrawingOptions)
        Me.MainMenuStrip = Me.mnuDrawingOptions
        Me.Name = "frmLineDrawing"
        Me.Text = "Line Drawing"
        Me.mnuDrawingOptions.ResumeLayout(False)
        Me.mnuDrawingOptions.PerformLayout()
        CType(Me.picCloud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCloud2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuDrawingOptions As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMyDesign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGrid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHalfpipe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTunnel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCircle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMyDesigns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLightning As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrLightning As System.Windows.Forms.Timer
    Friend WithEvents picCloud As System.Windows.Forms.PictureBox
    Friend WithEvents picCloud2 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuZeros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrZeros As System.Windows.Forms.Timer
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class

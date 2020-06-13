<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblStatistics = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.pieJobTitles = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pieGenders = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlHeader.SuspendLayout
        CType(Me.pieJobTitles,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pieGenders,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblMinimize)
        Me.pnlHeader.Controls.Add(Me.lblStatistics)
        Me.pnlHeader.Controls.Add(Me.lblClose)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(700, 80)
        Me.pnlHeader.TabIndex = 2
        '
        'lblMinimize
        '
        Me.lblMinimize.AutoSize = true
        Me.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(620, 9)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(28, 38)
        Me.lblMinimize.TabIndex = 0
        Me.lblMinimize.Text = "-"
        '
        'lblStatistics
        '
        Me.lblStatistics.AutoSize = true
        Me.lblStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStatistics.ForeColor = System.Drawing.Color.Black
        Me.lblStatistics.Location = New System.Drawing.Point(255, 17)
        Me.lblStatistics.Name = "lblStatistics"
        Me.lblStatistics.Size = New System.Drawing.Size(191, 46)
        Me.lblStatistics.TabIndex = 0
        Me.lblStatistics.Text = "Statistics"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = true
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblClose.Location = New System.Drawing.Point(654, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(34, 38)
        Me.lblClose.TabIndex = 0
        Me.lblClose.Text = "x"
        '
        'pieJobTitles
        '
        Me.pieJobTitles.BackColor = System.Drawing.SystemColors.Control
        ChartArea3.BackColor = System.Drawing.SystemColors.Control
        ChartArea3.Name = "ChartArea1"
        Me.pieJobTitles.ChartAreas.Add(ChartArea3)
        Me.pieJobTitles.Enabled = false
        Legend3.BackColor = System.Drawing.SystemColors.Control
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Legend3.IsTextAutoFit = false
        Legend3.Name = "Legend"
        Me.pieJobTitles.Legends.Add(Legend3)
        Me.pieJobTitles.Location = New System.Drawing.Point(0, 80)
        Me.pieJobTitles.Name = "pieJobTitles"
        Me.pieJobTitles.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.pieJobTitles.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.RoyalBlue, System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(87,Byte),Integer)), System.Drawing.Color.Gold, System.Drawing.Color.DarkOrange, System.Drawing.Color.Red}
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Series3.Legend = "Legend"
        Series3.Name = "jobTitles"
        Me.pieJobTitles.Series.Add(Series3)
        Me.pieJobTitles.Size = New System.Drawing.Size(700, 440)
        Me.pieJobTitles.TabIndex = 3
        Me.pieJobTitles.Text = "Job Titles"
        '
        'pieGenders
        '
        Me.pieGenders.BackColor = System.Drawing.SystemColors.Control
        ChartArea4.BackColor = System.Drawing.SystemColors.Control
        ChartArea4.Name = "ChartArea1"
        Me.pieGenders.ChartAreas.Add(ChartArea4)
        Me.pieGenders.Enabled = false
        Legend4.BackColor = System.Drawing.SystemColors.Control
        Legend4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Legend4.IsTextAutoFit = false
        Legend4.Name = "Legend"
        Me.pieGenders.Legends.Add(Legend4)
        Me.pieGenders.Location = New System.Drawing.Point(381, 230)
        Me.pieGenders.Name = "pieGenders"
        Me.pieGenders.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.pieGenders.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.RoyalBlue, System.Drawing.Color.DeepPink}
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Series4.IsVisibleInLegend = false
        Series4.Legend = "Legend"
        Series4.Name = "genders"
        Me.pieGenders.Series.Add(Series4)
        Me.pieGenders.Size = New System.Drawing.Size(290, 290)
        Me.pieGenders.TabIndex = 3
        Me.pieGenders.Text = "Job Titles"
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 519)
        Me.Controls.Add(Me.pieGenders)
        Me.Controls.Add(Me.pieJobTitles)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.Name = "Statistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics"
        Me.pnlHeader.ResumeLayout(false)
        Me.pnlHeader.PerformLayout
        CType(Me.pieJobTitles,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pieGenders,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblStatistics As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents pieJobTitles As DataVisualization.Charting.Chart
    Friend WithEvents pieGenders As DataVisualization.Charting.Chart
End Class

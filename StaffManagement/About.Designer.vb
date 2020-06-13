<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblMcDonaldsManagementSystem = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.lblMcDonalds = New System.Windows.Forms.Label()
        Me.picMcDonaldsLogo = New System.Windows.Forms.PictureBox()
        Me.pnlSideHeader = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout
        Me.pnlSide.SuspendLayout
        CType(Me.picMcDonaldsLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblMinimize)
        Me.pnlHeader.Controls.Add(Me.lblAbout)
        Me.pnlHeader.Controls.Add(Me.lblClose)
        Me.pnlHeader.Location = New System.Drawing.Point(180, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(540, 80)
        Me.pnlHeader.TabIndex = 2
        '
        'lblMinimize
        '
        Me.lblMinimize.AutoSize = true
        Me.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(460, 9)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(28, 38)
        Me.lblMinimize.TabIndex = 0
        Me.lblMinimize.Text = "-"
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = true
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.Black
        Me.lblAbout.Location = New System.Drawing.Point(205, 17)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(130, 46)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = "About"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = true
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblClose.Location = New System.Drawing.Point(494, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(34, 38)
        Me.lblClose.TabIndex = 0
        Me.lblClose.Text = "x"
        '
        'lblMcDonaldsManagementSystem
        '
        Me.lblMcDonaldsManagementSystem.AutoSize = true
        Me.lblMcDonaldsManagementSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMcDonaldsManagementSystem.Location = New System.Drawing.Point(207, 109)
        Me.lblMcDonaldsManagementSystem.Name = "lblMcDonaldsManagementSystem"
        Me.lblMcDonaldsManagementSystem.Size = New System.Drawing.Size(334, 25)
        Me.lblMcDonaldsManagementSystem.TabIndex = 3
        Me.lblMcDonaldsManagementSystem.Text = "McDonald's Management System"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = true
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVersion.Location = New System.Drawing.Point(207, 158)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(158, 25)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Version 1.0.0.0"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = true
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(207, 207)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(349, 25)
        Me.lblCopyright.TabIndex = 3
        Me.lblCopyright.Text = "Copyright © 2019 Dennis Heijmans"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescription.Enabled = false
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescription.Location = New System.Drawing.Point(207, 256)
        Me.txtDescription.Multiline = true
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = true
        Me.txtDescription.Size = New System.Drawing.Size(484, 66)
        Me.txtDescription.TabIndex = 4
        Me.txtDescription.Text = "McDonald's management System is an application you can use to store and manage yo"& _ 
    "ur employees."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(174,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.pnlSide.Controls.Add(Me.lblMcDonalds)
        Me.pnlSide.Controls.Add(Me.picMcDonaldsLogo)
        Me.pnlSide.Controls.Add(Me.pnlSideHeader)
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(180, 350)
        Me.pnlSide.TabIndex = 5
        '
        'lblMcDonalds
        '
        Me.lblMcDonalds.AutoSize = true
        Me.lblMcDonalds.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMcDonalds.ForeColor = System.Drawing.Color.White
        Me.lblMcDonalds.Location = New System.Drawing.Point(16, 245)
        Me.lblMcDonalds.Name = "lblMcDonalds"
        Me.lblMcDonalds.Size = New System.Drawing.Size(148, 29)
        Me.lblMcDonalds.TabIndex = 0
        Me.lblMcDonalds.Text = "McDonald's"
        '
        'picMcDonaldsLogo
        '
        Me.picMcDonaldsLogo.Image = Global.StaffManagement.My.Resources.Resources.McDonaldsLogo
        Me.picMcDonaldsLogo.Location = New System.Drawing.Point(35, 138)
        Me.picMcDonaldsLogo.Name = "picMcDonaldsLogo"
        Me.picMcDonaldsLogo.Size = New System.Drawing.Size(110, 104)
        Me.picMcDonaldsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMcDonaldsLogo.TabIndex = 3
        Me.picMcDonaldsLogo.TabStop = false
        '
        'pnlSideHeader
        '
        Me.pnlSideHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(41,Byte),Integer), CType(CType(28,Byte),Integer))
        Me.pnlSideHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideHeader.Name = "pnlSideHeader"
        Me.pnlSideHeader.Size = New System.Drawing.Size(180, 80)
        Me.pnlSideHeader.TabIndex = 1
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 350)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblMcDonaldsManagementSystem)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.pnlHeader.ResumeLayout(false)
        Me.pnlHeader.PerformLayout
        Me.pnlSide.ResumeLayout(false)
        Me.pnlSide.PerformLayout
        CType(Me.picMcDonaldsLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblMcDonaldsManagementSystem As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents pnlSide As Panel
    Friend WithEvents picMcDonaldsLogo As PictureBox
    Friend WithEvents pnlSideHeader As Panel
    Friend WithEvents lblMcDonalds As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnLoadAll = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnImportData = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.lblInportDataButton = New System.Windows.Forms.Label()
        Me.picImportData = New System.Windows.Forms.PictureBox()
        Me.lblImportDataImage = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.lblLoadAll = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.vscMainPanel = New System.Windows.Forms.VScrollBar()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout
        CType(Me.picImportData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblMinimize)
        Me.pnlHeader.Controls.Add(Me.lblHelp)
        Me.pnlHeader.Controls.Add(Me.lblClose)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(640, 80)
        Me.pnlHeader.TabIndex = 1
        '
        'lblMinimize
        '
        Me.lblMinimize.AutoSize = true
        Me.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(560, 9)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(28, 38)
        Me.lblMinimize.TabIndex = 0
        Me.lblMinimize.Text = "-"
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = true
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.Black
        Me.lblHelp.Location = New System.Drawing.Point(267, 17)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(106, 46)
        Me.lblHelp.TabIndex = 0
        Me.lblHelp.Text = "Help"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = true
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblClose.Location = New System.Drawing.Point(594, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(34, 38)
        Me.lblClose.TabIndex = 0
        Me.lblClose.Text = "x"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Location = New System.Drawing.Point(314, 598)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(200, 56)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = false
        '
        'btnLoadAll
        '
        Me.btnLoadAll.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLoadAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLoadAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnLoadAll.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLoadAll.Location = New System.Drawing.Point(18, 787)
        Me.btnLoadAll.Name = "btnLoadAll"
        Me.btnLoadAll.Size = New System.Drawing.Size(200, 56)
        Me.btnLoadAll.TabIndex = 12
        Me.btnLoadAll.Text = "Load All"
        Me.btnLoadAll.UseVisualStyleBackColor = false
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(18, 902)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 56)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = false
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Location = New System.Drawing.Point(18, 1030)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(200, 56)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = false
        '
        'btnImportData
        '
        Me.btnImportData.BackColor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.btnImportData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImportData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnImportData.ForeColor = System.Drawing.SystemColors.Control
        Me.btnImportData.Location = New System.Drawing.Point(18, 42)
        Me.btnImportData.Name = "btnImportData"
        Me.btnImportData.Size = New System.Drawing.Size(200, 56)
        Me.btnImportData.TabIndex = 13
        Me.btnImportData.Text = "Import Data"
        Me.btnImportData.UseVisualStyleBackColor = false
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(174,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31,Byte),Integer), CType(CType(43,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.btnAddEmployee.FlatAppearance.BorderSize = 0
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmployee.Location = New System.Drawing.Point(60, 598)
        Me.btnAddEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(200, 56)
        Me.btnAddEmployee.TabIndex = 14
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = false
        '
        'lblInportDataButton
        '
        Me.lblInportDataButton.AutoSize = true
        Me.lblInportDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInportDataButton.Location = New System.Drawing.Point(243, 33)
        Me.lblInportDataButton.Name = "lblInportDataButton"
        Me.lblInportDataButton.Size = New System.Drawing.Size(300, 75)
        Me.lblInportDataButton.TabIndex = 15
        Me.lblInportDataButton.Text = "If you click on the 'Import Data' "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"button, a window will open where "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"you can se"& _ 
    "lect your database file."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picImportData
        '
        Me.picImportData.Image = Global.StaffManagement.My.Resources.Resources.ImportData
        Me.picImportData.Location = New System.Drawing.Point(18, 136)
        Me.picImportData.Name = "picImportData"
        Me.picImportData.Size = New System.Drawing.Size(538, 338)
        Me.picImportData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImportData.TabIndex = 16
        Me.picImportData.TabStop = false
        '
        'lblImportDataImage
        '
        Me.lblImportDataImage.AutoSize = true
        Me.lblImportDataImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblImportDataImage.Location = New System.Drawing.Point(100, 488)
        Me.lblImportDataImage.Name = "lblImportDataImage"
        Me.lblImportDataImage.Size = New System.Drawing.Size(374, 75)
        Me.lblImportDataImage.TabIndex = 17
        Me.lblImportDataImage.Text = "You have to open the database file called "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"""McDonaldsManagementSystem.mbd"". "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Th"& _ 
    "is file is located in the solution directory."
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = true
        Me.lblEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(97, 672)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(375, 75)
        Me.lblEmployee.TabIndex = 15
        Me.lblEmployee.Text = "If you click on the 'Add Employee' or 'Edit' "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"button, a window will op where you"& _ 
    " can "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"add or edit an employee."
        '
        'lblLoadAll
        '
        Me.lblLoadAll.AutoSize = true
        Me.lblLoadAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLoadAll.Location = New System.Drawing.Point(240, 778)
        Me.lblLoadAll.Name = "lblLoadAll"
        Me.lblLoadAll.Size = New System.Drawing.Size(311, 75)
        Me.lblLoadAll.TabIndex = 15
        Me.lblLoadAll.Text = "If you click on the'Load all'  button, "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"all the data from the database will "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"be"& _ 
    " shown in the table."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = true
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSearch.Location = New System.Drawing.Point(243, 1008)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(313, 100)
        Me.lblSearch.TabIndex = 15
        Me.lblSearch.Text = "If you click on the 'Search' button, "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"there will be searched in the "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"database f"& _ 
    "or search and its results "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"will be shown in the table."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = true
        Me.lblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDelete.Location = New System.Drawing.Point(243, 893)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(299, 75)
        Me.lblDelete.TabIndex = 15
        Me.lblDelete.Text = "If you click on the 'Delete' button, "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"the employee who's selected will "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"be dele"& _ 
    "ted from the database."
        '
        'vscMainPanel
        '
        Me.vscMainPanel.Location = New System.Drawing.Point(615, 80)
        Me.vscMainPanel.Name = "vscMainPanel"
        Me.vscMainPanel.Size = New System.Drawing.Size(25, 480)
        Me.vscMainPanel.TabIndex = 18
        Me.vscMainPanel.Value = 100
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.btnImportData)
        Me.pnlMain.Controls.Add(Me.btnSearch)
        Me.pnlMain.Controls.Add(Me.lblImportDataImage)
        Me.pnlMain.Controls.Add(Me.lblLoadAll)
        Me.pnlMain.Controls.Add(Me.btnEdit)
        Me.pnlMain.Controls.Add(Me.lblDelete)
        Me.pnlMain.Controls.Add(Me.lblEmployee)
        Me.pnlMain.Controls.Add(Me.btnDelete)
        Me.pnlMain.Controls.Add(Me.btnAddEmployee)
        Me.pnlMain.Controls.Add(Me.btnLoadAll)
        Me.pnlMain.Controls.Add(Me.picImportData)
        Me.pnlMain.Controls.Add(Me.lblSearch)
        Me.pnlMain.Controls.Add(Me.lblInportDataButton)
        Me.pnlMain.Location = New System.Drawing.Point(20, 80)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(575, 1142)
        Me.pnlMain.TabIndex = 19
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 560)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.vscMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.Name = "Help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.pnlHeader.ResumeLayout(false)
        Me.pnlHeader.PerformLayout
        CType(Me.picImportData,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlMain.ResumeLayout(false)
        Me.pnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblHelp As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnLoadAll As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnImportData As Button
    Friend WithEvents lblInportDataButton As Label
    Friend WithEvents picImportData As PictureBox
    Friend WithEvents lblImportDataImage As Label
    Friend WithEvents lblEmployee As Label
    Friend WithEvents lblLoadAll As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblDelete As Label
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents vscMainPanel As VScrollBar
    Friend WithEvents pnlMain As Panel
End Class

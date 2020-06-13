<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblStaffDetails = New System.Windows.Forms.Label()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.picMcDonaldsLogo = New System.Windows.Forms.PictureBox()
        Me.lblMcDonalds = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.txtSearchSalary = New System.Windows.Forms.TextBox()
        Me.cmbSearchJobTitle = New System.Windows.Forms.ComboBox()
        Me.dtpSearch = New System.Windows.Forms.DateTimePicker()
        Me.rdoSearchFemale = New System.Windows.Forms.RadioButton()
        Me.rdoSearchMale = New System.Windows.Forms.RadioButton()
        Me.lblImportData = New System.Windows.Forms.Label()
        Me.lblSearchIn = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbTypes = New System.Windows.Forms.ComboBox()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnLoadAll = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnImportData = New System.Windows.Forms.Button()
        Me.lblSearchEuro = New System.Windows.Forms.Label()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnViewStatistics = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout
        Me.pnlLogo.SuspendLayout
        CType(Me.picMcDonaldsLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlMain.SuspendLayout
        CType(Me.dgvStaff,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlSide.SuspendLayout
        Me.SuspendLayout
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblMinimize)
        Me.pnlHeader.Controls.Add(Me.lblClose)
        Me.pnlHeader.Controls.Add(Me.lblStaffDetails)
        Me.pnlHeader.Location = New System.Drawing.Point(280, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 80)
        Me.pnlHeader.TabIndex = 0
        '
        'lblMinimize
        '
        Me.lblMinimize.AutoSize = true
        Me.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(920, 9)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(28, 38)
        Me.lblMinimize.TabIndex = 0
        Me.lblMinimize.Text = "-"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = true
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblClose.Location = New System.Drawing.Point(954, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(34, 38)
        Me.lblClose.TabIndex = 0
        Me.lblClose.Text = "x"
        '
        'lblStaffDetails
        '
        Me.lblStaffDetails.AutoSize = true
        Me.lblStaffDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStaffDetails.ForeColor = System.Drawing.Color.Black
        Me.lblStaffDetails.Location = New System.Drawing.Point(376, 17)
        Me.lblStaffDetails.Name = "lblStaffDetails"
        Me.lblStaffDetails.Size = New System.Drawing.Size(248, 46)
        Me.lblStaffDetails.TabIndex = 0
        Me.lblStaffDetails.Text = "Staff Details"
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(41,Byte),Integer), CType(CType(28,Byte),Integer))
        Me.pnlLogo.Controls.Add(Me.picMcDonaldsLogo)
        Me.pnlLogo.Controls.Add(Me.lblMcDonalds)
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(280, 80)
        Me.pnlLogo.TabIndex = 0
        '
        'picMcDonaldsLogo
        '
        Me.picMcDonaldsLogo.Image = Global.StaffManagement.My.Resources.Resources.McDonaldsLogo
        Me.picMcDonaldsLogo.Location = New System.Drawing.Point(22, 0)
        Me.picMcDonaldsLogo.Name = "picMcDonaldsLogo"
        Me.picMcDonaldsLogo.Size = New System.Drawing.Size(80, 80)
        Me.picMcDonaldsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMcDonaldsLogo.TabIndex = 3
        Me.picMcDonaldsLogo.TabStop = false
        '
        'lblMcDonalds
        '
        Me.lblMcDonalds.AutoSize = true
        Me.lblMcDonalds.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMcDonalds.ForeColor = System.Drawing.Color.White
        Me.lblMcDonalds.Location = New System.Drawing.Point(107, 26)
        Me.lblMcDonalds.Name = "lblMcDonalds"
        Me.lblMcDonalds.Size = New System.Drawing.Size(148, 29)
        Me.lblMcDonalds.TabIndex = 0
        Me.lblMcDonalds.Text = "McDonald's"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtSearchSalary)
        Me.pnlMain.Controls.Add(Me.cmbSearchJobTitle)
        Me.pnlMain.Controls.Add(Me.dtpSearch)
        Me.pnlMain.Controls.Add(Me.rdoSearchFemale)
        Me.pnlMain.Controls.Add(Me.rdoSearchMale)
        Me.pnlMain.Controls.Add(Me.lblImportData)
        Me.pnlMain.Controls.Add(Me.lblSearchIn)
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Controls.Add(Me.cmbTypes)
        Me.pnlMain.Controls.Add(Me.dgvStaff)
        Me.pnlMain.Controls.Add(Me.btnEdit)
        Me.pnlMain.Controls.Add(Me.btnLoadAll)
        Me.pnlMain.Controls.Add(Me.btnDelete)
        Me.pnlMain.Controls.Add(Me.btnSearch)
        Me.pnlMain.Controls.Add(Me.btnImportData)
        Me.pnlMain.Controls.Add(Me.lblSearchEuro)
        Me.pnlMain.Location = New System.Drawing.Point(280, 80)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1000, 640)
        Me.pnlMain.TabIndex = 0
        '
        'txtSearchSalary
        '
        Me.txtSearchSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSearchSalary.Location = New System.Drawing.Point(487, 25)
        Me.txtSearchSalary.MaxLength = 10
        Me.txtSearchSalary.Name = "txtSearchSalary"
        Me.txtSearchSalary.Size = New System.Drawing.Size(259, 30)
        Me.txtSearchSalary.TabIndex = 2
        Me.txtSearchSalary.Visible = false
        '
        'cmbSearchJobTitle
        '
        Me.cmbSearchJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchJobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmbSearchJobTitle.FormattingEnabled = true
        Me.cmbSearchJobTitle.Items.AddRange(New Object() {"Crew member", "Crew trainer", "Manager", "Department manager", "Restaurant manager"})
        Me.cmbSearchJobTitle.Location = New System.Drawing.Point(471, 24)
        Me.cmbSearchJobTitle.Name = "cmbSearchJobTitle"
        Me.cmbSearchJobTitle.Size = New System.Drawing.Size(275, 33)
        Me.cmbSearchJobTitle.TabIndex = 2
        Me.cmbSearchJobTitle.Visible = false
        '
        'dtpSearch
        '
        Me.dtpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtpSearch.Location = New System.Drawing.Point(471, 25)
        Me.dtpSearch.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpSearch.Name = "dtpSearch"
        Me.dtpSearch.Size = New System.Drawing.Size(275, 30)
        Me.dtpSearch.TabIndex = 2
        Me.dtpSearch.Visible = false
        '
        'rdoSearchFemale
        '
        Me.rdoSearchFemale.AutoSize = true
        Me.rdoSearchFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdoSearchFemale.Location = New System.Drawing.Point(626, 26)
        Me.rdoSearchFemale.Name = "rdoSearchFemale"
        Me.rdoSearchFemale.Size = New System.Drawing.Size(98, 29)
        Me.rdoSearchFemale.TabIndex = 3
        Me.rdoSearchFemale.TabStop = true
        Me.rdoSearchFemale.Text = "Female"
        Me.rdoSearchFemale.UseVisualStyleBackColor = true
        Me.rdoSearchFemale.Visible = false
        '
        'rdoSearchMale
        '
        Me.rdoSearchMale.AutoSize = true
        Me.rdoSearchMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdoSearchMale.Location = New System.Drawing.Point(494, 26)
        Me.rdoSearchMale.Name = "rdoSearchMale"
        Me.rdoSearchMale.Size = New System.Drawing.Size(76, 29)
        Me.rdoSearchMale.TabIndex = 2
        Me.rdoSearchMale.TabStop = true
        Me.rdoSearchMale.Text = "Male"
        Me.rdoSearchMale.UseVisualStyleBackColor = true
        Me.rdoSearchMale.Visible = false
        '
        'lblImportData
        '
        Me.lblImportData.AutoSize = true
        Me.lblImportData.BackColor = System.Drawing.Color.LightGray
        Me.lblImportData.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblImportData.Location = New System.Drawing.Point(211, 305)
        Me.lblImportData.Name = "lblImportData"
        Me.lblImportData.Size = New System.Drawing.Size(578, 29)
        Me.lblImportData.TabIndex = 4
        Me.lblImportData.Text = "Click on 'Import Data' to select your database file"
        '
        'lblSearchIn
        '
        Me.lblSearchIn.AutoSize = true
        Me.lblSearchIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSearchIn.Location = New System.Drawing.Point(21, 28)
        Me.lblSearchIn.Name = "lblSearchIn"
        Me.lblSearchIn.Size = New System.Drawing.Size(111, 25)
        Me.lblSearchIn.TabIndex = 4
        Me.lblSearchIn.Text = "Search in:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSearch.Location = New System.Drawing.Point(471, 25)
        Me.txtSearch.MaxLength = 40
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(275, 30)
        Me.txtSearch.TabIndex = 2
        '
        'cmbTypes
        '
        Me.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmbTypes.FormattingEnabled = true
        Me.cmbTypes.Items.AddRange(New Object() {"Id", "Firstname", "Lastname", "Gender", "Birthdate", "Email", "Phone", "HireDate", "JobTitle", "Salary"})
        Me.cmbTypes.Location = New System.Drawing.Point(164, 24)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.Size = New System.Drawing.Size(275, 33)
        Me.cmbTypes.TabIndex = 1
        '
        'dgvStaff
        '
        Me.dgvStaff.AllowUserToAddRows = false
        Me.dgvStaff.AllowUserToDeleteRows = false
        Me.dgvStaff.AllowUserToResizeColumns = false
        Me.dgvStaff.AllowUserToResizeRows = false
        Me.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(0, 79)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ReadOnly = true
        Me.dgvStaff.RowHeadersWidth = 51
        Me.dgvStaff.RowTemplate.Height = 24
        Me.dgvStaff.Size = New System.Drawing.Size(1000, 481)
        Me.dgvStaff.TabIndex = 0
        Me.dgvStaff.TabStop = false
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Location = New System.Drawing.Point(288, 572)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(200, 56)
        Me.btnEdit.TabIndex = 6
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
        Me.btnLoadAll.Location = New System.Drawing.Point(518, 572)
        Me.btnLoadAll.Name = "btnLoadAll"
        Me.btnLoadAll.Size = New System.Drawing.Size(200, 56)
        Me.btnLoadAll.TabIndex = 7
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
        Me.btnDelete.Location = New System.Drawing.Point(58, 572)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 56)
        Me.btnDelete.TabIndex = 5
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
        Me.btnSearch.Location = New System.Drawing.Point(778, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(200, 56)
        Me.btnSearch.TabIndex = 4
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
        Me.btnImportData.Location = New System.Drawing.Point(748, 572)
        Me.btnImportData.Name = "btnImportData"
        Me.btnImportData.Size = New System.Drawing.Size(200, 56)
        Me.btnImportData.TabIndex = 8
        Me.btnImportData.Text = "Import Data"
        Me.btnImportData.UseVisualStyleBackColor = false
        '
        'lblSearchEuro
        '
        Me.lblSearchEuro.AutoSize = true
        Me.lblSearchEuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSearchEuro.Location = New System.Drawing.Point(466, 29)
        Me.lblSearchEuro.Name = "lblSearchEuro"
        Me.lblSearchEuro.Size = New System.Drawing.Size(23, 25)
        Me.lblSearchEuro.TabIndex = 0
        Me.lblSearchEuro.Text = "€"
        Me.lblSearchEuro.Visible = false
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(174,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.pnlSide.Controls.Add(Me.btnAbout)
        Me.pnlSide.Controls.Add(Me.btnHelp)
        Me.pnlSide.Controls.Add(Me.btnViewStatistics)
        Me.pnlSide.Controls.Add(Me.btnAddEmployee)
        Me.pnlSide.Controls.Add(Me.pnlLogo)
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(280, 720)
        Me.pnlSide.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(174,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31,Byte),Integer), CType(CType(43,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 640)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(280, 56)
        Me.btnAbout.TabIndex = 12
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = false
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(174,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31,Byte),Integer), CType(CType(43,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 584)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(280, 56)
        Me.btnHelp.TabIndex = 11
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = false
        '
        'btnViewStatistics
        '
        Me.btnViewStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(174,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(22,Byte),Integer))
        Me.btnViewStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewStatistics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31,Byte),Integer), CType(CType(43,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.btnViewStatistics.FlatAppearance.BorderSize = 0
        Me.btnViewStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnViewStatistics.ForeColor = System.Drawing.Color.White
        Me.btnViewStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewStatistics.Location = New System.Drawing.Point(0, 136)
        Me.btnViewStatistics.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewStatistics.Name = "btnViewStatistics"
        Me.btnViewStatistics.Size = New System.Drawing.Size(280, 56)
        Me.btnViewStatistics.TabIndex = 10
        Me.btnViewStatistics.Text = "View Statistics"
        Me.btnViewStatistics.UseVisualStyleBackColor = false
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
        Me.btnAddEmployee.Location = New System.Drawing.Point(0, 80)
        Me.btnAddEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(280, 56)
        Me.btnAddEmployee.TabIndex = 9
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = false
        '
        'StaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.Name = "StaffDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Details"
        Me.pnlHeader.ResumeLayout(false)
        Me.pnlHeader.PerformLayout
        Me.pnlLogo.ResumeLayout(false)
        Me.pnlLogo.PerformLayout
        CType(Me.picMcDonaldsLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlMain.ResumeLayout(false)
        Me.pnlMain.PerformLayout
        CType(Me.dgvStaff,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlSide.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblStaffDetails As Label
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblMcDonalds As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlSide As Panel
    Friend WithEvents picMcDonaldsLogo As PictureBox
    Friend WithEvents btnImportData As Button
    Friend WithEvents dgvStaff As DataGridView
    Private WithEvents btnAddEmployee As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLoadAll As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbTypes As ComboBox
    Friend WithEvents lblSearchIn As Label
    Private WithEvents btnAbout As Button
    Private WithEvents btnHelp As Button
    Friend WithEvents lblImportData As Label
    Friend WithEvents rdoSearchFemale As RadioButton
    Friend WithEvents rdoSearchMale As RadioButton
    Friend WithEvents dtpSearch As DateTimePicker
    Friend WithEvents cmbSearchJobTitle As ComboBox
    Friend WithEvents txtSearchSalary As TextBox
    Friend WithEvents lblSearchEuro As Label
    Private WithEvents btnViewStatistics As Button
End Class

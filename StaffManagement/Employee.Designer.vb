<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblHireDate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.cmbJobTitle = New System.Windows.Forms.ComboBox()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout
        Me.SuspendLayout
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblMinimize)
        Me.pnlHeader.Controls.Add(Me.lblEmployee)
        Me.pnlHeader.Controls.Add(Me.lblClose)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
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
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = true
        Me.lblEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEmployee.ForeColor = System.Drawing.Color.Black
        Me.lblEmployee.Location = New System.Drawing.Point(397, 17)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(206, 46)
        Me.lblEmployee.TabIndex = 0
        Me.lblEmployee.Text = "Employee"
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
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = true
        Me.lblFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(47, 112)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(107, 25)
        Me.lblFirstname.TabIndex = 0
        Me.lblFirstname.Text = "Firstname"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(202, 109)
        Me.txtFirstname.MaxLength = 20
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(275, 30)
        Me.txtFirstname.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPhone.Location = New System.Drawing.Point(680, 109)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(275, 30)
        Me.txtPhone.TabIndex = 7
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = true
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPhone.Location = New System.Drawing.Point(525, 112)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(74, 25)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Phone"
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtLastname.Location = New System.Drawing.Point(202, 158)
        Me.txtLastname.MaxLength = 20
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(275, 30)
        Me.txtLastname.TabIndex = 2
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = true
        Me.lblLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLastname.Location = New System.Drawing.Point(47, 161)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(106, 25)
        Me.lblLastname.TabIndex = 0
        Me.lblLastname.Text = "Lastname"
        '
        'lblHireDate
        '
        Me.lblHireDate.AutoSize = true
        Me.lblHireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblHireDate.Location = New System.Drawing.Point(525, 161)
        Me.lblHireDate.Name = "lblHireDate"
        Me.lblHireDate.Size = New System.Drawing.Size(102, 25)
        Me.lblHireDate.TabIndex = 0
        Me.lblHireDate.Text = "Hire Date"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = true
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGender.Location = New System.Drawing.Point(47, 210)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(83, 25)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender"
        '
        'lblJobTitle
        '
        Me.lblJobTitle.AutoSize = true
        Me.lblJobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblJobTitle.Location = New System.Drawing.Point(525, 210)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(96, 25)
        Me.lblJobTitle.TabIndex = 0
        Me.lblJobTitle.Text = "Job Title"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSalary.Location = New System.Drawing.Point(696, 256)
        Me.txtSalary.MaxLength = 10
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(259, 30)
        Me.txtSalary.TabIndex = 10
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = true
        Me.lblBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBirthdate.Location = New System.Drawing.Point(47, 259)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(98, 25)
        Me.lblBirthdate.TabIndex = 0
        Me.lblBirthdate.Text = "Birthdate"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = true
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSalary.Location = New System.Drawing.Point(525, 259)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(139, 25)
        Me.lblSalary.TabIndex = 0
        Me.lblSalary.Text = "Salary / Hour"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtEmail.Location = New System.Drawing.Point(202, 305)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(275, 30)
        Me.txtEmail.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = true
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEmail.Location = New System.Drawing.Point(47, 308)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(65, 25)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(531, 317)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 56)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = false
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(755, 317)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 56)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = false
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtpBirthdate.Location = New System.Drawing.Point(202, 256)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(275, 30)
        Me.dtpBirthdate.TabIndex = 5
        '
        'dtpHireDate
        '
        Me.dtpHireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dtpHireDate.Location = New System.Drawing.Point(680, 158)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(275, 30)
        Me.dtpHireDate.TabIndex = 8
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = true
        Me.rdoMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdoMale.Location = New System.Drawing.Point(224, 208)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(76, 29)
        Me.rdoMale.TabIndex = 3
        Me.rdoMale.TabStop = true
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = true
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = true
        Me.rdoFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdoFemale.Location = New System.Drawing.Point(356, 208)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(98, 29)
        Me.rdoFemale.TabIndex = 4
        Me.rdoFemale.TabStop = true
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = true
        '
        'cmbJobTitle
        '
        Me.cmbJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmbJobTitle.FormattingEnabled = true
        Me.cmbJobTitle.Items.AddRange(New Object() {"Crew member", "Crew trainer", "Manager", "Department manager", "Restaurant manager"})
        Me.cmbJobTitle.Location = New System.Drawing.Point(680, 206)
        Me.cmbJobTitle.Name = "cmbJobTitle"
        Me.cmbJobTitle.Size = New System.Drawing.Size(275, 33)
        Me.cmbJobTitle.TabIndex = 13
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = true
        Me.lblEuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEuro.Location = New System.Drawing.Point(675, 260)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(23, 25)
        Me.lblEuro.TabIndex = 14
        Me.lblEuro.Text = "€"
        '
        'Employee
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 408)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblEuro)
        Me.Controls.Add(Me.cmbJobTitle)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.dtpHireDate)
        Me.Controls.Add(Me.dtpBirthdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblJobTitle)
        Me.Controls.Add(Me.lblHireDate)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.pnlHeader.ResumeLayout(false)
        Me.pnlHeader.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblEmployee As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblHireDate As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblJobTitle As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents dtpHireDate As DateTimePicker
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents cmbJobTitle As ComboBox
    Friend WithEvents lblEuro As Label
End Class

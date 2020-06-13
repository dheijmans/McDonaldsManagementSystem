Public Class StaffDetails

    'OpenFileDialog waarmee je je een database kunt selecteren
    ReadOnly _ofd = New OpenFileDialog()
    'Class die dataverwerkt
    Dim _psd As ProcessStaffData
    'Geeft aan of er een database is geïmporteerd
    Dim _dataImported = False
    'Geeft aan of je het scherm aan het verplaatsen bent
    Dim _drag = False
    'De startpositie van de muis als je het form wilt verplaat
    Dim _startPoint = New Point(0, 0)

    Private Sub StaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Stelt het icoontje voor het form vast
        Icon = My.Resources.McDonaldsIcon
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Sluit het volledige programma als je op het kruisje rechtsboven in het scherm klikt
        Close()
        Application.Exit()
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        'Minimaliseerd het form als je op het streepje rechtsboven in het scherm klikt
        WindowState = FormWindowState.Minimized
    End Sub

    'De volgende 3 functions zorgen ervoor dat je het form kunt verplaatsen
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, pnlLogo.MouseDown, picMcDonaldsLogo.MouseDown, lblMcDonalds.MouseDown, lblStaffDetails.MouseDown
        'Geeft aan dat de linker muisknop is ingedrukt op aan de bovenkant van het form 
        _drag = True
        'Bepaalt de locatie van de muis
        _startPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, pnlLogo.MouseMove, picMcDonaldsLogo.MouseMove, lblMcDonalds.MouseMove, lblStaffDetails.MouseMove
        'Controleert of de linker muisknop is ingedrukt op aan de bovenkant van het form 
        If _drag Then
            'Bepaalt de nieuwe locatie van de muis 
            Dim p = PointToScreen(e.Location)
            'Kijkt hoever de muis is verschoven en verschuift het form in dezelfde richting als de muis
            Location = New Point(p.X - _startPoint.X, p.Y - _startPoint.Y)
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp, pnlLogo.MouseUp, picMcDonaldsLogo.MouseUp, lblMcDonalds.MouseUp, lblStaffDetails.MouseUp
        'Geeft aan dat de linker muisknop niet meer is ingedrukt
        _drag = False
    End Sub

    Private Sub btnImportData_Click(sender As Object, e As EventArgs) Handles btnImportData.Click
        'Voegt een filter toe aan de open file dialog 
        _ofd.Filter = "Microsoft Access Databases|*.mdb"
        'Kijkt of je een database hebt geselcteerd met een .mdb als extensie
        If _ofd.ShowDialog() = DialogResult.OK Then
            'Maakt een connectionstring aan waarin de locatie van de geselecteerde database staat
            Dim conString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""{_ofd.FileName}"";"
            'Maakt een processStaffData class aan en voegt de connectionstring in deze class
            _psd = New ProcessStaffData(conString)
            'Maakt het stukje tekst onzichtbaar dat aangeeft dat je via de btnInportData een database file kunt openen
            lblImportData.Visible = False
            'Laad alle gegevens van de database in een dataGridView (tabel)
            dgvStaff.DataSource = _psd.LoadAllData()
            'Zorgt dat er geen cellen in de tabel geselecteerd zijn
            dgvStaff.ClearSelection()
            'Geeft aan dat er een database is geïmporteerd
            _dataImported = True
        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        'Controlleert of er een database geïmporteerd is
        If _dataImported Then
            'Zorgt voor een laad icoontje
            Cursor = Cursors.WaitCursor
            'Opent een form om een nieuwe werknemer toe te voegen
            Dim employee = New Employee(_psd, dgvStaff)
            employee.Show()
            'Verandert het icoontje van de muis weer terug
            Cursor = Cursors.Default
        Else
            'Geeft een foutmelding als er geen tekstbox geïmporteerd is
            MessageBox.Show($"Database file was not found", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Controlleert of er een database geïmporteerd is
        If _dataImported Then
            'Zet de volledige naam van de desbetreffende werknemer in een variable
            Dim fullName = dgvStaff.CurrentRow.Cells.Item(1).Value + " " + dgvStaff.CurrentRow.Cells.Item(2).Value
            'Vraagt of je zeker weet dat je de werknemer in questie wilt verwijderen
            If MessageBox.Show($"Are you sure you want to delete {fullName}?", $"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                'Bepaalt het id van de persoon die je wilt verwijderen
                Dim id = dgvStaff.CurrentRow.Cells.Item(0).Value
                'Delete de persoon met de bovenstaande id en vernieuwt de tabel
                dgvStaff.DataSource = _psd.DeleteRow(id)
                'Zorgt dat er geen cellen in de tabel geselecteerd zijn
                dgvStaff.ClearSelection()
            End If
        Else
            'Geeft een foutmelding als er geen database geïmporteerd is
            MessageBox.Show($"Database file was not found", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLoadAll_Click(sender As Object, e As EventArgs) Handles btnLoadAll.Click
        'Controlleert of er een database geïmporteerd is
        If _dataImported Then
            'Haalt alle data uit de database en zet het in de tabel
            dgvStaff.DataSource = _psd.LoadAllData()
            'Zorgt dat er geen cellen in de tabel geselecteerd zijn
            dgvStaff.ClearSelection()
        Else
            'Geeft een foutmelding als er geen database geïmporteerd is
            MessageBox.Show($"Database file was not found", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Controlleert of er een database geïmporteerd is
        If _dataImported Then
            'Slaat het type waar je opzoekt en je zoekopdracht op in variablelen
            Dim type = cmbTypes.Text
            Dim search = txtSearch.Text
            'Controleert of er een type is geselecteerd
            If Not String.IsNullOrEmpty(type) Then
                'Zorgt voor een laad icoontje
                Cursor = Cursors.WaitCursor
                'Vult de tabel met de zoekresultaten van je zoekopdracht
                dgvStaff.DataSource = _psd.Search(type, GetSearch())
                'Zorgt dat er geen cellen in de tabel geselecteerd zijn
                dgvStaff.ClearSelection()
                'Verandert het icoontje van de muis weer terug
                Cursor = Cursors.Default
            Else
                'Geeft een foutmelding als er geen type is geslecteerd
                MessageBox.Show($"Type was not selected", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            'Geeft een foutmelding als er geen database geïmporteerd is
            MessageBox.Show($"Database file was not found", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Controlleert of er een database geïmporteerd is
        If _dataImported Then
            'Zorgt voor een laad icoontje
            Cursor = Cursors.WaitCursor
            'Stelt het id van de geselecteerde persoon van
            Dim id = dgvStaff.CurrentRow.Cells.Item(0).Value
            'Opent een form om de gegevens van de werknemer aan te kunnen passen
            Dim employee = New Employee(_psd, dgvStaff, id)
            employee.Show()
            'Verandert het icoontje van de muis weer terug
            Cursor = Cursors.Default
        Else
            'Geeft een foutmelding als er geen database geïmporteerd is
            MessageBox.Show($"Database file was not found", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Search_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter, rdoSearchMale.Enter, rdoSearchFemale.Enter, dtpSearch.Enter, cmbSearchJobTitle.Enter, txtSearchSalary.Enter
        'Stelt de search knop in als acceptbutten (op de Enter-toets) als je aan het zoeken bent
        AcceptButton = btnSearch
    End Sub

    Private Sub Search_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave, rdoSearchMale.Leave, rdoSearchFemale.Leave, dtpSearch.Leave, cmbSearchJobTitle.Leave, txtSearchSalary.Leave
        'Stelt de search knop niet meer als acceptbutton in
        AcceptButton = Nothing
    End Sub

    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        'Slaat het veranderde searchtype op in een variabele
        Dim type = cmbTypes.Text
        'Zet alle searchTools in een list en stelt alle tools in op onzichtbaar
        Dim searchTools As New List(Of Control) From {txtSearch, rdoSearchMale, rdoSearchFemale, dtpSearch, cmbSearchJobTitle, lblSearchEuro, txtSearchSalary}
        For Each tool As Control In searchTools
            tool.Visible = False
        Next
        'Maakt de tool zichtbaar die hoort bij het juiste type en maakt je textboxes vrij
        Select Case type
            Case "Gender"
                rdoSearchMale.Visible = True
                rdoSearchFemale.Visible = True
            Case "Birthdate", "HireDate"
                dtpSearch.Visible = True
                dtpSearch.MaxDate = Date.Today
            Case "JobTitle"
                cmbSearchJobTitle.Visible = True
            Case "Salary"
                lblSearchEuro.Visible = True
                txtSearchSalary.Visible = True
                txtSearchSalary.Text = ""
            Case Else
                txtSearch.Visible = True
                txtSearch.Text = ""
        End Select
    End Sub

    Private Function GetSearch() As String
        'Slaat het searchtype op in een variabele
        Dim type = cmbTypes.Text
        'Kijkt aan de hand van het gesecteerde type waar de bijbehorende zoekopdracht staat
        Select Case type
            Case "Gender"
                If rdoSearchMale.Checked Then
                    Return "Male"
                ElseIf rdoSearchFemale.Checked Then
                    Return "Female"
                Else
                    Return ""
                End If
            Case "Birthdate", "HireDate"
                Return dtpSearch.Value.ToString("yyyy-MM-dd")
            Case "JobTitle"
                Return cmbSearchJobTitle.Text
            Case "Salary"
                Return "€" + txtSearchSalary.Text
            Case Else
                Return txtSearch.Text
        End Select
    End Function

    Private Sub btnViewStatistics_Click(sender As Object, e As EventArgs) Handles btnViewStatistics.Click
        'Controlleert of er een database geïmporteerd is
        If _dataImported Then
            'Zorgt voor een laad icoontje
            Cursor = Cursors.WaitCursor
            'Maakt en opent een from waar de statistieken kunt bekijken
            Dim statistics = New Statistics(_psd)
            statistics.Show()
            'Verandert het icoontje van de muis weer terug
            Cursor = Cursors.Default
        Else
            'Geeft een foutmelding als er geen database geïmporteerd is
            MessageBox.Show($"Database file was not found", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Zorgt voor een laad icoontje
        Cursor = Cursors.WaitCursor
        'Opent een het helpscherm
        Dim help = New Help()
        help.Show()
        'Verandert het icoontje van de muis weer terug
        Cursor = Cursors.Default
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        'Zorgt voor een laad icoontje
        Cursor = Cursors.WaitCursor
        'Opent een het aboutscherm
        Dim about = New About()
        about.Show()
        'Verandert het icoontje van de muis weer terug
        Cursor = Cursors.Default
    End Sub
End Class
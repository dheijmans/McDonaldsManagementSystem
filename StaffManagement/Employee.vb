Public Class Employee

    'Class die dataverwerkt
    ReadOnly _psd As ProcessStaffData
    'Id, alleen nodig als je aanpassingen wilt doen in de gegevens van een werknemer
    ReadOnly _id As String
    'Edit, geeft aan dat je een werknemer wilt bewerken
    ReadOnly _edit = False
    'Add, geeft aan dat je een nieuwe werknemer wilt aanmaken
    ReadOnly _add = False
    'De tabel van het hoofdscherm waarin de gegevens worden weergegeven
    ReadOnly _dvg As DataGridView
    'Geeft aan of je het scherm aan het verplaatsen bent
    Dim _drag = False
    'De startpositie van de muis als je het form wilt verplaat
    Dim _startPoint = New Point(0, 0)

    'Deze functie wordt geopend als je een werknemer wilt bewerken
    Sub New(psd As ProcessStaffData, dgv As DataGridView, id As String)
        'Zorgt dat alle knoppen en dergelijke inladen (gebeurd normaal automatisch, maar moet wel in een zelfgemaakte constructor staan)
        InitializeComponent()
        'Stelt alle gegevens die in de andere class zijn ingevoerd
        _psd = psd
        _dvg = dgv
        _id = id
        'Stelt dat de gegevens van een werknemer bewerkt moeten worden
        _edit = True
        'Vult alle textboxes en dergelijke met de gegevens van de desbetreffende werknemer
        FillBoxes()
    End Sub

    'Deze functie wordt geopend als je een werknemer wilt aanmaken
    Sub New(psd As ProcessStaffData, dgv As DataGridView)
        'Zorgt dat alle knoppen en dergelijke inladen (gebeurd normaal automatisch, maar moet wel in een zelfgemaakte constructor staan)
        InitializeComponent()
        'Stelt alle gegevens die in de andere class zijn ingevoerd
        _psd = psd
        _dvg = dgv
        'Stelt dat er een nieuwe werknemer aangemaakt moet worden
        _add = True
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Stelt het icoontje voor het form vast
        Icon = My.Resources.McDonaldsIcon
        'Zorgt ervoor dat je geen leeftijd van jonger dan 16 jaar kan invullen en niet ouder dan 100 jaar
        DateRestriction(dtpBirthdate, -100, -16)
        'Zorgt dat je geen hiredate kunt invoeren die in de toekomst is en niet langer dan 100 jaar geleden
        DateRestriction(dtpHireDate, -100, 0)
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Sluit het form als je op het kruisje rechtsboven in het scherm klikt
        Close()
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        'Minimaliseerd het form als je op het streepje rechtsboven in het scherm klikt
        WindowState = FormWindowState.Minimized
    End Sub

    'De volgende 3 functions zorgen ervoor dat je het form kunt verplaatsen
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, lblEmployee.MouseDown
        'Geeft aan dat de linker muisknop is ingedrukt op aan de bovenkant van het form 
        _drag = True
        'Bepaalt de locatie van de muis
        _startPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, lblEmployee.MouseMove
        'Controleert of de linker muisknop is ingedrukt op aan de bovenkant van het form 
        If _drag Then
            'Bepaalt de nieuwe locatie van de muis 
            Dim p = PointToScreen(e.Location)
            'Kijkt hoever de muis is verschoven en verschuift het form in dezelfde richting als de muis
            Location = New Point(p.X - _startPoint.X, p.Y - _startPoint.Y)
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp, lblEmployee.MouseUp
        'Geeft aan dat de linker muisknop niet meer is ingedrukt
        _drag = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Sluit het form als de cancel knop wordt ingedrukt
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Als je op de save button klikt, worden alle ingevoerde gegevens opgeslagen in variabelen
        Dim firstname = txtFirstname.Text
        Dim lastname = txtLastname.Text
        Dim gender = ""
        If rdoMale.Checked Then
            gender = "Male"
        ElseIf rdoFemale.Checked Then
            gender = "Female"
        End If
        Dim birthdate = dtpBirthdate.Value.ToString("yyyy-MM-dd")
        Dim email = txtEmail.Text
        Dim phone = txtPhone.Text
        Dim hireDate = dtpHireDate.Value.ToString("yyyy-MM-dd")
        Dim jobTitle = cmbJobTitle.Text
        Dim salary = "€" + txtSalary.Text

        'Loopt door alle variablen heen om te kijken of alles is ingevuld 
        Dim validInput = True
        Dim types As New List(Of String) From {firstname, lastname, gender, birthdate, email, phone, hireDate, jobTitle, salary}
        For Each type As String In types
            If String.IsNullOrEmpty(type) Then
                validInput = False
                Exit For
            End If
        Next

        'Kijkt of het telefoonnummer en het salaris uitsluitend getallen, komma's en punten bevat
        Dim numbers As New List(Of String) From {phone, salary}
        For Each number As String In numbers
            If Not IsNumeric(number) Then
                validInput = False
                Exit For
            End If
        Next

        'Kijkt aan de hand van de bovenstaande testen of de invoer geldig is
        If validInput Then
            'Bepaald of er een nieuwe werknemer aan de database moet worden toegevoegd of dat er alleen maar gegevens bewerkt moeten worden
            If _add Then
                'Maakt een nieuwe werknemer aan en vernieuwt de tabel op het hoofdscherm
                _dvg.DataSource = _psd.Add(firstname, lastname, gender, birthdate, email, phone, hireDate, jobTitle, salary)
            ElseIf _edit Then
                'Bewerkt de gegevens van de werknemer met het desbetreffende id en vernieuwt de tabel op het hoofdscherm
                _dvg.DataSource = _psd.Edit(firstname, lastname, gender, birthdate, email, phone, hireDate, jobTitle, salary, _id)
            End If
            'Zorgt dat er geen cellen in de tabel geselecteerd zijn
            _dvg.ClearSelection()
            'Sluit het form af
            Close()
        Else
            'Zorgt dat er een foutmelding in beeld komt als de invoer onjuist is
            MessageBox.Show($"Invalid input", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FillBoxes()
        'Vult alle gegevens van de werknemer met het desbetreffende id in alle velden in
        txtFirstname.Text = _psd.SearchValue("Firstname", _id)
        txtLastname.Text = _psd.SearchValue("Lastname", _id)
        If _psd.SearchValue("Gender", _id) = "Male" Then
            rdoMale.Checked = True
        ElseIf _psd.SearchValue("Gender", _id) = "Female" Then
            rdoFemale.Checked = True
        End If
        dtpBirthdate.Value = _psd.SearchValue("Birthdate", _id)
        txtEmail.Text = _psd.SearchValue("Email", _id)
        txtPhone.Text = _psd.SearchValue("Phone", _id)
        dtpHireDate.Value = _psd.SearchValue("HireDate", _id)
        cmbJobTitle.Text = _psd.SearchValue("JobTitle", _id)
        txtSalary.Text = _psd.SearchValue("Salary", _id).Substring(1)
    End Sub

    Private Sub DateRestriction(dtp As DateTimePicker, min As Integer, max As Integer)
        'Stelt een minimale en maxile datum die je kunt invoeren in de dateTimePicker
        dtp.MaxDate = Date.Today.AddYears(max)
        dtp.MinDate = Date.Today.AddYears(min)
    End Sub
End Class
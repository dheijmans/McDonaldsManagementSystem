Imports StaffManagement

Public Class LoginScreen

    'De gebruikersnaam
    ReadOnly _username = "admin"
    'Het wachtwoord
    ReadOnly _password = "admin"
    'Geeft aan of je het scherm aan het verplaatsen bent
    Dim _drag = False
    'De startpositie van de muis als je het form wilt verplaat
    Dim _startPoint = New Point(0, 0)

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Stelt het icoontje voor het form vast
        Icon = My.Resources.McDonaldsIcon
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        'Sluit het form als de cancel knop wordt ingedrukt
        Close()
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        'Minimaliseerd het form als je op het streepje rechtsboven in het scherm klikt
        WindowState = FormWindowState.Minimized
    End Sub

    'De volgende 3 functions zorgen ervoor dat je het form kunt verplaatsen
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, lblLogin.MouseDown
        'Geeft aan dat de linker muisknop is ingedrukt op aan de bovenkant van het form 
        _drag = True
        'Bepaalt de locatie van de muis
        _startPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, lblLogin.MouseMove
        'Controleert of de linker muisknop is ingedrukt op aan de bovenkant van het form 
        If _drag Then
            'Bepaalt de nieuwe locatie van de muis 
            Dim p = PointToScreen(e.Location)
            'Kijkt hoever de muis is verschoven en verschuift het form in dezelfde richting als de muis
            Location = New Point(p.X - _startPoint.X, p.Y - _startPoint.Y)
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp, lblLogin.MouseUp
        'Geeft aan dat de linker muisknop niet meer is ingedrukt
        _drag = False
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        'Zet de invoerde gebruikersnaam en het ingevoerde wachtwoord in variabelen
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        'De gebruikersnaam en het wachtwachtwoord juist zijn
        If username = _username AndAlso password = _password Then
            'Zorgt voor een laad icoontje
            Cursor = Cursors.WaitCursor
            'Verbergt het loginscherm
            Hide()
            'Opent het hoofdscherm
            Dim staffDetails = New StaffDetails()
            staffDetails.Show()
            'Verardert het icoontje van de muis weer terug
            Cursor = Cursors.Default
        Else
            'Geeft een foutmelding als de invoerde gebruikersnaam en het ingevoerde wachtwoord onjuist zijn
            MessageBox.Show($"Incorrect username or password", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Leegt de textboxes van de gebruikersnaam en het wachtwoord
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        'Geeft een melding met daarom de juiste gebruikersnaam en het juiste wachtwoord als er "Forgot Password?" wordt gedrukt
        MessageBox.Show($"Username: {_username} 
Password: {_password}", $"Forgot password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        'Maakt bolletjes van het wachtwoord als de checkbox niet is aangevinkt en maakt het zichtbaar als het wel is aangevinkt
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        ElseIf Not chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
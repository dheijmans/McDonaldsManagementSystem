Public Class Help

    'Geeft aan of je het scherm aan het verplaatsen bent
    Dim _drag = False
    'De startpositie van de muis als je het form wilt verplaat
    Dim _startPoint = New Point(0, 0)

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.McDonaldsIcon
        vscMainPanel.Minimum = Height - pnlMain.Height
        vscMainPanel.Maximum = pnlHeader.Height
        vscMainPanel.Value = vscMainPanel.Minimum
        NewPanelPosition()
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
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, lblHelp.MouseDown
        'Geeft aan dat de linker muisknop is ingedrukt op aan de bovenkant van het form 
        _drag = True
        'Bepaalt de locatie van de muis
        _startPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, lblHelp.MouseMove
        'Controleert of de linker muisknop is ingedrukt op aan de bovenkant van het form 
        If _drag Then
            'Bepaalt de nieuwe locatie van de muis 
            Dim p = PointToScreen(e.Location)
            'Kijkt hoever de muis is verschoven en verschuift het form in dezelfde richting als de muis
            Location = New Point(p.X - _startPoint.X, p.Y - _startPoint.Y)
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp, lblHelp.MouseUp
        'Geeft aan dat de linker muisknop niet meer is ingedrukt
        _drag = False
    End Sub

    Private Sub vscMailPanel_Scroll(sender As Object, e As ScrollEventArgs) Handles vscMainPanel.Scroll
        NewPanelPosition()
    End Sub

    Private Sub NewPanelPosition()
        Dim invertedScrollValue = vscMainPanel.Maximum - vscMainPanel.Value + vscMainPanel.Minimum
        pnlMain.Location = New Point(pnlMain.Location.X, invertedScrollValue)
    End Sub
End Class
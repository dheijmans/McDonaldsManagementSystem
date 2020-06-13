Public Class Statistics

    ReadOnly _psd As ProcessStaffData
    Dim _drag = False
    Dim _startPoint = New Point(0, 0)

    Sub New(psd As ProcessStaffData)
        InitializeComponent()
        _psd = psd
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, lblStatistics.MouseDown
        _drag = True
        _startPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, lblStatistics.MouseMove
        If _drag Then
            Dim p = PointToScreen(e.Location)
            Location = New Point(p.X - _startPoint.X, p.Y - _startPoint.Y)
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp, lblStatistics.MouseUp
        _drag = False
    End Sub

    Private Sub JobTitles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPieJobTitles()
        FillPieGenders()
    End Sub

    Private Sub FillPieJobTitles()
        pieJobTitles.Series("jobTitles")("PieLabelStyle") = "Disabled"
        Dim jobTitles As New List(Of String) From {"Crew member", "Crew trainer", "Manager", "Department manager", "Restaurant manager"}
        For Each jobTitle As String In jobTitles
            pieJobTitles.Series("jobTitles").Points.AddXY(jobTitle, _psd.Search("JobTitle", jobTitle).Rows.Count)
        Next
    End Sub

    Private Sub FillPieGenders()
        pieGenders.Series("genders").Points.AddXY("Male", _psd.Search("Gender", "Male").Rows.Count)
        pieGenders.Series("genders").Points.AddXY("Female", _psd.Search("Gender", "Female").Rows.Count)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) 
        Close()
    End Sub
End Class
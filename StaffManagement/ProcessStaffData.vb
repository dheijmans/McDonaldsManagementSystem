Imports System.Data.OleDb

Public Class ProcessStaffData

    'Databaseconntion die ervoor zorgt dat gegevens in de database kunt zetten en uit kunt halen
    ReadOnly _dbCon = New OleDbConnection()

    Public Sub New(conString As String)
        'Stelt de connectionstring van de databaseconnection in op de ingevoerde connectionstring
        _dbCon.ConnectionString = conString
    End Sub

    Public Function LoadAllData() As DataTable
        'Opdracht voor de database die alle gegevens uit de werknemers tabel haalt
        Dim query = $"SELECT * FROM tblStaff ORDER BY Id;"
        'Verkwerkt de opdracht en stuurt de gegevens voor tabel terug
        Return UpdateTable(query)
    End Function

    Public Function DeleteRow(id As String) As DataTable
        'Opdracht voor de database die een werknemer met een gegeven id verwijdert uit de werknemers tabel
        Dim query = $"DELETE FROM tblStaff WHERE Id = {id};"
        'Verkwerkt de opdracht
        UpdateTable(query)
        'Stuurt de vernieuwde tabel terug
        Return LoadAllData()
    End Function

    Public Function Search(type As String, searchQuery As String) As DataTable
        Dim query As String
        'Bepaald wat aan de hand van het type hoe de layout van de opdracht eruit komt te zien
        Select Case type.ToLower()
            Case "id"
                'Opdracht voor de database die alle gegevens die matchen met je zoekopdracht haalt
                query = $"SELECT * FROM tblStaff WHERE {type} = {searchQuery} ORDER BY Id;"
            Case Else
                'Opdracht voor de database die alle gegevens die matchen met je zoekopdracht haalt
                query = $"SELECT * FROM tblStaff WHERE {type} = ""{searchQuery}"" ORDER BY Id;"
        End Select
        'Haalt de zoekresultaten op en zet ze in een tabel
        Dim table = UpdateTable(query)
        'Controleert of er minimaal 1 zoekresultaat is
        If table.Rows.Count > 0 Then
            'Stuurt de tabel met de zoekresultaten terug
            Return table
        Else
            'Geeft een melding als er geen zoekresultaten zijn
            MessageBox.Show($"There was no result for your search", $"Nothing found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Stuurt de volledige tabel weer terug
            Return LoadAllData()
        End If
    End Function

    Public Function SearchValue(type As String, id As String) As String
        'Opdracht voor de database om een type van een werknemer met een bepaald id te zoeken
        Dim query = $"SELECT {type} FROM tblStaff WHERE id = {id};"
        'Stuurt de gevonde waarde uit de enige cell van de tabel terug
        Return UpdateTable(query).Rows(0)(0).ToString()
    End Function

    Public Function Add(firstname As String, lastname As String, gender As String, birthdate As String, email As String, phone As String, hireDate As String, jobTitle As String, salary As String) As DataTable
        'Opdracht voor de database om een nieuwe werknemer toe te voegen aan de database
        Dim query = $"INSERT INTO tblStaff ([Firstname], [Lastname], [Gender], [Birthdate], [Email], [Phone], [HireDate], [JobTitle], [Salary]) VALUES ('{firstname}', '{lastname}', '{gender}', '{birthdate}', '{email}', '{phone}', '{hireDate}', '{jobTitle}', '{salary}');"
        'Verwerkt de opdracht
        UpdateTable(query)
        'Stuurt de vernieuwde tabel terug
        Return LoadAllData()
    End Function

    Public Function Edit(firstname As String, lastname As String, gender As String, birthdate As String, email As String, phone As String, hireDate As String, jobTitle As String, salary As String, id As String) As DataTable
        'Opdracht voor de database om de gegevens van een bestaatde werknemer met een bepaald id te bewerken
        Dim query = $"UPDATE tblStaff SET Firstname = '{firstname}', Lastname = '{lastname}', Gender = '{gender}', Birthdate = '{birthdate}', Email = '{email}', Phone = '{phone}', HireDate = '{hireDate}', JobTitle = '{jobTitle}', Salary = '{salary}' WHERE Id = {id};"
        'Verwerkt de opdracht
        UpdateTable(query)
        'Stuurt de vernieuwde tabel terug
        Return LoadAllData()
    End Function

    Private Function UpdateTable(query As String) As DataTable
        'Maakt connectie met de database
        _dbCon.Open()
        'Maakt een command aan om en opdracht voor de database in te zetten
        Dim cmd = _dbCon.CreateCommand()
        'Zet de opdracht in het command
        cmd.CommandText = query
        'Maakt een dataTable aan
        Dim dt As New DataTable()
        'Verwerkt de command
        Dim da As New OleDbDataAdapter(cmd)
        'Vult de opgehaalde gegevens uit de database in de dataTable
        da.Fill(dt)
        'Verbreekt de connctie
        _dbCon.Close()
        'Stuur de tabel terug
        Return dt
    End Function
End Class
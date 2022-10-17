Imports System.Data.OleDb

Public Class BrowseWindow
    Dim SearchByMethods() As String = {"MPN", "Description", "Location"}
    Public Locations() As String
    Public Categories() As String
    Dim conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim sdr As OleDbDataReader
    Dim dbDataset As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
    Dim QUERY As String
    Public MPN_To_Edit As String

    Private Sub BrowseWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Categories = ColumnToArray("Category")
        Locations = ColumnToArray("Location")
        Me.CenterToParent()
        cbSearchByMethods.Items.AddRange(SearchByMethods)
        cbSearchByMethods.SelectedIndex = 0
        showAll()

        cbCategory.Items.AddRange(Categories)
        cbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        My.Forms.MainDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchKeyword(tbKeywords.Text, cbCategory.SelectedItem)
    End Sub


    Public Sub showAll()
        conn.ConnectionString = connectionString
        Dim command As String = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory"
        dbDataset = New DataSet
        tables = dbDataset.Tables
        adapter = New OleDbDataAdapter(command, conn)
        adapter.Fill(dbDataset, "sampleInventory")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Public Sub searchKeyword(ByVal keyword, ByVal category)
        conn.ConnectionString = connectionString
        If cbSearchByMethods.SelectedItem = "MPN" Then
            If (keyword = "" And category <> "") Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE Category='" & category & "'"
            ElseIf (keyword = "" And category Is Nothing) Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2,DateModified, LastModifiedBy from sampleInventory"
            ElseIf (keyword <> "" And category <> "") Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2,DateModified, LastModifiedBy from sampleInventory
                       WHERE MPN LIKE '%" & keyword & "%' AND
                       Category='" & category & "'"
            ElseIf (keyword <> "" And category Is Nothing) Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE MPN LIKE '%" & keyword & "%'"
            End If
        ElseIf cbSearchByMethods.SelectedItem = "Description" Then
            If (keyword = "" And category <> "") Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE Category='" & category & "'"
            ElseIf (keyword = "" And category Is Nothing) Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory"
            ElseIf (keyword <> "" And category <> "") Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE Descriptions LIKE '%" & keyword & "%' AND
                       Category='" & category & "'"
            ElseIf (keyword <> "" And category Is Nothing) Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE Descriptions LIKE '%" & keyword & "%'"
            End If
        ElseIf cbSearchByMethods.SelectedItem = "Location" Then
            If (keyword = "" And category <> "") Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE Location='" & category & "'"
            ElseIf (keyword = "" And category Is Nothing) Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory"
            ElseIf (keyword <> "" And category <> "") Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE MPN LIKE '%" & keyword & "%' AND
                       Location='" & category & "'"
            ElseIf (keyword <> "" And category Is Nothing) Then
                QUERY = "SELECT MPN, Qty, Descriptions, Location, Mouser1, Mouser2, LCSC1, LCSC2, DateModified, LastModifiedBy from sampleInventory
                       WHERE MPN LIKE '%" & keyword & "%'"
            End If
        End If
        dbDataset = New DataSet
        tables = dbDataset.Tables
        adapter = New OleDbDataAdapter(QUERY, conn)
        adapter.Fill(dbDataset, "sampleInventory")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub cbSearchByMethods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchByMethods.SelectedIndexChanged
        If cbSearchByMethods.SelectedItem = "MPN" Or cbSearchByMethods.SelectedItem = "Description" Then
            cbCategory.Text = ""
            cbCategory.Items.Clear()
            cbCategory.Items.AddRange(Categories)
        Else
            cbCategory.Text = ""
            cbCategory.Items.Clear()
            cbCategory.Items.AddRange(Locations)
        End If
    End Sub

    Public Function ColumnToArray(ByVal col As String)
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
        conn.Open()
        Dim command As String = "SELECT " + col + " FROM sampleInventory"
        cmd = New OleDbCommand(command, conn)
        sdr = cmd.ExecuteReader()
        Dim list As New List(Of String)()
        While sdr.Read()
            list.Add(sdr(col).ToString)
        End While
        conn.Close()
        Return list.Distinct().ToArray
    End Function

    Private Sub BrowseWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Forms.MainDashboard.Show()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim selectedMPN As String
        selectedMPN = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        MPN_To_Edit = selectedMPN
        My.Forms.FromBrowseWindow.Show()
        Me.Hide()
    End Sub

    Private Sub tbKeywords_TextChanged(sender As Object, e As EventArgs) Handles tbKeywords.TextChanged
        Me.btnSearch.PerformClick()
    End Sub
End Class
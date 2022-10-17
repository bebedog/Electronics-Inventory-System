Imports System.Data.OleDb
Public Class addComponentWindow
    Dim conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim sdr As OleDbDataReader
    Dim colBValues = New List(Of String)
    Public MPN_toEdit As String
    Public CategorySearched As String
    Public Category() As String
    Public PackageSearched As String
    Public Package() As String
    Public mountingSchemeSearched As String
    Public mountingScheme() as String
    Public Manufacturer As String
    Public description As String
    Public Mouser1 As String = "-"
    Public Mouser2 As String = "-"
    Public LCSC1 As String = "-"
    Public LCSC2 As String = "-"
    Public componentLocationSearched As String
    Public componentLocation() As String
    Public Qty As Integer
    Public DateLastModified As String
    Public LastModifiedBy As String
    Public newMPN As String


    Private Sub addComponentWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MainDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        If tbMPN.Text <> "" Then
            mountingScheme = ColumnToArray("MountingScheme")
            Package = ColumnToArray("Package")
            Category = ColumnToArray("Category")
            componentLocation = ColumnToArray("Location")
            Try
                GetDetailsOfMPN(tbMPN.Text)
                Dim result As DialogResult = (MessageBox.Show("MPN already exists. Would you like to edit its details instead?", "MPN already exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                If result = DialogResult.Yes Then
                    Me.Hide()
                    editMPNDetails.Show()
                Else
                    tbMPN.Clear()
                    tbMPN.Select()
                End If
            Catch ex As Exception
                'if details are not found
                newMPN = tbMPN.Text
                editMPNDetails.Show()
                Me.Hide()

            End Try
        Else
            MessageBox.Show("Please enter an MPN to search.", "MPN field cannot be left empty!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            tbMPN.Clear()
            tbMPN.Select()
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

    Public Sub GetDetailsOfMPN(ByVal MPN_To_Query As String)
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
        conn.Open()
        Dim inventoryQuery As String = "SELECT * FROM sampleInventory WHERE MPN='" & MPN_To_Query.ToString & "'"
        cmd = New OleDbCommand(inventoryQuery, conn)
        sdr = cmd.ExecuteReader()
        sdr.Read()
        DateLastModified = sdr("DateModified")
        LastModifiedBy = sdr("LastModifiedBy")
        CategorySearched = sdr("Category")
        PackageSearched = sdr("Package")
        mountingSchemeSearched = sdr("MountingScheme")
        description = sdr("Descriptions")
        Manufacturer = sdr("Manufacturer")
        Qty = sdr("Qty")
        componentLocationSearched = sdr("Location")
        MPN_toEdit = sdr("MPN")
        If Not IsDBNull(sdr("Mouser1")) Then
            Mouser1 = sdr("Mouser1")
        End If

        If Not IsDBNull(sdr("Mouser2")) Then
            Mouser2 = sdr("Mouser2")
        End If

        If Not IsDBNull(sdr("LCSC1")) Then
            LCSC1 = sdr("LCSC1")
        End If

        If Not IsDBNull(sdr("LCSC2")) Then
            LCSC2 = sdr("LCSC2")
        End If

        conn.Close()
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        tbMPN.Text = Clipboard.GetText
    End Sub
End Class
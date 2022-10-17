Imports System.Data.OleDb
Imports System.IO

Public Class InventoryCheckMin
    Dim conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim sdr As OleDbDataReader
    Dim dbDataset As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
    Dim QUERY As String

    Private Sub InventoryCheckMin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Try
            queryNow()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Uh-oh. There's something wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MainDashboard.Show()
        Me.Close()
    End Sub

    Private Sub queryNow()
        QUERY = "SELECT MPN, MinQty, Qty, Mouser1, Mouser2, LCSC1, LCSC2
                 FROM sampleInventory
                 WHERE Qty<MinQty"
        conn.ConnectionString = connectionString
        dbDataset = New DataSet
        tables = dbDataset.Tables
        adapter = New OleDbDataAdapter(QUERY, conn)
        adapter.Fill(dbDataset, "sampleInventory")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim todaysdate As String = String.Format("{0:yyyyMMdd}", DateTime.Now)
        Dim result As DialogResult = MessageBox.Show("Would you like to export current contents of the cell to CSV file?", "Export to CSV", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        SaveFileDialog1.FileName = "Inventory-Replenishment-csv-" + todaysdate
        SaveFileDialog1.Filter = "CSV File|*.csv"
        SaveFileDialog1.DefaultExt = ".csv"
        If result = DialogResult.Yes Then
            If SaveFileDialog1.ShowDialog() <> DialogResult.Cancel Then
                DataGridToCSV()
                MessageBox.Show("The file is succesfully exported to:" + Environment.NewLine + SaveFileDialog1.FileName, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start(SaveFileDialog1.FileName)
            End If
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Public Sub DataGridToCSV()
        Using sw As StreamWriter = File.CreateText(SaveFileDialog1.FileName)
            'write the datagridview column into the first line of csv file
            Dim dgvColumnNames As List(Of String) = DataGridView1.Columns.Cast(Of DataGridViewColumn).ToList().Select(Function(c) c.Name).ToList()

            sw.WriteLine(String.Join("|", dgvColumnNames))

            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim rowData As New List(Of String)
                For Each column As DataGridViewColumn In DataGridView1.Columns
                    rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                Next
                sw.WriteLine(String.Join("|", rowData))
            Next
        End Using
    End Sub

    Private Sub InventoryCheckMin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainDashboard.Show()
    End Sub
End Class
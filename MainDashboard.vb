Imports System.Data.OleDb

Public Class MainDashboard
    Dim conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim sdr As OleDbDataReader
    Dim dbDataset As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
    Dim QUERY As String
    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.Text = "Lasermet Inventory System v12 - " + Form1.sessionUser
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Close()
    End Sub

    Private Sub btnAddComponent_Click(sender As Object, e As EventArgs) Handles btnAddComponent.Click
        addComponentWindow.Show()
        Me.Close()
    End Sub

    Private Sub btnBrowseInventory_Click(sender As Object, e As EventArgs) Handles btnBrowseInventory.Click
        BrowseWindow.Show()
        Me.Close()
    End Sub

    Private Sub btnMinQty_Click(sender As Object, e As EventArgs) Handles btnMinQty.Click
        InventoryCheckMin.Show()
        Me.Close()
    End Sub

    Private Sub btnQtyToOrderMaker_Click(sender As Object, e As EventArgs) Handles btnQtyToOrderMaker.Click

    End Sub
End Class
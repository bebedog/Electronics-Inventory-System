Imports System.Data.OleDb

Public Class editMPNDetails
    Public MPN As String
    Dim conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim sdr As OleDbDataReader

    Private Sub editMPNDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbCategory.AutoCompleteMode = AutoCompleteMode.Append
        'cbLocation.AutoCompleteMode = AutoCompleteMode.Append
        'cbMountingScheme.AutoCompleteMode = AutoCompleteMode.Append
        'cbPackage.AutoCompleteMode = AutoCompleteMode.Append

        'cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
        'cbLocation.AutoCompleteSource = AutoCompleteSource.ListItems
        'cbMountingScheme.AutoCompleteSource = AutoCompleteSource.ListItems
        'cbPackage.AutoCompleteSource = AutoCompleteSource.ListItems
        'Me.CenterToParent()
        'dtpDateModified.Format = DateTimePickerFormat.Custom
        'dtpDateModified.CustomFormat = "dd/MM/yyyy"
        'dtpDateModified.Enabled = False
        'If My.Forms.addComponentWindow.MPN_toEdit <> "" Then
        '    Me.Text = My.Forms.addComponentWindow.MPN_toEdit
        '    tbMPN.Text = Me.Text
        '    tbMPN.Enabled = False
        '    cbMountingScheme.Items.AddRange(My.Forms.addComponentWindow.mountingScheme.ToArray)
        '    cbMountingScheme.SelectedItem = My.Forms.addComponentWindow.mountingSchemeSearched
        '    cbPackage.Items.AddRange(My.Forms.addComponentWindow.Package.ToArray)
        '    cbPackage.SelectedItem = My.Forms.addComponentWindow.PackageSearched
        '    cbCategory.Items.AddRange(My.Forms.addComponentWindow.Category.ToArray)
        '    cbCategory.SelectedItem = My.Forms.addComponentWindow.CategorySearched
        '    tbMfr.Text = My.Forms.addComponentWindow.Manufacturer
        '    tbQty.Text = My.Forms.addComponentWindow.Qty
        '    cbLocation.Items.AddRange(My.Forms.addComponentWindow.componentLocation.ToArray)
        '    cbLocation.SelectedItem = My.Forms.addComponentWindow.componentLocationSearched
        '    tbDescr.Text = My.Forms.addComponentWindow.description.ToString
        '    lblDateLastMod.Text = lblDateLastMod.Text + My.Forms.addComponentWindow.DateLastModified
        '    lblLastModifiedBy.Text = lblLastModifiedBy.Text + My.Forms.addComponentWindow.LastModifiedBy
        '    tbMouser1.Text = My.Forms.addComponentWindow.Mouser1
        '    tbMouser2.Text = My.Forms.addComponentWindow.Mouser2
        '    tbLCSC1.Text = My.Forms.addComponentWindow.LCSC1
        '    tbLCSC2.Text = My.Forms.addComponentWindow.LCSC2
        '    tbLCSC3.Enabled = False
        '    tbMouser3.Enabled = False
        'Else
        '    tbMPN.Text = My.Forms.addComponentWindow.newMPN
        '    Me.Text = tbMPN.Text
        '    cbMountingScheme.Items.AddRange(My.Forms.addComponentWindow.mountingScheme.ToArray)
        '    cbPackage.Items.AddRange(My.Forms.addComponentWindow.Package.ToArray)
        '    cbCategory.Items.AddRange(My.Forms.addComponentWindow.Category.ToArray)
        '    cbLocation.Items.AddRange(My.Forms.addComponentWindow.componentLocation.ToArray)
        '    tbMPN.Enabled = False
        'End If

        fromAddComponentWindow()
    End Sub

    Public Sub fromAddComponentWindow()
        cbCategory.AutoCompleteMode = AutoCompleteMode.Append
        cbLocation.AutoCompleteMode = AutoCompleteMode.Append
        cbMountingScheme.AutoCompleteMode = AutoCompleteMode.Append
        cbPackage.AutoCompleteMode = AutoCompleteMode.Append

        cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
        cbLocation.AutoCompleteSource = AutoCompleteSource.ListItems
        cbMountingScheme.AutoCompleteSource = AutoCompleteSource.ListItems
        cbPackage.AutoCompleteSource = AutoCompleteSource.ListItems
        Me.CenterToParent()
        dtpDateModified.Format = DateTimePickerFormat.Custom
        dtpDateModified.CustomFormat = "dd/MM/yyyy"
        dtpDateModified.Enabled = False
        If My.Forms.addComponentWindow.MPN_toEdit <> "" Then
            Me.Text = My.Forms.addComponentWindow.MPN_toEdit
            tbMPN.Text = Me.Text
            tbMPN.Enabled = False
            cbMountingScheme.Items.AddRange(My.Forms.addComponentWindow.mountingScheme.ToArray)
            cbMountingScheme.SelectedItem = My.Forms.addComponentWindow.mountingSchemeSearched
            cbPackage.Items.AddRange(My.Forms.addComponentWindow.Package.ToArray)
            cbPackage.SelectedItem = My.Forms.addComponentWindow.PackageSearched
            cbCategory.Items.AddRange(My.Forms.addComponentWindow.Category.ToArray)
            cbCategory.SelectedItem = My.Forms.addComponentWindow.CategorySearched
            tbMfr.Text = My.Forms.addComponentWindow.Manufacturer
            tbQty.Text = My.Forms.addComponentWindow.Qty
            cbLocation.Items.AddRange(My.Forms.addComponentWindow.componentLocation.ToArray)
            cbLocation.SelectedItem = My.Forms.addComponentWindow.componentLocationSearched
            tbDescr.Text = My.Forms.addComponentWindow.description.ToString
            lblDateLastMod.Text = lblDateLastMod.Text + My.Forms.addComponentWindow.DateLastModified
            lblLastModifiedBy.Text = lblLastModifiedBy.Text + My.Forms.addComponentWindow.LastModifiedBy
            tbMouser1.Text = My.Forms.addComponentWindow.Mouser1
            tbMouser2.Text = My.Forms.addComponentWindow.Mouser2
            tbLCSC1.Text = My.Forms.addComponentWindow.LCSC1
            tbLCSC2.Text = My.Forms.addComponentWindow.LCSC2
            tbLCSC3.Enabled = False
            tbMouser3.Enabled = False
        Else
            tbMPN.Text = My.Forms.addComponentWindow.newMPN
            Me.Text = tbMPN.Text
            cbMountingScheme.Items.AddRange(My.Forms.addComponentWindow.mountingScheme.ToArray)
            cbPackage.Items.AddRange(My.Forms.addComponentWindow.Package.ToArray)
            cbCategory.Items.AddRange(My.Forms.addComponentWindow.Category.ToArray)
            cbLocation.Items.AddRange(My.Forms.addComponentWindow.componentLocation.ToArray)
            tbMPN.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        addComponentWindow.Show()
        My.Forms.addComponentWindow.tbMPN.Clear()
        My.Forms.addComponentWindow.tbMPN.Select()
        resetMPN()
        Me.Close()

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If tbDescr.Text = "" Or tbMfr.Text = "" Or tbQty.Text = "" Or cbCategory.SelectedItem = "" Or cbLocation.SelectedItem = "" Or cbMountingScheme.SelectedItem = "" Or cbPackage.SelectedItem = "" Then
            MessageBox.Show("One or more important fields are empty. Please populate them before clicking apply.", "One or more fields are empty!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else

            If My.Forms.addComponentWindow.MPN_toEdit <> "" Then
                UpdateInventory()
                resetMPN()
            Else
                InsertToInventory()
                resetMPN()
            End If
        End If
    End Sub

    Public Sub UpdateInventory()

        Dim inventoryQuery As String = "UPDATE sampleInventory
                                        SET Category=@Category, Descriptions=@Descriptions, Package=@Package, MountingScheme=@MountingScheme,
                                            Manufacturer=@Manufacturer, Mouser1=@Mouser1, Mouser2=@Mouser2, LCSC1=@LCSC1, LCSC2=@LCSC2,
                                            Qty=@Qty, Location=@Location, LastModifiedBy=@LastModifiedBy, DateModified=@DateModified
                                        WHERE MPN='" & tbMPN.Text & "'"

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
        conn.Open()
        Try
            cmd = New OleDbCommand(inventoryQuery, conn)
            cmd.Parameters.AddWithValue("@Category", cbCategory.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@Descriptions", tbDescr.Text)
            cmd.Parameters.AddWithValue("@Package", cbPackage.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@MountingScheme", cbMountingScheme.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@Manufacturer", tbMfr.Text)

            If (tbMouser1.Text = "") Then
                cmd.Parameters.AddWithValue("@Mouser1", "-")
            Else
                cmd.Parameters.AddWithValue("@Mouser1", tbMouser1.Text)
            End If

            If (tbMouser2.Text = "") Then
                cmd.Parameters.AddWithValue("@Mouser2", "-")
            Else
                cmd.Parameters.AddWithValue("@Mouser2", tbMouser2.Text)
            End If

            If (tbLCSC1.Text = "") Then
                cmd.Parameters.AddWithValue("@LCSC1", "-")
            Else
                cmd.Parameters.AddWithValue("@LCSC1", tbLCSC1.Text)
            End If

            If (tbLCSC2.Text = "") Then
                cmd.Parameters.AddWithValue("@LCSC2", "-")
            Else
                cmd.Parameters.AddWithValue("@LCSC2", tbLCSC2.Text)
            End If

            cmd.Parameters.AddWithValue("@Qty", Int(tbQty.Text))
            cmd.Parameters.AddWithValue("@Location", cbLocation.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@LastModifiedBy", My.Forms.Form1.sessionUser)
            cmd.Parameters.AddWithValue("@DateModified", dtpDateModified.Value.Date)
            cmd.ExecuteNonQuery()
            MessageBox.Show(tbMPN.Text + " has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addComponentWindow.Show()
            My.Forms.addComponentWindow.tbMPN.Clear()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conn.Close()

    End Sub

    Public Sub InsertToInventory()

        Dim inventoryQuery As String = "INSERT INTO sampleInventory(MPN, Category, Descriptions, Package, MountingScheme, Manufacturer,
                                                    Mouser1, Mouser2, LCSC1, LCSC2, Qty, Location, LastModifiedBy, DateModified)
                                                             VALUES(@MPN, @Category, @Descriptions, @Package, @MountingScheme, @Manufacturer,
                                                                    @Mouser1, @Mouser2, @LCSC1, @LCSC2, @Qty, @Location, @LastModifiedBy, @DateModified)"

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
        conn.Open()
        Try
            cmd = New OleDbCommand(inventoryQuery, conn)
            cmd.Parameters.AddWithValue("@MPN", tbMPN.Text)
            cmd.Parameters.AddWithValue("@Category", cbCategory.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@Descriptions", tbDescr.Text)
            cmd.Parameters.AddWithValue("@Package", cbPackage.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@MountingScheme", cbMountingScheme.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@Manufacturer", tbMfr.Text)
            If (tbMouser1.Text = "") Then
                cmd.Parameters.AddWithValue("@Mouser1", "EMPTY")
            Else
                cmd.Parameters.AddWithValue("@Mouser1", tbMouser1.Text)
            End If

            If (tbMouser2.Text = "") Then
                cmd.Parameters.AddWithValue("@Mouser2", "EMPTY")
            Else
                cmd.Parameters.AddWithValue("@Mouser2", tbMouser2.Text)
            End If

            If (tbLCSC1.Text = "") Then
                cmd.Parameters.AddWithValue("@LCSC1", "EMPTY")
            Else
                cmd.Parameters.AddWithValue("@LCSC1", tbLCSC1.Text)
            End If

            If (tbLCSC2.Text = "") Then
                cmd.Parameters.AddWithValue("@LCSC2", "EMPTY")
            Else
                cmd.Parameters.AddWithValue("@LCSC2", tbLCSC2.Text)
            End If
            cmd.Parameters.AddWithValue("@Qty", Int(tbQty.Text))
            cmd.Parameters.AddWithValue("@Location", cbLocation.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@LastModifiedBy", My.Forms.Form1.sessionUser)
            cmd.Parameters.AddWithValue("@DateModified", dtpDateModified.Value.Date)
            cmd.ExecuteNonQuery()
            MessageBox.Show(tbMPN.Text + " has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addComponentWindow.Show()
            My.Forms.addComponentWindow.tbMPN.Clear()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        conn.Close()

    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click
        Dim x As Integer
        x = Int(tbQty.Text)
        tbQty.Text = (x - 1).ToString
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        Dim x As Integer
        x = Int(tbQty.Text)
        tbQty.Text = (x + 1).ToString
    End Sub

    Public Sub resetMPN()
        My.Forms.addComponentWindow.MPN_toEdit = ""
        My.Forms.addComponentWindow.newMPN = ""
    End Sub

    Public Sub searchMouser(ByVal StockCode)
        Dim searchDistributor As String = "https://www.mouser.ph/c/?q=" + StockCode
        Process.Start(searchDistributor)
    End Sub
    Public Sub searchLCSC(ByVal StockCode)
        Dim searchDistributor As String = "https://lcsc.com/search?q=%20" + StockCode
        Process.Start(searchDistributor)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If tbMouser1.Text <> "" Then
            searchMouser(tbMouser1.Text)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If tbMouser2.Text <> "" Then
            searchMouser(tbMouser2.Text)
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If tbLCSC1.Text <> "" Then
            searchLCSC(tbLCSC1.Text)
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If tbLCSC2.Text <> "" Then
            searchLCSC(tbLCSC2.Text)
        End If
    End Sub

    Private Sub btnMouser_Click(sender As Object, e As EventArgs) Handles btnMouser.Click
        Me.Hide()
        MouserCheck.Show()
    End Sub
End Class
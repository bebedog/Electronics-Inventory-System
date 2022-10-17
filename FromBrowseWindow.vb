Imports System.Data.OleDb
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net

Public Class FromBrowseWindow
    Dim conn As New OleDb.OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim sdr As OleDbDataReader
    Dim categories() As String
    Dim locations() As String
    Dim mountingScheme() As String
    Dim package() As String
    Dim tags() As String
    Dim DateLastModified As String
    Dim LastModifiedBy As String
    Dim CategorySearched As String
    Dim PackageSearched As String
    Dim mountingSchemeSearched As String
    Dim description As String
    Dim Manufacturer As String
    Dim Qty As String
    Dim MinQty As String
    Dim componentLocationSearched As String


    Dim Mouser1 As String
    Dim Mouser2 As String
    Dim LCSC1 As String
    Dim LCSC2 As String
    Dim datasheetURL As String


    Private Sub FromBrowseWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbLocation.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbMountingScheme.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbPackage.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
        cbLocation.AutoCompleteSource = AutoCompleteSource.ListItems
        cbMountingScheme.AutoCompleteSource = AutoCompleteSource.ListItems
        cbPackage.AutoCompleteSource = AutoCompleteSource.ListItems
        Me.CenterToParent()
        tbMPN.Text = My.Forms.BrowseWindow.MPN_To_Edit
        Me.Text = "Editing " + tbMPN.Text + " -- " + My.Forms.Form1.sessionUser

        dtpDateModified.Format = DateTimePickerFormat.Custom
        dtpDateModified.CustomFormat = "dd/MM/yyyy"
        dtpDateModified.Enabled = False
        dtpDateModified.Enabled = False

        GetDetailsOfMPN(tbMPN.Text)

        categories = ColumnToArray("Category")
        locations = ColumnToArray("Location")
        mountingScheme = ColumnToArray("MountingScheme")
        package = ColumnToArray("Package")
        tags = ColumnToArray("Tags")


        cbCategory.Items.AddRange(categories)
        cbLocation.Items.AddRange(locations)
        cbMountingScheme.Items.AddRange(mountingScheme)
        cbPackage.Items.AddRange(package)

        tbDescr.Text = description
        tbMfr.Text = Manufacturer
        tbQty.Text = Qty
        tbMinQty.Text = MinQty
        cbCategory.SelectedItem = CategorySearched
        cbLocation.SelectedItem = componentLocationSearched
        cbMountingScheme.SelectedItem = mountingSchemeSearched
        cbPackage.SelectedItem = PackageSearched
        tbMouser1.Text = Mouser1
        tbMouser2.Text = Mouser2
        tbLCSC1.Text = LCSC1
        tbLCSC2.Text = LCSC2

        tbMouser3.Enabled = False
        tbLCSC3.Enabled = False

        lblDateLastMod.Text = lblDateLastMod.Text + DateLastModified
        lblLastModifiedBy.Text = lblLastModifiedBy.Text + LastModifiedBy
        lblStockMouser1.Text = SearchMouserPartNumber(Mouser1)





    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        My.Forms.BrowseWindow.Show()
        Me.Close()
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

        If Not IsDBNull(sdr("MinQty")) Then
            MinQty = sdr("MinQty")
        End If
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

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If tbMinQty.Text = "" Or tbDescr.Text = "" Or tbMfr.Text = "" Or tbQty.Text = "" Or cbCategory.SelectedItem = "" Or cbLocation.SelectedItem = "" Or cbMountingScheme.SelectedItem = "" Or cbPackage.SelectedItem = "" Then
            MessageBox.Show("One or more important fields are empty. Please populate them before clicking apply.", "One or more fields are empty!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            UpdateInventory()
        End If
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

    Public Sub UpdateInventory()

        Dim inventoryQuery As String = "UPDATE sampleInventory
                                        SET Category=@Category, Descriptions=@Descriptions, Package=@Package, MountingScheme=@MountingScheme,
                                            Manufacturer=@Manufacturer, Mouser1=@Mouser1, Mouser2=@Mouser2, LCSC1=@LCSC1, LCSC2=@LCSC2, MinQty=@MinQty,
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


            cmd.Parameters.AddWithValue("@MinQty", Int(tbMinQty.Text))
            cmd.Parameters.AddWithValue("@Qty", Int(tbQty.Text))
            cmd.Parameters.AddWithValue("@Location", cbLocation.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@LastModifiedBy", My.Forms.Form1.sessionUser)
            cmd.Parameters.AddWithValue("@DateModified", dtpDateModified.Value.Date)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show(tbMPN.Text + " has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BrowseWindow.Show()
            My.Forms.BrowseWindow.btnSearch.PerformClick()
            My.Forms.BrowseWindow.tbKeywords.Select()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conn.Close()

    End Sub

    Private Sub lblMouser1_Click(sender As Object, e As EventArgs) Handles lblMouser1.Click
        If lblMouser1.Text = "" Or lblMouser1.Text = "EMPTY" Or lblMouser1.Text = "-" Then
            MessageBox.Show("There's no stock code in this field.", "Search Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim address As String = "https://www.mouser.ph/c/?q=" + tbMouser1.Text
            Process.Start(address)
        End If
    End Sub

    Private Sub lblMouser2_Click(sender As Object, e As EventArgs) Handles lblMouser2.Click
        If lblMouser2.Text = "" Or lblMouser2.Text = "EMPTY" Or lblMouser2.Text = "-" Then
            Dim address As String = "https://www.mouser.ph/c/?q=" + tbMouser2.Text
        Else
            Dim address As String = "https://www.mouser.ph/c/?q=" + tbMouser2.Text
            Process.Start(address)
        End If
    End Sub

    Private Sub lblLCSC1_Click(sender As Object, e As EventArgs) Handles lblLCSC1.Click
        If lblLCSC1.Text = "" Or lblLCSC1.Text = "EMPTY" Or lblLCSC1.Text = "-" Then
            Dim address As String = "https://www.mouser.ph/c/?q=" + tbMouser2.Text
        Else
            Dim address As String = "https://lcsc.com/search?q=" + tbLCSC1.Text
            Process.Start(address)
        End If
    End Sub

    Private Sub lblLCSC2_Click(sender As Object, e As EventArgs) Handles lblLCSC2.Click
        If lblLCSC1.Text = "" Or lblLCSC1.Text = "EMPTY" Or lblLCSC1.Text = "-" Then
            Dim address As String = "https://www.mouser.ph/c/?q=" + tbMouser2.Text
        Else
            Dim address As String = "https://lcsc.com/search?q=" + tbLCSC1.Text
            Process.Start(address)
        End If
    End Sub

    Private Sub btnIncreaseMinQty_Click(sender As Object, e As EventArgs) Handles btnIncreaseMinQty.Click
        Dim x As Integer
        x = Int(tbMinQty.Text)
        tbMinQty.Text = (x + 1).ToString
    End Sub

    Private Sub btnDecreaseMinQty_Click(sender As Object, e As EventArgs) Handles btnDecreaseMinQty.Click
        Dim x As Integer
        x = Int(tbMinQty.Text)
        tbMinQty.Text = (x - 1).ToString
    End Sub

    Public Function SearchMouserPartNumber(ByVal Mouser As String)
        Try
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = DirectCast(WebRequest.Create("https://api.mouser.com/api/v1/search/partnumber?apiKey=2f994a23-48ef-4d37-8da2-fd9d0c0a2f69"), HttpWebRequest)
            myReq.Method = "POST"
            myReq.ContentType = "application/json"
            myReq.Accept = "application/json"

            Dim myData As String = "
        {
          ""SearchByPartRequest"": {
            ""mouserPartNumber"": """ + Mouser + """
          }
        }
        "
            myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(myData), 0, System.Text.Encoding.UTF8.GetBytes(myData).Count)
            myResp = myReq.GetResponse
            myReader = New StreamReader(myResp.GetResponseStream)
            'parse json string into a readable form
            Dim pitoy As String = MyReader.ReadToEnd
            Dim jsonObject As JObject = JObject.Parse(pitoy)
            'point to the SearchResults Object to find the search results array
            Dim anotherJsonObject As JObject = jsonObject.SelectToken("SearchResults")
            Dim jsonArray As JArray = anotherJsonObject.SelectToken("Parts")
            'count how many are the results of the search
            Dim x As Integer = jsonArray.Count
            Console.WriteLine("There are " + x.ToString + " results found.")

            For Each item As JObject In jsonArray
                Dim pictureURL As String = item.SelectToken("ImagePath")
                PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(pictureURL)))
                lblStockMouser1.ForeColor = Color.Green
                datasheetURL = item.SelectToken("DataSheetUrl")
                Return item.SelectToken("Availability").ToString()
            Next
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            lblStockMouser1.ForeColor = Color.Red
            Return "No results found"
        End Try
    End Function

    Private Sub btnDatasheet_Click(sender As Object, e As EventArgs) Handles btnDatasheet.Click
        Try
            Process.Start(datasheetURL)
        Catch ex As Exception
            MessageBox.Show("Mouser has no datasheet for this component." + Environment.NewLine + "See more details:" + Environment.NewLine + ex.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
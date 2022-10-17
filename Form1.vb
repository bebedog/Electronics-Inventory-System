Imports System.Data.OleDb
Imports Google.Apis.Drive.v2
Imports Google.Apis.Requests
Imports System.Collections.Generic
Imports System.Net
Imports System.Threading
Imports System.Threading.Tasks

Imports Google
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v2.Data
Imports Google.Apis.Services

Imports Google.Apis.Auth
Imports Google.Apis.Download
Public Class Form1
    Dim BeGreen As Boolean
    Public sessionUser As String
    Dim conn As New OleDb.OleDbConnection


    'Dev Console:
    'https://console.developers.google.com/

    'Nuget command:
    'Install-Package Google.Apis.Drive.v2

    Private Service As DriveService = New DriveService

    Private Sub CreateService()
        If Not BeGreen Then
            Dim ClientId = "332230308695-bsfu7b57999pcanvdns93d9j5lpt0755.apps.googleusercontent.com"
            Dim ClientSecret = "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"
            Dim MyUserCredential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = ClientId, .ClientSecret = ClientSecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
            Service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = MyUserCredential, .ApplicationName = "Google Drive VB Dot Net"})
        End If
    End Sub


    Private Sub UploadFile(FilePath As String)
        Me.Cursor = Cursors.WaitCursor
        If Service.ApplicationName <> "Google Drive VB Dot Net" Then CreateService()

        Dim TheFile As New File()
        TheFile.Title = "Lasermet Inventory"
        TheFile.Description = "Lasermet Inventory"
        TheFile.MimeType = "application/msaccess"

        Dim ByteArray As Byte() = System.IO.File.ReadAllBytes(FilePath)
        Dim Stream As New System.IO.MemoryStream(ByteArray)

        Dim UploadRequest As FilesResource.InsertMediaUpload = Service.Files.Insert(TheFile, Stream, TheFile.MimeType)

        Me.Cursor = Cursors.Default
        MsgBox("Upload Finished")
    End Sub

    Private Sub DownloadFile(url As String, DownloadDir As String)
        Me.Cursor = Cursors.WaitCursor
        If Service.ApplicationName <> "Google Drive VB Dot Net" Then CreateService()

        Dim Downloader = New MediaDownloader(Service)
        Downloader.ChunkSize = 256 * 1024 '256 KB

        ' figure out the right file type base on UploadFileName extension
        Dim Filename = DownloadDir & "NewDoc.txt"
        Using FileStream = New System.IO.FileStream(Filename, System.IO.FileMode.Create, System.IO.FileAccess.Write)
            Dim Progress = Downloader.DownloadAsync(url, FileStream)
            Threading.Thread.Sleep(1000)
            Do While Progress.Status = TaskStatus.Running
            Loop
            If Progress.Status = TaskStatus.RanToCompletion Then
                MsgBox("Downloaded!")
            Else
                MsgBox("Not Downloaded :(")
            End If
        End Using
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BeGreen = False
        Me.CenterToParent()
        tbUsername.Select()
        If My.Settings.InventoryLocation = "" Then
            btnConnect.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If My.Settings.InventoryLocation = "" Then
            MessageBox.Show("Inventory database file not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
                'https://www.microsoft.com/en-us/download/confirmation.aspx?id=13255 you need to install this.
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Accounts
                                                            WHERE Username='" & tbUsername.Text & "' AND
                                                            Password='" & tbPassword.Text & "'", conn)
                conn.Open()
                Dim sdr As OleDbDataReader = cmd.ExecuteReader()
                If (sdr.Read() = True) Then
                    sessionUser = sdr("Username")
                    MessageBox.Show("Welcome, " + sessionUser, "Login successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    MainDashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("User not found.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tbUsername.Clear()
                    tbPassword.Clear()
                    tbUsername.Select()
                    conn.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SelectDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectDatabaseToolStripMenuItem.Click

    End Sub

    Public Function openDatabase(ByVal command As String)
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.InventoryLocation & ""
        conn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(command, conn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        Return sdr.Read()
        conn.Close()
    End Function

    Public Sub closeDatabase()
        conn.Close()
    End Sub


    Public Function msgBoxInformative(ByVal mainText, ByVal headerText)
        MessageBox.Show(mainText, headerText, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function

    Private Sub ConnectToDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToDatabaseToolStripMenuItem.Click
        If My.Settings.InventoryLocation = "" Then
            OpenFileDialog1.InitialDirectory = "C:\\"
            OpenFileDialog1.Filter = "Database Files (*.mdb)|*.mdb"

            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                My.Settings.InventoryLocation = OpenFileDialog1.FileName
                msgBoxInformative("Location has ben set to: " + My.Settings.InventoryLocation, "Success!")
                btnConnect.Enabled = True
            End If
        Else
            Dim dialog As DialogResult = MessageBox.Show("Current address found: " + My.Settings.InventoryLocation + Environment.NewLine + "Would you like to change this address?", "Inventory is already present!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dialog = DialogResult.Yes Then
                OpenFileDialog1.InitialDirectory = "C:\\"
                OpenFileDialog1.Filter = "Database Files (*.mdb)|*.mdb"
                If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                    My.Settings.InventoryLocation = OpenFileDialog1.FileName
                    msgBoxInformative("Location has ben set to: " + My.Settings.InventoryLocation, "Success!")
                    btnConnect.Enabled = True
                End If
            Else

            End If
        End If

    End Sub

    Private Sub BackupDatabaseToGoogleDriveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToGoogleDriveToolStripMenuItem.Click
        If BeGreen = False Then
            CreateService()
            UploadFile(My.Settings.InventoryLocation)
        End If

    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ConnectToDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToGoogleDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(194, 251)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(79, 34)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(297, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDatabaseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileToolStripMenuItem.Text = "Settings"
        '
        'SelectDatabaseToolStripMenuItem
        '
        Me.SelectDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToDatabaseToolStripMenuItem, Me.BackupDatabaseToGoogleDriveToolStripMenuItem})
        Me.SelectDatabaseToolStripMenuItem.Name = "SelectDatabaseToolStripMenuItem"
        Me.SelectDatabaseToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SelectDatabaseToolStripMenuItem.Text = "Connect to database"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Electronics Inventory"
        '
        'tbUsername
        '
        Me.tbUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(13, 156)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(260, 26)
        Me.tbUsername.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(13, 214)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(260, 26)
        Me.tbPassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.LasermetInventorySystem_v10.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ConnectToDatabaseToolStripMenuItem
        '
        Me.ConnectToDatabaseToolStripMenuItem.Name = "ConnectToDatabaseToolStripMenuItem"
        Me.ConnectToDatabaseToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ConnectToDatabaseToolStripMenuItem.Text = "Connect to database"
        '
        'BackupDatabaseToGoogleDriveToolStripMenuItem
        '
        Me.BackupDatabaseToGoogleDriveToolStripMenuItem.Name = "BackupDatabaseToGoogleDriveToolStripMenuItem"
        Me.BackupDatabaseToGoogleDriveToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BackupDatabaseToGoogleDriveToolStripMenuItem.Text = "Backup database to Google Drive"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnConnect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(297, 304)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Lasermet Inventory System v13 - Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ConnectToDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseToGoogleDriveToolStripMenuItem As ToolStripMenuItem
End Class

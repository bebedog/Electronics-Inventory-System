<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromBrowseWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromBrowseWindow))
        Me.dtpDateModified = New System.Windows.Forms.DateTimePicker()
        Me.lblLastModifiedBy = New System.Windows.Forms.Label()
        Me.lblDateLastMod = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbDescr = New System.Windows.Forms.RichTextBox()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMfr = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMountingScheme = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbPackage = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbLCSC3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbLCSC2 = New System.Windows.Forms.TextBox()
        Me.lblLCSC2 = New System.Windows.Forms.Label()
        Me.tbLCSC1 = New System.Windows.Forms.TextBox()
        Me.lblLCSC1 = New System.Windows.Forms.Label()
        Me.tbMouser3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMouser2 = New System.Windows.Forms.TextBox()
        Me.lblMouser2 = New System.Windows.Forms.Label()
        Me.tbMouser1 = New System.Windows.Forms.TextBox()
        Me.lblMouser1 = New System.Windows.Forms.Label()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMPN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMinQty = New System.Windows.Forms.TextBox()
        Me.btnIncreaseMinQty = New System.Windows.Forms.Button()
        Me.btnDecreaseMinQty = New System.Windows.Forms.Button()
        Me.lblStockMouser1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDatasheet = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDateModified
        '
        Me.dtpDateModified.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateModified.Location = New System.Drawing.Point(430, 303)
        Me.dtpDateModified.Name = "dtpDateModified"
        Me.dtpDateModified.Size = New System.Drawing.Size(202, 20)
        Me.dtpDateModified.TabIndex = 71
        '
        'lblLastModifiedBy
        '
        Me.lblLastModifiedBy.AutoSize = True
        Me.lblLastModifiedBy.Location = New System.Drawing.Point(17, 489)
        Me.lblLastModifiedBy.Name = "lblLastModifiedBy"
        Me.lblLastModifiedBy.Size = New System.Drawing.Size(91, 13)
        Me.lblLastModifiedBy.TabIndex = 70
        Me.lblLastModifiedBy.Text = "Last Modified By: "
        '
        'lblDateLastMod
        '
        Me.lblDateLastMod.AutoSize = True
        Me.lblDateLastMod.Location = New System.Drawing.Point(6, 466)
        Me.lblDateLastMod.Name = "lblDateLastMod"
        Me.lblDateLastMod.Size = New System.Drawing.Size(102, 13)
        Me.lblDateLastMod.TabIndex = 69
        Me.lblDateLastMod.Text = "Date Last Modified: "
        '
        'cbCategory
        '
        Me.cbCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(755, 26)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(202, 24)
        Me.cbCategory.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(672, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 20)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Category"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(969, 454)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 37)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(897, 454)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(66, 37)
        Me.btnApply.TabIndex = 53
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(331, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Description:"
        '
        'tbDescr
        '
        Me.tbDescr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescr.Location = New System.Drawing.Point(335, 356)
        Me.tbDescr.Name = "tbDescr"
        Me.tbDescr.Size = New System.Drawing.Size(711, 92)
        Me.tbDescr.TabIndex = 51
        Me.tbDescr.Text = ""
        '
        'cbLocation
        '
        Me.cbLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Location = New System.Drawing.Point(432, 262)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(202, 24)
        Me.cbLocation.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Location: "
        '
        'tbMfr
        '
        Me.tbMfr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMfr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMfr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMfr.Location = New System.Drawing.Point(430, 146)
        Me.tbMfr.Name = "tbMfr"
        Me.tbMfr.Size = New System.Drawing.Size(204, 22)
        Me.tbMfr.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(334, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 16)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Manufacturer: "
        '
        'cbMountingScheme
        '
        Me.cbMountingScheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMountingScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMountingScheme.FormattingEnabled = True
        Me.cbMountingScheme.Location = New System.Drawing.Point(432, 223)
        Me.cbMountingScheme.Name = "cbMountingScheme"
        Me.cbMountingScheme.Size = New System.Drawing.Size(202, 24)
        Me.cbMountingScheme.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(344, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "M. Scheme: "
        '
        'cbPackage
        '
        Me.cbPackage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPackage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPackage.FormattingEnabled = True
        Me.cbPackage.Location = New System.Drawing.Point(432, 184)
        Me.cbPackage.Name = "cbPackage"
        Me.cbPackage.Size = New System.Drawing.Size(202, 24)
        Me.cbPackage.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(349, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Package:"
        '
        'tbLCSC3
        '
        Me.tbLCSC3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLCSC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLCSC3.Location = New System.Drawing.Point(753, 264)
        Me.tbLCSC3.Name = "tbLCSC3"
        Me.tbLCSC3.Size = New System.Drawing.Size(199, 22)
        Me.tbLCSC3.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(677, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "LCSC 3:"
        '
        'tbLCSC2
        '
        Me.tbLCSC2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLCSC2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLCSC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLCSC2.Location = New System.Drawing.Point(753, 225)
        Me.tbLCSC2.Name = "tbLCSC2"
        Me.tbLCSC2.Size = New System.Drawing.Size(199, 22)
        Me.tbLCSC2.TabIndex = 50
        '
        'lblLCSC2
        '
        Me.lblLCSC2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLCSC2.AutoSize = True
        Me.lblLCSC2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLCSC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLCSC2.Location = New System.Drawing.Point(677, 226)
        Me.lblLCSC2.Name = "lblLCSC2"
        Me.lblLCSC2.Size = New System.Drawing.Size(68, 20)
        Me.lblLCSC2.TabIndex = 58
        Me.lblLCSC2.Text = "LCSC 2:"
        '
        'tbLCSC1
        '
        Me.tbLCSC1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLCSC1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLCSC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLCSC1.Location = New System.Drawing.Point(754, 186)
        Me.tbLCSC1.Name = "tbLCSC1"
        Me.tbLCSC1.Size = New System.Drawing.Size(199, 22)
        Me.tbLCSC1.TabIndex = 49
        '
        'lblLCSC1
        '
        Me.lblLCSC1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLCSC1.AutoSize = True
        Me.lblLCSC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLCSC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLCSC1.Location = New System.Drawing.Point(677, 187)
        Me.lblLCSC1.Name = "lblLCSC1"
        Me.lblLCSC1.Size = New System.Drawing.Size(68, 20)
        Me.lblLCSC1.TabIndex = 57
        Me.lblLCSC1.Text = "LCSC 1:"
        '
        'tbMouser3
        '
        Me.tbMouser3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMouser3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMouser3.Location = New System.Drawing.Point(754, 147)
        Me.tbMouser3.Name = "tbMouser3"
        Me.tbMouser3.Size = New System.Drawing.Size(199, 22)
        Me.tbMouser3.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(666, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Mouser 3:"
        '
        'tbMouser2
        '
        Me.tbMouser2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMouser2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMouser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMouser2.Location = New System.Drawing.Point(754, 108)
        Me.tbMouser2.Name = "tbMouser2"
        Me.tbMouser2.Size = New System.Drawing.Size(199, 22)
        Me.tbMouser2.TabIndex = 47
        '
        'lblMouser2
        '
        Me.lblMouser2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMouser2.AutoSize = True
        Me.lblMouser2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMouser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMouser2.Location = New System.Drawing.Point(666, 109)
        Me.lblMouser2.Name = "lblMouser2"
        Me.lblMouser2.Size = New System.Drawing.Size(79, 20)
        Me.lblMouser2.TabIndex = 52
        Me.lblMouser2.Text = "Mouser 2:"
        '
        'tbMouser1
        '
        Me.tbMouser1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMouser1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMouser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMouser1.Location = New System.Drawing.Point(755, 67)
        Me.tbMouser1.Name = "tbMouser1"
        Me.tbMouser1.Size = New System.Drawing.Size(199, 22)
        Me.tbMouser1.TabIndex = 46
        '
        'lblMouser1
        '
        Me.lblMouser1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMouser1.AutoSize = True
        Me.lblMouser1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMouser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMouser1.Location = New System.Drawing.Point(666, 68)
        Me.lblMouser1.Name = "lblMouser1"
        Me.lblMouser1.Size = New System.Drawing.Size(79, 20)
        Me.lblMouser1.TabIndex = 48
        Me.lblMouser1.Text = "Mouser 1:"
        '
        'btnIncrease
        '
        Me.btnIncrease.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIncrease.Location = New System.Drawing.Point(570, 67)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(64, 26)
        Me.btnIncrease.TabIndex = 67
        Me.btnIncrease.Text = ">>"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'btnDecrease
        '
        Me.btnDecrease.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDecrease.Location = New System.Drawing.Point(430, 67)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(64, 26)
        Me.btnDecrease.TabIndex = 66
        Me.btnDecrease.Text = "<<"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'tbQty
        '
        Me.tbQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQty.Location = New System.Drawing.Point(500, 67)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(64, 26)
        Me.tbQty.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Actual Qty:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "MPN: "
        '
        'tbMPN
        '
        Me.tbMPN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMPN.Location = New System.Drawing.Point(430, 28)
        Me.tbMPN.Name = "tbMPN"
        Me.tbMPN.Size = New System.Drawing.Size(204, 22)
        Me.tbMPN.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Min Qty: "
        '
        'tbMinQty
        '
        Me.tbMinQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMinQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMinQty.Location = New System.Drawing.Point(500, 106)
        Me.tbMinQty.Name = "tbMinQty"
        Me.tbMinQty.Size = New System.Drawing.Size(64, 26)
        Me.tbMinQty.TabIndex = 73
        '
        'btnIncreaseMinQty
        '
        Me.btnIncreaseMinQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIncreaseMinQty.Location = New System.Drawing.Point(570, 106)
        Me.btnIncreaseMinQty.Name = "btnIncreaseMinQty"
        Me.btnIncreaseMinQty.Size = New System.Drawing.Size(64, 26)
        Me.btnIncreaseMinQty.TabIndex = 75
        Me.btnIncreaseMinQty.Text = ">>"
        Me.btnIncreaseMinQty.UseVisualStyleBackColor = True
        '
        'btnDecreaseMinQty
        '
        Me.btnDecreaseMinQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDecreaseMinQty.Location = New System.Drawing.Point(430, 106)
        Me.btnDecreaseMinQty.Name = "btnDecreaseMinQty"
        Me.btnDecreaseMinQty.Size = New System.Drawing.Size(64, 26)
        Me.btnDecreaseMinQty.TabIndex = 74
        Me.btnDecreaseMinQty.Text = "<<"
        Me.btnDecreaseMinQty.UseVisualStyleBackColor = True
        '
        'lblStockMouser1
        '
        Me.lblStockMouser1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockMouser1.AutoSize = True
        Me.lblStockMouser1.Location = New System.Drawing.Point(960, 72)
        Me.lblStockMouser1.Name = "lblStockMouser1"
        Me.lblStockMouser1.Size = New System.Drawing.Size(10, 13)
        Me.lblStockMouser1.TabIndex = 77
        Me.lblStockMouser1.Text = "-"
        Me.lblStockMouser1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.LasermetInventorySystem_v10.My.Resources.Resources.image_not_available
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'btnDatasheet
        '
        Me.btnDatasheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDatasheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatasheet.Location = New System.Drawing.Point(811, 454)
        Me.btnDatasheet.Name = "btnDatasheet"
        Me.btnDatasheet.Size = New System.Drawing.Size(80, 37)
        Me.btnDatasheet.TabIndex = 79
        Me.btnDatasheet.Text = "Datasheet"
        Me.btnDatasheet.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Tags:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(20, 355)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(300, 92)
        Me.RichTextBox1.TabIndex = 80
        Me.RichTextBox1.Text = ""
        '
        'FromBrowseWindow
        '
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1058, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnDatasheet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStockMouser1)
        Me.Controls.Add(Me.btnIncreaseMinQty)
        Me.Controls.Add(Me.btnDecreaseMinQty)
        Me.Controls.Add(Me.tbMinQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDateModified)
        Me.Controls.Add(Me.lblLastModifiedBy)
        Me.Controls.Add(Me.lblDateLastMod)
        Me.Controls.Add(Me.cbCategory)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbDescr)
        Me.Controls.Add(Me.cbLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbMfr)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbMountingScheme)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbPackage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbLCSC3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbLCSC2)
        Me.Controls.Add(Me.lblLCSC2)
        Me.Controls.Add(Me.tbLCSC1)
        Me.Controls.Add(Me.lblLCSC1)
        Me.Controls.Add(Me.tbMouser3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbMouser2)
        Me.Controls.Add(Me.lblMouser2)
        Me.Controls.Add(Me.tbMouser1)
        Me.Controls.Add(Me.lblMouser1)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.tbQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMPN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1074, 596)
        Me.Name = "FromBrowseWindow"
        Me.Text = "FromBrowseWindow"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDateModified As DateTimePicker
    Friend WithEvents lblLastModifiedBy As Label
    Friend WithEvents lblDateLastMod As Label
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tbDescr As RichTextBox
    Friend WithEvents cbLocation As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbMfr As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbMountingScheme As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbPackage As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbLCSC3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbLCSC2 As TextBox
    Friend WithEvents lblLCSC2 As Label
    Friend WithEvents tbLCSC1 As TextBox
    Friend WithEvents lblLCSC1 As Label
    Friend WithEvents tbMouser3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbMouser2 As TextBox
    Friend WithEvents lblMouser2 As Label
    Friend WithEvents tbMouser1 As TextBox
    Friend WithEvents lblMouser1 As Label
    Friend WithEvents btnIncrease As Button
    Friend WithEvents btnDecrease As Button
    Friend WithEvents tbQty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMPN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMinQty As TextBox
    Friend WithEvents btnIncreaseMinQty As Button
    Friend WithEvents btnDecreaseMinQty As Button
    Friend WithEvents lblStockMouser1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDatasheet As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class

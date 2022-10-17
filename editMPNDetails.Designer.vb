<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editMPNDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editMPNDetails))
        Me.tbMPN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMouser1 = New System.Windows.Forms.TextBox()
        Me.tbMouser2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMouser3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbLCSC3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbLCSC2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbLCSC1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPackage = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMountingScheme = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbMfr = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDescr = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDateLastMod = New System.Windows.Forms.Label()
        Me.lblLastModifiedBy = New System.Windows.Forms.Label()
        Me.dtpDateModified = New System.Windows.Forms.DateTimePicker()
        Me.btnMouser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbMPN
        '
        Me.tbMPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMPN.Location = New System.Drawing.Point(106, 26)
        Me.tbMPN.Name = "tbMPN"
        Me.tbMPN.Size = New System.Drawing.Size(204, 22)
        Me.tbMPN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MPN: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity:"
        '
        'tbQty
        '
        Me.tbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQty.Location = New System.Drawing.Point(176, 65)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(64, 26)
        Me.tbQty.TabIndex = 0
        '
        'btnDecrease
        '
        Me.btnDecrease.Location = New System.Drawing.Point(106, 65)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(64, 26)
        Me.btnDecrease.TabIndex = 30
        Me.btnDecrease.Text = "<<"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'btnIncrease
        '
        Me.btnIncrease.Location = New System.Drawing.Point(246, 65)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(64, 26)
        Me.btnIncrease.TabIndex = 31
        Me.btnIncrease.Text = ">>"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(342, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mouser 1:"
        '
        'tbMouser1
        '
        Me.tbMouser1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMouser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMouser1.Location = New System.Drawing.Point(431, 65)
        Me.tbMouser1.Name = "tbMouser1"
        Me.tbMouser1.Size = New System.Drawing.Size(199, 22)
        Me.tbMouser1.TabIndex = 6
        '
        'tbMouser2
        '
        Me.tbMouser2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMouser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMouser2.Location = New System.Drawing.Point(430, 106)
        Me.tbMouser2.Name = "tbMouser2"
        Me.tbMouser2.Size = New System.Drawing.Size(199, 22)
        Me.tbMouser2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mouser 2:"
        '
        'tbMouser3
        '
        Me.tbMouser3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMouser3.Location = New System.Drawing.Point(430, 145)
        Me.tbMouser3.Name = "tbMouser3"
        Me.tbMouser3.Size = New System.Drawing.Size(199, 22)
        Me.tbMouser3.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Mouser 3:"
        '
        'tbLCSC3
        '
        Me.tbLCSC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLCSC3.Location = New System.Drawing.Point(429, 262)
        Me.tbLCSC3.Name = "tbLCSC3"
        Me.tbLCSC3.Size = New System.Drawing.Size(199, 22)
        Me.tbLCSC3.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(353, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "LCSC 3:"
        '
        'tbLCSC2
        '
        Me.tbLCSC2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLCSC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLCSC2.Location = New System.Drawing.Point(429, 223)
        Me.tbLCSC2.Name = "tbLCSC2"
        Me.tbLCSC2.Size = New System.Drawing.Size(199, 22)
        Me.tbLCSC2.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(353, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "LCSC 2:"
        '
        'tbLCSC1
        '
        Me.tbLCSC1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLCSC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLCSC1.Location = New System.Drawing.Point(430, 184)
        Me.tbLCSC1.Name = "tbLCSC1"
        Me.tbLCSC1.Size = New System.Drawing.Size(199, 22)
        Me.tbLCSC1.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(353, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "LCSC 1:"
        '
        'cbPackage
        '
        Me.cbPackage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPackage.FormattingEnabled = True
        Me.cbPackage.Location = New System.Drawing.Point(108, 144)
        Me.cbPackage.Name = "cbPackage"
        Me.cbPackage.Size = New System.Drawing.Size(202, 24)
        Me.cbPackage.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Package:"
        '
        'cbMountingScheme
        '
        Me.cbMountingScheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMountingScheme.FormattingEnabled = True
        Me.cbMountingScheme.Location = New System.Drawing.Point(108, 183)
        Me.cbMountingScheme.Name = "cbMountingScheme"
        Me.cbMountingScheme.Size = New System.Drawing.Size(202, 24)
        Me.cbMountingScheme.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "M. Scheme: "
        '
        'tbMfr
        '
        Me.tbMfr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMfr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMfr.Location = New System.Drawing.Point(106, 106)
        Me.tbMfr.Name = "tbMfr"
        Me.tbMfr.Size = New System.Drawing.Size(204, 22)
        Me.tbMfr.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Manufacturer: "
        '
        'cbLocation
        '
        Me.cbLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Location = New System.Drawing.Point(108, 222)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(202, 24)
        Me.cbLocation.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Location: "
        '
        'tbDescr
        '
        Me.tbDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescr.Location = New System.Drawing.Point(12, 339)
        Me.tbDescr.Name = "tbDescr"
        Me.tbDescr.Size = New System.Drawing.Size(620, 92)
        Me.tbDescr.TabIndex = 10
        Me.tbDescr.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Description:"
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(422, 437)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(66, 37)
        Me.btnApply.TabIndex = 11
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(494, 437)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 37)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbCategory
        '
        Me.cbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(431, 24)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(202, 24)
        Me.cbCategory.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(348, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Category"
        '
        'lblDateLastMod
        '
        Me.lblDateLastMod.AutoSize = True
        Me.lblDateLastMod.Location = New System.Drawing.Point(9, 449)
        Me.lblDateLastMod.Name = "lblDateLastMod"
        Me.lblDateLastMod.Size = New System.Drawing.Size(102, 13)
        Me.lblDateLastMod.TabIndex = 34
        Me.lblDateLastMod.Text = "Date Last Modified: "
        '
        'lblLastModifiedBy
        '
        Me.lblLastModifiedBy.AutoSize = True
        Me.lblLastModifiedBy.Location = New System.Drawing.Point(20, 472)
        Me.lblLastModifiedBy.Name = "lblLastModifiedBy"
        Me.lblLastModifiedBy.Size = New System.Drawing.Size(91, 13)
        Me.lblLastModifiedBy.TabIndex = 35
        Me.lblLastModifiedBy.Text = "Last Modified By: "
        '
        'dtpDateModified
        '
        Me.dtpDateModified.Location = New System.Drawing.Point(106, 263)
        Me.dtpDateModified.Name = "dtpDateModified"
        Me.dtpDateModified.Size = New System.Drawing.Size(202, 20)
        Me.dtpDateModified.TabIndex = 36
        '
        'btnMouser
        '
        Me.btnMouser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMouser.Location = New System.Drawing.Point(566, 437)
        Me.btnMouser.Name = "btnMouser"
        Me.btnMouser.Size = New System.Drawing.Size(66, 37)
        Me.btnMouser.TabIndex = 37
        Me.btnMouser.Text = "Mouser"
        Me.btnMouser.UseVisualStyleBackColor = True
        '
        'editMPNDetails
        '
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(650, 494)
        Me.Controls.Add(Me.btnMouser)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbLCSC1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbMouser3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbMouser2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbMouser1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.tbQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMPN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editMPNDetails"
        Me.Text = "editMPNDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbMPN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbQty As TextBox
    Friend WithEvents btnDecrease As Button
    Friend WithEvents btnIncrease As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMouser1 As TextBox
    Friend WithEvents tbMouser2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbMouser3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbLCSC3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbLCSC2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbLCSC1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbPackage As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbMountingScheme As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbMfr As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbLocation As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDescr As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDateLastMod As Label
    Friend WithEvents lblLastModifiedBy As Label
    Friend WithEvents dtpDateModified As DateTimePicker
    Friend WithEvents btnMouser As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addComponentWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addComponentWindow))
        Me.tbMPN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbMPN
        '
        Me.tbMPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMPN.Location = New System.Drawing.Point(108, 21)
        Me.tbMPN.Name = "tbMPN"
        Me.tbMPN.Size = New System.Drawing.Size(442, 26)
        Me.tbMPN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter MPN:"
        '
        'btnPaste
        '
        Me.btnPaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaste.Location = New System.Drawing.Point(556, 17)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(76, 34)
        Me.btnPaste.TabIndex = 2
        Me.btnPaste.Text = "Paste"
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(638, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 34)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(720, 17)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'addComponentWindow
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(815, 69)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMPN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addComponentWindow"
        Me.Text = "Add Components"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbMPN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPaste As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
End Class

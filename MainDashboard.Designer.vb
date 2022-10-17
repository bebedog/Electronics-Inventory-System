<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboard))
        Me.btnAddComponent = New System.Windows.Forms.Button()
        Me.btnBrowseInventory = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMinQty = New System.Windows.Forms.Button()
        Me.btnQtyToOrderMaker = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddComponent
        '
        Me.btnAddComponent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddComponent.Location = New System.Drawing.Point(12, 12)
        Me.btnAddComponent.Name = "btnAddComponent"
        Me.btnAddComponent.Size = New System.Drawing.Size(161, 154)
        Me.btnAddComponent.TabIndex = 0
        Me.btnAddComponent.Text = "Add Component"
        Me.btnAddComponent.UseVisualStyleBackColor = True
        '
        'btnBrowseInventory
        '
        Me.btnBrowseInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseInventory.Location = New System.Drawing.Point(179, 12)
        Me.btnBrowseInventory.Name = "btnBrowseInventory"
        Me.btnBrowseInventory.Size = New System.Drawing.Size(161, 154)
        Me.btnBrowseInventory.TabIndex = 1
        Me.btnBrowseInventory.Text = "Browse Inventory"
        Me.btnBrowseInventory.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(513, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 154)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMinQty
        '
        Me.btnMinQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinQty.Location = New System.Drawing.Point(346, 12)
        Me.btnMinQty.Name = "btnMinQty"
        Me.btnMinQty.Size = New System.Drawing.Size(161, 78)
        Me.btnMinQty.TabIndex = 3
        Me.btnMinQty.Text = "Min Qty Check"
        Me.btnMinQty.UseVisualStyleBackColor = True
        '
        'btnQtyToOrderMaker
        '
        Me.btnQtyToOrderMaker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQtyToOrderMaker.Location = New System.Drawing.Point(346, 88)
        Me.btnQtyToOrderMaker.Name = "btnQtyToOrderMaker"
        Me.btnQtyToOrderMaker.Size = New System.Drawing.Size(161, 78)
        Me.btnQtyToOrderMaker.TabIndex = 4
        Me.btnQtyToOrderMaker.Text = "Qty To Order Maker"
        Me.btnQtyToOrderMaker.UseVisualStyleBackColor = True
        '
        'MainDashboard
        '
        Me.AcceptButton = Me.btnAddComponent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(688, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnQtyToOrderMaker)
        Me.Controls.Add(Me.btnMinQty)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBrowseInventory)
        Me.Controls.Add(Me.btnAddComponent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainDashboard"
        Me.Text = "MainDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddComponent As Button
    Friend WithEvents btnBrowseInventory As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinQty As Button
    Friend WithEvents btnQtyToOrderMaker As Button
End Class

Public Class MouserCheck
    Private Sub MouserCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub MouserCheck_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FromBrowseWindow.Show()
    End Sub
End Class
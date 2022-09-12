Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WebBrowser1.Navigate("about:blank")
        Me.WebBrowser1.Document.Write(String.Empty)
        Me.WebBrowser1.DocumentText = My.Resources.setup

        Me.WebBrowser2.Navigate("about:blank")
        Me.WebBrowser2.Document.Write(String.Empty)
        Me.WebBrowser2.DocumentText = My.Resources.gplv3

    End Sub
    Private Sub DisplayHtml()

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
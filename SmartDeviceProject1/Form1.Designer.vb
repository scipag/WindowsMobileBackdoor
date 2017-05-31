<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer
    private mainMenu1 As System.Windows.Forms.MainMenu

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnMail = New System.Windows.Forms.Button
        Me.webBrowser = New System.Windows.Forms.WebBrowser
        Me.psbStatus = New System.Windows.Forms.ProgressBar
        Me.lsbStatus = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnDebug = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.Text = "SCIP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 30)
        Me.Label2.Text = ")"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(76, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 29)
        Me.Label3.Text = "("
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMail
        '
        Me.btnMail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMail.BackColor = System.Drawing.Color.Blue
        Me.btnMail.ForeColor = System.Drawing.Color.Yellow
        Me.btnMail.Location = New System.Drawing.Point(15, 52)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(71, 20)
        Me.btnMail.TabIndex = 0
        Me.btnMail.Text = "Exploit"
        '
        'webBrowser
        '
        Me.webBrowser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.webBrowser.Location = New System.Drawing.Point(15, 116)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.ScriptErrorsSuppressed = True
        Me.webBrowser.Size = New System.Drawing.Size(212, 119)
        Me.webBrowser.Visible = False
        '
        'psbStatus
        '
        Me.psbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.psbStatus.Location = New System.Drawing.Point(15, 245)
        Me.psbStatus.Name = "psbStatus"
        Me.psbStatus.Size = New System.Drawing.Size(212, 10)
        '
        'lsbStatus
        '
        Me.lsbStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lsbStatus.BackColor = System.Drawing.Color.Black
        Me.lsbStatus.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lsbStatus.ForeColor = System.Drawing.Color.Lime
        Me.lsbStatus.Location = New System.Drawing.Point(15, 116)
        Me.lsbStatus.Name = "lsbStatus"
        Me.lsbStatus.Size = New System.Drawing.Size(212, 119)
        Me.lsbStatus.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 35)
        '
        'btnDebug
        '
        Me.btnDebug.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDebug.BackColor = System.Drawing.Color.Blue
        Me.btnDebug.ForeColor = System.Drawing.Color.Yellow
        Me.btnDebug.Location = New System.Drawing.Point(15, 78)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(71, 20)
        Me.btnDebug.TabIndex = 7
        Me.btnDebug.Text = "Response"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(92, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 16)
        Me.Label5.Text = "© 2009 by scip AG"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.lsbStatus)
        Me.Controls.Add(Me.psbStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.webBrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "scip Backdoor 1.2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMail As System.Windows.Forms.Button
    Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents psbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents lsbStatus As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbStatus = New Label()
        txtStatus = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lbStatus
        ' 
        lbStatus.AutoSize = True
        lbStatus.Location = New Point(423, 311)
        lbStatus.Name = "lbStatus"
        lbStatus.Size = New Size(0, 20)
        lbStatus.TabIndex = 15
        ' 
        ' txtStatus
        ' 
        txtStatus.AutoSize = True
        txtStatus.Location = New Point(398, 311)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(0, 20)
        txtStatus.TabIndex = 14
        ' 
        ' btnLogin
        ' 
        btnLogin.ForeColor = SystemColors.HotTrack
        btnLogin.Location = New Point(192, 293)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 13
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(141, 251)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(198, 27)
        txtPassword.TabIndex = 12
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(141, 203)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(198, 27)
        txtUsername.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 10
        Label3.Text = "Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 9
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(163, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 38)
        Label1.TabIndex = 8
        Label1.Text = "LOGIN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(410, 487)
        Controls.Add(lbStatus)
        Controls.Add(txtStatus)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbStatus As Label
    Friend WithEvents txtStatus As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class

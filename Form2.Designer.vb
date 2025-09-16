<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblTest = New Label()
        btnTest = New Button()
        btnSubmit = New Button()
        inputLNAME = New TextBox()
        inputFNAME = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        chkGMITS = New CheckBox()
        chkPSITS = New CheckBox()
        chkPGITS = New CheckBox()
        inputYearLevel = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        updateID = New Label()
        GroupBox2 = New GroupBox()
        updateChkGMITS = New CheckBox()
        updateChkPSITS = New CheckBox()
        updateChkPGITS = New CheckBox()
        Label12 = New Label()
        updateYearLevel = New TextBox()
        Label9 = New Label()
        label = New Label()
        btnUpdate = New Button()
        updateLNAME = New TextBox()
        updateFNAME = New TextBox()
        Label2 = New Label()
        Label5 = New Label()
        GroupBox4 = New GroupBox()
        btnSearch = New Button()
        TextBox1 = New TextBox()
        dgvNames = New DataGridView()
        GroupBox3 = New GroupBox()
        deleteOrganization = New Label()
        deleteYearLevel = New Label()
        Label14 = New Label()
        Label13 = New Label()
        btnDelete = New Button()
        deleteLNAME = New Label()
        Label11 = New Label()
        Label10 = New Label()
        deleteFNAME = New Label()
        deleteID = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvNames, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTest
        ' 
        lblTest.AutoSize = True
        lblTest.Location = New Point(218, 23)
        lblTest.Name = "lblTest"
        lblTest.Size = New Size(21, 20)
        lblTest.TabIndex = 18
        lblTest.Text = "--"
        ' 
        ' btnTest
        ' 
        btnTest.BackColor = SystemColors.ButtonHighlight
        btnTest.Location = New Point(44, 18)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(94, 29)
        btnTest.TabIndex = 16
        btnTest.Text = "Test"
        btnTest.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(141, 263)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' inputLNAME
        ' 
        inputLNAME.Location = New Point(106, 103)
        inputLNAME.Name = "inputLNAME"
        inputLNAME.Size = New Size(225, 27)
        inputLNAME.TabIndex = 3
        ' 
        ' inputFNAME
        ' 
        inputFNAME.Location = New Point(106, 58)
        inputFNAME.Name = "inputFNAME"
        inputFNAME.Size = New Size(225, 27)
        inputFNAME.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 1
        Label4.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 0
        Label3.Text = "First Name:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkGMITS)
        GroupBox1.Controls.Add(chkPSITS)
        GroupBox1.Controls.Add(chkPGITS)
        GroupBox1.Controls.Add(inputYearLevel)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnSubmit)
        GroupBox1.Controls.Add(inputLNAME)
        GroupBox1.Controls.Add(inputFNAME)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(44, 68)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(361, 313)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "CREATE"
        ' 
        ' chkGMITS
        ' 
        chkGMITS.AutoSize = True
        chkGMITS.Location = New Point(221, 213)
        chkGMITS.Name = "chkGMITS"
        chkGMITS.Size = New Size(74, 24)
        chkGMITS.TabIndex = 12
        chkGMITS.Text = "GMITS"
        chkGMITS.UseVisualStyleBackColor = True
        ' 
        ' chkPSITS
        ' 
        chkPSITS.AutoSize = True
        chkPSITS.Location = New Point(121, 213)
        chkPSITS.Name = "chkPSITS"
        chkPSITS.Size = New Size(67, 24)
        chkPSITS.TabIndex = 11
        chkPSITS.Text = "PSITS"
        chkPSITS.UseVisualStyleBackColor = True
        ' 
        ' chkPGITS
        ' 
        chkPGITS.AutoSize = True
        chkPGITS.Location = New Point(23, 213)
        chkPGITS.Name = "chkPGITS"
        chkPGITS.Size = New Size(69, 24)
        chkPGITS.TabIndex = 10
        chkPGITS.Text = "PGITS"
        chkPGITS.UseVisualStyleBackColor = True
        ' 
        ' inputYearLevel
        ' 
        inputYearLevel.Location = New Point(105, 146)
        inputYearLevel.Name = "inputYearLevel"
        inputYearLevel.Size = New Size(226, 27)
        inputYearLevel.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 186)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 20)
        Label8.TabIndex = 8
        Label8.Text = "Organization:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 20)
        Label7.TabIndex = 6
        Label7.Text = "Year Level:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(165, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 17
        Label1.Text = "Status:"
        ' 
        ' updateID
        ' 
        updateID.AutoSize = True
        updateID.Location = New Point(105, 33)
        updateID.Name = "updateID"
        updateID.Size = New Size(21, 20)
        updateID.TabIndex = 7
        updateID.Text = "--"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(updateChkGMITS)
        GroupBox2.Controls.Add(updateChkPSITS)
        GroupBox2.Controls.Add(updateChkPGITS)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(updateYearLevel)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(updateID)
        GroupBox2.Controls.Add(label)
        GroupBox2.Controls.Add(btnUpdate)
        GroupBox2.Controls.Add(updateLNAME)
        GroupBox2.Controls.Add(updateFNAME)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(44, 414)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(361, 316)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "UPDATE"
        ' 
        ' updateChkGMITS
        ' 
        updateChkGMITS.AutoSize = True
        updateChkGMITS.Location = New Point(221, 228)
        updateChkGMITS.Name = "updateChkGMITS"
        updateChkGMITS.Size = New Size(74, 24)
        updateChkGMITS.TabIndex = 17
        updateChkGMITS.Text = "GMITS"
        updateChkGMITS.UseVisualStyleBackColor = True
        ' 
        ' updateChkPSITS
        ' 
        updateChkPSITS.AutoSize = True
        updateChkPSITS.Location = New Point(121, 228)
        updateChkPSITS.Name = "updateChkPSITS"
        updateChkPSITS.Size = New Size(67, 24)
        updateChkPSITS.TabIndex = 16
        updateChkPSITS.Text = "PSITS"
        updateChkPSITS.UseVisualStyleBackColor = True
        ' 
        ' updateChkPGITS
        ' 
        updateChkPGITS.AutoSize = True
        updateChkPGITS.Location = New Point(23, 228)
        updateChkPGITS.Name = "updateChkPGITS"
        updateChkPGITS.Size = New Size(69, 24)
        updateChkPGITS.TabIndex = 15
        updateChkPGITS.Text = "PGITS"
        updateChkPGITS.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(16, 201)
        Label12.Name = "Label12"
        Label12.Size = New Size(98, 20)
        Label12.TabIndex = 14
        Label12.Text = "Organization:"
        ' 
        ' updateYearLevel
        ' 
        updateYearLevel.Location = New Point(105, 156)
        updateYearLevel.Name = "updateYearLevel"
        updateYearLevel.Size = New Size(226, 27)
        updateYearLevel.TabIndex = 13
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(16, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 20)
        Label9.TabIndex = 8
        Label9.Text = "Year Level:"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(17, 33)
        label.Name = "label"
        label.Size = New Size(27, 20)
        label.TabIndex = 6
        label.Text = "ID:"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(141, 272)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' updateLNAME
        ' 
        updateLNAME.Location = New Point(106, 112)
        updateLNAME.Name = "updateLNAME"
        updateLNAME.Size = New Size(225, 27)
        updateLNAME.TabIndex = 3
        ' 
        ' updateFNAME
        ' 
        updateFNAME.Location = New Point(106, 64)
        updateFNAME.Name = "updateFNAME"
        updateFNAME.Size = New Size(225, 27)
        updateFNAME.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 1
        Label2.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 68)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 0
        Label5.Text = "First Name:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnSearch)
        GroupBox4.Controls.Add(TextBox1)
        GroupBox4.Controls.Add(dgvNames)
        GroupBox4.Location = New Point(544, 68)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(695, 682)
        GroupBox4.TabIndex = 22
        GroupBox4.TabStop = False
        GroupBox4.Text = "RETRIEVE"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.DodgerBlue
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(349, 44)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(96, 34)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(17, 42)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 36)
        TextBox1.TabIndex = 1
        ' 
        ' dgvNames
        ' 
        dgvNames.AllowUserToAddRows = False
        dgvNames.AllowUserToDeleteRows = False
        dgvNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNames.Location = New Point(17, 106)
        dgvNames.Name = "dgvNames"
        dgvNames.ReadOnly = True
        dgvNames.RowHeadersWidth = 51
        dgvNames.Size = New Size(661, 541)
        dgvNames.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(deleteOrganization)
        GroupBox3.Controls.Add(deleteYearLevel)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(btnDelete)
        GroupBox3.Controls.Add(deleteLNAME)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(deleteFNAME)
        GroupBox3.Controls.Add(deleteID)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Location = New Point(44, 766)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(361, 277)
        GroupBox3.TabIndex = 21
        GroupBox3.TabStop = False
        GroupBox3.Text = "DELETE"
        ' 
        ' deleteOrganization
        ' 
        deleteOrganization.AutoSize = True
        deleteOrganization.Location = New Point(120, 200)
        deleteOrganization.Name = "deleteOrganization"
        deleteOrganization.Size = New Size(21, 20)
        deleteOrganization.TabIndex = 10
        deleteOrganization.Text = "--"
        ' 
        ' deleteYearLevel
        ' 
        deleteYearLevel.AutoSize = True
        deleteYearLevel.Location = New Point(120, 156)
        deleteYearLevel.Name = "deleteYearLevel"
        deleteYearLevel.Size = New Size(21, 20)
        deleteYearLevel.TabIndex = 9
        deleteYearLevel.Text = "--"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(6, 200)
        Label14.Name = "Label14"
        Label14.Size = New Size(110, 20)
        Label14.TabIndex = 8
        Label14.Text = "Organization/s:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(20, 156)
        Label13.Name = "Label13"
        Label13.Size = New Size(78, 20)
        Label13.TabIndex = 7
        Label13.Text = "Year Level:"
        ' 
        ' btnDelete
        ' 
        btnDelete.ForeColor = Color.Red
        btnDelete.Location = New Point(141, 233)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' deleteLNAME
        ' 
        deleteLNAME.AutoSize = True
        deleteLNAME.Location = New Point(120, 115)
        deleteLNAME.Name = "deleteLNAME"
        deleteLNAME.Size = New Size(21, 20)
        deleteLNAME.TabIndex = 5
        deleteLNAME.Text = "--"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(19, 116)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 20)
        Label11.TabIndex = 4
        Label11.Text = "Last Name:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(19, 75)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 20)
        Label10.TabIndex = 3
        Label10.Text = "First Name:"
        ' 
        ' deleteFNAME
        ' 
        deleteFNAME.AutoSize = True
        deleteFNAME.Location = New Point(120, 74)
        deleteFNAME.Name = "deleteFNAME"
        deleteFNAME.Size = New Size(21, 20)
        deleteFNAME.TabIndex = 2
        deleteFNAME.Text = "--"
        ' 
        ' deleteID
        ' 
        deleteID.AutoSize = True
        deleteID.Location = New Point(120, 38)
        deleteID.Name = "deleteID"
        deleteID.Size = New Size(21, 20)
        deleteID.TabIndex = 1
        deleteID.Text = "--"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 20)
        Label6.TabIndex = 0
        Label6.Text = "ID:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(1374, 1055)
        Controls.Add(lblTest)
        Controls.Add(btnTest)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(dgvNames, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTest As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents inputLNAME As TextBox
    Friend WithEvents inputFNAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents updateID As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents label As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents updateLNAME As TextBox
    Friend WithEvents updateFNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvNames As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents deleteLNAME As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents deleteFNAME As Label
    Friend WithEvents deleteID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents inputYearLevel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkPSITS As CheckBox
    Friend WithEvents chkPGITS As CheckBox
    Friend WithEvents chkGMITS As CheckBox
    Friend WithEvents updateYearLevel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents updateChkGMITS As CheckBox
    Friend WithEvents updateChkPSITS As CheckBox
    Friend WithEvents updateChkPGITS As CheckBox
    Friend WithEvents deleteOrganization As Label
    Friend WithEvents deleteYearLevel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class

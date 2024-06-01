<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.LblRegister = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.LblUploadyourphoto = New System.Windows.Forms.Label()
        Me.ComboUsertype = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TxtContact = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Checkshowpassword = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUsern = New System.Windows.Forms.TextBox()
        Me.LogoUserpic = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.LogoUserpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblRegister
        '
        Me.LblRegister.AutoSize = True
        Me.LblRegister.BackColor = System.Drawing.Color.Transparent
        Me.LblRegister.Font = New System.Drawing.Font("Ink Free", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblRegister.Location = New System.Drawing.Point(229, 51)
        Me.LblRegister.Name = "LblRegister"
        Me.LblRegister.Size = New System.Drawing.Size(336, 75)
        Me.LblRegister.TabIndex = 6
        Me.LblRegister.Text = "REGISTER"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnBrowse)
        Me.Panel1.Controls.Add(Me.LblUploadyourphoto)
        Me.Panel1.Controls.Add(Me.ComboUsertype)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TxtContact)
        Me.Panel1.Controls.Add(Me.BtnRegister)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.Checkshowpassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtPass)
        Me.Panel1.Controls.Add(Me.TxtUsern)
        Me.Panel1.Controls.Add(Me.LogoUserpic)
        Me.Panel1.Location = New System.Drawing.Point(18, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 454)
        Me.Panel1.TabIndex = 7
        '
        'BtnBrowse
        '
        Me.BtnBrowse.AllowDrop = True
        Me.BtnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.BtnBrowse.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.button1black
        Me.BtnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnBrowse.FlatAppearance.BorderSize = 0
        Me.BtnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.ForeColor = System.Drawing.Color.White
        Me.BtnBrowse.Location = New System.Drawing.Point(46, 267)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(119, 78)
        Me.BtnBrowse.TabIndex = 25
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'LblUploadyourphoto
        '
        Me.LblUploadyourphoto.AutoSize = True
        Me.LblUploadyourphoto.Font = New System.Drawing.Font("Ink Free", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUploadyourphoto.ForeColor = System.Drawing.Color.Black
        Me.LblUploadyourphoto.Location = New System.Drawing.Point(15, 246)
        Me.LblUploadyourphoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUploadyourphoto.Name = "LblUploadyourphoto"
        Me.LblUploadyourphoto.Size = New System.Drawing.Size(187, 21)
        Me.LblUploadyourphoto.TabIndex = 24
        Me.LblUploadyourphoto.Text = "*Upload your photo here*"
        Me.LblUploadyourphoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboUsertype
        '
        Me.ComboUsertype.Font = New System.Drawing.Font("Ink Free", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboUsertype.FormattingEnabled = True
        Me.ComboUsertype.Items.AddRange(New Object() {"User", "Admin"})
        Me.ComboUsertype.Location = New System.Drawing.Point(556, 53)
        Me.ComboUsertype.Name = "ComboUsertype"
        Me.ComboUsertype.Size = New System.Drawing.Size(121, 27)
        Me.ComboUsertype.TabIndex = 14
        Me.ComboUsertype.Text = "Usertype?"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(281, 207)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(254, 36)
        Me.TextBox4.TabIndex = 13
        '
        'TxtEmail
        '
        Me.TxtEmail.AutoSize = True
        Me.TxtEmail.BackColor = System.Drawing.Color.Transparent
        Me.TxtEmail.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Black
        Me.TxtEmail.Location = New System.Drawing.Point(170, 210)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(93, 29)
        Me.TxtEmail.TabIndex = 12
        Me.TxtEmail.Text = "EMAIL:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(282, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(254, 36)
        Me.TextBox3.TabIndex = 11
        '
        'TxtContact
        '
        Me.TxtContact.AutoSize = True
        Me.TxtContact.BackColor = System.Drawing.Color.Transparent
        Me.TxtContact.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContact.ForeColor = System.Drawing.Color.Black
        Me.TxtContact.Location = New System.Drawing.Point(164, 153)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(122, 29)
        Me.TxtContact.TabIndex = 10
        Me.TxtContact.Text = "CONTACT:"
        '
        'BtnRegister
        '
        Me.BtnRegister.AllowDrop = True
        Me.BtnRegister.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.button1green
        Me.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnRegister.FlatAppearance.BorderSize = 0
        Me.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.Color.White
        Me.BtnRegister.Location = New System.Drawing.Point(223, 271)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(199, 182)
        Me.BtnRegister.TabIndex = 9
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.AllowDrop = True
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.GET_STARTED_BUTTON
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(414, 267)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(287, 182)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Checkshowpassword
        '
        Me.Checkshowpassword.AutoSize = True
        Me.Checkshowpassword.BackColor = System.Drawing.Color.Transparent
        Me.Checkshowpassword.ForeColor = System.Drawing.Color.Black
        Me.Checkshowpassword.Location = New System.Drawing.Point(542, 120)
        Me.Checkshowpassword.Name = "Checkshowpassword"
        Me.Checkshowpassword.Size = New System.Drawing.Size(125, 20)
        Me.Checkshowpassword.TabIndex = 6
        Me.Checkshowpassword.Text = "Show Password"
        Me.Checkshowpassword.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(189, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PASS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(189, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "USER:"
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(282, 98)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(254, 36)
        Me.TxtPass.TabIndex = 2
        '
        'TxtUsern
        '
        Me.TxtUsern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsern.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsern.Location = New System.Drawing.Point(281, 48)
        Me.TxtUsern.Name = "TxtUsern"
        Me.TxtUsern.Size = New System.Drawing.Size(254, 36)
        Me.TxtUsern.TabIndex = 1
        '
        'LogoUserpic
        '
        Me.LogoUserpic.BackColor = System.Drawing.Color.Transparent
        Me.LogoUserpic.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.LOGIN_USER_PNG
        Me.LogoUserpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoUserpic.ErrorImage = Nothing
        Me.LogoUserpic.Location = New System.Drawing.Point(-60, -19)
        Me.LogoUserpic.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoUserpic.Name = "LogoUserpic"
        Me.LogoUserpic.Size = New System.Drawing.Size(290, 274)
        Me.LogoUserpic.TabIndex = 3
        Me.LogoUserpic.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.LOGIN_WALLPAPER_1
        Me.Panel2.Controls.Add(Me.BtnExit)
        Me.Panel2.Location = New System.Drawing.Point(757, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 534)
        Me.Panel2.TabIndex = 8
        '
        'BtnExit
        '
        Me.BtnExit.AllowDrop = True
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.GET_STARTED_BUTTON
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(81, 0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(169, 74)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 577)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblRegister)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.Text = "Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LogoUserpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblRegister As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRegister As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Checkshowpassword As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtUsern As TextBox
    Friend WithEvents LogoUserpic As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TxtEmail As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TxtContact As Label
    Friend WithEvents ComboUsertype As ComboBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents LblUploadyourphoto As Label
End Class

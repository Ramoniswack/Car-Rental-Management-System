<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnGetStarted = New System.Windows.Forms.Button()
        Me.LinkRegister = New System.Windows.Forms.LinkLabel()
        Me.CheckShowpassword = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoFleetEase = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.LogoFleetEase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.BackColor = System.Drawing.Color.Transparent
        Me.LblLogin.Font = New System.Drawing.Font("Ink Free", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblLogin.Location = New System.Drawing.Point(293, 42)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(233, 75)
        Me.LblLogin.TabIndex = 0
        Me.LblLogin.Text = "LOGIN"
        '
        'TxtUser
        '
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(281, 48)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(254, 32)
        Me.TxtUser.TabIndex = 1
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(281, 109)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(254, 32)
        Me.TxtPass.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnGetStarted)
        Me.Panel1.Controls.Add(Me.LinkRegister)
        Me.Panel1.Controls.Add(Me.CheckShowpassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtPass)
        Me.Panel1.Controls.Add(Me.TxtUser)
        Me.Panel1.Controls.Add(Me.LogoFleetEase)
        Me.Panel1.Location = New System.Drawing.Point(24, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 454)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.button1green
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(235, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 182)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnGetStarted
        '
        Me.BtnGetStarted.AllowDrop = True
        Me.BtnGetStarted.BackColor = System.Drawing.Color.Transparent
        Me.BtnGetStarted.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.GET_STARTED_BUTTON
        Me.BtnGetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGetStarted.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnGetStarted.FlatAppearance.BorderSize = 0
        Me.BtnGetStarted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGetStarted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetStarted.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetStarted.ForeColor = System.Drawing.Color.White
        Me.BtnGetStarted.Location = New System.Drawing.Point(406, 171)
        Me.BtnGetStarted.Name = "BtnGetStarted"
        Me.BtnGetStarted.Size = New System.Drawing.Size(287, 182)
        Me.BtnGetStarted.TabIndex = 8
        Me.BtnGetStarted.Text = "Cancel"
        Me.BtnGetStarted.UseVisualStyleBackColor = False
        '
        'LinkRegister
        '
        Me.LinkRegister.AutoSize = True
        Me.LinkRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRegister.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkRegister.LinkColor = System.Drawing.Color.Black
        Me.LinkRegister.Location = New System.Drawing.Point(251, 372)
        Me.LinkRegister.Name = "LinkRegister"
        Me.LinkRegister.Size = New System.Drawing.Size(250, 25)
        Me.LinkRegister.TabIndex = 7
        Me.LinkRegister.TabStop = True
        Me.LinkRegister.Text = "Not Registered? Click here!!!"
        '
        'CheckShowpassword
        '
        Me.CheckShowpassword.AutoSize = True
        Me.CheckShowpassword.BackColor = System.Drawing.Color.Transparent
        Me.CheckShowpassword.ForeColor = System.Drawing.Color.Black
        Me.CheckShowpassword.Location = New System.Drawing.Point(542, 120)
        Me.CheckShowpassword.Name = "CheckShowpassword"
        Me.CheckShowpassword.Size = New System.Drawing.Size(125, 20)
        Me.CheckShowpassword.TabIndex = 6
        Me.CheckShowpassword.Text = "Show Password"
        Me.CheckShowpassword.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(189, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 34)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PASS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(189, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "USER:"
        '
        'LogoFleetEase
        '
        Me.LogoFleetEase.BackColor = System.Drawing.Color.Transparent
        Me.LogoFleetEase.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.Fleet_Ease_black_removebg_preview
        Me.LogoFleetEase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoFleetEase.ErrorImage = Nothing
        Me.LogoFleetEase.Location = New System.Drawing.Point(-39, -35)
        Me.LogoFleetEase.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoFleetEase.Name = "LogoFleetEase"
        Me.LogoFleetEase.Size = New System.Drawing.Size(290, 274)
        Me.LogoFleetEase.TabIndex = 3
        Me.LogoFleetEase.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.LOGIN_WALLPAPER_1
        Me.Panel2.Controls.Add(Me.BtnExit)
        Me.Panel2.Location = New System.Drawing.Point(763, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 534)
        Me.Panel2.TabIndex = 5
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
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 577)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LogoFleetEase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblLogin As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents LogoFleetEase As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkRegister As LinkLabel
    Friend WithEvents CheckShowpassword As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnGetStarted As Button
    Friend WithEvents BtnExit As Button
End Class

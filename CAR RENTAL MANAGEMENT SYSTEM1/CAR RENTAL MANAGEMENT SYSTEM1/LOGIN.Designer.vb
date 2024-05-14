<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Loginpicture = New System.Windows.Forms.PictureBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(477, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(107, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "*Upload your photo here*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.Black
        Me.lblusername.Location = New System.Drawing.Point(367, 160)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(95, 22)
        Me.lblusername.TabIndex = 9
        Me.lblusername.Text = "Username:"
        Me.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.Black
        Me.lblpassword.Location = New System.Drawing.Point(370, 207)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(92, 22)
        Me.lblpassword.TabIndex = 10
        Me.lblpassword.Text = "Password:"
        Me.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(468, 160)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(259, 20)
        Me.txtUsername.TabIndex = 11
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(468, 207)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(259, 20)
        Me.txtpassword.TabIndex = 12
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(468, 233)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(457, 379)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(255, 22)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "NO ID REGISTERED? CLICK HERE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.LOGIN_WALLPAPER_1
        Me.PictureBox1.Location = New System.Drawing.Point(775, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 596)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btncancel
        '
        Me.btncancel.AllowDrop = True
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.GET_STARTED_BUTTON
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Transparent
        Me.btncancel.Location = New System.Drawing.Point(595, 246)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(132, 118)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Loginpicture
        '
        Me.Loginpicture.Image = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.LOGIN_USER_PNG
        Me.Loginpicture.Location = New System.Drawing.Point(75, 86)
        Me.Loginpicture.Name = "Loginpicture"
        Me.Loginpicture.Size = New System.Drawing.Size(260, 256)
        Me.Loginpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Loginpicture.TabIndex = 3
        Me.Loginpicture.TabStop = False
        '
        'btnlogin
        '
        Me.btnlogin.AllowDrop = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.button1green
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnlogin.Location = New System.Drawing.Point(461, 245)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(150, 119)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.button1black
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(75, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 69)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Loginpicture)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Loginpicture As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btncancel As Button
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class

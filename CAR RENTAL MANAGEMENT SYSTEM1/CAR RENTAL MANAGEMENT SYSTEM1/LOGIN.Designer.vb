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
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Lblpassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btncancel = New System.Windows.Forms.Button()
        Me.Loginpicture = New System.Windows.Forms.PictureBox()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Btnbrowse = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusername.ForeColor = System.Drawing.Color.Black
        Me.Lblusername.Location = New System.Drawing.Point(342, 160)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(95, 22)
        Me.Lblusername.TabIndex = 9
        Me.Lblusername.Text = "Username:"
        Me.Lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblpassword
        '
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpassword.ForeColor = System.Drawing.Color.Black
        Me.Lblpassword.Location = New System.Drawing.Point(348, 207)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(92, 22)
        Me.Lblpassword.TabIndex = 10
        Me.Lblpassword.Text = "Password:"
        Me.Lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(468, 160)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(259, 20)
        Me.TxtUsername.TabIndex = 11
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(468, 207)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(259, 20)
        Me.Txtpassword.TabIndex = 12
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(468, 245)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(463, 354)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(238, 21)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "NO ID REGISTERED? CLICK HERE"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
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
        'Btncancel
        '
        Me.Btncancel.AllowDrop = True
        Me.Btncancel.BackColor = System.Drawing.Color.Transparent
        Me.Btncancel.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.GET_STARTED_BUTTON
        Me.Btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancel.FlatAppearance.BorderSize = 0
        Me.Btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncancel.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancel.ForeColor = System.Drawing.Color.Transparent
        Me.Btncancel.Location = New System.Drawing.Point(595, 246)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(132, 118)
        Me.Btncancel.TabIndex = 8
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.UseVisualStyleBackColor = False
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
        'Btnlogin
        '
        Me.Btnlogin.AllowDrop = True
        Me.Btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.button1green
        Me.Btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnlogin.FlatAppearance.BorderSize = 0
        Me.Btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlogin.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.ForeColor = System.Drawing.Color.Transparent
        Me.Btnlogin.Location = New System.Drawing.Point(461, 245)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(150, 119)
        Me.Btnlogin.TabIndex = 0
        Me.Btnlogin.Text = "LOGIN"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'Btnbrowse
        '
        Me.Btnbrowse.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.button1black
        Me.Btnbrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnbrowse.FlatAppearance.BorderSize = 0
        Me.Btnbrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btnbrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbrowse.Location = New System.Drawing.Point(75, 371)
        Me.Btnbrowse.Name = "Btnbrowse"
        Me.Btnbrowse.Size = New System.Drawing.Size(288, 69)
        Me.Btnbrowse.TabIndex = 5
        Me.Btnbrowse.Text = "BROWSE"
        Me.Btnbrowse.UseVisualStyleBackColor = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 539)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Lblpassword)
        Me.Controls.Add(Me.Lblusername)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Loginpicture)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnbrowse)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LOGIN"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Loginpicture As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btnbrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Btncancel As Button
    Friend WithEvents Lblusername As Label
    Friend WithEvents Lblpassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class

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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Lblpassword = New System.Windows.Forms.Label()
        Me.Txtemail = New System.Windows.Forms.TextBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btncancel = New System.Windows.Forms.Button()
        Me.Btnlogin = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(426, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 226)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
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
        Me.Lblusername.Location = New System.Drawing.Point(244, 199)
        Me.Lblusername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(70, 28)
        Me.Lblusername.TabIndex = 9
        Me.Lblusername.Text = "Email:"
        Me.Lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblpassword
        '
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpassword.ForeColor = System.Drawing.Color.Black
        Me.Lblpassword.Location = New System.Drawing.Point(244, 257)
        Me.Lblpassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(114, 28)
        Me.Lblpassword.TabIndex = 10
        Me.Lblpassword.Text = "Password:"
        Me.Lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txtemail
        '
        Me.Txtemail.Location = New System.Drawing.Point(404, 199)
        Me.Txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(344, 22)
        Me.Txtemail.TabIndex = 11
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(404, 257)
        Me.Txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(344, 22)
        Me.Txtpassword.TabIndex = 12
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(404, 304)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 20)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(399, 425)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(285, 25)
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
        Me.PictureBox1.Location = New System.Drawing.Point(801, -6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(415, 734)
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
        Me.Btncancel.Location = New System.Drawing.Point(546, 305)
        Me.Btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(176, 145)
        Me.Btncancel.TabIndex = 8
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.UseVisualStyleBackColor = False
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
        Me.Btnlogin.Location = New System.Drawing.Point(365, 304)
        Me.Btnlogin.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(200, 146)
        Me.Btnlogin.TabIndex = 0
        Me.Btnlogin.Text = "LOGIN"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1122, 630)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Txtemail)
        Me.Controls.Add(Me.Lblpassword)
        Me.Controls.Add(Me.Lblusername)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Btncancel As Button
    Friend WithEvents Lblusername As Label
    Friend WithEvents Lblpassword As Label
    Friend WithEvents Txtemail As TextBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class

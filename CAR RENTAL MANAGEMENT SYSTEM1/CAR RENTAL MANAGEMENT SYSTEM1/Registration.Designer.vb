<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtRegistration = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.Lblcontact = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CheckPassword = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Txtusertype = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Loginpicture = New System.Windows.Forms.PictureBox()
        Me.Btnbrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtRegistration
        '
        Me.TxtRegistration.AutoSize = True
        Me.TxtRegistration.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegistration.ForeColor = System.Drawing.Color.Black
        Me.TxtRegistration.Location = New System.Drawing.Point(612, 38)
        Me.TxtRegistration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtRegistration.Name = "TxtRegistration"
        Me.TxtRegistration.Size = New System.Drawing.Size(230, 75)
        Me.TxtRegistration.TabIndex = 1
        Me.TxtRegistration.Text = "SIGN UP "
        Me.TxtRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.Black
        Me.LblName.Location = New System.Drawing.Point(487, 169)
        Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(132, 28)
        Me.LblName.TabIndex = 10
        Me.LblName.Text = "Username  :"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.Black
        Me.LblPassword.Location = New System.Drawing.Point(486, 207)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(132, 28)
        Me.LblPassword.TabIndex = 11
        Me.LblPassword.Text = "Password   :"
        Me.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblcontact
        '
        Me.Lblcontact.AutoSize = True
        Me.Lblcontact.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcontact.ForeColor = System.Drawing.Color.Black
        Me.Lblcontact.Location = New System.Drawing.Point(508, 245)
        Me.Lblcontact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcontact.Name = "Lblcontact"
        Me.Lblcontact.Size = New System.Drawing.Size(112, 28)
        Me.Lblcontact.TabIndex = 12
        Me.Lblcontact.Text = "Contact  :"
        Me.Lblcontact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(534, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 28)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Email   :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(644, 171)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(255, 22)
        Me.TxtUsername.TabIndex = 14
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(644, 209)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(255, 22)
        Me.TxtPassword.TabIndex = 15
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(644, 247)
        Me.TxtContact.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(255, 22)
        Me.TxtContact.TabIndex = 16
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(644, 287)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(255, 22)
        Me.TxtEmail.TabIndex = 17
        '
        'BtnRegister
        '
        Me.BtnRegister.AllowDrop = True
        Me.BtnRegister.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.GET_STARTED_BUTTON
        Me.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegister.FlatAppearance.BorderSize = 0
        Me.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.Color.Transparent
        Me.BtnRegister.Location = New System.Drawing.Point(666, 319)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(176, 145)
        Me.BtnRegister.TabIndex = 18
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("MS Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(662, 431)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(179, 19)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Get back to Login"
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.BackColor = System.Drawing.Color.Transparent
        Me.CheckPassword.ForeColor = System.Drawing.Color.Black
        Me.CheckPassword.Location = New System.Drawing.Point(910, 212)
        Me.CheckPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckPassword.Name = "CheckPassword"
        Me.CheckPassword.Size = New System.Drawing.Size(125, 20)
        Me.CheckPassword.TabIndex = 20
        Me.CheckPassword.Text = "Show Password"
        Me.CheckPassword.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Txtusertype
        '
        Me.Txtusertype.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusertype.FormattingEnabled = True
        Me.Txtusertype.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.Txtusertype.Location = New System.Drawing.Point(644, 140)
        Me.Txtusertype.Name = "Txtusertype"
        Me.Txtusertype.Size = New System.Drawing.Size(121, 26)
        Me.Txtusertype.TabIndex = 21
        Me.Txtusertype.Text = "USERTYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(121, 390)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 28)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "*Upload your photo here*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Loginpicture
        '
        Me.Loginpicture.Image = Global.CAR_RENTAL_MANAGEMENT_SYSTEM1.My.Resources.Resources.LOGIN_USER_PNG
        Me.Loginpicture.Location = New System.Drawing.Point(78, 60)
        Me.Loginpicture.Margin = New System.Windows.Forms.Padding(4)
        Me.Loginpicture.Name = "Loginpicture"
        Me.Loginpicture.Size = New System.Drawing.Size(347, 315)
        Me.Loginpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Loginpicture.TabIndex = 22
        Me.Loginpicture.TabStop = False
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
        Me.Btnbrowse.Location = New System.Drawing.Point(78, 411)
        Me.Btnbrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnbrowse.Name = "Btnbrowse"
        Me.Btnbrowse.Size = New System.Drawing.Size(384, 85)
        Me.Btnbrowse.TabIndex = 24
        Me.Btnbrowse.Text = "BROWSE"
        Me.Btnbrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Loginpicture)
        Me.Controls.Add(Me.Btnbrowse)
        Me.Controls.Add(Me.Txtusertype)
        Me.Controls.Add(Me.CheckPassword)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtContact)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lblcontact)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtRegistration)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Registration"
        Me.Text = "Registration"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loginpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRegistration As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents Lblcontact As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckPassword As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Txtusertype As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Loginpicture As PictureBox
    Friend WithEvents Btnbrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminView
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTransactions = New System.Windows.Forms.LinkLabel()
        Me.LblVehicleInfo = New System.Windows.Forms.LinkLabel()
        Me.Lbluserinfo = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoUserpic = New System.Windows.Forms.PictureBox()
        Me.LogoFleetEase = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LogoUserpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoFleetEase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(231, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 564)
        Me.Panel2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(432, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Please choose an action!!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(791, 99)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "WELCOME ADMIN :)"
        '
        'LblTransactions
        '
        Me.LblTransactions.AutoSize = True
        Me.LblTransactions.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransactions.LinkColor = System.Drawing.Color.Black
        Me.LblTransactions.Location = New System.Drawing.Point(226, 44)
        Me.LblTransactions.Name = "LblTransactions"
        Me.LblTransactions.Size = New System.Drawing.Size(260, 29)
        Me.LblTransactions.TabIndex = 10
        Me.LblTransactions.TabStop = True
        Me.LblTransactions.Text = "TRANSACTION INFO"
        Me.LblTransactions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LblVehicleInfo
        '
        Me.LblVehicleInfo.AutoSize = True
        Me.LblVehicleInfo.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVehicleInfo.LinkColor = System.Drawing.Color.Black
        Me.LblVehicleInfo.Location = New System.Drawing.Point(566, 44)
        Me.LblVehicleInfo.Name = "LblVehicleInfo"
        Me.LblVehicleInfo.Size = New System.Drawing.Size(191, 29)
        Me.LblVehicleInfo.TabIndex = 11
        Me.LblVehicleInfo.TabStop = True
        Me.LblVehicleInfo.Text = "VEHICLE INFO"
        Me.LblVehicleInfo.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Lbluserinfo
        '
        Me.Lbluserinfo.AutoSize = True
        Me.Lbluserinfo.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluserinfo.LinkColor = System.Drawing.Color.Black
        Me.Lbluserinfo.Location = New System.Drawing.Point(858, 44)
        Me.Lbluserinfo.Name = "Lbluserinfo"
        Me.Lbluserinfo.Size = New System.Drawing.Size(146, 29)
        Me.Lbluserinfo.TabIndex = 12
        Me.Lbluserinfo.TabStop = True
        Me.Lbluserinfo.Text = "USER INFO"
        Me.Lbluserinfo.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.LOGIN_WALLPAPER_1
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LogoUserpic)
        Me.Panel1.Controls.Add(Me.LogoFleetEase)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(22, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 677)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 645)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Admin"
        '
        'LogoUserpic
        '
        Me.LogoUserpic.BackColor = System.Drawing.Color.Transparent
        Me.LogoUserpic.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.LOGIN_USER_PNG
        Me.LogoUserpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoUserpic.ErrorImage = Nothing
        Me.LogoUserpic.Location = New System.Drawing.Point(-11, 497)
        Me.LogoUserpic.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoUserpic.Name = "LogoUserpic"
        Me.LogoUserpic.Size = New System.Drawing.Size(185, 148)
        Me.LogoUserpic.TabIndex = 4
        Me.LogoUserpic.TabStop = False
        '
        'LogoFleetEase
        '
        Me.LogoFleetEase.BackColor = System.Drawing.Color.Transparent
        Me.LogoFleetEase.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.Fleet_EASE_removebg_preview
        Me.LogoFleetEase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoFleetEase.ErrorImage = Nothing
        Me.LogoFleetEase.Location = New System.Drawing.Point(-16, 0)
        Me.LogoFleetEase.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoFleetEase.Name = "LogoFleetEase"
        Me.LogoFleetEase.Size = New System.Drawing.Size(190, 189)
        Me.LogoFleetEase.TabIndex = 4
        Me.LogoFleetEase.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(1086, 44)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(214, 29)
        Me.LinkLabel1.TabIndex = 29
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CUSTOMER INFO"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 721)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Lbluserinfo)
        Me.Controls.Add(Me.LblVehicleInfo)
        Me.Controls.Add(Me.LblTransactions)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminView"
        Me.Text = "AdminView"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LogoUserpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoFleetEase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoFleetEase As PictureBox
    Friend WithEvents LogoUserpic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblTransactions As LinkLabel
    Friend WithEvents LblVehicleInfo As LinkLabel
    Friend WithEvents Lbluserinfo As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfo
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
        Me.LblLogininfo = New System.Windows.Forms.LinkLabel()
        Me.LblVehicleInfo = New System.Windows.Forms.LinkLabel()
        Me.LblTransactions = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoUserpic = New System.Windows.Forms.PictureBox()
        Me.LogoFleetEase = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LogoUserpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoFleetEase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLogininfo
        '
        Me.LblLogininfo.AutoSize = True
        Me.LblLogininfo.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogininfo.LinkColor = System.Drawing.Color.Red
        Me.LblLogininfo.Location = New System.Drawing.Point(764, 43)
        Me.LblLogininfo.Name = "LblLogininfo"
        Me.LblLogininfo.Size = New System.Drawing.Size(146, 29)
        Me.LblLogininfo.TabIndex = 27
        Me.LblLogininfo.TabStop = True
        Me.LblLogininfo.Text = "USER INFO"
        Me.LblLogininfo.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LblVehicleInfo
        '
        Me.LblVehicleInfo.AutoSize = True
        Me.LblVehicleInfo.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVehicleInfo.LinkColor = System.Drawing.Color.Black
        Me.LblVehicleInfo.Location = New System.Drawing.Point(522, 43)
        Me.LblVehicleInfo.Name = "LblVehicleInfo"
        Me.LblVehicleInfo.Size = New System.Drawing.Size(191, 29)
        Me.LblVehicleInfo.TabIndex = 26
        Me.LblVehicleInfo.TabStop = True
        Me.LblVehicleInfo.Text = "VEHICLE INFO"
        Me.LblVehicleInfo.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LblTransactions
        '
        Me.LblTransactions.AutoSize = True
        Me.LblTransactions.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransactions.LinkColor = System.Drawing.Color.Black
        Me.LblTransactions.Location = New System.Drawing.Point(240, 43)
        Me.LblTransactions.Name = "LblTransactions"
        Me.LblTransactions.Size = New System.Drawing.Size(260, 29)
        Me.LblTransactions.TabIndex = 25
        Me.LblTransactions.TabStop = True
        Me.LblTransactions.Text = "TRANSACTION INFO"
        Me.LblTransactions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(245, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 564)
        Me.Panel2.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(909, 459)
        Me.DataGridView1.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(66, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 29)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Grid View:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Ink Free", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(970, 43)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(214, 29)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CUSTOMER INFO"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.CAR_RENTAL_MANAGEMENT_SYSTEMm.My.Resources.Resources.LOGIN_WALLPAPER_1
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LogoUserpic)
        Me.Panel1.Controls.Add(Me.LogoFleetEase)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(36, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 677)
        Me.Panel1.TabIndex = 23
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
        'UserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 721)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LblLogininfo)
        Me.Controls.Add(Me.LblVehicleInfo)
        Me.Controls.Add(Me.LblTransactions)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserInfo"
        Me.Text = "UserInfo"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LogoUserpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoFleetEase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblLogininfo As LinkLabel
    Friend WithEvents LblVehicleInfo As LinkLabel
    Friend WithEvents LblTransactions As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoUserpic As PictureBox
    Friend WithEvents LogoFleetEase As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

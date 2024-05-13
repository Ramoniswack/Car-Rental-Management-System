<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Landing
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnstart = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CAR_RENTAL_MANAGEMENT_SYSTEM.My.Resources.Resources.LANDING_PAGE_FLEET_EASE1
        Me.PictureBox1.Location = New System.Drawing.Point(1, -37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 622)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnstart.Font = New System.Drawing.Font("Mont Heavy DEMO", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.Color.Black
        Me.btnstart.Location = New System.Drawing.Point(741, 206)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(162, 60)
        Me.btnstart.TabIndex = 1
        Me.btnstart.Text = "GET STARTED"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 529)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Landing"
        Me.Text = "Landing"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnstart As Button
End Class

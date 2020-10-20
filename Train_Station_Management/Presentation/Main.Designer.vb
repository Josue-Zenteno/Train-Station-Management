<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.btnConnectMain = New System.Windows.Forms.Button()
        Me.btnManagementMain = New System.Windows.Forms.Button()
        Me.btnRankingsMain = New System.Windows.Forms.Button()
        Me.btnTrainInfoMain = New System.Windows.Forms.Button()
        Me.btnSelectMain = New System.Windows.Forms.Button()
        Me.btnBestTripMain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'btnConnectMain
        '
        Me.btnConnectMain.BackColor = System.Drawing.Color.Tomato
        Me.btnConnectMain.Enabled = False
        Me.btnConnectMain.Location = New System.Drawing.Point(136, 273)
        Me.btnConnectMain.Name = "btnConnectMain"
        Me.btnConnectMain.Size = New System.Drawing.Size(104, 50)
        Me.btnConnectMain.TabIndex = 0
        Me.btnConnectMain.Text = "Connect"
        Me.btnConnectMain.UseVisualStyleBackColor = False
        '
        'btnManagementMain
        '
        Me.btnManagementMain.BackColor = System.Drawing.Color.Tomato
        Me.btnManagementMain.Enabled = False
        Me.btnManagementMain.Location = New System.Drawing.Point(266, 105)
        Me.btnManagementMain.Name = "btnManagementMain"
        Me.btnManagementMain.Size = New System.Drawing.Size(104, 50)
        Me.btnManagementMain.TabIndex = 10
        Me.btnManagementMain.Text = "Management"
        Me.btnManagementMain.UseVisualStyleBackColor = False
        '
        'btnRankingsMain
        '
        Me.btnRankingsMain.BackColor = System.Drawing.Color.Tomato
        Me.btnRankingsMain.Enabled = False
        Me.btnRankingsMain.Location = New System.Drawing.Point(266, 161)
        Me.btnRankingsMain.Name = "btnRankingsMain"
        Me.btnRankingsMain.Size = New System.Drawing.Size(104, 50)
        Me.btnRankingsMain.TabIndex = 11
        Me.btnRankingsMain.Text = "Rankings"
        Me.btnRankingsMain.UseVisualStyleBackColor = False
        '
        'btnTrainInfoMain
        '
        Me.btnTrainInfoMain.BackColor = System.Drawing.Color.Tomato
        Me.btnTrainInfoMain.Enabled = False
        Me.btnTrainInfoMain.Location = New System.Drawing.Point(266, 217)
        Me.btnTrainInfoMain.Name = "btnTrainInfoMain"
        Me.btnTrainInfoMain.Size = New System.Drawing.Size(104, 50)
        Me.btnTrainInfoMain.TabIndex = 12
        Me.btnTrainInfoMain.Text = "Train Information"
        Me.btnTrainInfoMain.UseVisualStyleBackColor = False
        '
        'btnSelectMain
        '
        Me.btnSelectMain.BackColor = System.Drawing.Color.Tomato
        Me.btnSelectMain.Location = New System.Drawing.Point(26, 273)
        Me.btnSelectMain.Name = "btnSelectMain"
        Me.btnSelectMain.Size = New System.Drawing.Size(104, 50)
        Me.btnSelectMain.TabIndex = 13
        Me.btnSelectMain.Text = "Select"
        Me.btnSelectMain.UseVisualStyleBackColor = False
        '
        'btnBestTripMain
        '
        Me.btnBestTripMain.BackColor = System.Drawing.Color.Tomato
        Me.btnBestTripMain.Enabled = False
        Me.btnBestTripMain.Location = New System.Drawing.Point(266, 273)
        Me.btnBestTripMain.Name = "btnBestTripMain"
        Me.btnBestTripMain.Size = New System.Drawing.Size(104, 50)
        Me.btnBestTripMain.TabIndex = 14
        Me.btnBestTripMain.Text = "Best Trip"
        Me.btnBestTripMain.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Spicy Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = " Trains Data Base"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(51, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(312, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(349, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 378)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBestTripMain)
        Me.Controls.Add(Me.btnSelectMain)
        Me.Controls.Add(Me.btnTrainInfoMain)
        Me.Controls.Add(Me.btnRankingsMain)
        Me.Controls.Add(Me.btnManagementMain)
        Me.Controls.Add(Me.btnConnectMain)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents btnConnectMain As Button
    Friend WithEvents btnManagementMain As Button
    Friend WithEvents btnRankingsMain As Button
    Friend WithEvents btnTrainInfoMain As Button
    Friend WithEvents btnSelectMain As Button
    Friend WithEvents btnBestTripMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

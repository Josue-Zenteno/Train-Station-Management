<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management))
        Me.cmbOptionTableManagement = New System.Windows.Forms.ComboBox()
        Me.btnSelectTableManagement = New System.Windows.Forms.Button()
        Me.lblAttribute1Management = New System.Windows.Forms.Label()
        Me.lblAttribute2Management = New System.Windows.Forms.Label()
        Me.lblAttribute3Management = New System.Windows.Forms.Label()
        Me.txtAttributeValue1Management = New System.Windows.Forms.TextBox()
        Me.txtAttributeValue2Management = New System.Windows.Forms.TextBox()
        Me.txtAttributeValue3Management = New System.Windows.Forms.TextBox()
        Me.btnUpdateManagement = New System.Windows.Forms.Button()
        Me.btnInsertManagement = New System.Windows.Forms.Button()
        Me.btnDeleteManagement = New System.Windows.Forms.Button()
        Me.lstTableInfo1Management = New System.Windows.Forms.ListBox()
        Me.txtAttributeValue4Management = New System.Windows.Forms.TextBox()
        Me.lblAttribute4Management = New System.Windows.Forms.Label()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.lstTableInfo2Management = New System.Windows.Forms.ListBox()
        Me.lstTableInfo3Management = New System.Windows.Forms.ListBox()
        Me.btnViewInfoManagement = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDelst1Management = New System.Windows.Forms.Label()
        Me.lblDelst2Management = New System.Windows.Forms.Label()
        Me.lblDelst3Management = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbOptionTableManagement
        '
        Me.cmbOptionTableManagement.FormattingEnabled = True
        Me.cmbOptionTableManagement.Items.AddRange(New Object() {"TrainTypes", "Trains", "Products", "Prices", "Trips"})
        Me.cmbOptionTableManagement.Location = New System.Drawing.Point(35, 89)
        Me.cmbOptionTableManagement.Name = "cmbOptionTableManagement"
        Me.cmbOptionTableManagement.Size = New System.Drawing.Size(193, 21)
        Me.cmbOptionTableManagement.TabIndex = 0
        Me.cmbOptionTableManagement.Text = "Option"
        '
        'btnSelectTableManagement
        '
        Me.btnSelectTableManagement.BackColor = System.Drawing.Color.Tomato
        Me.btnSelectTableManagement.Location = New System.Drawing.Point(379, 483)
        Me.btnSelectTableManagement.Name = "btnSelectTableManagement"
        Me.btnSelectTableManagement.Size = New System.Drawing.Size(114, 79)
        Me.btnSelectTableManagement.TabIndex = 1
        Me.btnSelectTableManagement.Text = "Charge"
        Me.btnSelectTableManagement.UseVisualStyleBackColor = False
        '
        'lblAttribute1Management
        '
        Me.lblAttribute1Management.AutoSize = True
        Me.lblAttribute1Management.Location = New System.Drawing.Point(42, 459)
        Me.lblAttribute1Management.Name = "lblAttribute1Management"
        Me.lblAttribute1Management.Size = New System.Drawing.Size(56, 13)
        Me.lblAttribute1Management.TabIndex = 2
        Me.lblAttribute1Management.Text = "Attribute1"
        Me.lblAttribute1Management.Visible = False
        '
        'lblAttribute2Management
        '
        Me.lblAttribute2Management.AutoSize = True
        Me.lblAttribute2Management.Location = New System.Drawing.Point(42, 497)
        Me.lblAttribute2Management.Name = "lblAttribute2Management"
        Me.lblAttribute2Management.Size = New System.Drawing.Size(58, 13)
        Me.lblAttribute2Management.TabIndex = 3
        Me.lblAttribute2Management.Text = "Attribute2"
        Me.lblAttribute2Management.Visible = False
        '
        'lblAttribute3Management
        '
        Me.lblAttribute3Management.AutoSize = True
        Me.lblAttribute3Management.Location = New System.Drawing.Point(42, 530)
        Me.lblAttribute3Management.Name = "lblAttribute3Management"
        Me.lblAttribute3Management.Size = New System.Drawing.Size(58, 13)
        Me.lblAttribute3Management.TabIndex = 4
        Me.lblAttribute3Management.Text = "Attribute3"
        Me.lblAttribute3Management.Visible = False
        '
        'txtAttributeValue1Management
        '
        Me.txtAttributeValue1Management.Location = New System.Drawing.Point(181, 452)
        Me.txtAttributeValue1Management.Name = "txtAttributeValue1Management"
        Me.txtAttributeValue1Management.Size = New System.Drawing.Size(169, 21)
        Me.txtAttributeValue1Management.TabIndex = 10
        Me.txtAttributeValue1Management.Text = "-"
        Me.txtAttributeValue1Management.Visible = False
        '
        'txtAttributeValue2Management
        '
        Me.txtAttributeValue2Management.Location = New System.Drawing.Point(181, 492)
        Me.txtAttributeValue2Management.Name = "txtAttributeValue2Management"
        Me.txtAttributeValue2Management.Size = New System.Drawing.Size(169, 21)
        Me.txtAttributeValue2Management.TabIndex = 11
        Me.txtAttributeValue2Management.Text = "-"
        Me.txtAttributeValue2Management.Visible = False
        '
        'txtAttributeValue3Management
        '
        Me.txtAttributeValue3Management.Location = New System.Drawing.Point(181, 528)
        Me.txtAttributeValue3Management.Name = "txtAttributeValue3Management"
        Me.txtAttributeValue3Management.Size = New System.Drawing.Size(169, 21)
        Me.txtAttributeValue3Management.TabIndex = 12
        Me.txtAttributeValue3Management.Text = "-"
        Me.txtAttributeValue3Management.Visible = False
        '
        'btnUpdateManagement
        '
        Me.btnUpdateManagement.BackColor = System.Drawing.Color.Tomato
        Me.btnUpdateManagement.Enabled = False
        Me.btnUpdateManagement.Location = New System.Drawing.Point(162, 613)
        Me.btnUpdateManagement.Name = "btnUpdateManagement"
        Me.btnUpdateManagement.Size = New System.Drawing.Size(87, 54)
        Me.btnUpdateManagement.TabIndex = 13
        Me.btnUpdateManagement.Text = "Update"
        Me.btnUpdateManagement.UseVisualStyleBackColor = False
        '
        'btnInsertManagement
        '
        Me.btnInsertManagement.BackColor = System.Drawing.Color.Tomato
        Me.btnInsertManagement.Enabled = False
        Me.btnInsertManagement.Location = New System.Drawing.Point(257, 613)
        Me.btnInsertManagement.Name = "btnInsertManagement"
        Me.btnInsertManagement.Size = New System.Drawing.Size(87, 54)
        Me.btnInsertManagement.TabIndex = 14
        Me.btnInsertManagement.Text = "Insert"
        Me.btnInsertManagement.UseVisualStyleBackColor = False
        '
        'btnDeleteManagement
        '
        Me.btnDeleteManagement.BackColor = System.Drawing.Color.Tomato
        Me.btnDeleteManagement.Enabled = False
        Me.btnDeleteManagement.Location = New System.Drawing.Point(353, 613)
        Me.btnDeleteManagement.Name = "btnDeleteManagement"
        Me.btnDeleteManagement.Size = New System.Drawing.Size(87, 54)
        Me.btnDeleteManagement.TabIndex = 15
        Me.btnDeleteManagement.Text = "Delete"
        Me.btnDeleteManagement.UseVisualStyleBackColor = False
        '
        'lstTableInfo1Management
        '
        Me.lstTableInfo1Management.AccessibleName = ""
        Me.lstTableInfo1Management.FormattingEnabled = True
        Me.lstTableInfo1Management.Location = New System.Drawing.Point(35, 152)
        Me.lstTableInfo1Management.Name = "lstTableInfo1Management"
        Me.lstTableInfo1Management.Size = New System.Drawing.Size(157, 264)
        Me.lstTableInfo1Management.TabIndex = 17
        '
        'txtAttributeValue4Management
        '
        Me.txtAttributeValue4Management.Location = New System.Drawing.Point(181, 562)
        Me.txtAttributeValue4Management.Name = "txtAttributeValue4Management"
        Me.txtAttributeValue4Management.Size = New System.Drawing.Size(169, 21)
        Me.txtAttributeValue4Management.TabIndex = 19
        Me.txtAttributeValue4Management.Text = "-"
        Me.txtAttributeValue4Management.Visible = False
        '
        'lblAttribute4Management
        '
        Me.lblAttribute4Management.AutoSize = True
        Me.lblAttribute4Management.Location = New System.Drawing.Point(42, 564)
        Me.lblAttribute4Management.Name = "lblAttribute4Management"
        Me.lblAttribute4Management.Size = New System.Drawing.Size(58, 13)
        Me.lblAttribute4Management.TabIndex = 18
        Me.lblAttribute4Management.Text = "Attribute4"
        Me.lblAttribute4Management.Visible = False
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'lstTableInfo2Management
        '
        Me.lstTableInfo2Management.AccessibleName = ""
        Me.lstTableInfo2Management.FormattingEnabled = True
        Me.lstTableInfo2Management.Location = New System.Drawing.Point(191, 152)
        Me.lstTableInfo2Management.Name = "lstTableInfo2Management"
        Me.lstTableInfo2Management.Size = New System.Drawing.Size(157, 264)
        Me.lstTableInfo2Management.TabIndex = 20
        '
        'lstTableInfo3Management
        '
        Me.lstTableInfo3Management.AccessibleName = ""
        Me.lstTableInfo3Management.FormattingEnabled = True
        Me.lstTableInfo3Management.Location = New System.Drawing.Point(347, 152)
        Me.lstTableInfo3Management.Name = "lstTableInfo3Management"
        Me.lstTableInfo3Management.Size = New System.Drawing.Size(157, 264)
        Me.lstTableInfo3Management.TabIndex = 21
        '
        'btnViewInfoManagement
        '
        Me.btnViewInfoManagement.BackColor = System.Drawing.Color.Tomato
        Me.btnViewInfoManagement.Location = New System.Drawing.Point(67, 613)
        Me.btnViewInfoManagement.Name = "btnViewInfoManagement"
        Me.btnViewInfoManagement.Size = New System.Drawing.Size(87, 54)
        Me.btnViewInfoManagement.TabIndex = 22
        Me.btnViewInfoManagement.Text = "View"
        Me.btnViewInfoManagement.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(432, 670)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Spicy Team"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(473, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 32)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(436, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 23)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Management"
        '
        'lblDelst1Management
        '
        Me.lblDelst1Management.AutoSize = True
        Me.lblDelst1Management.Location = New System.Drawing.Point(32, 132)
        Me.lblDelst1Management.Name = "lblDelst1Management"
        Me.lblDelst1Management.Size = New System.Drawing.Size(12, 13)
        Me.lblDelst1Management.TabIndex = 36
        Me.lblDelst1Management.Text = "-"
        Me.lblDelst1Management.Visible = False
        '
        'lblDelst2Management
        '
        Me.lblDelst2Management.AutoSize = True
        Me.lblDelst2Management.Location = New System.Drawing.Point(188, 132)
        Me.lblDelst2Management.Name = "lblDelst2Management"
        Me.lblDelst2Management.Size = New System.Drawing.Size(12, 13)
        Me.lblDelst2Management.TabIndex = 37
        Me.lblDelst2Management.Text = "-"
        Me.lblDelst2Management.Visible = False
        '
        'lblDelst3Management
        '
        Me.lblDelst3Management.AutoSize = True
        Me.lblDelst3Management.Location = New System.Drawing.Point(350, 132)
        Me.lblDelst3Management.Name = "lblDelst3Management"
        Me.lblDelst3Management.Size = New System.Drawing.Size(12, 13)
        Me.lblDelst3Management.TabIndex = 38
        Me.lblDelst3Management.Text = "-"
        Me.lblDelst3Management.Visible = False
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 704)
        Me.Controls.Add(Me.lblDelst3Management)
        Me.Controls.Add(Me.lblDelst2Management)
        Me.Controls.Add(Me.lblDelst1Management)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewInfoManagement)
        Me.Controls.Add(Me.lstTableInfo3Management)
        Me.Controls.Add(Me.lstTableInfo2Management)
        Me.Controls.Add(Me.txtAttributeValue4Management)
        Me.Controls.Add(Me.lblAttribute4Management)
        Me.Controls.Add(Me.lstTableInfo1Management)
        Me.Controls.Add(Me.btnDeleteManagement)
        Me.Controls.Add(Me.btnInsertManagement)
        Me.Controls.Add(Me.btnUpdateManagement)
        Me.Controls.Add(Me.txtAttributeValue3Management)
        Me.Controls.Add(Me.txtAttributeValue2Management)
        Me.Controls.Add(Me.txtAttributeValue1Management)
        Me.Controls.Add(Me.lblAttribute3Management)
        Me.Controls.Add(Me.lblAttribute2Management)
        Me.Controls.Add(Me.lblAttribute1Management)
        Me.Controls.Add(Me.btnSelectTableManagement)
        Me.Controls.Add(Me.cmbOptionTableManagement)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Management"
        Me.Text = "Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbOptionTableManagement As ComboBox
    Friend WithEvents btnSelectTableManagement As Button
    Friend WithEvents lblAttribute1Management As Label
    Friend WithEvents lblAttribute2Management As Label
    Friend WithEvents lblAttribute3Management As Label
    Friend WithEvents txtAttributeValue1Management As TextBox
    Friend WithEvents txtAttributeValue2Management As TextBox
    Friend WithEvents txtAttributeValue3Management As TextBox
    Friend WithEvents btnUpdateManagement As Button
    Friend WithEvents btnInsertManagement As Button
    Friend WithEvents btnDeleteManagement As Button
    Friend WithEvents lstTableInfo1Management As ListBox
    Friend WithEvents txtAttributeValue4Management As TextBox
    Friend WithEvents lblAttribute4Management As Label
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents lstTableInfo2Management As ListBox
    Friend WithEvents lstTableInfo3Management As ListBox
    Friend WithEvents btnViewInfoManagement As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDelst1Management As Label
    Friend WithEvents lblDelst2Management As Label
    Friend WithEvents lblDelst3Management As Label
End Class

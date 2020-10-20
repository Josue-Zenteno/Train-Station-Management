<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rankings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rankings))
        Me.btnTypeOfTrain = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.lstProducts1Rankings = New System.Windows.Forms.ListBox()
        Me.DateTimePicker1Rankings = New System.Windows.Forms.DateTimePicker()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.DateTimePicker2Rankings = New System.Windows.Forms.DateTimePicker()
        Me.lblInitialDateRankings = New System.Windows.Forms.Label()
        Me.lblEndDateRankings = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProductDescriptionRankings = New System.Windows.Forms.Label()
        Me.lblProductIDRankings = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstTrainTypes1Rankings = New System.Windows.Forms.ListBox()
        Me.lblTrainTypeIDRankings = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTrainTypeDescriptionRankings = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstTrainTypesRepetitionsRankings = New System.Windows.Forms.ListBox()
        Me.lstProductRepetitionsRankings = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTypeOfTrain
        '
        Me.btnTypeOfTrain.BackColor = System.Drawing.Color.Tomato
        Me.btnTypeOfTrain.Location = New System.Drawing.Point(619, 422)
        Me.btnTypeOfTrain.Name = "btnTypeOfTrain"
        Me.btnTypeOfTrain.Size = New System.Drawing.Size(105, 50)
        Me.btnTypeOfTrain.TabIndex = 0
        Me.btnTypeOfTrain.Text = "Train Type"
        Me.btnTypeOfTrain.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.Tomato
        Me.btnProduct.Location = New System.Drawing.Point(493, 422)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(105, 50)
        Me.btnProduct.TabIndex = 1
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'lstProducts1Rankings
        '
        Me.lstProducts1Rankings.FormattingEnabled = True
        Me.lstProducts1Rankings.Location = New System.Drawing.Point(267, 230)
        Me.lstProducts1Rankings.Name = "lstProducts1Rankings"
        Me.lstProducts1Rankings.Size = New System.Drawing.Size(98, 238)
        Me.lstProducts1Rankings.TabIndex = 2
        '
        'DateTimePicker1Rankings
        '
        Me.DateTimePicker1Rankings.Location = New System.Drawing.Point(127, 97)
        Me.DateTimePicker1Rankings.Name = "DateTimePicker1Rankings"
        Me.DateTimePicker1Rankings.Size = New System.Drawing.Size(326, 21)
        Me.DateTimePicker1Rankings.TabIndex = 7
        Me.DateTimePicker1Rankings.Value = New Date(2020, 4, 21, 0, 0, 0, 0)
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'DateTimePicker2Rankings
        '
        Me.DateTimePicker2Rankings.Location = New System.Drawing.Point(127, 129)
        Me.DateTimePicker2Rankings.Name = "DateTimePicker2Rankings"
        Me.DateTimePicker2Rankings.Size = New System.Drawing.Size(326, 21)
        Me.DateTimePicker2Rankings.TabIndex = 11
        Me.DateTimePicker2Rankings.Value = New Date(2020, 4, 21, 0, 0, 0, 0)
        '
        'lblInitialDateRankings
        '
        Me.lblInitialDateRankings.AutoSize = True
        Me.lblInitialDateRankings.Location = New System.Drawing.Point(49, 101)
        Me.lblInitialDateRankings.Name = "lblInitialDateRankings"
        Me.lblInitialDateRankings.Size = New System.Drawing.Size(61, 13)
        Me.lblInitialDateRankings.TabIndex = 12
        Me.lblInitialDateRankings.Text = "Initial Date"
        '
        'lblEndDateRankings
        '
        Me.lblEndDateRankings.AutoSize = True
        Me.lblEndDateRankings.Location = New System.Drawing.Point(50, 133)
        Me.lblEndDateRankings.Name = "lblEndDateRankings"
        Me.lblEndDateRankings.Size = New System.Drawing.Size(52, 13)
        Me.lblEndDateRankings.TabIndex = 13
        Me.lblEndDateRankings.Text = "End Date"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(688, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 32)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(651, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Rankings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Spicy Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Product Description :"
        '
        'lblProductDescriptionRankings
        '
        Me.lblProductDescriptionRankings.AutoSize = True
        Me.lblProductDescriptionRankings.Location = New System.Drawing.Point(507, 338)
        Me.lblProductDescriptionRankings.Name = "lblProductDescriptionRankings"
        Me.lblProductDescriptionRankings.Size = New System.Drawing.Size(12, 13)
        Me.lblProductDescriptionRankings.TabIndex = 40
        Me.lblProductDescriptionRankings.Text = "-"
        '
        'lblProductIDRankings
        '
        Me.lblProductIDRankings.AutoSize = True
        Me.lblProductIDRankings.Location = New System.Drawing.Point(589, 280)
        Me.lblProductIDRankings.Name = "lblProductIDRankings"
        Me.lblProductIDRankings.Size = New System.Drawing.Size(12, 13)
        Me.lblProductIDRankings.TabIndex = 42
        Me.lblProductIDRankings.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(503, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Product ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Products ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Train Types ID"
        '
        'lstTrainTypes1Rankings
        '
        Me.lstTrainTypes1Rankings.FormattingEnabled = True
        Me.lstTrainTypes1Rankings.Location = New System.Drawing.Point(46, 230)
        Me.lstTrainTypes1Rankings.Name = "lstTrainTypes1Rankings"
        Me.lstTrainTypes1Rankings.Size = New System.Drawing.Size(104, 238)
        Me.lstTrainTypes1Rankings.TabIndex = 44
        '
        'lblTrainTypeIDRankings
        '
        Me.lblTrainTypeIDRankings.AutoSize = True
        Me.lblTrainTypeIDRankings.Location = New System.Drawing.Point(604, 124)
        Me.lblTrainTypeIDRankings.Name = "lblTrainTypeIDRankings"
        Me.lblTrainTypeIDRankings.Size = New System.Drawing.Size(12, 13)
        Me.lblTrainTypeIDRankings.TabIndex = 49
        Me.lblTrainTypeIDRankings.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(502, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Train Type ID :"
        '
        'lblTrainTypeDescriptionRankings
        '
        Me.lblTrainTypeDescriptionRankings.AutoSize = True
        Me.lblTrainTypeDescriptionRankings.Location = New System.Drawing.Point(504, 180)
        Me.lblTrainTypeDescriptionRankings.Name = "lblTrainTypeDescriptionRankings"
        Me.lblTrainTypeDescriptionRankings.Size = New System.Drawing.Size(12, 13)
        Me.lblTrainTypeDescriptionRankings.TabIndex = 47
        Me.lblTrainTypeDescriptionRankings.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(502, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Train Type Description :"
        '
        'lstTrainTypesRepetitionsRankings
        '
        Me.lstTrainTypesRepetitionsRankings.FormattingEnabled = True
        Me.lstTrainTypesRepetitionsRankings.Location = New System.Drawing.Point(147, 230)
        Me.lstTrainTypesRepetitionsRankings.Name = "lstTrainTypesRepetitionsRankings"
        Me.lstTrainTypesRepetitionsRankings.Size = New System.Drawing.Size(95, 238)
        Me.lstTrainTypesRepetitionsRankings.TabIndex = 55
        '
        'lstProductRepetitionsRankings
        '
        Me.lstProductRepetitionsRankings.FormattingEnabled = True
        Me.lstProductRepetitionsRankings.Location = New System.Drawing.Point(363, 230)
        Me.lstProductRepetitionsRankings.Name = "lstProductRepetitionsRankings"
        Me.lstProductRepetitionsRankings.Size = New System.Drawing.Size(90, 238)
        Me.lstProductRepetitionsRankings.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Repetitions"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(360, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Repetitions"
        '
        'Rankings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(740, 511)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstProductRepetitionsRankings)
        Me.Controls.Add(Me.lstTrainTypesRepetitionsRankings)
        Me.Controls.Add(Me.lblTrainTypeIDRankings)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTrainTypeDescriptionRankings)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstTrainTypes1Rankings)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblProductIDRankings)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblProductDescriptionRankings)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEndDateRankings)
        Me.Controls.Add(Me.lblInitialDateRankings)
        Me.Controls.Add(Me.DateTimePicker2Rankings)
        Me.Controls.Add(Me.DateTimePicker1Rankings)
        Me.Controls.Add(Me.lstProducts1Rankings)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnTypeOfTrain)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rankings"
        Me.Text = "Rankings"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTypeOfTrain As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents DateTimePicker1Rankings As DateTimePicker
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DateTimePicker2Rankings As DateTimePicker
    Friend WithEvents lblInitialDateRankings As Label
    Friend WithEvents lblEndDateRankings As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProductDescriptionRankings As Label
    Friend WithEvents lblProductIDRankings As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstTrainTypes1Rankings As ListBox
    Friend WithEvents lblTrainTypeIDRankings As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTrainTypeDescriptionRankings As Label
    Friend WithEvents Label10 As Label
    Private WithEvents lstProducts1Rankings As ListBox
    Friend WithEvents lstTrainTypesRepetitionsRankings As ListBox
    Private WithEvents lstProductRepetitionsRankings As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class

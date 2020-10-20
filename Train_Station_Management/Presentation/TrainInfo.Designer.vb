<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrainInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainInfo))
        Me.lstTrainsTrainInfo = New System.Windows.Forms.ListBox()
        Me.lblNumberOfTripsTrainInfo = New System.Windows.Forms.Label()
        Me.lstProductsTrainInfo = New System.Windows.Forms.ListBox()
        Me.PickerInitialDate = New System.Windows.Forms.DateTimePicker()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.btnDoitTrainInfo = New System.Windows.Forms.Button()
        Me.PickerEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblNoT = New System.Windows.Forms.Label()
        Me.lblInitialDateTrainInfo = New System.Windows.Forms.Label()
        Me.lblEndDateTrainInfo = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProductIDTrainInfo = New System.Windows.Forms.Label()
        Me.lblProductDescriptionTrainInfo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTrainTypeValueTrainInfo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstTrainsTrainInfo
        '
        Me.lstTrainsTrainInfo.FormattingEnabled = True
        Me.lstTrainsTrainInfo.Location = New System.Drawing.Point(35, 205)
        Me.lstTrainsTrainInfo.Name = "lstTrainsTrainInfo"
        Me.lstTrainsTrainInfo.Size = New System.Drawing.Size(163, 186)
        Me.lstTrainsTrainInfo.TabIndex = 0
        '
        'lblNumberOfTripsTrainInfo
        '
        Me.lblNumberOfTripsTrainInfo.AutoSize = True
        Me.lblNumberOfTripsTrainInfo.Location = New System.Drawing.Point(38, 410)
        Me.lblNumberOfTripsTrainInfo.Name = "lblNumberOfTripsTrainInfo"
        Me.lblNumberOfTripsTrainInfo.Size = New System.Drawing.Size(88, 13)
        Me.lblNumberOfTripsTrainInfo.TabIndex = 1
        Me.lblNumberOfTripsTrainInfo.Text = "Number of trips:"
        '
        'lstProductsTrainInfo
        '
        Me.lstProductsTrainInfo.FormattingEnabled = True
        Me.lstProductsTrainInfo.Location = New System.Drawing.Point(223, 205)
        Me.lstProductsTrainInfo.Name = "lstProductsTrainInfo"
        Me.lstProductsTrainInfo.Size = New System.Drawing.Size(163, 186)
        Me.lstProductsTrainInfo.TabIndex = 2
        '
        'PickerInitialDate
        '
        Me.PickerInitialDate.Location = New System.Drawing.Point(132, 96)
        Me.PickerInitialDate.Name = "PickerInitialDate"
        Me.PickerInitialDate.Size = New System.Drawing.Size(245, 21)
        Me.PickerInitialDate.TabIndex = 5
        Me.PickerInitialDate.Value = New Date(2020, 4, 21, 0, 0, 0, 0)
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'btnDoitTrainInfo
        '
        Me.btnDoitTrainInfo.BackColor = System.Drawing.Color.Tomato
        Me.btnDoitTrainInfo.Location = New System.Drawing.Point(158, 495)
        Me.btnDoitTrainInfo.Name = "btnDoitTrainInfo"
        Me.btnDoitTrainInfo.Size = New System.Drawing.Size(106, 49)
        Me.btnDoitTrainInfo.TabIndex = 6
        Me.btnDoitTrainInfo.Text = "Search"
        Me.btnDoitTrainInfo.UseVisualStyleBackColor = False
        '
        'PickerEndDate
        '
        Me.PickerEndDate.Location = New System.Drawing.Point(132, 126)
        Me.PickerEndDate.Name = "PickerEndDate"
        Me.PickerEndDate.Size = New System.Drawing.Size(245, 21)
        Me.PickerEndDate.TabIndex = 7
        Me.PickerEndDate.Value = New Date(2020, 4, 21, 0, 0, 0, 0)
        '
        'lblNoT
        '
        Me.lblNoT.AutoSize = True
        Me.lblNoT.Location = New System.Drawing.Point(153, 410)
        Me.lblNoT.Name = "lblNoT"
        Me.lblNoT.Size = New System.Drawing.Size(12, 13)
        Me.lblNoT.TabIndex = 8
        Me.lblNoT.Text = "-"
        '
        'lblInitialDateTrainInfo
        '
        Me.lblInitialDateTrainInfo.AutoSize = True
        Me.lblInitialDateTrainInfo.Location = New System.Drawing.Point(54, 98)
        Me.lblInitialDateTrainInfo.Name = "lblInitialDateTrainInfo"
        Me.lblInitialDateTrainInfo.Size = New System.Drawing.Size(58, 13)
        Me.lblInitialDateTrainInfo.TabIndex = 9
        Me.lblInitialDateTrainInfo.Text = "InitialDate"
        '
        'lblEndDateTrainInfo
        '
        Me.lblEndDateTrainInfo.AutoSize = True
        Me.lblEndDateTrainInfo.Location = New System.Drawing.Point(54, 128)
        Me.lblEndDateTrainInfo.Name = "lblEndDateTrainInfo"
        Me.lblEndDateTrainInfo.Size = New System.Drawing.Size(49, 13)
        Me.lblEndDateTrainInfo.TabIndex = 10
        Me.lblEndDateTrainInfo.Text = "EndDate"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(370, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 32)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(333, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 23)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Train Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Spicy Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Trains"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Products ID"
        '
        'lblProductIDTrainInfo
        '
        Me.lblProductIDTrainInfo.AutoSize = True
        Me.lblProductIDTrainInfo.Location = New System.Drawing.Point(315, 410)
        Me.lblProductIDTrainInfo.Name = "lblProductIDTrainInfo"
        Me.lblProductIDTrainInfo.Size = New System.Drawing.Size(12, 13)
        Me.lblProductIDTrainInfo.TabIndex = 40
        Me.lblProductIDTrainInfo.Text = "-"
        '
        'lblProductDescriptionTrainInfo
        '
        Me.lblProductDescriptionTrainInfo.AutoSize = True
        Me.lblProductDescriptionTrainInfo.Location = New System.Drawing.Point(315, 437)
        Me.lblProductDescriptionTrainInfo.Name = "lblProductDescriptionTrainInfo"
        Me.lblProductDescriptionTrainInfo.Size = New System.Drawing.Size(12, 13)
        Me.lblProductDescriptionTrainInfo.TabIndex = 41
        Me.lblProductDescriptionTrainInfo.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Description :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Product ID :"
        '
        'lblTrainTypeValueTrainInfo
        '
        Me.lblTrainTypeValueTrainInfo.AutoSize = True
        Me.lblTrainTypeValueTrainInfo.Location = New System.Drawing.Point(38, 463)
        Me.lblTrainTypeValueTrainInfo.Name = "lblTrainTypeValueTrainInfo"
        Me.lblTrainTypeValueTrainInfo.Size = New System.Drawing.Size(12, 13)
        Me.lblTrainTypeValueTrainInfo.TabIndex = 45
        Me.lblTrainTypeValueTrainInfo.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Type of Train:"
        '
        'TrainInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(429, 565)
        Me.Controls.Add(Me.lblTrainTypeValueTrainInfo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblProductDescriptionTrainInfo)
        Me.Controls.Add(Me.lblProductIDTrainInfo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEndDateTrainInfo)
        Me.Controls.Add(Me.lblInitialDateTrainInfo)
        Me.Controls.Add(Me.lblNoT)
        Me.Controls.Add(Me.PickerEndDate)
        Me.Controls.Add(Me.btnDoitTrainInfo)
        Me.Controls.Add(Me.PickerInitialDate)
        Me.Controls.Add(Me.lstProductsTrainInfo)
        Me.Controls.Add(Me.lblNumberOfTripsTrainInfo)
        Me.Controls.Add(Me.lstTrainsTrainInfo)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrainInfo"
        Me.Text = "TrainInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTrainsTrainInfo As ListBox
    Friend WithEvents lblNumberOfTripsTrainInfo As Label
    Friend WithEvents lstProductsTrainInfo As ListBox
    Friend WithEvents PickerInitialDate As DateTimePicker
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents btnDoitTrainInfo As Button
    Friend WithEvents PickerEndDate As DateTimePicker
    Friend WithEvents lblNoT As Label
    Friend WithEvents lblInitialDateTrainInfo As Label
    Friend WithEvents lblEndDateTrainInfo As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProductIDTrainInfo As Label
    Friend WithEvents lblProductDescriptionTrainInfo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTrainTypeValueTrainInfo As Label
    Friend WithEvents Label8 As Label
End Class

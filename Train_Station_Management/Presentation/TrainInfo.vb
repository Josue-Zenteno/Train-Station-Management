Public Class TrainInfo
    Private tt As TrainType
    Private t As Train
    Private tr As Trip
    Private p As Product

    Private Sub btnDoitTrainInfo_Click(sender As Object, e As EventArgs) Handles btnDoitTrainInfo.Click

        lstProductsTrainInfo.Items.Clear()

        Me.tr = New Trip
        Me.t = New Train(Me.lstTrainsTrainInfo.SelectedItem)

        tr.infoTrip(PickerInitialDate.Value, PickerEndDate.Value, Me.t)

        lblNoT.Text = tr.trDAO.Trips.Count 'Beign a product per trip we can easily count the number of trips just looking at the entries on the collection

        For Each tr In tr.trDAO.Trips
            lstProductsTrainInfo.Items.Add(tr.tripProduct.ProductID)
        Next

    End Sub

    Private Sub TrainInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.t = New Train
        Dim tAux As Train

        Try
            Me.t.ReadAllTrains(Main.fileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnDoitTrainInfo.Enabled = False
        End Try

        For Each tAux In Me.t.tDAO.Trains
            Me.lstTrainsTrainInfo.Items.Add(tAux.TrainID)
        Next

    End Sub


    Private Sub lstProductsTrainInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductsTrainInfo.SelectedIndexChanged
        p = New Product(Integer.Parse(lstProductsTrainInfo.SelectedItem))
        p.ReadProduct()
        lblProductIDTrainInfo.Text = p.ProductID
        lblProductDescriptionTrainInfo.Text = p.ProductDescription
    End Sub

    Private Sub lstTrainsTrainInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrainsTrainInfo.SelectedIndexChanged
        t = New Train(lstTrainsTrainInfo.SelectedItem)
        t.ReadTrain()
        tt = New TrainType(t.tType.TypeID)
        tt.ReadType()
        lblTrainTypeValueTrainInfo.Text = tt.TypeDescriptor
    End Sub

    'AUXILIAR METHODS REALTED TO THE WINDOW

    'Como Hacer que la ventana se mueva arrastrando con el raton
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub frm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub frm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    'Como hacer los botones de Cerrar aplicacion y minimizar la ventana
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
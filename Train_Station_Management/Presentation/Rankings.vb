Public Class Rankings

    Private tr As Trip
    Private tt As TrainType
    Private p As Product
    Private t As Train

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click

        Try
            Me.lstProducts1Rankings.Items.Clear()
            Me.lstProductRepetitionsRankings.Items.Clear()

            tr = New Trip
            p = New Product

            Dim aux As Collection

            aux = tr.rankingMoreTripsProducts(Main.fileName, Me.DateTimePicker1Rankings.Value, Me.DateTimePicker2Rankings.Value)

            For Each p In aux
                lstProducts1Rankings.Items.Add(p.ProductID)
                lstProductRepetitionsRankings.Items.Add(p.count)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnProduct.Enabled = False
            btnTypeOfTrain.Enabled = False
        End Try

    End Sub

    Private Sub btnTypeOfTrain_Click(sender As Object, e As EventArgs) Handles btnTypeOfTrain.Click

        Try
            Me.lstTrainTypes1Rankings.Items.Clear()
            Me.lstTrainTypesRepetitionsRankings.Items.Clear()

            tr = New Trip
            tt = New TrainType

            Dim aux As Collection

            aux = tr.rankingMoreTripsTrainType(Main.fileName, Me.DateTimePicker1Rankings.Value, Me.DateTimePicker2Rankings.Value)

            For Each tt In aux
                lstTrainTypes1Rankings.Items.Add(tt.TypeID)
                lstTrainTypesRepetitionsRankings.Items.Add(tt.count)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnProduct.Enabled = False
            btnTypeOfTrain.Enabled = False
        End Try

    End Sub

    Private Sub lstProducts1Rankings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts1Rankings.SelectedIndexChanged
        Me.lstProductRepetitionsRankings.SelectedIndex = Me.lstProducts1Rankings.SelectedIndex
        p = New Product(Integer.Parse(lstProducts1Rankings.SelectedItem))
        p.ReadProduct()
        lblProductIDRankings.Text = p.ProductID
        lblProductDescriptionRankings.Text = p.ProductDescription
    End Sub


    Private Sub lstProductRepetitionsRankings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductRepetitionsRankings.SelectedIndexChanged
        Me.lstProducts1Rankings.SelectedIndex = Me.lstProductRepetitionsRankings.SelectedIndex
        p = New Product(Integer.Parse(lstProducts1Rankings.SelectedItem))
        p.ReadProduct()
        lblProductIDRankings.Text = p.ProductID
        lblProductDescriptionRankings.Text = p.ProductDescription
    End Sub


    Private Sub lstTrainTypes1Rankings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrainTypes1Rankings.SelectedIndexChanged
        Me.lstTrainTypesRepetitionsRankings.SelectedIndex = Me.lstTrainTypes1Rankings.SelectedIndex
        tt = New TrainType(Integer.Parse(lstTrainTypes1Rankings.SelectedItem))
        tt.ReadType()
        lblTrainTypeIDRankings.Text = tt.TypeID
        lblTrainTypeDescriptionRankings.Text = tt.TypeDescriptor
    End Sub


    Private Sub lstTrainTypesRepetitionsRankings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrainTypesRepetitionsRankings.SelectedIndexChanged
        Me.lstTrainTypes1Rankings.SelectedIndex = Me.lstTrainTypesRepetitionsRankings.SelectedIndex
        tt = New TrainType(Integer.Parse(lstTrainTypes1Rankings.SelectedItem))
        tt.ReadType()
        lblTrainTypeIDRankings.Text = tt.TypeID
        lblTrainTypeDescriptionRankings.Text = tt.TypeDescriptor
    End Sub



    'AUXILIAR METHODS RELATED TO THE WINDOW

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
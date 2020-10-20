Public Class BestTrip

    Private tr As Trip
    Private t As Train
    Private tt As TrainType
    Private pr As Price
    Private p As Product

    Private Sub BestTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            tr = New Trip
            Dim Profit As Double
            Dim Best_Trip As Collection = Me.tr.bestTripEver(Main.fileName)

            Profit = Convert.ToDouble(Best_Trip(5))

            tr = New Trip(Convert.ToDateTime(Best_Trip(1)), Best_Trip(3).ToString, Integer.Parse(Best_Trip(4)))
            t = New Train(Best_Trip(3).ToString)
            pr = New Price(Integer.Parse(Best_Trip(4)), Convert.ToDateTime(Best_Trip(2)))

            tr.ReadTrip()
            t.ReadTrain()
            tt = New TrainType(Integer.Parse(t.tType.TypeID))
            tt.ReadType()
            pr.ReadPrice()
            p = New Product(Integer.Parse(tr.tripProduct.ProductID))
            p.ReadProduct()

            lblDateBestTrip.Text = tr.tripDate
            lblTrainBestTrip.Text = t.TrainID
            lblTrainTypeBestTrip.Text = tt.TypeDescriptor
            lblProductBestTrip.Text = p.ProductDescription
            lblTonsBestTrip.Text = tr.tons
            lblPriceProductBestTrip.Text = pr.EurosPerTon
            lblTotalProfitBestTrip.Text = Profit

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

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
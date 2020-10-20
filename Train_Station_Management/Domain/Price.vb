Public Class Price
    Public Property PriceDate As DateTime
    Public Property EurosPerTon As Double
    Public Property Product As Product
    Public ReadOnly Property prDAO As PriceDAO

    Public Sub New()
        Me.prDAO = New PriceDAO
    End Sub

    Public Sub New(prID As String, dat As DateTime)
        Me.prDAO = New PriceDAO
        Me.Product = New Product(prID)
        Me.PriceDate = dat
    End Sub

    Public Sub ReadAllPrices(path As String)
        Me.prDAO.ReadAll(path)
    End Sub

    Public Sub ReadPrice()
        Me.prDAO.Read(Me)
    End Sub

    Public Function InsertPrice() As Integer
        Return Me.prDAO.Insert(Me)
    End Function

    Public Function UpdatePrice() As Integer
        Return Me.prDAO.Update(Me)
    End Function

    Public Function DeletePrice() As Integer
        Return Me.prDAO.Delete(Me)
    End Function
End Class

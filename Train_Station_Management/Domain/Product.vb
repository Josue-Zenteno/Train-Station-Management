Public Class Product
    Public Property ProductID As Integer
    Public Property ProductDescription As String
    Public Property pDAO As ProductDAO
    Public Property count As Integer

    Public Sub New()
        Me.pDAO = New ProductDAO
    End Sub

    Public Sub New(id As Integer)
        Me.pDAO = New ProductDAO
        Me.ProductID = id
    End Sub

    Public Sub ReadAllProducts(path As String)
        Me.pDAO.ReadAll(path)
    End Sub

    Public Sub ReadProduct()
        Me.pDAO.Read(Me)
    End Sub

    Public Function InsertProduct() As Integer
        Return Me.pDAO.Insert(Me)
    End Function

    Public Function UpdateProduct() As Integer
        Return Me.pDAO.Update(Me)
    End Function

    Public Function DeleteProduct() As Integer
        Return Me.pDAO.Delete(Me)
    End Function
End Class

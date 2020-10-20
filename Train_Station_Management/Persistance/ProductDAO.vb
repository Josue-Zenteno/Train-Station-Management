Public Class ProductDAO
    Public ReadOnly Property Products As Collection

    Public Sub New()
        Me.Products = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim pr As Product
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Products ORDER BY ProductID")
        For Each aux In col
            pr = New Product(Integer.Parse(aux(1)))
            pr.ProductDescription = aux(2).ToString
            Me.Products.Add(pr)
        Next
    End Sub

    Public Sub Read(ByRef p As Product)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Products WHERE ProductID = " & p.ProductID & ";")
        For Each aux In col
            p.ProductDescription = aux(2).ToString
        Next
    End Sub

    Public Function Insert(ByVal p As Product) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Products VALUES (" & p.ProductID & ", '" & p.ProductDescription & "');")
    End Function

    Public Function Update(ByVal p As Product) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Products SET ProductDescription ='" & p.ProductDescription & "' WHERE ProductID = " & p.ProductID & ";")
    End Function

    Public Function Delete(ByVal p As Product) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Products WHERE ProductID = " & p.ProductID & ";")
    End Function

End Class

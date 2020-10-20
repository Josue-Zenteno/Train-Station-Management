Public Class PriceDAO
    Public ReadOnly Property Prices As Collection

    Public Sub New()
        Me.Prices = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim pr As Price
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Prices ORDER BY Product , PriceDate")
        For Each aux In col
            pr = New Price(aux(1).ToString, Convert.ToDateTime(aux(2)))
            pr.EurosPerTon = Convert.ToDouble(aux(3))
            Me.Prices.Add(pr)
        Next
    End Sub

    Public Sub Read(ByRef pr As Price)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Prices WHERE Product = " & pr.Product.ProductID & " AND PriceDate = #" & pr.PriceDate & "# ;")
        For Each aux In col
            pr.EurosPerTon = Convert.ToDouble(aux(3))
        Next
    End Sub

    Public Function Insert(ByVal pr As Price) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Prices VALUES (" & pr.Product.ProductID & ", #" & pr.PriceDate & "#," & pr.EurosPerTon & ");")
    End Function

    Public Function Update(ByVal pr As Price) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Prices SET EurosPerTon=" & pr.EurosPerTon & " WHERE Product=" & pr.Product.ProductID & " AND PriceDate = #" & pr.PriceDate & "#;")
    End Function

    Public Function Delete(ByVal pr As Price) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Prices WHERE Product=" & pr.Product.ProductID & " AND PriceDate = #" & pr.PriceDate & "#;")
    End Function
End Class

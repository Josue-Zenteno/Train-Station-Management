Public Class TripDAO
    Public ReadOnly Property Trips As Collection

    Public Sub New()
        Me.Trips = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim tr As Trip
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Trips ORDER BY TripDate , Train , Product")
        For Each aux In col
            tr = New Trip(aux(1).ToString, aux(2).ToString, aux(3).ToString)
            Me.Trips.Add(tr)
        Next
    End Sub

    Public Sub Read(ByRef tr As Trip)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trips WHERE TripDate = #" & tr.tripDate & "# AND Train = '" & tr.tripTrain.TrainID & "' AND Product = " & tr.tripProduct.ProductID & " ;")
        For Each aux In col
            tr.tons = Integer.Parse(aux(4))
        Next
    End Sub

    Public Function SpecialRead(ByRef tr As Trip) As Integer
        Dim counter As Integer
        counter = 0
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trips WHERE TripDate = #" & tr.tripDate & "# AND Train = '" & tr.tripTrain.TrainID & "' ;")
        For Each aux In col
            counter += 1
        Next
        Return counter
    End Function

    Public Function Insert(ByVal tr As Trip) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Trips VALUES (#" & tr.tripDate & "#, '" & tr.tripTrain.TrainID & "'," & tr.tripProduct.ProductID & "," & tr.tons & ");")
    End Function

    Public Function Update(ByVal tr As Trip) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Trips SET TonsTransported = " & tr.tons & " WHERE TripDate=#" & tr.tripDate & "# AND Train = '" & tr.tripTrain.TrainID & "' AND Product = " & tr.tripProduct.ProductID & ";")
    End Function

    Public Function Delete(ByVal tr As Trip) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Trips WHERE TripDate = #" & tr.tripDate & "# AND Train = '" & tr.tripTrain.TrainID & "' AND Product = " & tr.tripProduct.ProductID & ";")
    End Function

    Public Sub Info(ByRef tr As Trip, ByVal initialDate As DateTime, ByVal finalDate As DateTime, t As Train)
        Dim trAux As Trip
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trips WHERE Train = '" & t.TrainID & "' AND TripDate BETWEEN #" & initialDate & "# AND #" & finalDate & "# ;")
        For Each aux In col
            trAux = New Trip(Convert.ToDateTime(aux(1)), aux(2).ToString, Integer.Parse(aux(3)))
            Trips.Add(trAux)
            tr.tripProduct = New Product()
            tr.tripProduct.ProductID = Integer.Parse(aux(3))
        Next
    End Sub

    Public Function rankingMoreTripsTrainType(path As String, ByRef tr As Trip, initialDate As DateTime, finalDate As DateTime) As Collection
        Dim col As Collection
        col = DBBroker.GetBroker(path).Read("SELECT Train, COUNT(*) FROM Trips WHERE TripDate BETWEEN #" & initialDate & "# AND #" & finalDate & "# GROUP BY Train ORDER BY COUNT(*) DESC;")
        Return col
    End Function

    Public Function rankingMoreTripsProducts(path As String, ByRef tr As Trip, initialDate As DateTime, finalDate As DateTime) As Collection
        Dim col As Collection
        col = DBBroker.GetBroker(path).Read("SELECT Product, COUNT(*) FROM Trips WHERE TripDate BETWEEN #" & initialDate & "# AND #" & finalDate & "# GROUP BY Product ORDER BY COUNT(*) DESC ;")
        Return col
    End Function

    Public Function bestTrip(path As String) As Collection
        Dim col As Collection
        col = DBBroker.GetBroker(path).Read("SELECT t.TripDate, p.PriceDate, t.Train, t.Product, p.EurosPerTon*t.TonsTransported FROM Trips AS t, Prices AS p WHERE t.Product=p.Product AND t.TripDate>=p.PriceDate ORDER BY t.Train , t.TripDate, p.PriceDate DESC;")
        Return col
    End Function
End Class

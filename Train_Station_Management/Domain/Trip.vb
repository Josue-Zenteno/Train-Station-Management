Public Class Trip
    Public Property tripDate As DateTime
    Public Property tripTrain As Train
    Public Property tripProduct As Product
    Public Property tons As Integer
    Public Property trDAO As TripDAO

    Public Sub New()
        Me.trDAO = New TripDAO
    End Sub

    Public Sub New(dat As DateTime, tID As String, prodID As Integer)
        Me.trDAO = New TripDAO
        Me.tripTrain = New Train(tID)
        Me.tripProduct = New Product(prodID)
        Me.tripDate = dat
    End Sub

    Public Sub ReadAllTrips(path As String)
        Me.trDAO.ReadAll(path)
    End Sub

    Public Sub ReadTrip()
        Me.trDAO.Read(Me)
    End Sub

    Public Function SpecialReadTrip() As Integer
        Return Me.trDAO.SpecialRead(Me)
    End Function

    Public Function InsertTrip() As Integer
        Return Me.trDAO.Insert(Me)
    End Function

    Public Function UpdateTrip() As Integer
        Return Me.trDAO.Update(Me)
    End Function

    Public Function DeleteTrip() As Integer
        Return Me.trDAO.Delete(Me)
    End Function

    Public Sub infoTrip(initialDate As DateTime, finalDate As DateTime, t As Train)
        Me.trDAO.Info(Me, initialDate, finalDate, t)
    End Sub

    Public Function rankingMoreTripsTrainType(path As String, initialDate As DateTime, finalDate As DateTime) As Collection

        Dim collectionAUX As Collection
        collectionAUX = New Collection
        Dim t As Train
        Dim tt As TrainType

        Dim col As Collection : Dim aux As Collection
        col = Me.trDAO.rankingMoreTripsTrainType(path, Me, initialDate, finalDate)

        For Each aux In col
            t = New Train(aux(1).ToString)
            t.ReadTrain()
            tt = New TrainType(t.tType.TypeID)
            tt.count = Integer.Parse(aux(2))
            collectionAUX.Add(tt)
        Next
        Return collectionAUX

    End Function

    Public Function rankingMoreTripsProducts(path As String, initialDate As DateTime, finalDate As DateTime) As Collection

        Dim collectionAUX As Collection
        collectionAUX = New Collection

        Dim p As Product
        Dim col As Collection : Dim aux As Collection
        col = Me.trDAO.rankingMoreTripsProducts(path, Me, initialDate, finalDate)

        For Each aux In col
            p = New Product(Integer.Parse(aux(1)))
            p.count = Integer.Parse(aux(2))
            collectionAUX.Add(p)
        Next

        Return collectionAUX
    End Function

    Public Function bestTripEver(path As String) As Collection

        Dim filtered_collection As Collection
        filtered_collection = New Collection

        Dim final_collection As Collection
        final_collection = New Collection
        Dim maximum As Double = 0.0
        Dim aux As Collection

        Dim col As Collection
        col = Me.trDAO.bestTrip(path)

        'Filtering the given ResultSet to obtain a collection of trips only with the latest price date
        filtered_collection.Add(col(1))
        Dim j = 1
        For index As Integer = 2 To col.Count
            If filtered_collection(j)(1) <> col(index)(1) Or filtered_collection(j)(3) <> col(index)(3) Then
                filtered_collection.Add(col(index))
                j += 1
            End If
        Next
        'Calculating the maximum profit
        For index As Integer = 1 To filtered_collection.Count
            If filtered_collection(index)(5) > maximum Then
                maximum = filtered_collection(index)(5)
            End If
        Next
        'Looking for the trip that has the maximum profit
        For Each aux In filtered_collection
            If aux(5) = maximum Then
                final_collection = aux
            End If
        Next

        Return final_collection

    End Function

End Class

Public Class TrainTypeDAO
    Public ReadOnly Property TrainTypes As Collection

    Public Sub New()
        Me.TrainTypes = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim tt As TrainType
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM TrainTypes ORDER BY TrainTypeID")
        For Each aux In col
            tt = New TrainType(Integer.Parse(aux(1)))
            tt.TypeDescriptor = aux(2).ToString
            tt.MaxCapacity = Convert.ToDouble(aux(3))
            Me.TrainTypes.Add(tt)
        Next
    End Sub

    Public Sub Read(ByRef tt As TrainType)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM TrainTypes WHERE TrainTypeID=" & tt.TypeID & ";")
        For Each aux In col
            tt.TypeDescriptor = aux(2).ToString
            tt.MaxCapacity = Convert.ToDouble(aux(3))
        Next
    End Sub

    Public Function Insert(ByVal tt As TrainType) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO TrainTypes VALUES (" & tt.TypeID & ", '" & tt.TypeDescriptor & "'," & tt.MaxCapacity & ");")
    End Function

    Public Function Update(ByVal tt As TrainType) As Integer
        Return DBBroker.GetBroker.Change("UPDATE TrainTypes SET TrainTypeDescription = '" & tt.TypeDescriptor & "' , MaxCapacity=" & tt.MaxCapacity & " WHERE TrainTypeID=" & tt.TypeID & ";")
    End Function

    Public Function Delete(ByVal tt As TrainType) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM TrainTypes WHERE TrainTypeID=" & tt.TypeID & ";")
    End Function
End Class

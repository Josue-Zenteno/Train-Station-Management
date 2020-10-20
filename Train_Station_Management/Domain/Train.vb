Public Class Train
    Public Property TrainID As String
    Public Property tType As TrainType
    Public ReadOnly Property tDAO As TrainDAO

    Public Sub New()
        Me.tDAO = New TrainDAO
    End Sub

    Public Sub New(id As String)
        Me.tDAO = New TrainDAO
        Me.tType = New TrainType
        Me.TrainID = id
    End Sub

    Public Sub ReadAllTrains(path As String)
        Me.tDAO.ReadAll(path)
    End Sub

    Public Sub ReadTrain()
        Me.tDAO.Read(Me)
    End Sub

    Public Function InsertTrain() As Integer
        Return Me.tDAO.Insert(Me)
    End Function

    Public Function UpdateTrain() As Integer
        Return Me.tDAO.Update(Me)
    End Function

    Public Function DeleteTrain() As Integer
        Return Me.tDAO.Delete(Me)
    End Function
End Class

Public Class TrainType
    Public Property TypeID As Integer
    Public Property TypeDescriptor As String
    Public Property MaxCapacity As Double
    Public ReadOnly Property ttDAO As TrainTypeDAO
    Public Property count As Integer

    Public Sub New()
        Me.ttDAO = New TrainTypeDAO
    End Sub

    Public Sub New(id As Integer)
        Me.ttDAO = New TrainTypeDAO
        Me.TypeID = id
    End Sub

    Public Sub ReadAllType(path As String)
        Me.ttDAO.ReadAll(path)
    End Sub

    Public Sub ReadType()
        Me.ttDAO.Read(Me)
    End Sub

    Public Function InsertType() As Integer
        Return Me.ttDAO.Insert(Me)
    End Function

    Public Function UpdateType() As Integer
        Return Me.ttDAO.Update(Me)
    End Function

    Public Function DeleteType() As Integer
        Return Me.ttDAO.Delete(Me)
    End Function
End Class

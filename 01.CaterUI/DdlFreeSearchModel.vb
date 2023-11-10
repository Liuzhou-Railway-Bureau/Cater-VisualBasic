Public Class DdlFreeSearchModel

    Public Property Title As String
    Public Property Id As String

    ''' <summary>
    ''' initializes properties
    ''' </summary>
    ''' <param name="title">description</param>
    ''' <param name="id">identifier</param>
    Public Sub New(id As String, title As String)
        Me.Title = title
        Me.Id = id
    End Sub
End Class

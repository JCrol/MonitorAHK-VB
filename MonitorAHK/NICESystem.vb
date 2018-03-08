Public Class NICESystem
    Private _dbServer As String
    Private _sspi As Boolean
    Private _username As String
    Private _password As String

    Public Property DbServer As String
        Get
            Return _dbServer
        End Get
        Set(value As String)
            _dbServer = value
        End Set
    End Property

    Public Property Sspi As Boolean
        Get
            Return _sspi
        End Get
        Set(value As Boolean)
            _sspi = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Sub New(dbServer As String, sspi As Boolean, Optional username As String = "", Optional password As String = "")
        _dbServer = dbServer
        _sspi = sspi
        _username = username
        _password = password
    End Sub
End Class

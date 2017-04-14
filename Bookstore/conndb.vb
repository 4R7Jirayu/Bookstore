Option Explicit On
Option Strict On
Imports System.Data.SqlClient
'Imports CrystalDecisions.CrystalReports.Engine
Public Class conndb
    Private StrConn As String = "Data Source=10.199.66.228; Initial Catalog=bookbd; Uid=bookbd; Pwd=bookbd;"
    Private ObjConn As New SqlConnection(StrConn)
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private dr As SqlDataReader
    Private str As String
    Dim cmd As New SqlCommand(str, ObjConn)

    Public Property mystr() As String
        Get
            Return str
        End Get
        Set(value As String)
            str = value
        End Set
    End Property


    Public Property mydr() As SqlDataReader
        Get
            Return dr
        End Get
        Set(value As SqlDataReader)
            value = cmd.ExecuteReader()
            dr = value
        End Set
    End Property
    Public Property myStrconn() As String
        Get
            Return StrConn
        End Get
        Set(value As String)
            StrConn = value
        End Set
    End Property

    Public Property myObjconn() As SqlConnection
        Get
            Return ObjConn
        End Get
        Set(value As SqlConnection)
            ObjConn = value
        End Set
    End Property
    Public Property myds() As DataSet
        Get
            Return ds
        End Get
        Set(value As DataSet)
            ds = value
        End Set
    End Property
    Public Property myda() As SqlDataAdapter
        Get
            Return da
        End Get
        Set(value As SqlDataAdapter)
            da = value
        End Set
    End Property

End Class
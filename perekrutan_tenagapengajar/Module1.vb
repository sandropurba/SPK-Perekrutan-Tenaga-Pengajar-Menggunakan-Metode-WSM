Imports System.Data.OleDb
Module Module1
    Public Koneksikan As New Module1.KoneksiDatabase
    Public Cmd As OleDbCommand
    Public Class KoneksiDatabase
        Public Function open() As OleDb.OleDbConnection
            Dim conect As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & Application.StartupPath & "\dbperekrutan.mdb")
            conect.Open()
            Return conect
        End Function
    End Class
End Module

Imports System.Data.OleDb
Public Class Formlogin

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Formlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Using Login As New OleDbCommand("Select * From tbl_login Where Username='" & txtusername.Text & "'", Koneksikan.open)
            Using Data As OleDbDataReader = Login.ExecuteReader
                If Data.HasRows Then
                    While Data.Read
                        If Data("Password") = txtpassword.Text Then
                            menu_utama.Show()
                            Me.Hide()
                        Else
                            MsgBox("Password Salah!", MsgBoxStyle.Critical, "Peringatan!")
                        End If
                    End While
                Else
                    MsgBox("Username Salah!", MsgBoxStyle.Critical, "Peringatan!")
                End If
            End Using
        End Using
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin_Click(Nothing, Nothing)
        End If
    End Sub
End Class

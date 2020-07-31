Imports System.Runtime.InteropServices
Imports DominioDiarioADiario
Imports CommonDiarioADiario

Public Class FormInicioSesion

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userModel As New UserModel()
        Dim validLogin = userModel.Login(txtUser.Text, txtPass.Text)
        If validLogin = True Then
            Dim frm As New FormInicioSesion()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
            Me.Hide()
        Else
            MessageBox.Show("Incorrect username or password entered." + vbNewLine + "Please try again.")
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUser.Clear()
        txtPass.Clear()
        Me.Show()
        txtUser.Focus()
    End Sub

End Class


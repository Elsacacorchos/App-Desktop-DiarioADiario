Imports System.Runtime.InteropServices
Imports DominioDiarioADiario
Imports CommonDiarioADiario

Public Class FormInicioSesion

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userModel As New UserModel()
        Dim validLogin = userModel.Login(txtUser.Text, txtPass.Text)
        If validLogin = True Then
            '-----Agregamos estos codigos antes de mostrar el formulario principal-----'
            Me.Hide()
            Dim formwelcome As New FormWelcome()
            formwelcome.ShowDialog()
            '----------------------------------------------------------------'
            Dim frm As New Form1()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout1
        Else
            MessageBox.Show("Nombre o contraseña incorrecta." + vbNewLine + "Por favor, intente nuevamente.")
            txtPass.Clear()
            txtPass.Focus()
        End If


    End Sub

    Private Sub Logout1(sender As Object, e As FormClosedEventArgs)
        txtUser.Clear()
        txtPass.Clear()
        Me.Show()
        txtUser.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class


Public Class FormUsers

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DDBDDataSet.UsersClient' Puede moverla o quitarla según sea necesario.
        Me.UsersClientTableAdapter.Fill(Me.DDBDDataSet.UsersClient)

    End Sub
End Class
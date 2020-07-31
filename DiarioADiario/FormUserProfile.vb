Imports CommonDiarioADiario
Imports DominioDiarioADiario

Public Class FormUserProfile
    Private Sub FormEditUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserData()
        initializeControlsEditPass()
    End Sub
    Private Sub loadUserData()

        lblUser.Text = ActiveUser.loginName
        lblName.Text = ActiveUser.firstName
        lblLastName.Text = ActiveUser.lastName
        lblMail.Text = ActiveUser.email
        lblUserType.Text = ActiveUser.position

        TextBox1.Text = ActiveUser.loginName
        TextBox2.Text = ActiveUser.firstName
        TextBox3.Text = ActiveUser.lastName
        TextBox4.Text = ActiveUser.email
        TextBox5.Text = ActiveUser.password
        TextBox6.Text = ActiveUser.password
        TextBox7.Text = ActiveUser.position
    End Sub
    Private Sub initializeControlsEditPass()
        LinkLabel2.Text = "Editar"
        TextBox5.UseSystemPasswordChar = True
        TextBox5.Enabled = False
        TextBox6.UseSystemPasswordChar = True
        TextBox6.Enabled = False
    End Sub
    Private Sub reset()
        loadUserData()
        initializeControlsEditPass()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If LinkLabel2.Text = "Editar" Then
            LinkLabel2.Text = "Cancelar"
            TextBox5.Enabled = True
            TextBox5.Text = ""
            TextBox6.Enabled = True
            TextBox6.Text = ""
        ElseIf LinkLabel2.Text = "Cancelar" Then
            initializeControlsEditPass()
            TextBox5.Text = ActiveUser.password
            TextBox6.Text = ActiveUser.password
        End If
    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Panel2.Visible = True
        loadUserData()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TextBox5.Text = TextBox6.Text Then
            Dim userModel As New UserModel(idUser:=ActiveUser.idUser,
                                           loginName:=TextBox1.Text,
                                           password:=TextBox5.Text,
                                           firstName:=TextBox2.Text,
                                           lastName:=TextBox3.Text,
                                           position:=TextBox7.Text,
                                           email:=TextBox4.Text)
            Dim result = userModel.editUserProfile()
            MessageBox.Show(result)
            Panel1.Visible = False
            reset()
        Else
            MessageBox.Show("Las cotraseñas no coinciden, prueba nuevamente")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel2.Visible = False
        reset()
    End Sub

End Class


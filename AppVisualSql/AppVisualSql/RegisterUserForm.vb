Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class RegisterUserForm
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click

        Dim user As String = userTxt.Text
        Dim email As String = emailTxt.Text
        Dim pass As String = passwordTxt.Text
        Dim pass2 As String = password2Txt.Text

        If (user = "" Or email = "" Or pass = "" Or pass2 = "") Then
            MessageBox.Show("You must enter all fields and text to continue.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If (pass = pass2) Then

                Dim connectionString As String = ModuleGlobal.connectionString
                Dim consulta As String = "INSERT INTO [User](name,email,password,status) VALUES (@name,@email,@password,1)"


                ' Crear una conexión
                Using conexion As New SqlConnection(connectionString)
                    Try
                        ' Abrir la conexión
                        conexion.Open()

                        ' Crear un comando con parámetros
                        Using comando As New SqlCommand(consulta, conexion)
                            ' Agregar parámetros con valores
                            comando.Parameters.AddWithValue("@name", user)
                            comando.Parameters.AddWithValue("@email", email)
                            comando.Parameters.AddWithValue("@password", ModuleGlobal.CalculateMD5Hash(pass))


                            ' Ejecutar la consulta de inserción
                            comando.ExecuteNonQuery()

                            ' Mensaje de éxito (puedes personalizarlo)
                            MessageBox.Show("Correctly inserted data..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Dim form1 As New LoginForm()
                            form1.Show()
                            Me.Hide()
                        End Using
                    Catch ex As Exception
                        ' Manejar errores
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Else
                MessageBox.Show("Passwords are not equal.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub RegisterUserForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form1 As New LoginForm()
        form1.Show()
        Me.Hide()
    End Sub
End Class
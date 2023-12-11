Imports System.Data.SqlClient

Public Class UpdateUserForm
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Dim user As String = userTxt.Text
        Dim pass As String = passwordTxt.Text
        Dim pass2 As String = password2Txt.Text
        Dim id As Integer = 0
        Dim hasData As Boolean = False

        If (user = "" Or pass = "" Or pass2 = "") Then
            MessageBox.Show("You must enter all fields and text to continue.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If (pass = pass2) Then

                Dim connectionString As String = ModuleGlobal.connectionString
                Dim queryString As String = "SELECT idUser from [User] where name = @name"
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(queryString, connection)

                        command.Parameters.AddWithValue("@name", user)
                        connection.Open()

                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                ' La consulta trajo al menos una fila
                                hasData = True

                                ' Puedes obtener el ID desde la primera fila (asumiendo que solo hay una fila)
                                If reader.Read() Then
                                    id = reader.GetInt32(0) ' Ajusta el índice según la posición de la columna en tu consulta
                                End If
                            Else
                                ' La consulta no trajo ninguna fila
                                hasData = False
                            End If
                        End Using

                    End Using
                End Using


                If hasData Then

                    Dim consulta As String = "UPDATE [User] SET password = @password WHERE idUser = @id"


                    ' Crear una conexión
                    Using conexion As New SqlConnection(connectionString)
                        Try
                            ' Abrir la conexión
                            conexion.Open()

                            ' Crear un comando con parámetros
                            Using comando As New SqlCommand(consulta, conexion)
                                ' Agregar parámetros con valores
                                comando.Parameters.AddWithValue("@password", ModuleGlobal.CalculateMD5Hash(pass))
                                comando.Parameters.AddWithValue("@id", id)



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
            Else
                MessageBox.Show("There Is no user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub UpdateUserForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form1 As New LoginForm()
        form1.Show()
        Me.Hide()
    End Sub
End Class
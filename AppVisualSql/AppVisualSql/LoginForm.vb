Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        Dim connectionString As String = ModuleGlobal.connectionString
        Dim queryString As String = "SELECT idUser from [User] where name = @name and password = @pass "
        Dim hasData As Boolean = False
        Dim id As Integer = 0

        Dim user As String = userTxt.Text
        Dim pass As String = passwordTxt.Text

        If (user = "" Or pass = "") Then

            MessageBox.Show("You must enter all fields and text to continue.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryString, connection)

                    command.Parameters.AddWithValue("@name", user)
                    command.Parameters.AddWithValue("@pass", ModuleGlobal.CalculateMD5Hash(pass))
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

            ' Utiliza hasData y id para tomar decisiones basadas en si la consulta trajo datos o no
            If hasData Then
                ModuleGlobal.idUser = id
                Dim form1 As New Form1()
                form1.Show()
                Me.Hide()

            Else
                ' Hacer algo si la consulta no trajo datos                
                MessageBox.Show("User not foud.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If




    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Cerrar la aplicación al cerrar Form1
        Me.Dispose()
        'Application.Exit()
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Dim form1 As New RegisterUserForm()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim form1 As New UpdateUserForm()
        form1.Show()
        Me.Hide()
    End Sub
End Class
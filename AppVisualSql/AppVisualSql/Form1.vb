Imports System.Data.SqlClient




Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarTabla()


        ' Crear una columna de botones
        Dim columnaBotones As New DataGridViewButtonColumn()
        columnaBotones.HeaderText = "Update"
        columnaBotones.Text = "Update"
        columnaBotones.UseColumnTextForButtonValue = True ' Esto permite mostrar el mismo texto en todos los botones

        ' Crear una columna de botones
        Dim columnaBotonesElim As New DataGridViewButtonColumn()
        columnaBotonesElim.HeaderText = "Delete"
        columnaBotonesElim.Text = "Delete"
        columnaBotonesElim.UseColumnTextForButtonValue = True ' Esto permite mostrar el mismo texto en todos los botones

        ' Agregar la columna al DataGridView
        DataGridView1.Columns.Add(columnaBotones)
        DataGridView1.Columns.Add(columnaBotonesElim)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Crear una instancia del Form2
        Dim form2 As New Form2()

        ' Mostrar Form2
        form2.Show()

        ' Opcional: Ocultar Form1 si es necesario
        Me.Hide()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Crear una instancia del Form1
        Dim form1 As New LoginForm()

        ' Mostrar Form2
        form1.Show()

        ' Opcional: Ocultar Form1 si es necesario
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        ' Verificar si el clic fue en una celda de la columna de botones
        If e.ColumnIndex = 8 AndAlso e.RowIndex >= 0 Then
            ' Realizar acciones al hacer clic en el botón, por ejemplo, mostrar un mensaje
            'MessageBox.Show("Botón Actualizar clickeado en la fila " & e.RowIndex.ToString())
            Dim idCompany As String = DataGridView1.Rows(e.RowIndex).Cells("idCompany").Value.ToString()
            Dim name As String = DataGridView1.Rows(e.RowIndex).Cells("name").Value.ToString()
            Dim email As String = DataGridView1.Rows(e.RowIndex).Cells("email").Value.ToString()
            Dim phone As String = DataGridView1.Rows(e.RowIndex).Cells("phone").Value.ToString()
            Dim address As String = DataGridView1.Rows(e.RowIndex).Cells("address").Value.ToString()
            Dim identificationNumber As String = DataGridView1.Rows(e.RowIndex).Cells("identificationNumber").Value.ToString()
            Dim idSector As String = DataGridView1.Rows(e.RowIndex).Cells("idSector").Value.ToString()
            Dim sectorname As String = DataGridView1.Rows(e.RowIndex).Cells("sectorname").Value.ToString()


            ' Crear una instancia del Form2
            Dim form2 As New Form2()
            form2.RecibirParametros(idCompany, name, email, phone, address, identificationNumber, idSector, sectorname)

            ' Mostrar Form2
            form2.Show()

            ' Opcional: Ocultar Form1 si es necesario
            Me.Hide()


        End If

        If e.ColumnIndex = 9 AndAlso e.RowIndex >= 0 Then
            ' Realizar acciones al hacer clic en el botón, por ejemplo, mostrar un mensaje
            Dim idProfesor As String = DataGridView1.Rows(e.RowIndex).Cells("idCompany").Value.ToString()

            ' Console.WriteLine(idProfesor)

            Dim resultado As DialogResult = MessageBox.Show("¿You're sure to delete this record?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Verificar la respuesta del usuario
            If resultado = DialogResult.Yes Then
                ' Realizar la acción si el usuario presionó "Sí"
                ' Cadena de conexión a SQL Server con autenticación de Windows
                Dim cadenaConexion As String = ModuleGlobal.connectionString

                ' ID del registro que deseas eliminar (puedes ajustar esto según tu lógica)
                'Dim idRegistroAEliminar As Integer = 123

                ' Consulta SQL de eliminación
                Dim consulta As String = "UPDATE Company SET status = 0 WHERE idCompany = @idRegistro"

                ' Crear una conexión
                Using conexion As New SqlConnection(cadenaConexion)
                    Try
                        ' Abrir la conexión
                        conexion.Open()

                        ' Crear un comando con parámetros
                        Using comando As New SqlCommand(consulta, conexion)
                            ' Agregar el parámetro con el ID del registro a eliminar
                            comando.Parameters.AddWithValue("@idRegistro", idProfesor)

                            ' Ejecutar la consulta de eliminación
                            comando.ExecuteNonQuery()

                            ' Mensaje de éxito (puedes personalizarlo)
                            MessageBox.Show("Successfully deleted record.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    Catch ex As Exception
                        ' Manejar errores
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using

                CargarTabla()
            End If

        End If

    End Sub


    Private Sub CargarTabla()
        ' Cadena de conexión a SQL Server   User ID=tu_usuario;Password=tu_contraseña
        Dim cadenaConexion As String = ModuleGlobal.connectionString

        ' Consulta SQL
        Dim consulta As String = "SELECT idCompany, name,email,phone,address,identificationNumber,Company.idSector, Sector.sectorname FROM Company INNER JOIN Sector on Company.idSector = Sector.idSector where Company.status = 1"
        ' consulta = "select * from MYSQL_AMITDB...cliente"
        ' Crear una conexión
        Using conexion As New SqlConnection(cadenaConexion)
            Try
                ' Abrir la conexión
                conexion.Open()

                ' Crear un adaptador de datos
                Using adaptador As New SqlDataAdapter(consulta, conexion)
                    ' Crear un DataSet para almacenar los resultados
                    Dim dataSet As New DataSet()

                    ' Llenar el DataSet con los resultados de la consulta
                    adaptador.Fill(dataSet, "Resultados")

                    ' Mostrar los resultados en el DataGridView
                    DataGridView1.DataSource = dataSet.Tables("Resultados")
                End Using
            Catch ex As Exception
                ' Manejar errores
                Console.WriteLine("Error: " & ex.Message)
            End Try
        End Using


    End Sub

End Class

Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Form2
    Public idProfesor As String
    'Public nombreProf As String
    'Public apellidoProf As String
    'Public especialidadProf As String
    'Public correoProf As String
    'Public telefonoProf As String
    Public Id As String, nameObj As String, emailObj As String, phoneObj As String, addressObj As String, identificationNumberObj As String, idSectorObj As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameTxt.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub AccionBtn_Click(sender As Object, e As EventArgs) Handles AccionBtn.Click

        ' Cadena de conexión a SQL Server con autenticación de Windows
        Dim cadenaConexion As String = ModuleGlobal.connectionString

        ' Valores a insertar
        Dim nombre As String = NameTxt.Text
        Dim email As String = EmailTxt.Text
        Dim phone As String = PhoneTxt.Text
        Dim adress As String = AdressTxt.Text
        Dim idNumber As String = IdNumberTxt.Text
        Dim sectorId As Integer = 0
        ' Verificar si hay elementos en el ComboBox
        If ComboBox1.SelectedItem IsNot Nothing Then
            ' Obtener el objeto ComboBoxItem seleccionado
            Dim itemSeleccionado As ComboBoxItem = DirectCast(ComboBox1.SelectedItem, ComboBoxItem)

            ' Obtener el ID del elemento seleccionado
            Dim idSeleccionado As Integer = itemSeleccionado.IdSector
            sectorId = idSeleccionado

        End If


        'Si no esta asignado un valor es que crearemos un nuevo registro
        If idProfesor Is Nothing Then
            'MessageBox.Show("La variable no está asignada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Consulta SQL de inserción
            Dim consulta As String = "INSERT INTO Company(name,email,phone,address,identificationNumber,idSector,status,idUserCreate,dateCreate) VALUES (@name,@email,@phone,@address,@identificationNumber,@idSector,1,@idUser,GETDATE())"


            ' Crear una conexión
            Using conexion As New SqlConnection(cadenaConexion)
                Try
                    ' Abrir la conexión
                    conexion.Open()

                    ' Crear un comando con parámetros
                    Using comando As New SqlCommand(consulta, conexion)
                        ' Agregar parámetros con valores
                        comando.Parameters.AddWithValue("@name", nombre)
                        comando.Parameters.AddWithValue("@email", email)
                        comando.Parameters.AddWithValue("@phone", phone)
                        comando.Parameters.AddWithValue("@address", adress)
                        comando.Parameters.AddWithValue("@identificationNumber", idNumber)
                        comando.Parameters.AddWithValue("@idSector", sectorId)
                        comando.Parameters.AddWithValue("@idUser", ModuleGlobal.idUser)

                        ' Ejecutar la consulta de inserción
                        comando.ExecuteNonQuery()

                        ' Mensaje de éxito (puedes personalizarlo)
                        MessageBox.Show("Correctly inserted data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    ' Manejar errores
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        Else
            ' La variable tiene un valor asignado, se requiere actualizar el registro
            'MessageBox.Show($"La variable tiene el valor: {idProfesor}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Consulta SQL de actualizacion
            Dim consulta As String = "UPDATE Company SET name=@name ,email=@email ,phone=@phone ,address=@address ,identificationNumber=@identificationNumber ,idSector=@idSector, idUserModified = @idUser, dateModified = GETDATE()  where idCompany = @id"

            ' Crear una conexión
            Using conexion As New SqlConnection(cadenaConexion)
                Try
                    ' Abrir la conexión
                    conexion.Open()

                    ' Crear un comando con parámetros
                    Using comando As New SqlCommand(consulta, conexion)
                        ' Agregar parámetros con valores
                        comando.Parameters.AddWithValue("@name", nombre)
                        comando.Parameters.AddWithValue("@email", email)
                        comando.Parameters.AddWithValue("@phone", phone)
                        comando.Parameters.AddWithValue("@address", adress)
                        comando.Parameters.AddWithValue("@identificationNumber", idNumber)
                        comando.Parameters.AddWithValue("@idSector", sectorId)
                        comando.Parameters.AddWithValue("@idUser", ModuleGlobal.idUser)
                        comando.Parameters.AddWithValue("@id", idProfesor)


                        ' Ejecutar la consulta de inserción
                        comando.ExecuteNonQuery()

                        ' Mensaje de éxito (puedes personalizarlo)
                        MessageBox.Show("Correctly updated data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    ' Manejar errores
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If


        Me.Hide()
        ' Mostrar nuevamente Form1 al cerrar Form2
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' Mostrar nuevamente Form1 al cerrar Form2
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    ' Método para recibir el parámetro  idCompany, name,email,phone,address,identificationNumber,Company.idSecto r
    Public Sub RecibirParametros(Id As String, name As String, email As String, phone As String, address As String, identificationNumber As String, idSector As Integer, sectorname As String)
        ' Realizar acciones con el parámetro recibido
        idProfesor = Id
        nameObj = name
        emailObj = email
        phoneObj = phone
        addressObj = address
        identificationNumberObj = identificationNumber
        idSectorObj = idSector

        NameTxt.Text = nameObj
        EmailTxt.Text = emailObj
        PhoneTxt.Text = phoneObj
        AdressTxt.Text = addressObj
        IdNumberTxt.Text = identificationNumberObj


        Dim itemSeleccionado As New ComboBoxItem() With {.IdSector = idSectorObj, .SectorName = sectorname}
        ComboBox1.SelectedItem = itemSeleccionado
        ComboBox1.SelectedText = sectorname


    End Sub

    Private Sub CargarDatosComboBox()
        ' Ajusta la cadena de conexión según tu entorno
        Dim cadenaConexion As String = ModuleGlobal.connectionString

        ' Consulta SQL para obtener datos
        Dim consulta As String = "SELECT idSector, sectorname FROM Sector"

        Try
            ' Usar SqlConnection para conectarse a la base de datos
            Using conexion As New SqlConnection(cadenaConexion)
                ' Abrir la conexión
                conexion.Open()

                ' Usar SqlCommand para ejecutar la consulta
                Using comando As New SqlCommand(consulta, conexion)
                    ' Usar SqlDataReader para leer los resultados de la consulta
                    Using reader As SqlDataReader = comando.ExecuteReader()
                        ' Limpiar los elementos existentes en el ComboBox
                        ComboBox1.Items.Clear()

                        ' Iterar a través de los resultados y agregar elementos al ComboBox
                        While reader.Read()
                            ' Agregar un elemento al ComboBox utilizando los datos de la consulta                            
                            ComboBox1.Items.Add(New ComboBoxItem() With {
                                .IdSector = reader.GetInt32(0),
                                .SectorName = reader.GetString(1)
                            })
                        End While

                        ' Seleccionar el primer elemento si hay al menos uno
                        If ComboBox1.Items.Count > 0 Then
                            ComboBox1.SelectedIndex = 0
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosComboBox()
    End Sub
End Class

' Clase auxiliar para almacenar datos del ComboBox
Public Class ComboBoxItem
    Public Property IdSector As Integer
    Public Property SectorName As String

    Public Overrides Function ToString() As String
        Return SectorName
    End Function
End Class
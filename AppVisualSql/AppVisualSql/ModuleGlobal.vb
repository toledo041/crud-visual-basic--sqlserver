Imports System.Security.Cryptography
Imports System.Text

Module ModuleGlobal
    Public idUser As Integer
    Public connectionString As String = "Data Source=LAPTOP-I0I1BV8J;Initial Catalog=Vinculation;Integrated Security=True"

    Public Function CalculateMD5Hash(input As String) As String
        ' Crear una instancia de la clase MD5
        Using md5Hash As MD5 = MD5.Create()

            ' Convertir la cadena de entrada en un array de bytes
            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

            ' Crear un StringBuilder para almacenar el hash MD5 calculado
            Dim sBuilder As New StringBuilder()

            ' Recorrer cada byte del hash y convertirlo a formato hexadecimal
            For Each byteData As Byte In data
                sBuilder.Append(byteData.ToString("x2"))
            Next

            ' Devolver el hash MD5 como una cadena
            Return sBuilder.ToString()
        End Using
    End Function
End Module

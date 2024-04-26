

Public Class CancionesDAO

    'Colección para almacenar objetos de tipo Cancion
    Public ReadOnly Property Cancion As Collection

    'Constructor de la clase CancionDAO
    Public Sub New()
        Me.Canciones = New Collection 'Inicializa la colección de Canciones
    End Sub

    'Método para leer todas las canciones desde la base de datos
    Public Sub LeerTodos()

        Dim c As Canciones 'Variable temporal para almacenar cada canción
        Dim col, aux As Collection 'Variables para almacenar resultados de la consulta y un auxiliar

        'Realiza la consulta SQL para obtener todas las canciones ordenadas por IdCancion
        col = AgenteBD.ObtenerAgente().Leer("SELECT idCancion, nombre FROM Cancion ORDER BY idCancion")

        'Itera sobre el resultado de la consulta
        For Each aux In col
            c = New Canciones(aux(1).ToString) 'Crea un nuevo objeto Cancion con el IdCancion obtenido de la consulta
            c.Titulo = aux(2).ToString 'Asigna el nombre de la canción al objeto Cancion
            Me.Cancion.Add(c) 'Agrega la canción a la colección
        Next
    End Sub

    'Método para leer una canción específica desde la base de datos
    Public Sub Leer(ByRef c As Canciones)

        Dim col As Collection : Dim aux As Collection 'Variables para almacenar resultados de la consulta y un auxiliar

        'Realiza la consulta SQL para obtener la canción con el IdCancion especificado
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Cancion WHERE idCancion='" & c.IdCancion & "';")

        For Each aux In col 'Itera sobre el resultado de la consulta
            c.Titulo = aux(2).ToString 'Asigna el título de la canción al objeto Cancion pasado como parámetro
        Next

    End Sub

    'Método para añadir una nueva canción a la base de datos
    Public Function Anadir(ByVal c As Canciones) As Integer
        ' Realiza una operación de inserción en la base de datos con los datos de la canción pasada como parámetro
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Cancion VALUES ('" & c.IdCancion & "', '" & c.Titulo & "', '" & c.Duracion & "', '" & c.Id_Album & "');")
    End Function

    'Método para modificar una canción existente en la base de datos
    Public Function Modificar(ByVal c As Canciones) As Integer
        'Realiza una operación de actualización en la base de datos con los datos de la canción pasada como parámetro
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Cancion SET Titulo='" & c.Titulo & "', Duracion='" & c.Duracion & "', Id_Album='" & c.Id_Album & "';")
    End Function

    'Método para eliminar una canción existente en la base de datos
    Public Function Eliminar(ByVal c As Canciones) As Integer
        'Realiza una operación de eliminación en la base de datos con los datos de la canción pasada como parámetro
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Cancion WHERE IdCancion = '" & c.IdCancion & "' AND Titulo = '" & c.Titulo & "' AND Duracion = '" & c.Duracion & "' AND Id_Album = '" & c.Id_Album & "';")
    End Function
End Class

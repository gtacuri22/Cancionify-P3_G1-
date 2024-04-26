Public Class Canciones

    'Propiedades de la clase Cancion
    Public Property IdCancion As Integer
    Public Property Titulo As String
    Public Property Id_Album As Integer
    Public Property Duracion As Integer

    'Propiedad de solo lectura para acceder al objeto CancionDao
    Public ReadOnly Property CancionDAO As CancionDAO

    'Constructor por defecto de la clase Cancion
    Public Sun New()
        Me.CancionDAO = New CancionDAO 'Inicializa la propiedad CancionDAO con una nueva instancia de CancionDAO
    End Sub

    'Constructor con parámetro para inicializar el IdCancion
    Public Sub New(id As String)
        Me.CancionDAO = New CancionDAO 'Inicializa la propiedad CancionDAO con una nueva instancia de CancionDAO
        Me.IdCancion = id 'Asigna el valor del parámetro "id" a la propiedad IdCancion
    End Sub

    'Método para leer todas las canciones
    Public Sub LeerTodasCanciones()
        Me.CancionDAO.LeerTodas() 'Llama al método LeerTodas de CancionDAO para obtener todas las canciones
    End Sub

    'Método para leer una canción específica
    Public Sub LeerCancion()
        Me.CancionDAO.Leer(Me) 'Llama al método Leer de CancionDAO para leer la canción actual
    End Sub

    'Método para añadir una canción
    Public Function AnadirCancion() As Integer
        Return Me.CircuitoDAO.Anadir(Me) 'Devuelve el resultado de llamar al método Anadir de CircuitoDAO para añadir la canción actual
    End Function

    'Método para modificar una canción
    Public Function ModificarCancion() As Integer 'Devuelve el resultado de llamar al método Modificar de CancionDAO para modificar la canción actual
        Return Me.CancionDAO.Modificar(Me)
    End Function

    'Método para eliminar una canción
    Public Function EliminarCancion() As Integer
        Return Me.CancionDAO.Eliminar(Me) 'Devuelve el resultado de llamar al método Eliminar de CancionDAO para eliminar la canción actual
    End Function





End Class

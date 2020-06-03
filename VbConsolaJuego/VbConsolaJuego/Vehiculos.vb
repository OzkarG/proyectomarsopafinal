Interface ITerrestre
    Function CantidadCocaina(cantidad As Integer) As Boolean

End Interface

Public MustInherit Class Vehiculos

    Private Velocida As Integer
    Private atrapa As Integer

    Public Property Velocidad() As Integer
        Get
            Return Velocida
        End Get
        Set(value As Integer)
            Velocida = value
        End Set
    End Property

    Public Property AtrapadoPorba() As Integer
        Get
            Return Velocida
        End Get
        Set(value As Integer)
            Velocida = value
        End Set
    End Property

    Public Function Tardanza() As Integer

        Dim x As Integer
        x = 2500 / Velocida
        Return x

    End Function

    Public Function ganar() As Boolean
        Dim ganarste As Integer
        ganarste = atrapa + ((Tardanza() * 1000) / 2500)

        If (ganarste <= 35) Then
            Return True

        Else
            Return False
        End If

    End Function

    Public MustOverride Function Tranportar() As String

End Class

Public Class Terrestre
    Inherits Vehiculos
    Implements ITerrestre

    Private nombree As String

    Public Sub New(nombre As String)
        nombree = nombre
    End Sub


    Public Overrides Function Tranportar() As String
        Dim texto As String = "Conduciras por las peligrosas carreteras con tu" & nombree


        Return texto

    End Function

    Public Function CantidadCocaina(cantidad As Integer) As Boolean Implements ITerrestre.CantidadCocaina

        If (cantidad > 5) Then
            Return False
        Else
            Return True

        End If

    End Function
End Class

Public Class Maritimo
    Inherits Vehiculos
    Private nombree As String


    Public Sub New(nombre As String)
        nombree = nombre
    End Sub

    Public Overrides Function Tranportar() As String
        Dim texto As Integer = "Navegaras por el oceano con tu" & nombree
        Return texto

    End Function
End Class

Public Class Aereo
    Inherits Vehiculos
    Private nombree As String


    Public Sub New(nombre As String)
        nombree = nombre
    End Sub

    Public Overrides Function Tranportar() As String
        Dim texto As Integer = "Volaras por los aires con tu" & nombree
        Return texto

    End Function
End Class

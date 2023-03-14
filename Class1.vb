Public MustInherit Class Vehiculo
    Public MustOverride Sub Sonido()
End Class

Public Class Carro
    Inherits Vehiculo
    Implements IVehiculo

    Public Overrides Sub Sonido()
        MessageBox.Show("RUUUMMMMMMM")
    End Sub

    Public Sub Arrancar() Implements IVehiculo.Arrancar
        MessageBox.Show("Arrancaste el carro")
    End Sub
End Class

Public Class Avion
    Inherits Vehiculo
    Implements IVehiculo

    Public Overrides Sub Sonido()
        MessageBox.Show("FIUUUUMMMMM")
    End Sub

    Public Sub Arrancar() Implements IVehiculo.Arrancar
        MessageBox.Show("Arrancaste el avión")
    End Sub
End Class

Public Interface IVehiculo
    Sub Arrancar()
End Interface
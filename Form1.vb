Public Class Form1
    Private carro As Carro
    Private avion As Avion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carro = New Carro()
        avion = New Avion()

    End Sub

    Private Sub btnCarro_Click(sender As Object, e As EventArgs) Handles btnCarro.Click
        lblFinal.Text = ""
        carro.Sonido()
        lblFinal.Text = "RUUUUMMMMM" & vbCrLf

        Dim vehiculo As IVehiculo = carro
        vehiculo.Arrancar()
        lblFinal.Text += "Arrancó el carro"
    End Sub

    Private Sub btnAvion_Click(sender As Object, e As EventArgs) Handles btnAvion.Click
        lblFinal.Text = ""
        avion.Sonido()
        lblFinal.Text = "FIUUUUMMMMMM" & vbCrLf

        Dim vehiculo As IVehiculo = avion
        vehiculo.Arrancar()
        lblFinal.Text += "Arrancó el Avión"
    End Sub
End Class

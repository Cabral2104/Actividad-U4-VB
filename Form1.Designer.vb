<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.btnAvion = New System.Windows.Forms.Button()
        Me.btnCarro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFinal
        '
        Me.lblFinal.Location = New System.Drawing.Point(208, 203)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(385, 198)
        Me.lblFinal.TabIndex = 5
        '
        'btnAvion
        '
        Me.btnAvion.Location = New System.Drawing.Point(419, 50)
        Me.btnAvion.Name = "btnAvion"
        Me.btnAvion.Size = New System.Drawing.Size(109, 58)
        Me.btnAvion.TabIndex = 4
        Me.btnAvion.Text = "Avión"
        Me.btnAvion.UseVisualStyleBackColor = True
        '
        'btnCarro
        '
        Me.btnCarro.Location = New System.Drawing.Point(238, 50)
        Me.btnCarro.Name = "btnCarro"
        Me.btnCarro.Size = New System.Drawing.Size(124, 58)
        Me.btnCarro.TabIndex = 3
        Me.btnCarro.Text = "Carro"
        Me.btnCarro.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.btnAvion)
        Me.Controls.Add(Me.btnCarro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblFinal As Label
    Private WithEvents btnAvion As Button
    Private WithEvents btnCarro As Button
End Class

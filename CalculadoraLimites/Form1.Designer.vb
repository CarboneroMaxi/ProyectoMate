<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadoraLineal
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAbrirCalculadora = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(105, 64)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(373, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Calculadora de limites"
        '
        'btnAbrirCalculadora
        '
        Me.btnAbrirCalculadora.BackColor = System.Drawing.Color.White
        Me.btnAbrirCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAbrirCalculadora.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAbrirCalculadora.Location = New System.Drawing.Point(223, 183)
        Me.btnAbrirCalculadora.Name = "btnAbrirCalculadora"
        Me.btnAbrirCalculadora.Size = New System.Drawing.Size(121, 38)
        Me.btnAbrirCalculadora.TabIndex = 1
        Me.btnAbrirCalculadora.Text = "Abrir calculadora"
        Me.btnAbrirCalculadora.UseVisualStyleBackColor = False
        '
        'FrmCalculadoraLineal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnAbrirCalculadora)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmCalculadoraLineal"
        Me.Text = "Calculadora Lineal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAbrirCalculadora As Button

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalculadoraLimite
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAbrirCalculadora = New System.Windows.Forms.Button()
        Me.btnCalcularLimiteDividiendo = New System.Windows.Forms.Button()
        Me.btnCalculadoraLimiteRaizCuadrada = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.btnAbrirCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirCalculadora.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAbrirCalculadora.Location = New System.Drawing.Point(232, 120)
        Me.btnAbrirCalculadora.Name = "btnAbrirCalculadora"
        Me.btnAbrirCalculadora.Size = New System.Drawing.Size(121, 38)
        Me.btnAbrirCalculadora.TabIndex = 1
        Me.btnAbrirCalculadora.Text = "f(x) = ax+b"
        Me.btnAbrirCalculadora.UseVisualStyleBackColor = False
        '
        'btnCalcularLimiteDividiendo
        '
        Me.btnCalcularLimiteDividiendo.BackColor = System.Drawing.Color.White
        Me.btnCalcularLimiteDividiendo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCalcularLimiteDividiendo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularLimiteDividiendo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCalcularLimiteDividiendo.Location = New System.Drawing.Point(232, 161)
        Me.btnCalcularLimiteDividiendo.Name = "btnCalcularLimiteDividiendo"
        Me.btnCalcularLimiteDividiendo.Size = New System.Drawing.Size(121, 38)
        Me.btnCalcularLimiteDividiendo.TabIndex = 2
        Me.btnCalcularLimiteDividiendo.Text = "f(x) = ax+b"
        Me.btnCalcularLimiteDividiendo.UseVisualStyleBackColor = False
        '
        'btnCalculadoraLimiteRaizCuadrada
        '
        Me.btnCalculadoraLimiteRaizCuadrada.BackColor = System.Drawing.Color.White
        Me.btnCalculadoraLimiteRaizCuadrada.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCalculadoraLimiteRaizCuadrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculadoraLimiteRaizCuadrada.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCalculadoraLimiteRaizCuadrada.Location = New System.Drawing.Point(232, 205)
        Me.btnCalculadoraLimiteRaizCuadrada.Name = "btnCalculadoraLimiteRaizCuadrada"
        Me.btnCalculadoraLimiteRaizCuadrada.Size = New System.Drawing.Size(121, 38)
        Me.btnCalculadoraLimiteRaizCuadrada.TabIndex = 3
        Me.btnCalculadoraLimiteRaizCuadrada.Text = "f(x) = ax+b"
        Me.btnCalculadoraLimiteRaizCuadrada.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Adrián Machado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(444, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Maximiliano Domínguez"
        '
        'FrmCalculadoraLimite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculadoraLimiteRaizCuadrada)
        Me.Controls.Add(Me.btnCalcularLimiteDividiendo)
        Me.Controls.Add(Me.btnAbrirCalculadora)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmCalculadoraLimite"
        Me.Text = "Calculadora Lineal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAbrirCalculadora As Button


    Private Sub btnAbrirCalculadora_Click(sender As Object, e As EventArgs) Handles btnAbrirCalculadora.Click
        frmCalcularLimite.Show()
        Me.Visible = False
    End Sub

    Friend WithEvents btnCalcularLimiteDividiendo As Button
    Friend WithEvents btnCalculadoraLimiteRaizCuadrada As Button

    Private Sub btnCalcularLimiteDividiendo_Click(sender As Object, e As EventArgs) Handles btnCalcularLimiteDividiendo.Click
        frmCalcularLimiteDividiendo.Show()
        Me.Visible = False
    End Sub

    Private Sub btnCalculadoraLimiteRaizCuadrada_Click(sender As Object, e As EventArgs) Handles btnCalculadoraLimiteRaizCuadrada.Click
        frmCalculadoraLimiteRaizCuadrada.Show()
        Me.Visible = False
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

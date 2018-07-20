<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadoraLimiteRaizCuadrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculadoraLimiteRaizCuadrada))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.txtx = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Lim"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.Location = New System.Drawing.Point(388, 135)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(0, 25)
        Me.lblr.TabIndex = 22
        '
        'txtb
        '
        Me.txtb.Location = New System.Drawing.Point(309, 144)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(34, 20)
        Me.txtb.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "x +"
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(222, 144)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(34, 20)
        Me.txta.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "--"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "\"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "|"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(207, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "|"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "-----------------------------------------------------"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(9, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "|"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(364, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(9, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "|"
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(298, 204)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(75, 23)
        Me.btnResultado.TabIndex = 31
        Me.btnResultado.Text = "Calcular"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'txtx
        '
        Me.txtx.Location = New System.Drawing.Point(180, 188)
        Me.txtx.Name = "txtx"
        Me.txtx.Size = New System.Drawing.Size(34, 20)
        Me.txtx.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(120, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "X ->"
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(298, 233)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 34
        Me.btnreset.Text = "Borrar"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolver.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnvolver.Image = CType(resources.GetObject("btnvolver.Image"), System.Drawing.Image)
        Me.btnvolver.Location = New System.Drawing.Point(42, 298)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(72, 51)
        Me.btnvolver.TabIndex = 35
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'frmCalculadoraLimiteRaizCuadrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.txtb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCalculadoraLimiteRaizCuadrada"
        Me.Text = "CalculadoraLimiteRaizCuadrada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblr As Label
    Friend WithEvents txtb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnResultado As Button
    Friend WithEvents txtx As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents btnvolver As Button
End Class

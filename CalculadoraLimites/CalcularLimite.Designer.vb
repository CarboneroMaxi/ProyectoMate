<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalcularLimite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalcularLimite))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtx = New System.Windows.Forms.TextBox()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.lblr = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lim"
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(188, 122)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(34, 20)
        Me.txta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "x +"
        '
        'txtb
        '
        Me.txtb.Location = New System.Drawing.Point(275, 122)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(34, 20)
        Me.txtb.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "X ->"
        '
        'txtx
        '
        Me.txtx.Location = New System.Drawing.Point(188, 155)
        Me.txtx.Name = "txtx"
        Me.txtx.Size = New System.Drawing.Size(34, 20)
        Me.txtx.TabIndex = 6
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(348, 200)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(75, 23)
        Me.btnResultado.TabIndex = 8
        Me.btnResultado.Text = "Calcular"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.Location = New System.Drawing.Point(351, 119)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(0, 25)
        Me.lblr.TabIndex = 9
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(348, 229)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 10
        Me.btnreset.Text = "Borrar"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(44, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 51)
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCalcularLimite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCalcularLimite"
        Me.Text = "CalcularLimite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtx As TextBox
    Friend WithEvents btnResultado As Button
    Friend WithEvents lblr As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents Button1 As Button
End Class

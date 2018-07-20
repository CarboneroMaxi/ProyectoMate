<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcularLimiteDividiendo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalcularLimiteDividiendo))
        Me.lblr = New System.Windows.Forms.Label()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.lblx = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.txtx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.Location = New System.Drawing.Point(361, 131)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(0, 25)
        Me.lblr.TabIndex = 18
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(352, 235)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(75, 23)
        Me.btnResultado.TabIndex = 17
        Me.btnResultado.Text = "Calcular"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'txtc
        '
        Me.txtc.Location = New System.Drawing.Point(206, 191)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(34, 20)
        Me.txtc.TabIndex = 16
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx.Location = New System.Drawing.Point(244, 186)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(52, 25)
        Me.lblx.TabIndex = 15
        Me.lblx.Text = "X ² -"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(201, 154)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(131, 25)
        Me.lbl.TabIndex = 14
        Me.lbl.Text = "-----------------"
        '
        'txtb
        '
        Me.txtb.Location = New System.Drawing.Point(293, 134)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(34, 20)
        Me.txtb.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "x +"
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(206, 134)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(34, 20)
        Me.txta.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Lim"
        '
        'txtd
        '
        Me.txtd.Location = New System.Drawing.Point(296, 191)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(34, 20)
        Me.txtd.TabIndex = 19
        '
        'txtx
        '
        Me.txtx.Location = New System.Drawing.Point(204, 234)
        Me.txtx.Name = "txtx"
        Me.txtx.Size = New System.Drawing.Size(34, 20)
        Me.txtx.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "X ->"
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(352, 264)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 22
        Me.btnreset.Text = "Borrar"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Purple
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(27, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 51)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCalcularLimiteDividiendo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.txtc)
        Me.Controls.Add(Me.lblx)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCalcularLimiteDividiendo"
        Me.Text = "frmCalcularLimiteDividiendo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblr As Label
    Friend WithEvents btnResultado As Button
    Friend WithEvents txtc As TextBox
    Friend WithEvents lblx As Label
    Friend WithEvents lbl As Label
    Friend WithEvents txtb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtd As TextBox
    Friend WithEvents txtx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents Button1 As Button
End Class

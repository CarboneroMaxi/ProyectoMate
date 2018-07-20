Public Class frmCalculadoraLimiteRaizCuadrada
    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Dim A, B, X As Integer
        Dim m, d As Double
        If (txta.Text = "" Or Not (Int32.TryParse(txta.Text, A))) Then
        ElseIf (txtb.Text = "" Or Not (Int32.TryParse(txtb.Text, B))) Then
        ElseIf (txtx.Text = "" Or Not (Int32.TryParse(txtx.Text, X))) Then
        Else
            m = A * X + B
            lblr.Text = m
            d = Math.Sqrt(m)
            lblr.Text = d
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txta.Text = ""
        txtb.Text = ""
        txtx.Text = ""
        lblr.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        FrmCalculadoraLimite.Show()
        Me.Visible = False
    End Sub
End Class
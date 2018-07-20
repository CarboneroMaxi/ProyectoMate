Public Class frmCalcularLimiteDividiendo
    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Dim A1, B1, C1, X1, D1 As Integer
        Dim m, n As Double
        If (txta.Text = "" Or Not (Int32.TryParse(txta.Text, A1))) Then
        ElseIf (txtb.Text = "" Or Not (Int32.TryParse(txtb.Text, B1))) Then
        ElseIf (txtc.Text = "" Or Not (Int32.TryParse(txtc.Text, C1))) Then
        ElseIf (txtd.Text = "" Or Not (Int32.TryParse(txtd.Text, D1))) Then
        ElseIf (txtx.Text = "" Or Not (Int32.TryParse(txtx.Text, X1))) Then
        Else
            m = A1 * X1 + B1
            n = C1 * (X1 * X1) - D1
            lblr.Text = m / n
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txta.Text = ""
        txtb.Text = ""
        txtx.Text = ""
        txtc.Text = ""
        txtd.Text = ""
        lblr.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCalculadoraLimite.Show()
        Me.Visible = False
    End Sub
End Class
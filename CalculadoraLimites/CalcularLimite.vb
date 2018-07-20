Public Class frmCalcularLimite
    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Dim A, B, X As Integer
        Dim m As Double
        If (txta.Text = "" Or Not (Int32.TryParse(txta.Text, A))) Then
        ElseIf (txtb.Text = "" Or Not (Int32.TryParse(txtb.Text, B))) Then
        ElseIf (txtx.Text = "" Or Not (Int32.TryParse(txtx.Text, X))) Then
        Else
            m = A * X + B
            lblr.Text = m
        End If
    End Sub

    Private Sub txtresultado_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmCalcularLimite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txta.Text = ""
        txtb.Text = ""
        txtx.Text = ""
        lblr.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCalculadoraLimite.Show()
        Me.Visible = False
    End Sub
End Class
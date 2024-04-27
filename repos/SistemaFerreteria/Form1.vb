Public Class Form1
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim oCategoria As New NEGOCIO.Categoria
        Dim dtCategoria As DataTable

        dtCategoria = oCategoria.Traer("")

        dgvCategoria.DataSource = dtCategoria

    End Sub
End Class

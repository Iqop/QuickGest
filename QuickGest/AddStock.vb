Public Class AddStock
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\stock.data", nome.Text + "&&" + quant.Text + "&&" + ean.Text + "&&" + preco.Text + ";", True)
        QuickGest.loadStock(True)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
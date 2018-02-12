Public Class AddCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\cliente.data", nome.Text + "&&" + telem.Text + "&&" + email.Text + "&&" + dividas.Text + ";", True)
        QuickGest.loadClient(True)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

End Class
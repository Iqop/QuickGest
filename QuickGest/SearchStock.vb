Public Class SearchStock
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each element In QuickGest.stockData
            If Not (element = vbNewLine Or element = "") Then
                Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                If data(2).Equals(TextBox1.Text) Then
                    list.Items.Add(New ListViewItem(data))
                    Exit For


                End If
            End If
        Next
        If (list.Items.Count = 0) Then
            MsgBox("Não foram encontrados produtos com esse parametro")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EditStock.isFromSearch = True
        EditStock.Show()
        list.Items.Clear()
        TextBox1.Text = ""
        Button3.Enabled = False
        Button4.Enabled = False

    End Sub

    Private Sub list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list.SelectedIndexChanged
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Deseja mesmo remover o produto selecionado?", MsgBoxStyle.YesNo, "Remover produto") = MsgBoxResult.Yes Then
            Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\stock.data").Split(New Char() {";"c})
            Dim save As String = ""
            For Each element In data
                If Not (element = "" Or element = vbNewLine) Then
                    If (Not (element = list.SelectedItems(0).SubItems(0).Text + "&&" + list.SelectedItems(0).SubItems(1).Text + "&&" + list.SelectedItems(0).SubItems(2).Text + "&&" + list.SelectedItems(0).SubItems(3).Text)) Then
                        save = save + element + ";" + vbNewLine

                    End If
                End If

            Next
            My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\stock.data", save, False)

            QuickGest.loadStock(True)
            list.Items.Clear()
            TextBox1.Text = ""
            Button3.Enabled = False
            Button4.Enabled = False
        End If
    End Sub
End Class
Public Class SearchCli
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button5.Enabled = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        List.Items.Clear()

        Select Case ComboBox1.SelectedItem.ToString
            Case "Nome"

                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(0).Equals(TextBox1.Text) Then
                            List.Items.Add(New ListViewItem(data))
                            Exit For


                        End If
                    End If
                Next
            Case "Telemovel"
                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(1).Equals(TextBox1.Text) Then
                            List.Items.Add(New ListViewItem(data))
                            Exit For


                        End If
                    End If
                Next
            Case "Email"
                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(2).Equals(TextBox1.Text) Then
                            List.Items.Add(New ListViewItem(data))
                            Exit For


                        End If
                    End If
                Next

        End Select

        If (List.Items.Count = 0) Then
            MsgBox("Não foram encontrados clientes com esses parametros")
        End If
    End Sub

    Private Sub ClientesBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Deseja mesmo remover o cliente selecionado?", MsgBoxStyle.YesNo, "Remover cliente") = MsgBoxResult.Yes Then
            Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\cliente.data").Split(New Char() {";"c})
            Dim save As String = ""
            For Each element In data
                If Not (element = "" Or element = vbNewLine) Then
                    If (Not (element = List.SelectedItems(0).SubItems(0).Text + "&&" + List.SelectedItems(0).SubItems(1).Text + "&&" + List.SelectedItems(0).SubItems(2).Text + "&&" + List.SelectedItems(0).SubItems(3).Text)) Then
                        save = save + element + ";" + vbNewLine

                    End If
                End If

            Next
            My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\cliente.data", save, False)

            QuickGest.loadClient(True)
            List.Items.Clear()
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditClients.isFromSearch = True
        EditClients.Show()
        List.Items.Clear()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        historyByClient.nome = List.SelectedItems(0).SubItems(0).Text
        historyByClient.telem = List.SelectedItems(0).SubItems(1).Text
        historyByClient.Show()
        List.Items.Clear()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
End Class
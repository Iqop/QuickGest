Public Class AddCompras
    Dim save As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "/data/stock.data")
    Dim timeStamp As String = My.Computer.Clock.LocalTime.ToShortDateString + " | " + My.Computer.Clock.LocalTime.ToShortTimeString
    Dim nome As String
    Dim telem As String
    Dim editIndex As Integer
    Dim isConcluir As Boolean = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "/data/stock.data", save, False)
        QuickGest.loadCompras(True)
        QuickGest.loadStock(True)
        QuickGest.loadClient(True)
        Me.Close()

    End Sub

    Private Sub calcTotal()

        Dim total As Double = 0.0
        For Each value As ListViewItem In lista.Items
            total += CDbl(value.SubItems(2).Text) * CDbl(value.SubItems(3).Text)
        Next

        totalLabel.Text = CStr(total)
    End Sub



    Private Sub AddCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "TimeStamp: " + timeStamp
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim save As String = ""
        Dim paidValue As String
        If (CheckBox1.Checked) Then
            paidValue = "sim"

        Else
            paidValue = "nao"
            Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\data\cliente.data").Split(New Char() {";"c})
            Dim index As Integer = 0
            Dim s As String = ""
            For Each element As String In data
                Dim res = element.Split(New String() {"&&"}, StringSplitOptions.None)
                If (index = editIndex) Then
                    res(3) = CStr(CDbl(res(3)) + CDbl(totalLabel.Text))

                End If

                If Not (element = "" Or element = vbNewLine) Then
                    s += res(0) + "&&" + res(1) + "&&" + res(2) + "&&" + res(3) + ";" + vbNewLine
                End If

                index += 1
            Next

            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\data\cliente.data", s, False)
        End If

        For Each item As ListViewItem In lista.Items
            save += timeStamp + "&&" + nome + "&&" + item.SubItems(0).Text + "&&" + item.SubItems(1).Text + "&&" + item.SubItems(3).Text + "&&" + item.SubItems(2).Text + "&&" + paidValue + " ;" + vbNewLine
        Next

        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\historico\all.data", save, True)







        isConcluir = True
        QuickGest.loadCompras(True)
        QuickGest.loadStock(True)
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        DelCompra.Enabled = True

    End Sub


    Private Sub DelCompra_Click(sender As Object, e As EventArgs) Handles DelCompra.Click
        If MsgBox("Deseja mesmo remover este elemento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim save As String = ""
            Dim read As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\data\stock.data").Split(New Char() {";"c})
            For Each value As String In read
                If Not (value = "" Or value = vbNewLine) Then
                    Dim res As String() = value.Split(New String() {"&&"}, StringSplitOptions.None)
                    If res(2) = lista.SelectedItems(0).SubItems(1).Text Then
                        res(1) += CInt(lista.SelectedItems(0).SubItems(2).Text)
                    End If
                    save += res(0) + "&&" + res(1) + "&&" + res(2) + "&&" + res(3) + ";" + vbNewLine
                End If
            Next
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\data\stock.data", save, False)
            lista.Items.Remove(lista.SelectedItems(0))
            QuickGest.loadStock(False)
        End If
        DelCompra.Enabled = False
    End Sub

    Private Sub pesquisa_Click(sender As Object, e As EventArgs) Handles pesquisa.Click
        nomeCliente.Text = ""
        editIndex = 0
        Select Case ComboBox1.SelectedItem.ToString
            Case "Nome"

                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(0).Equals(TextBox1.Text) Then
                            nomeCliente.Text = data(0) + ", telem: " + data(1)
                            nome = data(0)
                            telem = data(1)
                            Exit For


                        End If
                    End If
                    editIndex += 1
                Next
            Case "Telemovel"
                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(1).Equals(TextBox1.Text) Then
                            nomeCliente.Text = data(0) + ", telem: " + data(1)
                            nome = data(0)
                            telem = data(1)
                            Exit For


                        End If
                    End If
                    editIndex += 1
                Next
            Case "Email"
                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(2).Equals(TextBox1.Text) Then
                            nomeCliente.Text = data(0) + ", telem: " + data(1)
                            nome = data(0)
                            telem = data(1)
                            Exit For


                        End If
                    End If
                    editIndex += 1
                Next

        End Select

        If (nomeCliente.Text = "") Then
            If (MsgBox("Não foram encontrados clientes com esses parametros" + vbNewLine + "Deseja adicionar esse cliente?", MsgBoxStyle.YesNo, "Cliente não encontrado") = MsgBoxResult.Yes) Then
                AddCliente.Show()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        pesquisa.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddToShoppingList.Show()

        DelCompra.Enabled = False

    End Sub


    Private Sub nomeCliente_TextChanged(sender As Object, e As EventArgs) Handles nomeCliente.TextChanged
        Button4.Enabled = True

    End Sub

    Private Sub AddCompras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isConcluir Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "/data/stock.data", save, False)
            QuickGest.loadCompras(True)
            QuickGest.loadStock(True)
            QuickGest.loadClient(True)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        calcTotal()

    End Sub

End Class
Public Class historyByClient
    Public nome As String, telem As String
    Private Sub historyByClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nome = "" Then
            ComboBox1.Enabled = False
            TextBox1.Enabled = False
            Button1.Enabled = False
            nomeCliente.Text = nome + ", telem: " + telem
            loadToList()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nomeCliente.Text = ""
        Select Case ComboBox1.SelectedItem.ToString
            Case "Nome"

                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(0).Equals(TextBox1.Text) Then
                            nomeCliente.Text = data(0) + ", telem: " + data(1)
                            nome = data(0)
                            telem = data(1)
                            loadToList()
                            Exit For


                        End If
                    End If
                Next
            Case "Telemovel"
                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(1).Equals(TextBox1.Text) Then
                            nomeCliente.Text = data(0) + ", telem: " + data(1)
                            nome = data(0)
                            telem = data(1)
                            loadToList()
                            Exit For


                        End If
                    End If
                Next
            Case "Email"
                For Each element In QuickGest.clientData
                    If Not (element = vbNewLine Or element = "") Then
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If data(2).Equals(TextBox1.Text) Then
                            nomeCliente.Text = data(0) + ", telem: " + data(1)
                            nome = data(0)
                            telem = data(1)
                            loadToList()
                            Exit For


                        End If
                    End If
                Next

        End Select

        If (nomeCliente.Text = "") Then
            If (MsgBox("Não foram encontrados clientes com esses parametros" + vbNewLine + "Deseja adicionar esse cliente?", MsgBoxStyle.YesNo, "Cliente não encontrado") = MsgBoxResult.Yes) Then
                AddCliente.Show()
            End If
        End If
    End Sub



    Sub loadToList()
        ListView1.Items.Clear()

        Dim read As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\historico\all.data").Split(New Char() {";"c})
        read = Filter(read, nome, True, CompareMethod.Text)
        For Each value As String In read
            If Not (value = "" Or value = vbNewLine) Then
                Dim data As String() = value.Split(New String() {"&&"}, StringSplitOptions.None)
                ListView1.Items.Insert(0, New ListViewItem(New String() {data(0), data(2), data(3), data(4), data(5), data(6)}))
            End If

        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim read As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\historico\all.data").Split(New Char() {";"c})
        Dim save As String = ""
        For Each item In read
            If item.Equals(ListView1.SelectedItems(0).SubItems(0).Text + "&&" + nome + "&&" + ListView1.SelectedItems(0).SubItems(1).Text + "&&" + ListView1.SelectedItems(0).SubItems(2).Text + "&&" + ListView1.SelectedItems(0).SubItems(3).Text + "&&" + ListView1.SelectedItems(0).SubItems(4).Text + "&&" + ListView1.SelectedItems(0).SubItems(5).Text) Then

                If ListView1.SelectedItems(0).SubItems(5).Text = "sim" Then
                    item = ListView1.SelectedItems(0).SubItems(0).Text + "&&" + nome + "&&" + ListView1.SelectedItems(0).SubItems(1).Text + "&&" + ListView1.SelectedItems(0).SubItems(2).Text + "&&" + ListView1.SelectedItems(0).SubItems(3).Text + "&&" + ListView1.SelectedItems(0).SubItems(4).Text + "&&" + "nao"
                    Dim rClients As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\data\cliente.data").Split(New Char() {";"c})
                    Dim sCLientes As String = ""
                    For Each element In rClients
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If nome = data(0) Then
                            data(3) = CStr(CDbl(data(3)) + (CDbl(ListView1.SelectedItems(0).SubItems(3).Text) * CDbl(ListView1.SelectedItems(0).SubItems(4).Text)))
                        End If
                        If Not (element = vbNewLine Or element = "") Then
                            sCLientes += data(0) + "&&" + data(1) + "&&" + data(2) + "&&" + data(3) + ";" + vbNewLine
                        End If
                    Next
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\data\cliente.data", sCLientes, False)


                Else
                    item = ListView1.SelectedItems(0).SubItems(0).Text + "&&" + nome + "&&" + ListView1.SelectedItems(0).SubItems(1).Text + "&&" + ListView1.SelectedItems(0).SubItems(2).Text + "&&" + ListView1.SelectedItems(0).SubItems(3).Text + "&&" + ListView1.SelectedItems(0).SubItems(4).Text + "&&" + "sim"
                    Dim rClients As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\data\cliente.data").Split(New Char() {";"c})
                    Dim sCLientes As String = ""
                    For Each element In rClients
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If nome = data(0) Then
                            data(3) = CStr(CDbl(data(3)) - (CDbl(ListView1.SelectedItems(0).SubItems(3).Text) * CDbl(ListView1.SelectedItems(0).SubItems(4).Text)))
                        End If
                        If Not (element = vbNewLine Or element = "") Then
                            sCLientes += data(0) + "&&" + data(1) + "&&" + data(2) + "&&" + data(3) + ";" + vbNewLine
                        End If
                    Next
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\data\cliente.data", sCLientes, False)


                End If

            End If

            If Not (item.Equals("") Or item.Equals(vbNewLine)) Then
                save += item + ";" + vbNewLine
            End If

        Next

        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\historico\all.data", save, False)
        Button2.Enabled = False
        loadToList()
        QuickGest.loadClient(True)
        QuickGest.loadCompras(True)
    End Sub
End Class
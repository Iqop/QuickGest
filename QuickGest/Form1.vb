Public Class QuickGest
    Public stockData As String()
    Public clientData As String()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)

        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height
        TabControl1.ItemSize = New Size(TabControl1.ItemSize.Width, Me.Height * 0.07)


        StockBox.Size = New Size(Stock.Width / 2, Stock.Height - 45)
        StockBox.Location = New Point(0, 0)
        BtnaddProd.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (1 / 8))
        BtnEditStock.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (2 / 8))
        BtndelStock.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (3 / 8))
        BtnSearchStock.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (4 / 8))

        ClientesBox.Size = New Size(Stock.Width / 2, Stock.Height - 45)
        ClientesBox.Location = New Point(0, 0)
        BtnAddClient.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (1 / 8))
        BtnEditCliente.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (2 / 8))
        BtnHistorico.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (3 / 8))
        BtnDelCliente.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (4 / 8))
        BtnSearchCli.Location = New Point(Stock.Width * (2 / 3), Stock.Height * (5 / 8))

        compras.Size = New Size(Stock.Width * (3 / 4), Stock.Height - 45)
        compras.Location = New Point(0, 0)
        BtnAddCompras.Location = New Point(Stock.Width * (4 / 5), Stock.Height * (1 / 8))
        BtnIsPaid.Location = New Point(Stock.Width * (4 / 5), Stock.Height * (2 / 8))
        BtnSearchCompras.Location = New Point(Stock.Width * (4 / 5), Stock.Height * (3 / 8))

        TabControl1.TabPages(0).Text = "Stock" + putSpaces("Stock")
        TabControl1.TabPages(1).Text = "Clientes" + putSpaces("Clientes")
        TabControl1.TabPages(2).Text = "Compras" + putSpaces("Compras")
        For Each value In StockBox.Columns
            value.width = Me.Width / 8 - 3
        Next
        For Each value In ClientesBox.Columns
            value.width = Me.Width / 8 - 3
        Next

        For Each value In compras.Columns
            value.width = Me.Width / 11 + 2
        Next




        loadStock(False)
    End Sub
    'Tenho que fazer pesquisa
    Function putSpaces(name As String) As String
        Dim toRet As String = ""
        Dim size As Integer = Me.Width / 3 - (name.Length * 8)
        Dim i As Integer = 0
        While i < size
            toRet += " "
            i += 3
        End While
        Return toRet
    End Function

    Sub loadStock(isReload As Boolean)
        Dim read As String
        read = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\stock.data")
        stockData = read.Split(New Char() {";"c})
        If (isReload) Then
            StockBox.Items.Clear()
        End If
        For Each element In stockData
            If Not (element = "") Then
                Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                StockBox.Items.Add(New ListViewItem(data))
            End If
        Next

    End Sub

    Sub loadClient(isReload As Boolean)
        Dim read As String
        read = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\cliente.data")
        clientData = read.Split(New Char() {";"c})
        If (isReload) Then
            ClientesBox.Items.Clear()
        End If
        For Each element In clientData
            If Not (element = "") Then
                Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                ClientesBox.Items.Add(New ListViewItem(data))
            End If
        Next

    End Sub

    Sub loadCompras(isReload As Boolean)
        Dim read As String
        read = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\historico\all.data")
        Dim comprasData = read.Split(New Char() {";"c})
        If (isReload) Then
            compras.Items.Clear()
        End If
        For Each element In comprasData
            If Not (element = "" Or element = vbNewLine) Then
                Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                compras.Items.Insert(0, New ListViewItem(data))
            End If
        Next

    End Sub


    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

        loadStock(True)
        BtnEditStock.Enabled = False
        BtndelStock.Enabled = False
        loadClient(True)
        BtnHistorico.Enabled = False
        BtnEditCliente.Enabled = False
        BtnDelCliente.Enabled = False
        loadCompras(True)
        BtnIsPaid.Enabled = False


    End Sub

    Private Sub BtnaddProd_Click(sender As Object, e As EventArgs) Handles BtnaddProd.Click
        AddStock.Show()
        BtnEditStock.Enabled = False
        BtndelStock.Enabled = False

    End Sub

    Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
        AddCliente.Show()
        BtnEditCliente.Enabled = False
        BtnDelCliente.Enabled = False
    End Sub

    Private Sub StockBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StockBox.SelectedIndexChanged
        BtnEditStock.Enabled = True
        BtndelStock.Enabled = True

    End Sub

    Private Sub BtnEditStock_Click(sender As Object, e As EventArgs) Handles BtnEditStock.Click
        EditStock.isFromSearch = False
        EditStock.Show()
        BtnEditStock.Enabled = False
        BtndelStock.Enabled = False
    End Sub

    Private Sub BtndelStock_Click(sender As Object, e As EventArgs) Handles BtndelStock.Click
        If MsgBox("Deseja mesmo remover o produto selecionado?", MsgBoxStyle.YesNo, "Remover produto") = MsgBoxResult.Yes Then
            Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\stock.data").Split(New Char() {";"c})
            Dim save As String = ""
            For Each element In data
                If Not (element = "" Or element = vbNewLine) Then
                    If (Not (element = StockBox.SelectedItems(0).SubItems(0).Text + "&&" + StockBox.SelectedItems(0).SubItems(1).Text + "&&" + StockBox.SelectedItems(0).SubItems(2).Text + "&&" + StockBox.SelectedItems(0).SubItems(3).Text)) Then
                        save = save + element + ";" + vbNewLine

                    End If
                End If

            Next
            My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\stock.data", save, False)

            loadStock(True)
            BtnEditStock.Enabled = False
            BtndelStock.Enabled = False
        End If

    End Sub

    Private Sub BtnDelCliente_Click(sender As Object, e As EventArgs) Handles BtnDelCliente.Click
        If MsgBox("Deseja mesmo remover o cliente selecionado?", MsgBoxStyle.YesNo, "Remover cliente") = MsgBoxResult.Yes Then
            Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\cliente.data").Split(New Char() {";"c})
            Dim save As String = ""
            For Each element In data
                If Not (element = "" Or element = vbNewLine) Then
                    If (Not (element = ClientesBox.SelectedItems(0).SubItems(0).Text + "&&" + ClientesBox.SelectedItems(0).SubItems(1).Text + "&&" + ClientesBox.SelectedItems(0).SubItems(2).Text + "&&" + ClientesBox.SelectedItems(0).SubItems(3).Text)) Then
                        save = save + element + ";" + vbNewLine

                    End If
                End If

            Next
            My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\cliente.data", save, False)

            loadClient(True)
            BtnEditCliente.Enabled = False
            BtnDelCliente.Enabled = False
        End If
    End Sub

    Private Sub BtnEditCliente_Click(sender As Object, e As EventArgs) Handles BtnEditCliente.Click
        EditClients.isFromSearch = False
        EditClients.Show()
        BtnEditCliente.Enabled = False
        BtnDelCliente.Enabled = False
    End Sub

    Private Sub ClientesBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClientesBox.SelectedIndexChanged
        BtnEditCliente.Enabled = True
        BtnDelCliente.Enabled = True
        BtnHistorico.Enabled = True
    End Sub

    Private Sub BtnSearchStock_Click(sender As Object, e As EventArgs) Handles BtnSearchStock.Click
        SearchStock.Show()

    End Sub

    Private Sub BtnSearchCli_Click(sender As Object, e As EventArgs) Handles BtnSearchCli.Click
        SearchCli.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnSearchCompras.Click
        historyByClient.nome = ""
        historyByClient.telem = ""
        historyByClient.Show()
    End Sub

    Private Sub BtnAddCompras_Click(sender As Object, e As EventArgs) Handles BtnAddCompras.Click
        BtnIsPaid.Enabled = False
        AddCompras.Show()

    End Sub

    Private Sub compras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles compras.SelectedIndexChanged
        BtnIsPaid.Enabled = True

    End Sub

    Private Sub BtnIsPaid_Click(sender As Object, e As EventArgs) Handles BtnIsPaid.Click
        Dim read As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\historico\all.data").Split(New Char() {";"c})
        Dim save As String = ""
        For Each item In read
            If item.Equals(compras.SelectedItems(0).SubItems(0).Text + "&&" + compras.SelectedItems(0).SubItems(1).Text + "&&" + compras.SelectedItems(0).SubItems(2).Text + "&&" + compras.SelectedItems(0).SubItems(3).Text + "&&" + compras.SelectedItems(0).SubItems(4).Text + "&&" + compras.SelectedItems(0).SubItems(5).Text + "&&" + compras.SelectedItems(0).SubItems(6).Text) Then

                If compras.SelectedItems(0).SubItems(6).Text = "sim" Then
                    item = compras.SelectedItems(0).SubItems(0).Text + "&&" + compras.SelectedItems(0).SubItems(1).Text + "&&" + compras.SelectedItems(0).SubItems(2).Text + "&&" + compras.SelectedItems(0).SubItems(3).Text + "&&" + compras.SelectedItems(0).SubItems(4).Text + "&&" + compras.SelectedItems(0).SubItems(5).Text + "&&" + "nao"
                    Dim rClients As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\data\cliente.data").Split(New Char() {";"c})
                    Dim sCLientes As String = ""
                    For Each element In rClients
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If compras.SelectedItems(0).SubItems(1).Text = data(0) Then
                            data(3) = CStr(CDbl(data(3)) + (CDbl(compras.SelectedItems(0).SubItems(4).Text) * CDbl(compras.SelectedItems(0).SubItems(5).Text)))
                        End If
                        If Not (element = vbNewLine Or element = "") Then
                            sCLientes += data(0) + "&&" + data(1) + "&&" + data(2) + "&&" + data(3) + ";" + vbNewLine
                        End If
                    Next
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\data\cliente.data", sCLientes, False)
                    loadClient(True)
                Else
                    item = compras.SelectedItems(0).SubItems(0).Text + "&&" + compras.SelectedItems(0).SubItems(1).Text + "&&" + compras.SelectedItems(0).SubItems(2).Text + "&&" + compras.SelectedItems(0).SubItems(3).Text + "&&" + compras.SelectedItems(0).SubItems(4).Text + "&&" + compras.SelectedItems(0).SubItems(5).Text + "&&" + "sim"
                    Dim rClients As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\data\cliente.data").Split(New Char() {";"c})
                    Dim sCLientes As String = ""
                    For Each element In rClients
                        Dim data As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                        If compras.SelectedItems(0).SubItems(1).Text = data(0) Then
                            data(3) = CStr(CDbl(data(3)) - (CDbl(compras.SelectedItems(0).SubItems(4).Text) * CDbl(compras.SelectedItems(0).SubItems(5).Text)))
                        End If
                        If Not (element = vbNewLine Or element = "") Then
                            sCLientes += data(0) + "&&" + data(1) + "&&" + data(2) + "&&" + data(3) + ";" + vbNewLine
                        End If
                    Next
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\data\cliente.data", sCLientes, False)
                    loadClient(True)

                End If

            End If

            If Not (item.Equals("") Or item.Equals(vbNewLine)) Then
                save += item + ";" + vbNewLine
            End If

        Next

        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\historico\all.data", save, False)

        'ADD CHANGE TO INDIVIDUAL CLIENT FILE TOO

        loadCompras(True)
        BtnIsPaid.Enabled = False

    End Sub

    Private Sub BtnHistorico_Click(sender As Object, e As EventArgs) Handles BtnHistorico.Click
        historyByClient.nome = ClientesBox.SelectedItems(0).SubItems(0).Text
        historyByClient.telem = ClientesBox.SelectedItems(0).SubItems(1).Text
        historyByClient.Show()
        BtnEditCliente.Enabled = False
        BtnDelCliente.Enabled = False
    End Sub
End Class

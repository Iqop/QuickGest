Public Class EditStock
    Public isFromSearch As Boolean
    Dim Vnome As String
    Dim Vquant As String
    Dim Vean As String
    Dim Vpreco As String
    Private Sub EditStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (isFromSearch) Then
            nome.Text = SearchStock.list.SelectedItems(0).SubItems(0).Text
            quant.Text = SearchStock.list.SelectedItems(0).SubItems(1).Text
            ean.Text = SearchStock.list.SelectedItems(0).SubItems(2).Text
            preco.Text = SearchStock.list.SelectedItems(0).SubItems(3).Text
        Else
            nome.Text = QuickGest.StockBox.SelectedItems(0).SubItems(0).Text
            quant.Text = QuickGest.StockBox.SelectedItems(0).SubItems(1).Text
            ean.Text = QuickGest.StockBox.SelectedItems(0).SubItems(2).Text
            preco.Text = QuickGest.StockBox.SelectedItems(0).SubItems(3).Text
        End If
        Vnome = nome.Text
        Vquant = quant.Text
        Vean = ean.Text
        Vpreco = preco.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\stock.data").Split(New Char() {";"c})
        Dim save As String = ""
        For Each elem In data

            If elem.Equals(Vnome + "&&" + Vquant + "&&" + Vean + "&&" + Vpreco) Then
                elem = nome.Text + "&&" + quant.Text + "&&" + ean.Text + "&&" + preco.Text
            End If


            If Not (elem.Equals("") Or elem.Equals(vbNewLine)) Then
                save += elem + ";" + vbNewLine
            End If

        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\stock.data", save, False)

        QuickGest.loadStock(True)
        Me.Close()
    End Sub

End Class
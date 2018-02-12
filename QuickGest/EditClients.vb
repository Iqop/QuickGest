Public Class EditClients
    Public isFromSearch As Boolean
    Dim Vnome As String
    Dim Vtelem As String
    Dim Vemail As String
    Dim Vdiv As String
    Private Sub EditClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isFromSearch Then
            nome.Text = SearchCli.List.SelectedItems(0).SubItems(0).Text
            telem.Text = SearchCli.List.SelectedItems(0).SubItems(1).Text
            email.Text = SearchCli.List.SelectedItems(0).SubItems(2).Text
            dividas.Text = SearchCli.List.SelectedItems(0).SubItems(3).Text
        Else
            nome.Text = QuickGest.ClientesBox.SelectedItems(0).SubItems(0).Text
            telem.Text = QuickGest.ClientesBox.SelectedItems(0).SubItems(1).Text
            email.Text = QuickGest.ClientesBox.SelectedItems(0).SubItems(2).Text
            dividas.Text = QuickGest.ClientesBox.SelectedItems(0).SubItems(3).Text
        End If

        Vnome = nome.Text
        Vtelem = telem.Text
        Vemail = email.Text
        Vdiv = dividas.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\cliente.data").Split(New Char() {";"c})
        Dim save As String = ""
        For Each elem In data
            If elem.Equals(Vnome + "&&" + Vtelem + "&&" + Vemail + "&&" + Vdiv) Then
                elem = nome.Text + "&&" + telem.Text + "&&" + email.Text + "&&" + dividas.Text
            End If
            If Not (elem.Equals("") Or elem.Equals(vbNewLine)) Then
                save += elem + ";" + vbNewLine
            End If

        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\cliente.data", save, False)

        QuickGest.loadClient(True)
        Me.Close()
    End Sub
End Class
Public Class AddToShoppingList

    Dim foundElement As String()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Produto.Text = ""
        Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\stock.data").Split(New Char() {";"c})
        For Each element In data
            If Not (element = vbNewLine Or element = "") Then
                Dim elem As String() = element.Split(New String() {"&&"}, StringSplitOptions.None)
                If elem(2).Equals(EAN.Text) Then
                    foundElement = elem
                    Produto.Text = elem(0).Substring(elem(0).LastIndexOf(vbNewLine) + 1) + ", " + elem(1)
                    Exit For


                End If
            End If
        Next
        If (Produto.Text = "") Then
            MsgBox("Produto não encontrado")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Quantidade.Text = "" Or Quantidade.Text = "0") Then
            MsgBox("Não é possivel adicionar 0 elementos de " + foundElement(0) + "à lista")
        Else
            If CInt(foundElement(1)) >= Quantidade.Text Then
                Dim data As String() = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\data\stock.data").Split(New Char() {";"c})
                Dim save As String = ""
                For Each elem In data

                    If elem.Equals(foundElement(0) + "&&" + foundElement(1) + "&&" + foundElement(2) + "&&" + foundElement(3)) Then

                        elem = foundElement(0) + "&&" + CStr(CInt(foundElement(1)) - Quantidade.Text) + "&&" + foundElement(2) + "&&" + foundElement(3)

                    End If


                    If Not (elem = "" Or elem.Equals(vbNewLine)) Then
                        save += elem + ";" + vbNewLine
                    End If

                Next
                My.Computer.FileSystem.WriteAllText(Application.StartupPath() + "\data\stock.data", save, False)

                QuickGest.loadStock(True)
                AddCompras.lista.Items.Insert(0, New ListViewItem({foundElement(0), foundElement(2), Quantidade.Text, foundElement(3)}))
                MsgBox("Produto adicionado")
                Me.Close()
            Else
                MsgBox("Quantidade excede a quantidade em stock, por favor verifique")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
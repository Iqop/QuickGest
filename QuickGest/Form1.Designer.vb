<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickGest
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Stock = New System.Windows.Forms.TabPage()
        Me.BtnSearchStock = New System.Windows.Forms.Button()
        Me.StockBox = New System.Windows.Forms.ListView()
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EAN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preço = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtndelStock = New System.Windows.Forms.Button()
        Me.BtnEditStock = New System.Windows.Forms.Button()
        Me.BtnaddProd = New System.Windows.Forms.Button()
        Me.Clientes = New System.Windows.Forms.TabPage()
        Me.BtnSearchCli = New System.Windows.Forms.Button()
        Me.BtnHistorico = New System.Windows.Forms.Button()
        Me.BtnAddClient = New System.Windows.Forms.Button()
        Me.BtnEditCliente = New System.Windows.Forms.Button()
        Me.BtnDelCliente = New System.Windows.Forms.Button()
        Me.ClientesBox = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnSearchCompras = New System.Windows.Forms.Button()
        Me.BtnIsPaid = New System.Windows.Forms.Button()
        Me.BtnAddCompras = New System.Windows.Forms.Button()
        Me.compras = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.Stock.SuspendLayout()
        Me.Clientes.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Stock)
        Me.TabControl1.Controls.Add(Me.Clientes)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(988, 431)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'Stock
        '
        Me.Stock.Controls.Add(Me.BtnSearchStock)
        Me.Stock.Controls.Add(Me.StockBox)
        Me.Stock.Controls.Add(Me.BtndelStock)
        Me.Stock.Controls.Add(Me.BtnEditStock)
        Me.Stock.Controls.Add(Me.BtnaddProd)
        Me.Stock.Location = New System.Drawing.Point(4, 22)
        Me.Stock.Margin = New System.Windows.Forms.Padding(2)
        Me.Stock.Name = "Stock"
        Me.Stock.Padding = New System.Windows.Forms.Padding(2)
        Me.Stock.Size = New System.Drawing.Size(980, 405)
        Me.Stock.TabIndex = 0
        Me.Stock.Text = "Stock                                        "
        Me.Stock.UseVisualStyleBackColor = True
        '
        'BtnSearchStock
        '
        Me.BtnSearchStock.Location = New System.Drawing.Point(652, 259)
        Me.BtnSearchStock.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearchStock.Name = "BtnSearchStock"
        Me.BtnSearchStock.Size = New System.Drawing.Size(186, 48)
        Me.BtnSearchStock.TabIndex = 5
        Me.BtnSearchStock.Text = "Procurar Produtos"
        Me.BtnSearchStock.UseVisualStyleBackColor = True
        '
        'StockBox
        '
        Me.StockBox.AllowColumnReorder = True
        Me.StockBox.AutoArrange = False
        Me.StockBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nome, Me.Quantidade, Me.EAN, Me.Preço})
        Me.StockBox.FullRowSelect = True
        Me.StockBox.GridLines = True
        Me.StockBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.StockBox.Location = New System.Drawing.Point(5, 0)
        Me.StockBox.MultiSelect = False
        Me.StockBox.Name = "StockBox"
        Me.StockBox.Size = New System.Drawing.Size(327, 400)
        Me.StockBox.TabIndex = 4
        Me.StockBox.UseCompatibleStateImageBehavior = False
        Me.StockBox.View = System.Windows.Forms.View.Details
        '
        'Nome
        '
        Me.Nome.Tag = ""
        Me.Nome.Text = "Nome"
        '
        'Quantidade
        '
        Me.Quantidade.Tag = ""
        Me.Quantidade.Text = "Quantidade"
        '
        'EAN
        '
        Me.EAN.Tag = ""
        Me.EAN.Text = "EAN"
        '
        'Preço
        '
        Me.Preço.Tag = "Preço"
        Me.Preço.Text = "Preço"
        '
        'BtndelStock
        '
        Me.BtndelStock.Enabled = False
        Me.BtndelStock.Location = New System.Drawing.Point(652, 193)
        Me.BtndelStock.Margin = New System.Windows.Forms.Padding(2)
        Me.BtndelStock.Name = "BtndelStock"
        Me.BtndelStock.Size = New System.Drawing.Size(186, 48)
        Me.BtndelStock.TabIndex = 3
        Me.BtndelStock.Text = "Eliminar Produto"
        Me.BtndelStock.UseVisualStyleBackColor = True
        '
        'BtnEditStock
        '
        Me.BtnEditStock.Enabled = False
        Me.BtnEditStock.Location = New System.Drawing.Point(652, 119)
        Me.BtnEditStock.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditStock.Name = "BtnEditStock"
        Me.BtnEditStock.Size = New System.Drawing.Size(186, 48)
        Me.BtnEditStock.TabIndex = 2
        Me.BtnEditStock.Text = "Editar Produto"
        Me.BtnEditStock.UseVisualStyleBackColor = True
        '
        'BtnaddProd
        '
        Me.BtnaddProd.Location = New System.Drawing.Point(652, 54)
        Me.BtnaddProd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnaddProd.Name = "BtnaddProd"
        Me.BtnaddProd.Size = New System.Drawing.Size(186, 48)
        Me.BtnaddProd.TabIndex = 1
        Me.BtnaddProd.Text = "Adicionar Produto"
        Me.BtnaddProd.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.Clientes.Controls.Add(Me.BtnSearchCli)
        Me.Clientes.Controls.Add(Me.BtnHistorico)
        Me.Clientes.Controls.Add(Me.BtnAddClient)
        Me.Clientes.Controls.Add(Me.BtnEditCliente)
        Me.Clientes.Controls.Add(Me.BtnDelCliente)
        Me.Clientes.Controls.Add(Me.ClientesBox)
        Me.Clientes.Location = New System.Drawing.Point(4, 22)
        Me.Clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Padding = New System.Windows.Forms.Padding(2)
        Me.Clientes.Size = New System.Drawing.Size(980, 405)
        Me.Clientes.TabIndex = 1
        Me.Clientes.Text = "Clientes"
        Me.Clientes.UseVisualStyleBackColor = True
        '
        'BtnSearchCli
        '
        Me.BtnSearchCli.Location = New System.Drawing.Point(527, 323)
        Me.BtnSearchCli.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearchCli.Name = "BtnSearchCli"
        Me.BtnSearchCli.Size = New System.Drawing.Size(186, 48)
        Me.BtnSearchCli.TabIndex = 10
        Me.BtnSearchCli.Text = "Procurar Clientes"
        Me.BtnSearchCli.UseVisualStyleBackColor = True
        '
        'BtnHistorico
        '
        Me.BtnHistorico.Enabled = False
        Me.BtnHistorico.Location = New System.Drawing.Point(527, 262)
        Me.BtnHistorico.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHistorico.Name = "BtnHistorico"
        Me.BtnHistorico.Size = New System.Drawing.Size(186, 48)
        Me.BtnHistorico.TabIndex = 9
        Me.BtnHistorico.Text = "Historico do Cliente"
        Me.BtnHistorico.UseVisualStyleBackColor = True
        '
        'BtnAddClient
        '
        Me.BtnAddClient.Location = New System.Drawing.Point(527, 56)
        Me.BtnAddClient.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddClient.Name = "BtnAddClient"
        Me.BtnAddClient.Size = New System.Drawing.Size(186, 48)
        Me.BtnAddClient.TabIndex = 8
        Me.BtnAddClient.Text = "Adicionar Cliente"
        Me.BtnAddClient.UseVisualStyleBackColor = True
        '
        'BtnEditCliente
        '
        Me.BtnEditCliente.Enabled = False
        Me.BtnEditCliente.Location = New System.Drawing.Point(527, 126)
        Me.BtnEditCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditCliente.Name = "BtnEditCliente"
        Me.BtnEditCliente.Size = New System.Drawing.Size(186, 48)
        Me.BtnEditCliente.TabIndex = 7
        Me.BtnEditCliente.Text = "Editar Cliente"
        Me.BtnEditCliente.UseVisualStyleBackColor = True
        '
        'BtnDelCliente
        '
        Me.BtnDelCliente.Enabled = False
        Me.BtnDelCliente.Location = New System.Drawing.Point(527, 198)
        Me.BtnDelCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelCliente.Name = "BtnDelCliente"
        Me.BtnDelCliente.Size = New System.Drawing.Size(186, 48)
        Me.BtnDelCliente.TabIndex = 6
        Me.BtnDelCliente.Text = "Remover Cliente"
        Me.BtnDelCliente.UseVisualStyleBackColor = True
        '
        'ClientesBox
        '
        Me.ClientesBox.AllowColumnReorder = True
        Me.ClientesBox.AutoArrange = False
        Me.ClientesBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ClientesBox.FullRowSelect = True
        Me.ClientesBox.GridLines = True
        Me.ClientesBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ClientesBox.Location = New System.Drawing.Point(8, 5)
        Me.ClientesBox.MultiSelect = False
        Me.ClientesBox.Name = "ClientesBox"
        Me.ClientesBox.Size = New System.Drawing.Size(274, 227)
        Me.ClientesBox.TabIndex = 5
        Me.ClientesBox.UseCompatibleStateImageBehavior = False
        Me.ClientesBox.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Tag = ""
        Me.ColumnHeader1.Text = "Nome"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Tag = ""
        Me.ColumnHeader2.Text = "Telemovel"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Tag = ""
        Me.ColumnHeader3.Text = "Email"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Tag = "Preço"
        Me.ColumnHeader4.Text = "Dividas"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnSearchCompras)
        Me.TabPage1.Controls.Add(Me.BtnIsPaid)
        Me.TabPage1.Controls.Add(Me.BtnAddCompras)
        Me.TabPage1.Controls.Add(Me.compras)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(980, 405)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Compras"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnSearchCompras
        '
        Me.BtnSearchCompras.Location = New System.Drawing.Point(739, 231)
        Me.BtnSearchCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearchCompras.Name = "BtnSearchCompras"
        Me.BtnSearchCompras.Size = New System.Drawing.Size(186, 48)
        Me.BtnSearchCompras.TabIndex = 12
        Me.BtnSearchCompras.Text = "Procurar"
        Me.BtnSearchCompras.UseVisualStyleBackColor = True
        '
        'BtnIsPaid
        '
        Me.BtnIsPaid.Enabled = False
        Me.BtnIsPaid.Location = New System.Drawing.Point(739, 164)
        Me.BtnIsPaid.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnIsPaid.Name = "BtnIsPaid"
        Me.BtnIsPaid.Size = New System.Drawing.Size(186, 48)
        Me.BtnIsPaid.TabIndex = 11
        Me.BtnIsPaid.Text = "Marcar como Pago/Nao pago"
        Me.BtnIsPaid.UseVisualStyleBackColor = True
        '
        'BtnAddCompras
        '
        Me.BtnAddCompras.Location = New System.Drawing.Point(739, 32)
        Me.BtnAddCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddCompras.Name = "BtnAddCompras"
        Me.BtnAddCompras.Size = New System.Drawing.Size(186, 48)
        Me.BtnAddCompras.TabIndex = 9
        Me.BtnAddCompras.Text = "Adicionar"
        Me.BtnAddCompras.UseVisualStyleBackColor = True
        '
        'compras
        '
        Me.compras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader18})
        Me.compras.FullRowSelect = True
        Me.compras.GridLines = True
        Me.compras.Location = New System.Drawing.Point(3, 3)
        Me.compras.Name = "compras"
        Me.compras.Size = New System.Drawing.Size(580, 399)
        Me.compras.TabIndex = 0
        Me.compras.UseCompatibleStateImageBehavior = False
        Me.compras.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Data"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Nome Cliente"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Nome Produto"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "EAN"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Preço Unidade"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Quantidade"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Pago"
        '
        'QuickGest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 427)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "QuickGest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuickGest-Ferramenta para a gestão de stock e clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.Stock.ResumeLayout(False)
        Me.Clientes.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Stock As TabPage
    Friend WithEvents Clientes As TabPage
    Friend WithEvents BtndelStock As Button
    Friend WithEvents BtnEditStock As Button
    Friend WithEvents BtnaddProd As Button
    Friend WithEvents StockBox As ListView
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Quantidade As ColumnHeader
    Friend WithEvents EAN As ColumnHeader
    Friend WithEvents Preço As ColumnHeader
    Friend WithEvents ClientesBox As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BtnHistorico As Button
    Friend WithEvents BtnAddClient As Button
    Friend WithEvents BtnEditCliente As Button
    Friend WithEvents BtnDelCliente As Button
    Friend WithEvents BtnSearchStock As Button
    Friend WithEvents BtnSearchCli As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents compras As ListView
    Friend WithEvents BtnSearchCompras As Button
    Friend WithEvents BtnIsPaid As Button
    Friend WithEvents BtnAddCompras As Button
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
End Class

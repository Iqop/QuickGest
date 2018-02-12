<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCompras
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
        Me.components = New System.ComponentModel.Container()
        Me.pesquisa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nomeCliente = New System.Windows.Forms.Label()
        Me.lista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DelCompra = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'pesquisa
        '
        Me.pesquisa.Enabled = False
        Me.pesquisa.Location = New System.Drawing.Point(444, 16)
        Me.pesquisa.Name = "pesquisa"
        Me.pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.pesquisa.TabIndex = 2
        Me.pesquisa.Text = "Pesquisar"
        Me.pesquisa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nome", "Telemovel", "Email"})
        Me.ComboBox1.Location = New System.Drawing.Point(56, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultado Pesquisa de Cliente: "
        '
        'nomeCliente
        '
        Me.nomeCliente.AutoSize = True
        Me.nomeCliente.Location = New System.Drawing.Point(174, 55)
        Me.nomeCliente.Name = "nomeCliente"
        Me.nomeCliente.Size = New System.Drawing.Size(0, 13)
        Me.nomeCliente.TabIndex = 5
        '
        'lista
        '
        Me.lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lista.FullRowSelect = True
        Me.lista.GridLines = True
        Me.lista.Location = New System.Drawing.Point(14, 146)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(509, 220)
        Me.lista.TabIndex = 6
        Me.lista.UseCompatibleStateImageBehavior = False
        Me.lista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome Produto"
        Me.ColumnHeader1.Width = 158
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "EAN"
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantidade"
        Me.ColumnHeader3.Width = 152
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Preço"
        Me.ColumnHeader4.Width = 88
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Concluir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(318, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 35)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Fechar/Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(14, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 46)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Adicionar Produto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DelCompra
        '
        Me.DelCompra.Enabled = False
        Me.DelCompra.Location = New System.Drawing.Point(387, 85)
        Me.DelCompra.Name = "DelCompra"
        Me.DelCompra.Size = New System.Drawing.Size(136, 46)
        Me.DelCompra.TabIndex = 5
        Me.DelCompra.Text = "Eliminar Produto"
        Me.DelCompra.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total:"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(49, 417)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(28, 13)
        Me.totalLabel.TabIndex = 13
        Me.totalLabel.Text = "0.00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 417)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(15, 382)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Pago? "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AddCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 497)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DelCompra)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.nomeCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pesquisa)
        Me.Name = "AddCompras"
        Me.Text = "AddCompras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pesquisa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nomeCliente As Label
    Friend WithEvents lista As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Button4 As Button
    Friend WithEvents DelCompra As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class

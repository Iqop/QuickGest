<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchStock
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.list = New System.Windows.Forms.ListView()
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EAN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preço = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EAN"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Pesquisar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(412, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.TabStop = False
        Me.Button2.Text = "Fechar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(428, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 20)
        Me.TextBox1.TabIndex = 1
        '
        'list
        '
        Me.list.AllowColumnReorder = True
        Me.list.AutoArrange = False
        Me.list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nome, Me.Quantidade, Me.EAN, Me.Preço})
        Me.list.FullRowSelect = True
        Me.list.GridLines = True
        Me.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.list.Location = New System.Drawing.Point(10, 87)
        Me.list.MultiSelect = False
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(406, 51)
        Me.list.TabIndex = 5
        Me.list.UseCompatibleStateImageBehavior = False
        Me.list.View = System.Windows.Forms.View.Details
        '
        'Nome
        '
        Me.Nome.Tag = ""
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 150
        '
        'Quantidade
        '
        Me.Quantidade.Tag = ""
        Me.Quantidade.Text = "Quantidade"
        Me.Quantidade.Width = 70
        '
        'EAN
        '
        Me.EAN.Tag = ""
        Me.EAN.Text = "EAN"
        Me.EAN.Width = 100
        '
        'Preço
        '
        Me.Preço.Tag = "Preço"
        Me.Preço.Text = "Preço"
        Me.Preço.Width = 70
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(428, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SearchStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 167)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SearchStock"
        Me.Text = "SearchStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents list As ListView
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Quantidade As ColumnHeader
    Friend WithEvents EAN As ColumnHeader
    Friend WithEvents Preço As ColumnHeader
    Friend WithEvents Button4 As Button
End Class

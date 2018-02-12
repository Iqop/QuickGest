<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStock
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.preco = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ean = New System.Windows.Forms.TextBox()
        Me.quant = New System.Windows.Forms.TextBox()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Preço por unidade"
        '
        'preco
        '
        Me.preco.Location = New System.Drawing.Point(118, 96)
        Me.preco.Name = "preco"
        Me.preco.Size = New System.Drawing.Size(257, 20)
        Me.preco.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.TabStop = False
        Me.Button2.Text = "Fechar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "EAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Unidades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nome de Produto"
        '
        'ean
        '
        Me.ean.Enabled = False
        Me.ean.Location = New System.Drawing.Point(118, 70)
        Me.ean.Name = "ean"
        Me.ean.Size = New System.Drawing.Size(257, 20)
        Me.ean.TabIndex = 13
        Me.ean.TabStop = False
        '
        'quant
        '
        Me.quant.Location = New System.Drawing.Point(118, 44)
        Me.quant.Name = "quant"
        Me.quant.Size = New System.Drawing.Size(257, 20)
        Me.quant.TabIndex = 12
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(118, 18)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(257, 20)
        Me.nome.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 170)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.preco)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ean)
        Me.Controls.Add(Me.quant)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EditStock"
        Me.Text = "EditStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents preco As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ean As TextBox
    Friend WithEvents quant As TextBox
    Friend WithEvents nome As TextBox
    Friend WithEvents Button1 As Button
End Class

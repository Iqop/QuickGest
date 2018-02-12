<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dividas = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.telem = New System.Windows.Forms.TextBox()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Dividas"
        '
        'dividas
        '
        Me.dividas.Location = New System.Drawing.Point(120, 94)
        Me.dividas.Name = "dividas"
        Me.dividas.Size = New System.Drawing.Size(257, 20)
        Me.dividas.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 130)
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
        Me.Label3.Location = New System.Drawing.Point(21, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Telemovel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nome"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(120, 68)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(257, 20)
        Me.email.TabIndex = 3
        '
        'telem
        '
        Me.telem.Location = New System.Drawing.Point(120, 42)
        Me.telem.Name = "telem"
        Me.telem.Size = New System.Drawing.Size(257, 20)
        Me.telem.TabIndex = 2
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(120, 16)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(257, 20)
        Me.nome.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 172)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dividas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.telem)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddCliente"
        Me.Text = "AddCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents dividas As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents telem As TextBox
    Friend WithEvents nome As TextBox
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_exp2 = New System.Windows.Forms.TextBox()
        Me.txt_exp1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.txt_ed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_xi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_exp2)
        Me.GroupBox1.Controls.Add(Me.txt_exp1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_b)
        Me.GroupBox1.Controls.Add(Me.txt_c)
        Me.GroupBox1.Controls.Add(Me.txt_ed)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_xi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_a)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 245)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txt_exp2
        '
        Me.txt_exp2.BackColor = System.Drawing.SystemColors.Control
        Me.txt_exp2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exp2.Location = New System.Drawing.Point(231, 31)
        Me.txt_exp2.Multiline = True
        Me.txt_exp2.Name = "txt_exp2"
        Me.txt_exp2.Size = New System.Drawing.Size(25, 21)
        Me.txt_exp2.TabIndex = 14
        Me.txt_exp2.Text = "2"
        '
        'txt_exp1
        '
        Me.txt_exp1.BackColor = System.Drawing.SystemColors.Control
        Me.txt_exp1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exp1.Location = New System.Drawing.Point(131, 31)
        Me.txt_exp1.Multiline = True
        Me.txt_exp1.Name = "txt_exp1"
        Me.txt_exp1.Size = New System.Drawing.Size(25, 21)
        Me.txt_exp1.TabIndex = 13
        Me.txt_exp1.Text = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "X   + "
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(144, 189)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(100, 35)
        Me.btn_calcular.TabIndex = 2
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "X    +"
        '
        'txt_b
        '
        Me.txt_b.BackColor = System.Drawing.SystemColors.Control
        Me.txt_b.Location = New System.Drawing.Point(174, 45)
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(44, 29)
        Me.txt_b.TabIndex = 9
        Me.txt_b.Text = "-2"
        '
        'txt_c
        '
        Me.txt_c.BackColor = System.Drawing.SystemColors.Control
        Me.txt_c.Location = New System.Drawing.Point(269, 46)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(44, 29)
        Me.txt_c.TabIndex = 8
        Me.txt_c.Text = "5"
        '
        'txt_ed
        '
        Me.txt_ed.Location = New System.Drawing.Point(118, 143)
        Me.txt_ed.Name = "txt_ed"
        Me.txt_ed.Size = New System.Drawing.Size(160, 29)
        Me.txt_ed.TabIndex = 7
        Me.txt_ed.Text = "0.10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "E.D"
        '
        'txt_xi
        '
        Me.txt_xi.Location = New System.Drawing.Point(118, 108)
        Me.txt_xi.Name = "txt_xi"
        Me.txt_xi.Size = New System.Drawing.Size(160, 29)
        Me.txt_xi.TabIndex = 3
        Me.txt_xi.Text = "-2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Xi"
        '
        'txt_a
        '
        Me.txt_a.BackColor = System.Drawing.SystemColors.Control
        Me.txt_a.Location = New System.Drawing.Point(72, 44)
        Me.txt_a.Multiline = True
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(44, 26)
        Me.txt_a.TabIndex = 1
        Me.txt_a.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Funcion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 275)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_exp2 As TextBox
    Friend WithEvents txt_exp1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_b As TextBox
    Friend WithEvents txt_c As TextBox
    Friend WithEvents txt_ed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_xi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_a As TextBox
    Friend WithEvents Label1 As Label
End Class

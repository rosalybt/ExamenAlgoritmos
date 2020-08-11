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
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_xd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_xi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_num3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_num2)
        Me.GroupBox1.Controls.Add(Me.txt_num3)
        Me.GroupBox1.Controls.Add(Me.txt_ed)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_xd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_xi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_num1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 290)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(213, 249)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(100, 35)
        Me.btn_limpiar.TabIndex = 12
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(95, 249)
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
        Me.Label5.Location = New System.Drawing.Point(149, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "X^2 +"
        '
        'txt_ed
        '
        Me.txt_ed.Location = New System.Drawing.Point(118, 185)
        Me.txt_ed.Name = "txt_ed"
        Me.txt_ed.Size = New System.Drawing.Size(160, 29)
        Me.txt_ed.TabIndex = 7
        Me.txt_ed.Text = "0.01"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "E.D"
        '
        'txt_xd
        '
        Me.txt_xd.Location = New System.Drawing.Point(118, 150)
        Me.txt_xd.Name = "txt_xd"
        Me.txt_xd.Size = New System.Drawing.Size(160, 29)
        Me.txt_xd.TabIndex = 5
        Me.txt_xd.Text = "5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Xd"
        '
        'txt_xi
        '
        Me.txt_xi.Location = New System.Drawing.Point(118, 108)
        Me.txt_xi.Name = "txt_xi"
        Me.txt_xi.Size = New System.Drawing.Size(160, 29)
        Me.txt_xi.TabIndex = 3
        Me.txt_xi.Text = "-4"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Funcion"
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(112, 45)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(31, 29)
        Me.txt_num1.TabIndex = 1
        Me.txt_num1.Text = "1"
        '
        'txt_num3
        '
        Me.txt_num3.Location = New System.Drawing.Point(290, 45)
        Me.txt_num3.Name = "txt_num3"
        Me.txt_num3.Size = New System.Drawing.Size(61, 29)
        Me.txt_num3.TabIndex = 8
        Me.txt_num3.Text = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "x + "
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(197, 45)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(57, 29)
        Me.txt_num2.TabIndex = 9
        Me.txt_num2.Text = "-2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_xd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_xi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_num2 As TextBox
    Friend WithEvents txt_num3 As TextBox
    Friend WithEvents txt_num1 As TextBox
End Class

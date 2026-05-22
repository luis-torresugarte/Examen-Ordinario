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
        Me.precio1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'precio1
        '
        Me.precio1.Location = New System.Drawing.Point(128, 76)
        Me.precio1.Name = "precio1"
        Me.precio1.Size = New System.Drawing.Size(179, 20)
        Me.precio1.TabIndex = 0
        Me.precio1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(196, 153)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Precio:        $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subtotal:     $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "IVA (16%): $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(334, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TOTAL:      $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(265, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Aplicación de Tienda"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calcular Subtotal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(92, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Calcular IVA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(92, 339)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 34)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Calcular Total"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(128, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 36)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "-1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(306, 145)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 36)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "+1"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(457, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(457, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(457, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.precio1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents precio1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class

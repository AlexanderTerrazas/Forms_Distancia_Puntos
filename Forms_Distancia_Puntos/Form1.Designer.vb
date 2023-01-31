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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_XA = New System.Windows.Forms.TextBox()
        Me.Txt_YA = New System.Windows.Forms.TextBox()
        Me.Txt_YB = New System.Windows.Forms.TextBox()
        Me.Txt_XB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Punto A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Y"
        '
        'Txt_XA
        '
        Me.Txt_XA.Location = New System.Drawing.Point(119, 95)
        Me.Txt_XA.Name = "Txt_XA"
        Me.Txt_XA.Size = New System.Drawing.Size(100, 20)
        Me.Txt_XA.TabIndex = 3
        '
        'Txt_YA
        '
        Me.Txt_YA.Location = New System.Drawing.Point(120, 118)
        Me.Txt_YA.Name = "Txt_YA"
        Me.Txt_YA.Size = New System.Drawing.Size(100, 20)
        Me.Txt_YA.TabIndex = 4
        '
        'Txt_YB
        '
        Me.Txt_YB.Location = New System.Drawing.Point(303, 118)
        Me.Txt_YB.Name = "Txt_YB"
        Me.Txt_YB.Size = New System.Drawing.Size(100, 20)
        Me.Txt_YB.TabIndex = 9
        '
        'Txt_XB
        '
        Me.Txt_XB.Location = New System.Drawing.Point(302, 95)
        Me.Txt_XB.Name = "Txt_XB"
        Me.Txt_XB.Size = New System.Drawing.Size(100, 20)
        Me.Txt_XB.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Punto B"
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.Location = New System.Drawing.Point(119, 183)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calcular.TabIndex = 10
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = True
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(205, 186)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Resultado.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 279)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Btn_Calcular)
        Me.Controls.Add(Me.Txt_YB)
        Me.Controls.Add(Me.Txt_XB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_YA)
        Me.Controls.Add(Me.Txt_XA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_XA As TextBox
    Friend WithEvents Txt_YA As TextBox
    Friend WithEvents Txt_YB As TextBox
    Friend WithEvents Txt_XB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_Calcular As Button
    Friend WithEvents Txt_Resultado As TextBox
End Class

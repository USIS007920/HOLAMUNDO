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
        Me.optModulo = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optRestar = New System.Windows.Forms.RadioButton()
        Me.optSumar = New System.Windows.Forms.RadioButton()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtnumero2 = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnumero1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'optModulo
        '
        Me.optModulo.AutoSize = True
        Me.optModulo.Location = New System.Drawing.Point(360, 267)
        Me.optModulo.Name = "optModulo"
        Me.optModulo.Size = New System.Drawing.Size(46, 17)
        Me.optModulo.TabIndex = 25
        Me.optModulo.TabStop = True
        Me.optModulo.Text = "Mod"
        Me.optModulo.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(360, 244)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(31, 17)
        Me.optExponenciacion.TabIndex = 24
        Me.optExponenciacion.TabStop = True
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(360, 221)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(33, 17)
        Me.optPorcentaje.TabIndex = 23
        Me.optPorcentaje.TabStop = True
        Me.optPorcentaje.Text = "%"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(360, 198)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(30, 17)
        Me.optDividir.TabIndex = 22
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "/"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(360, 175)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicar.TabIndex = 21
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optRestar
        '
        Me.optRestar.AutoSize = True
        Me.optRestar.Location = New System.Drawing.Point(360, 152)
        Me.optRestar.Name = "optRestar"
        Me.optRestar.Size = New System.Drawing.Size(28, 17)
        Me.optRestar.TabIndex = 20
        Me.optRestar.TabStop = True
        Me.optRestar.Text = "-"
        Me.optRestar.UseVisualStyleBackColor = True
        '
        'optSumar
        '
        Me.optSumar.AutoSize = True
        Me.optSumar.Location = New System.Drawing.Point(360, 129)
        Me.optSumar.Name = "optSumar"
        Me.optSumar.Size = New System.Drawing.Size(31, 17)
        Me.optSumar.TabIndex = 19
        Me.optSumar.TabStop = True
        Me.optSumar.Text = "+"
        Me.optSumar.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(567, 133)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(62, 13)
        Me.lblrespuesta.TabIndex = 18
        Me.lblrespuesta.Text = "respuesta:?"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(360, 302)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtnumero2
        '
        Me.txtnumero2.AutoSize = True
        Me.txtnumero2.Location = New System.Drawing.Point(413, 129)
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.Size = New System.Drawing.Size(33, 13)
        Me.txtnumero2.TabIndex = 16
        Me.txtnumero2.Text = "num2"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(452, 126)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 15
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(240, 126)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 14
        '
        'txtnumero1
        '
        Me.txtnumero1.AutoSize = True
        Me.txtnumero1.Location = New System.Drawing.Point(171, 126)
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.Size = New System.Drawing.Size(33, 13)
        Me.txtnumero1.TabIndex = 13
        Me.txtnumero1.Text = "num1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.optModulo)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optRestar)
        Me.Controls.Add(Me.optSumar)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtnumero2)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.txtnumero1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optModulo As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optRestar As RadioButton
    Friend WithEvents optSumar As RadioButton
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtnumero2 As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnumero1 As Label
End Class

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
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblRepuestaMedia = New System.Windows.Forms.Label()
        Me.lbloRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lblDesvTipica = New System.Windows.Forms.Label()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(340, 304)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(110, 55)
        Me.btnMediaAritmetica.TabIndex = 0
        Me.btnMediaAritmetica.Text = "Calculos estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(349, 186)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(101, 20)
        Me.txtserie.TabIndex = 1
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(295, 186)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 2
        Me.lblserie.Text = "Serie:"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(340, 221)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaMedia.TabIndex = 3
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblRepuestaMedia
        '
        Me.lblRepuestaMedia.AutoSize = True
        Me.lblRepuestaMedia.Location = New System.Drawing.Point(346, 245)
        Me.lblRepuestaMedia.Name = "lblRepuestaMedia"
        Me.lblRepuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRepuestaMedia.TabIndex = 4
        Me.lblRepuestaMedia.Text = "?"
        '
        'lbloRespuestaMedia
        '
        Me.lbloRespuestaMedia.AutoSize = True
        Me.lbloRespuestaMedia.Location = New System.Drawing.Point(295, 221)
        Me.lbloRespuestaMedia.Name = "lbloRespuestaMedia"
        Me.lbloRespuestaMedia.Size = New System.Drawing.Size(39, 13)
        Me.lbloRespuestaMedia.TabIndex = 5
        Me.lbloRespuestaMedia.Text = "Media:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(295, 245)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblVarianza.TabIndex = 6
        Me.lblVarianza.Text = "Varianza:"
        '
        'lblDesvTipica
        '
        Me.lblDesvTipica.AutoSize = True
        Me.lblDesvTipica.Location = New System.Drawing.Point(292, 271)
        Me.lblDesvTipica.Name = "lblDesvTipica"
        Me.lblDesvTipica.Size = New System.Drawing.Size(67, 13)
        Me.lblDesvTipica.TabIndex = 7
        Me.lblDesvTipica.Text = "Desv. Tipica"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(365, 271)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaDesvTipica.TabIndex = 8
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lblDesvTipica)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lbloRespuestaMedia)
        Me.Controls.Add(Me.lblRepuestaMedia)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMediaAritmetica As Button
    Friend WithEvents txtserie As TextBox
    Friend WithEvents lblserie As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblRepuestaMedia As Label
    Friend WithEvents lbloRespuestaMedia As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lblDesvTipica As Label
    Friend WithEvents lblRespuestaDesvTipica As Label
End Class

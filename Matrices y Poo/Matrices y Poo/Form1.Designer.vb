﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbltotalx21xf1 = New System.Windows.Forms.Label()
        Me.lbltotalx1xf1 = New System.Windows.Forms.Label()
        Me.lbltotalf1 = New System.Windows.Forms.Label()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.x1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x1xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x21xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.lbldesvtipica = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblRespuestaVarianza = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltotalx21xf1
        '
        Me.lbltotalx21xf1.AutoSize = True
        Me.lbltotalx21xf1.Location = New System.Drawing.Point(759, 414)
        Me.lbltotalx21xf1.Name = "lbltotalx21xf1"
        Me.lbltotalx21xf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalx21xf1.TabIndex = 25
        Me.lbltotalx21xf1.Text = "0.0"
        '
        'lbltotalx1xf1
        '
        Me.lbltotalx1xf1.AutoSize = True
        Me.lbltotalx1xf1.Location = New System.Drawing.Point(659, 414)
        Me.lbltotalx1xf1.Name = "lbltotalx1xf1"
        Me.lbltotalx1xf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalx1xf1.TabIndex = 24
        Me.lbltotalx1xf1.Text = "0.0"
        '
        'lbltotalf1
        '
        Me.lbltotalf1.AutoSize = True
        Me.lbltotalf1.Location = New System.Drawing.Point(453, 414)
        Me.lbltotalf1.Name = "lbltotalf1"
        Me.lbltotalf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalf1.TabIndex = 23
        Me.lbltotalf1.Text = "0.0"
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x1, Me.f1, Me.n1, Me.x1xf1, Me.x21xf1})
        Me.grdEstadistica.Location = New System.Drawing.Point(248, 10)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.Size = New System.Drawing.Size(543, 393)
        Me.grdEstadistica.TabIndex = 22
        '
        'x1
        '
        Me.x1.HeaderText = "X1"
        Me.x1.Name = "x1"
        '
        'f1
        '
        Me.f1.HeaderText = "F1"
        Me.f1.Name = "f1"
        '
        'n1
        '
        Me.n1.HeaderText = "N1"
        Me.n1.Name = "n1"
        '
        'x1xf1
        '
        Me.x1xf1.HeaderText = "X1 x F1"
        Me.x1xf1.Name = "x1xf1"
        '
        'x21xf1
        '
        Me.x21xf1.HeaderText = "X21 x F1"
        Me.x21xf1.Name = "x21xf1"
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(86, 107)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaDesvTipica.TabIndex = 21
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'lbldesvtipica
        '
        Me.lbldesvtipica.AutoSize = True
        Me.lbldesvtipica.Location = New System.Drawing.Point(10, 107)
        Me.lbldesvtipica.Name = "lbldesvtipica"
        Me.lbldesvtipica.Size = New System.Drawing.Size(70, 13)
        Me.lbldesvtipica.TabIndex = 20
        Me.lbldesvtipica.Text = "Desv. Tipica:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(10, 78)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(51, 13)
        Me.lblVarianza.TabIndex = 19
        Me.lblVarianza.Text = "Varianza:"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(10, 53)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(39, 13)
        Me.lblMedia.TabIndex = 18
        Me.lblMedia.Text = "Media:"
        '
        'lblRespuestaVarianza
        '
        Me.lblRespuestaVarianza.AutoSize = True
        Me.lblRespuestaVarianza.Location = New System.Drawing.Point(86, 78)
        Me.lblRespuestaVarianza.Name = "lblRespuestaVarianza"
        Me.lblRespuestaVarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaVarianza.TabIndex = 17
        Me.lblRespuestaVarianza.Text = "?"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(86, 53)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(13, 13)
        Me.lblRespuestaMedia.TabIndex = 16
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(10, 13)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 15
        Me.lblserie.Text = "Serie:"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(50, 10)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(175, 20)
        Me.txtserie.TabIndex = 14
        Me.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(13, 399)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(212, 42)
        Me.btnMediaAritmetica.TabIndex = 13
        Me.btnMediaAritmetica.Text = "Calculos estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbltotalx21xf1)
        Me.Controls.Add(Me.lbltotalx1xf1)
        Me.Controls.Add(Me.lbltotalf1)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lbldesvtipica)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.lblRespuestaVarianza)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltotalx21xf1 As Label
    Friend WithEvents lbltotalx1xf1 As Label
    Friend WithEvents lbltotalf1 As Label
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents x1 As DataGridViewTextBoxColumn
    Friend WithEvents f1 As DataGridViewTextBoxColumn
    Friend WithEvents n1 As DataGridViewTextBoxColumn
    Friend WithEvents x1xf1 As DataGridViewTextBoxColumn
    Friend WithEvents x21xf1 As DataGridViewTextBoxColumn
    Friend WithEvents lblRespuestaDesvTipica As Label
    Friend WithEvents lbldesvtipica As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lblMedia As Label
    Friend WithEvents lblRespuestaVarianza As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblserie As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents btnMediaAritmetica As Button
End Class

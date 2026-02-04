<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaEntradas
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
        Me.lblTituloSeleccionado = New System.Windows.Forms.Label()
        Me.lblNumEntradas = New System.Windows.Forms.Label()
        Me.NumEntradas = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnComprar = New System.Windows.Forms.Button()
        Me.lblDisponibles = New System.Windows.Forms.Label()
        CType(Me.NumEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloSeleccionado
        '
        Me.lblTituloSeleccionado.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloSeleccionado.ForeColor = System.Drawing.Color.White
        Me.lblTituloSeleccionado.Location = New System.Drawing.Point(13, 22)
        Me.lblTituloSeleccionado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloSeleccionado.Name = "lblTituloSeleccionado"
        Me.lblTituloSeleccionado.Size = New System.Drawing.Size(756, 73)
        Me.lblTituloSeleccionado.TabIndex = 1
        Me.lblTituloSeleccionado.Text = "Label1"
        '
        'lblNumEntradas
        '
        Me.lblNumEntradas.AutoSize = True
        Me.lblNumEntradas.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblNumEntradas.ForeColor = System.Drawing.Color.Silver
        Me.lblNumEntradas.Location = New System.Drawing.Point(286, 379)
        Me.lblNumEntradas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumEntradas.Name = "lblNumEntradas"
        Me.lblNumEntradas.Size = New System.Drawing.Size(69, 28)
        Me.lblNumEntradas.TabIndex = 10
        Me.lblNumEntradas.Text = "Label2"
        '
        'NumEntradas
        '
        Me.NumEntradas.Location = New System.Drawing.Point(139, 131)
        Me.NumEntradas.Name = "NumEntradas"
        Me.NumEntradas.Size = New System.Drawing.Size(253, 22)
        Me.NumEntradas.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Recuerda que el maximo de entradas por persona son 10"
        '
        'BtnComprar
        '
        Me.BtnComprar.Location = New System.Drawing.Point(544, 367)
        Me.BtnComprar.Name = "BtnComprar"
        Me.BtnComprar.Size = New System.Drawing.Size(141, 40)
        Me.BtnComprar.TabIndex = 13
        Me.BtnComprar.Text = "Comprar"
        Me.BtnComprar.UseVisualStyleBackColor = True
        '
        'lblDisponibles
        '
        Me.lblDisponibles.AutoSize = True
        Me.lblDisponibles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponibles.ForeColor = System.Drawing.Color.White
        Me.lblDisponibles.Location = New System.Drawing.Point(398, 131)
        Me.lblDisponibles.Name = "lblDisponibles"
        Me.lblDisponibles.Size = New System.Drawing.Size(59, 28)
        Me.lblDisponibles.TabIndex = 14
        Me.lblDisponibles.Text = "Aaaa"
        '
        'VentaEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDisponibles)
        Me.Controls.Add(Me.BtnComprar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumEntradas)
        Me.Controls.Add(Me.lblNumEntradas)
        Me.Controls.Add(Me.lblTituloSeleccionado)
        Me.Name = "VentaEntradas"
        Me.Text = "Venta Entradas"
        CType(Me.NumEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTituloSeleccionado As Label
    Friend WithEvents lblNumEntradas As Label
    Friend WithEvents NumEntradas As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnComprar As Button
    Friend WithEvents lblDisponibles As Label
End Class

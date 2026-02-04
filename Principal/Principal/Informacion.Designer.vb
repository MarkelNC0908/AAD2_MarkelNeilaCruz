<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informacion
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.pbImagenGrande = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.txtSinopsis = New System.Windows.Forms.RichTextBox()
        CType(Me.pbImagenGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(417, 35)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(400, 59)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label1"
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblSala.ForeColor = System.Drawing.Color.Silver
        Me.lblSala.Location = New System.Drawing.Point(421, 94)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(56, 21)
        Me.lblSala.TabIndex = 1
        Me.lblSala.Text = "Label2"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrecio.Location = New System.Drawing.Point(420, 208)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(70, 25)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Label3"
        '
        'pbImagenGrande
        '
        Me.pbImagenGrande.Location = New System.Drawing.Point(50, 80)
        Me.pbImagenGrande.Name = "pbImagenGrande"
        Me.pbImagenGrande.Size = New System.Drawing.Size(300, 450)
        Me.pbImagenGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagenGrande.TabIndex = 6
        Me.pbImagenGrande.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(658, 480)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(142, 50)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDuracion.ForeColor = System.Drawing.Color.Silver
        Me.lblDuracion.Location = New System.Drawing.Point(421, 128)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(56, 21)
        Me.lblDuracion.TabIndex = 8
        Me.lblDuracion.Text = "Label2"
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblAnio.ForeColor = System.Drawing.Color.Silver
        Me.lblAnio.Location = New System.Drawing.Point(421, 162)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(56, 21)
        Me.lblAnio.TabIndex = 9
        Me.lblAnio.Text = "Label2"
        '
        'txtSinopsis
        '
        Me.txtSinopsis.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSinopsis.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSinopsis.ForeColor = System.Drawing.Color.White
        Me.txtSinopsis.Location = New System.Drawing.Point(425, 271)
        Me.txtSinopsis.Name = "txtSinopsis"
        Me.txtSinopsis.ReadOnly = True
        Me.txtSinopsis.Size = New System.Drawing.Size(348, 176)
        Me.txtSinopsis.TabIndex = 10
        Me.txtSinopsis.Text = ""
        '
        'Informacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 561)
        Me.Controls.Add(Me.txtSinopsis)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.pbImagenGrande)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblSala)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Informacion"
        Me.Text = "Informacion"
        CType(Me.pbImagenGrande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSala As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents pbImagenGrande As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblAnio As Label
    Friend WithEvents txtSinopsis As RichTextBox
End Class

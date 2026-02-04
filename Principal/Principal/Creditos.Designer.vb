<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creditos
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
        Me.pbGitHub = New System.Windows.Forms.PictureBox()
        Me.LBLNombreGitHub = New System.Windows.Forms.Label()
        Me.LBLRepoPublico = New System.Windows.Forms.Label()
        Me.BTNVolver = New System.Windows.Forms.Button()
        CType(Me.pbGitHub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGitHub
        '
        Me.pbGitHub.Location = New System.Drawing.Point(213, 12)
        Me.pbGitHub.Name = "pbGitHub"
        Me.pbGitHub.Size = New System.Drawing.Size(337, 274)
        Me.pbGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGitHub.TabIndex = 0
        Me.pbGitHub.TabStop = False
        '
        'LBLNombreGitHub
        '
        Me.LBLNombreGitHub.AutoSize = True
        Me.LBLNombreGitHub.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNombreGitHub.ForeColor = System.Drawing.Color.White
        Me.LBLNombreGitHub.Location = New System.Drawing.Point(207, 308)
        Me.LBLNombreGitHub.Name = "LBLNombreGitHub"
        Me.LBLNombreGitHub.Size = New System.Drawing.Size(84, 31)
        Me.LBLNombreGitHub.TabIndex = 1
        Me.LBLNombreGitHub.Text = "Label1"
        '
        'LBLRepoPublico
        '
        Me.LBLRepoPublico.AutoSize = True
        Me.LBLRepoPublico.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRepoPublico.ForeColor = System.Drawing.Color.White
        Me.LBLRepoPublico.Location = New System.Drawing.Point(208, 349)
        Me.LBLRepoPublico.Name = "LBLRepoPublico"
        Me.LBLRepoPublico.Size = New System.Drawing.Size(63, 25)
        Me.LBLRepoPublico.TabIndex = 2
        Me.LBLRepoPublico.Text = "Label1"
        '
        'BTNVolver
        '
        Me.BTNVolver.Location = New System.Drawing.Point(647, 399)
        Me.BTNVolver.Name = "BTNVolver"
        Me.BTNVolver.Size = New System.Drawing.Size(110, 39)
        Me.BTNVolver.TabIndex = 3
        Me.BTNVolver.Text = "Volver"
        Me.BTNVolver.UseVisualStyleBackColor = True
        '
        'Creditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNVolver)
        Me.Controls.Add(Me.LBLRepoPublico)
        Me.Controls.Add(Me.LBLNombreGitHub)
        Me.Controls.Add(Me.pbGitHub)
        Me.Name = "Creditos"
        Me.Text = "Creditos"
        CType(Me.pbGitHub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbGitHub As PictureBox
    Friend WithEvents LBLNombreGitHub As Label
    Friend WithEvents LBLRepoPublico As Label
    Friend WithEvents BTNVolver As Button
End Class

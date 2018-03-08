<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMonitor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.backlogGridView = New System.Windows.Forms.DataGridView()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabBacklog = New System.Windows.Forms.TabPage()
        Me.btQueryNow = New System.Windows.Forms.Button()
        CType(Me.backlogGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tabBacklog.SuspendLayout()
        Me.SuspendLayout()
        '
        'backlogGridView
        '
        Me.backlogGridView.AllowUserToAddRows = False
        Me.backlogGridView.AllowUserToDeleteRows = False
        Me.backlogGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backlogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.backlogGridView.Location = New System.Drawing.Point(0, 0)
        Me.backlogGridView.Name = "backlogGridView"
        Me.backlogGridView.ReadOnly = True
        Me.backlogGridView.Size = New System.Drawing.Size(624, 376)
        Me.backlogGridView.TabIndex = 0
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.tabBacklog)
        Me.tabControl.Location = New System.Drawing.Point(8, 8)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(632, 440)
        Me.tabControl.TabIndex = 2
        '
        'tabBacklog
        '
        Me.tabBacklog.Controls.Add(Me.btQueryNow)
        Me.tabBacklog.Controls.Add(Me.backlogGridView)
        Me.tabBacklog.Location = New System.Drawing.Point(4, 22)
        Me.tabBacklog.Name = "tabBacklog"
        Me.tabBacklog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBacklog.Size = New System.Drawing.Size(624, 414)
        Me.tabBacklog.TabIndex = 0
        Me.tabBacklog.Text = "Backlog"
        Me.tabBacklog.UseVisualStyleBackColor = True
        '
        'btQueryNow
        '
        Me.btQueryNow.Location = New System.Drawing.Point(520, 384)
        Me.btQueryNow.Name = "btQueryNow"
        Me.btQueryNow.Size = New System.Drawing.Size(96, 24)
        Me.btQueryNow.TabIndex = 1
        Me.btQueryNow.Text = "Consultar ahora"
        Me.btQueryNow.UseVisualStyleBackColor = True
        '
        'frmMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 455)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "frmMonitor"
        Me.Text = "Monitor AHK"
        CType(Me.backlogGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tabBacklog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backlogGridView As DataGridView
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabBacklog As TabPage
    Friend WithEvents btQueryNow As Button
End Class

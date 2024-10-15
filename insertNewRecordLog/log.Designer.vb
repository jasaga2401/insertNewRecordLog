<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dvgLog = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        CType(Me.dvgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgLog
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dvgLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgLog.Location = New System.Drawing.Point(114, 106)
        Me.dvgLog.Name = "dvgLog"
        Me.dvgLog.RowHeadersWidth = 51
        Me.dvgLog.RowTemplate.Height = 24
        Me.dvgLog.Size = New System.Drawing.Size(744, 250)
        Me.dvgLog.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(114, 53)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(179, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "New Users Log"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(147, 384)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(47, 20)
        Me.lblBack.TabIndex = 2
        Me.lblBack.Text = "Back"
        '
        'log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 488)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dvgLog)
        Me.Name = "log"
        Me.Text = "log"
        CType(Me.dvgLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dvgLog As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblBack As Label
End Class

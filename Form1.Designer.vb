<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.boutonVueCSV = New System.Windows.Forms.Button()
        Me.DataGridViewCSV = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boutonVueCSV
        '
        Me.boutonVueCSV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.boutonVueCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boutonVueCSV.Location = New System.Drawing.Point(0, 876)
        Me.boutonVueCSV.Name = "boutonVueCSV"
        Me.boutonVueCSV.Size = New System.Drawing.Size(1660, 121)
        Me.boutonVueCSV.TabIndex = 0
        Me.boutonVueCSV.Text = "Voir mon fichier CSV"
        Me.boutonVueCSV.UseVisualStyleBackColor = True
        '
        'DataGridViewCSV
        '
        Me.DataGridViewCSV.AllowUserToOrderColumns = True
        Me.DataGridViewCSV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCSV.Location = New System.Drawing.Point(75, 56)
        Me.DataGridViewCSV.Name = "DataGridViewCSV"
        Me.DataGridViewCSV.RowHeadersWidth = 82
        Me.DataGridViewCSV.RowTemplate.Height = 41
        Me.DataGridViewCSV.Size = New System.Drawing.Size(1479, 735)
        Me.DataGridViewCSV.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1660, 997)
        Me.Controls.Add(Me.DataGridViewCSV)
        Me.Controls.Add(Me.boutonVueCSV)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boutonVueCSV As Button
    Friend WithEvents DataGridViewCSV As DataGridView
End Class

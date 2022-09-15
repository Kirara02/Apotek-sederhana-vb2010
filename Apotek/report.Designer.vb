<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DbApotekDataSet = New Apotek.DbApotekDataSet()
        Me.transaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.transaksiTableAdapter = New Apotek.DbApotekDataSetTableAdapters.transaksiTableAdapter()
        CType(Me.DbApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.transaksiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Apotek.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(621, 369)
        Me.ReportViewer1.TabIndex = 0
        '
        'DbApotekDataSet
        '
        Me.DbApotekDataSet.DataSetName = "DbApotekDataSet"
        Me.DbApotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'transaksiBindingSource
        '
        Me.transaksiBindingSource.DataMember = "transaksi"
        Me.transaksiBindingSource.DataSource = Me.DbApotekDataSet
        '
        'transaksiTableAdapter
        '
        Me.transaksiTableAdapter.ClearBeforeFill = True
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 383)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "report"
        Me.Text = "report"
        CType(Me.DbApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents transaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbApotekDataSet As Apotek.DbApotekDataSet
    Friend WithEvents transaksiTableAdapter As Apotek.DbApotekDataSetTableAdapters.transaksiTableAdapter
End Class

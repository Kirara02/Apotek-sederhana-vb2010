<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObat
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
        Me.cr = New System.Windows.Forms.TextBox()
        Me.btns = New System.Windows.Forms.Button()
        Me.btnd = New System.Windows.Forms.Button()
        Me.btnu = New System.Windows.Forms.Button()
        Me.btni = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nm = New System.Windows.Forms.TextBox()
        Me.kd = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnk = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cr
        '
        Me.cr.Location = New System.Drawing.Point(51, 181)
        Me.cr.Name = "cr"
        Me.cr.Size = New System.Drawing.Size(155, 20)
        Me.cr.TabIndex = 32
        '
        'btns
        '
        Me.btns.Location = New System.Drawing.Point(212, 179)
        Me.btns.Name = "btns"
        Me.btns.Size = New System.Drawing.Size(75, 23)
        Me.btns.TabIndex = 31
        Me.btns.Text = "Search"
        Me.btns.UseVisualStyleBackColor = True
        '
        'btnd
        '
        Me.btnd.Location = New System.Drawing.Point(462, 179)
        Me.btnd.Name = "btnd"
        Me.btnd.Size = New System.Drawing.Size(75, 23)
        Me.btnd.TabIndex = 30
        Me.btnd.Text = "Delete"
        Me.btnd.UseVisualStyleBackColor = True
        '
        'btnu
        '
        Me.btnu.Location = New System.Drawing.Point(382, 179)
        Me.btnu.Name = "btnu"
        Me.btnu.Size = New System.Drawing.Size(75, 23)
        Me.btnu.TabIndex = 29
        Me.btnu.Text = "Update"
        Me.btnu.UseVisualStyleBackColor = True
        '
        'btni
        '
        Me.btni.Location = New System.Drawing.Point(301, 179)
        Me.btni.Name = "btni"
        Me.btni.Size = New System.Drawing.Size(75, 23)
        Me.btni.TabIndex = 28
        Me.btni.Text = "Insert"
        Me.btni.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.CustomFormat = "DD/MM/yyyy"
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(136, 111)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(155, 20)
        Me.dtp.TabIndex = 27
        Me.dtp.Value = New Date(2022, 8, 22, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Harga"
        '
        'hr
        '
        Me.hr.Location = New System.Drawing.Point(136, 137)
        Me.hr.Name = "hr"
        Me.hr.Size = New System.Drawing.Size(155, 20)
        Me.hr.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Expired Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Kode Obat"
        '
        'nm
        '
        Me.nm.Location = New System.Drawing.Point(136, 85)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(155, 20)
        Me.nm.TabIndex = 20
        '
        'kd
        '
        Me.kd.Location = New System.Drawing.Point(136, 59)
        Me.kd.Name = "kd"
        Me.kd.Size = New System.Drawing.Size(155, 20)
        Me.kd.TabIndex = 19
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(51, 207)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(487, 157)
        Me.dgv.TabIndex = 18
        '
        'btnk
        '
        Me.btnk.Location = New System.Drawing.Point(311, 135)
        Me.btnk.Name = "btnk"
        Me.btnk.Size = New System.Drawing.Size(75, 23)
        Me.btnk.TabIndex = 33
        Me.btnk.Text = "Kosongkan"
        Me.btnk.UseVisualStyleBackColor = True
        '
        'FormObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(589, 373)
        Me.Controls.Add(Me.btnk)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.btns)
        Me.Controls.Add(Me.btnd)
        Me.Controls.Add(Me.btnu)
        Me.Controls.Add(Me.btni)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.kd)
        Me.Controls.Add(Me.dgv)
        Me.Name = "FormObat"
        Me.Text = "Obat"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cr As System.Windows.Forms.TextBox
    Friend WithEvents btns As System.Windows.Forms.Button
    Friend WithEvents btnd As System.Windows.Forms.Button
    Friend WithEvents btnu As System.Windows.Forms.Button
    Friend WithEvents btni As System.Windows.Forms.Button
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents hr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nm As System.Windows.Forms.TextBox
    Friend WithEvents kd As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnk As System.Windows.Forms.Button
End Class

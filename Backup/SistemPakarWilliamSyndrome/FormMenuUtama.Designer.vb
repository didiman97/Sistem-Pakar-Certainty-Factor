<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataBakatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGejalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BasisPengetahuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiagnosaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesCFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DiagnosaToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(731, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBakatToolStripMenuItem, Me.DataGejalaToolStripMenuItem, Me.BasisPengetahuanToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.FileToolStripMenuItem.Text = "Data"
        '
        'DataBakatToolStripMenuItem
        '
        Me.DataBakatToolStripMenuItem.Name = "DataBakatToolStripMenuItem"
        Me.DataBakatToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.DataBakatToolStripMenuItem.Text = "Data Penyakit"
        '
        'DataGejalaToolStripMenuItem
        '
        Me.DataGejalaToolStripMenuItem.Name = "DataGejalaToolStripMenuItem"
        Me.DataGejalaToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.DataGejalaToolStripMenuItem.Text = "Data Gejala"
        '
        'BasisPengetahuanToolStripMenuItem
        '
        Me.BasisPengetahuanToolStripMenuItem.Name = "BasisPengetahuanToolStripMenuItem"
        Me.BasisPengetahuanToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.BasisPengetahuanToolStripMenuItem.Text = "Basis Pengetahuan"
        '
        'DiagnosaToolStripMenuItem
        '
        Me.DiagnosaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesCFToolStripMenuItem})
        Me.DiagnosaToolStripMenuItem.Name = "DiagnosaToolStripMenuItem"
        Me.DiagnosaToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.DiagnosaToolStripMenuItem.Text = "Konsultasi"
        '
        'ProsesCFToolStripMenuItem
        '
        Me.ProsesCFToolStripMenuItem.Name = "ProsesCFToolStripMenuItem"
        Me.ProsesCFToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.ProsesCFToolStripMenuItem.Text = "Proses CF"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(66, 25)
        Me.HelpToolStripMenuItem.Text = "Keluar"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(731, 442)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormMenuUtama"
        Me.Text = "FormMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiagnosaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesCFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBakatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGejalaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasisPengetahuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

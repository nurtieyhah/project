<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployedYear
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1SelectRange2 = New System.Windows.Forms.ToolStripComboBox()
        Me.PanelChartTitle = New System.Windows.Forms.Panel()
        Me.LabelChartTitle = New System.Windows.Forms.Label()
        Me.ChartYear = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BptmsEmployedbystateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployedDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployedDataSet = New Employed_by_State.employedDataSet()
        Me.Bptms_Employed_by_stateTableAdapter = New Employed_by_State.employedDataSetTableAdapters.bptms_Employed_by_stateTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelChartTitle.SuspendLayout()
        CType(Me.ChartYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BptmsEmployedbystateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployedDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.ToolStripComboBox1SelectRange2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(790, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizeToolStripMenuItem, Me.RestoreDownToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'RestoreDownToolStripMenuItem
        '
        Me.RestoreDownToolStripMenuItem.Name = "RestoreDownToolStripMenuItem"
        Me.RestoreDownToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestoreDownToolStripMenuItem.Text = "Restore Down"
        '
        'ToolStripComboBox1SelectRange2
        '
        Me.ToolStripComboBox1SelectRange2.Items.AddRange(New Object() {"2016 (Ascending)"})
        Me.ToolStripComboBox1SelectRange2.Name = "ToolStripComboBox1SelectRange2"
        Me.ToolStripComboBox1SelectRange2.Size = New System.Drawing.Size(121, 23)
        '
        'PanelChartTitle
        '
        Me.PanelChartTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelChartTitle.Controls.Add(Me.LabelChartTitle)
        Me.PanelChartTitle.Location = New System.Drawing.Point(12, 45)
        Me.PanelChartTitle.Name = "PanelChartTitle"
        Me.PanelChartTitle.Size = New System.Drawing.Size(744, 47)
        Me.PanelChartTitle.TabIndex = 1
        '
        'LabelChartTitle
        '
        Me.LabelChartTitle.AutoSize = True
        Me.LabelChartTitle.Font = New System.Drawing.Font("Wide Latin", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChartTitle.Location = New System.Drawing.Point(208, 15)
        Me.LabelChartTitle.Name = "LabelChartTitle"
        Me.LabelChartTitle.Size = New System.Drawing.Size(339, 26)
        Me.LabelChartTitle.TabIndex = 0
        Me.LabelChartTitle.Text = "STATE VS YEAR"
        '
        'ChartYear
        '
        Me.ChartYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.ChartYear.ChartAreas.Add(ChartArea1)
        Me.ChartYear.DataSource = Me.BptmsEmployedbystateBindingSource
        Legend1.Name = "Legend1"
        Me.ChartYear.Legends.Add(Legend1)
        Me.ChartYear.Location = New System.Drawing.Point(65, 106)
        Me.ChartYear.Name = "ChartYear"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Year"
        Me.ChartYear.Series.Add(Series1)
        Me.ChartYear.Size = New System.Drawing.Size(690, 332)
        Me.ChartYear.TabIndex = 2
        Me.ChartYear.Text = "Chart1"
        '
        'BptmsEmployedbystateBindingSource
        '
        Me.BptmsEmployedbystateBindingSource.DataMember = "bptms_Employed_by_state"
        Me.BptmsEmployedbystateBindingSource.DataSource = Me.EmployedDataSetBindingSource
        '
        'EmployedDataSetBindingSource
        '
        Me.EmployedDataSetBindingSource.DataSource = Me.EmployedDataSet
        Me.EmployedDataSetBindingSource.Position = 0
        '
        'EmployedDataSet
        '
        Me.EmployedDataSet.DataSetName = "employedDataSet"
        Me.EmployedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bptms_Employed_by_stateTableAdapter
        '
        Me.Bptms_Employed_by_stateTableAdapter.ClearBeforeFill = True
        '
        'EmployedYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 450)
        Me.Controls.Add(Me.ChartYear)
        Me.Controls.Add(Me.PanelChartTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmployedYear"
        Me.Text = "EmployedYear"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelChartTitle.ResumeLayout(False)
        Me.PanelChartTitle.PerformLayout()
        CType(Me.ChartYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BptmsEmployedbystateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployedDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1SelectRange2 As ToolStripComboBox
    Friend WithEvents PanelChartTitle As Panel
    Friend WithEvents LabelChartTitle As Label
    Friend WithEvents ChartYear As DataVisualization.Charting.Chart
    Friend WithEvents EmployedDataSetBindingSource As BindingSource
    Friend WithEvents EmployedDataSet As employedDataSet
    Friend WithEvents BptmsEmployedbystateBindingSource As BindingSource
    Friend WithEvents Bptms_Employed_by_stateTableAdapter As employedDataSetTableAdapters.bptms_Employed_by_stateTableAdapter
End Class

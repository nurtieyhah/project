Public Class EmployedYear

    Private Sub EmployedYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployedDataSet.bptms_Employed_by_state' table. You can move, or remove it, as needed.
        Me.Bptms_Employed_by_stateTableAdapter.Fill(Me.EmployedDataSet.bptms_Employed_by_state)

        LabelChartTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffb90f")
        PanelChartTitle.BackColor = Color.DarkGray

        'setup Employed Chart
        ChartYear.ChartAreas(0).AxisX.LabelStyle.Interval = 1

        'axis X 
        ChartYear.ChartAreas(0).AxisX.TitleFont = New Font("oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        ChartYear.ChartAreas(0).AxisX.Title = "Employed State"

        'axis Y
        ChartYear.ChartAreas(0).AxisY.TitleFont = New Font("Oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        ChartYear.ChartAreas(0).AxisY.Title = "Year"

        ChartYear.ChartAreas(0).AxisY.TitleForeColor = Color.FromName("DodgerBlue")

        'Hide legend label1
        ChartYear.Series("Year").IsVisibleInLegend = False

        ' Show number value in bar / column chart
        ChartYear.Series("Year").IsValueShownAsLabel = True

        ' Value member
        ChartYear.Series("Year").XValueMember = "State/Country"
        ChartYear.Series("Year").YValueMembers = "Year"

        ' ChartEmployed.DataSource = Nothing

        'Selected items = 2016 (Ascending)
        ToolStripComboBox1SelectRange2.SelectedIndex = 0
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RestoreDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDownToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
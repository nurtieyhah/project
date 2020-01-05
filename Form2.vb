Public Class EmployedChart
    Private Sub EmployedChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployedDataSet.bptms_Employed_by_state' table. You can move, or remove it, as needed.
        Me.Bptms_Employed_by_stateTableAdapter.Fill(Me.EmployedDataSet.bptms_Employed_by_state)

        LabelChartTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffb90f")
        PanelChartTitle.BackColor = Color.DarkGray

        'setup Employed Chart
        ChartEmployed.ChartAreas(0).AxisX.LabelStyle.Interval = 1

        'axis X 
        ChartEmployed.ChartAreas(0).AxisX.TitleFont = New Font("oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        ChartEmployed.ChartAreas(0).AxisX.Title = "Year of Employed"

        'axis Y
        ChartEmployed.ChartAreas(0).AxisY.TitleFont = New Font("Oswald", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        ChartEmployed.ChartAreas(0).AxisY.Title = "Employed Total"

        ChartEmployed.ChartAreas(0).AxisY.TitleForeColor = Color.FromName("DodgerBlue")

        'Hide legend label1
        ChartEmployed.Series("Employed").IsVisibleInLegend = False

        ' Show number value in bar / column chart
        ChartEmployed.Series("Employed").IsValueShownAsLabel = True

        ' Value member
        ChartEmployed.Series("Employed").XValueMember = "Year"
        ChartEmployed.Series("Employed").YValueMembers = "Total"

        ' ChartEmployed.DataSource = Nothing

        'Selected items = 2016 (Ascending)
        ToolStripComboBox1SelectRange.SelectedIndex = 0

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RestoreDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDownToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ChartEmployed_Click(sender As Object, e As EventArgs) Handles ChartEmployed.Click

    End Sub
End Class
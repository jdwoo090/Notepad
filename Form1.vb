Public Class Form1
    Structure Employee
        Public id As String
        Public firstName As String
        Public lastName As String
        Public pay As Double
    End Structure

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim f As IO.StreamReader
        f = IO.File.OpenText(OpenFileDialog1.FileName)
        TextBox1.Text = f.ReadToEnd
        f.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Dim f As IO.StreamWriter
        f = IO.File.AppendText(SaveFileDialog1.FileName)
        f.Write(TextBox1.Text)
        f.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        TextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub SaveASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveASToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Dim f As IO.StreamWriter
        f = IO.File.AppendText(SaveFileDialog1.FileName)
        f.Write(TextBox1.Text)
        f.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        MessageBox.Show("First save your document!")
        SaveFileDialog1.ShowDialog()
        Dim f As IO.StreamWriter
        f = IO.File.AppendText(SaveFileDialog1.FileName)
        f.Write(TextBox1.Text)
        f.Close()
        TextBox1.Text = ""
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub ClearTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTextToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click

    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        MessageBox.Show("Please hook up a printer first")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub
End Class

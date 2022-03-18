Public Class Form1
    'Adding and removing tabs
    Private Sub AddTabButton_Click(sender As Object, e As EventArgs) Handles AddTabButton.Click
        Dim NTP As New TabPage()
        Dim NRTB As New RichTextBox
        NRTB.BorderStyle = BorderStyle.None
        NRTB.Dock = DockStyle.Fill
        NTP.Controls.Add(NRTB)
        NTP.Text = "Tab " & (TabControl1.TabPages.Count + 1)
        TabControl1.TabPages.Add(NTP)
    End Sub
    Private Sub RemoveTabButton_Click(sender As Object, e As EventArgs) Handles RemoveTabButton.Click
        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
    End Sub
    'Renaming tabs
    Private Sub RenameTabButton_Click(sender As Object, e As EventArgs) Handles RenameTabButton.Click
        TabControl1.SelectedTab.Text = RenameBox.Text
    End Sub
    Private Sub RenameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RenameBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedTab.Text = RenameBox.Text
        End If
    End Sub
    'Themes
    Private Sub Black_Click(sender As Object, e As EventArgs) Handles Black.Click
        Me.BackColor = Color.Black
        Black.Checked = True
        Blue.Checked = False
        Gray.Checked = False
        Green.Checked = False
        Orange.Checked = False
        Purple.Checked = False
        Red.Checked = False
        White.Checked = False
        Yellow.Checked = False
    End Sub
    Private Sub Blue_Click(sender As Object, e As EventArgs) Handles Blue.Click
        Me.BackColor = Color.AliceBlue
        Black.Checked = False
        Blue.Checked = True
        Gray.Checked = False
        Green.Checked = False
        Orange.Checked = False
        Purple.Checked = False
        Red.Checked = False
        White.Checked = False
        Yellow.Checked = False
    End Sub
    Private Sub Gray_Click(sender As Object, e As EventArgs) Handles Gray.Click
        Me.BackColor = Color.LightGray
        Black.Checked = False
        Blue.Checked = False
        Gray.Checked = True
        Green.Checked = False
        Orange.Checked = False
        Purple.Checked = False
        Red.Checked = False
        White.Checked = False
        Yellow.Checked = False
    End Sub
    Private Sub Green_Click(sender As Object, e As EventArgs) Handles Green.Click
        Me.BackColor = Color.Honeydew
        Black.Checked = False
        Blue.Checked = False
        Gray.Checked = False
        Green.Checked = True
        Orange.Checked = False
        Purple.Checked = False
        Red.Checked = False
        White.Checked = False
        Yellow.Checked = False
    End Sub
    Private Sub Orange_Click(sender As Object, e As EventArgs) Handles Orange.Click
        Me.BackColor = Color.Moccasin
        Black.Checked = False
        Blue.Checked = False
        Gray.Checked = False
        Green.Checked = False
        Orange.Checked = True
        Purple.Checked = False
        Red.Checked = False
        White.Checked = False
        Yellow.Checked = False
    End Sub
    Private Sub Purple_Click(sender As Object, e As EventArgs) Handles Purple.Click
        Me.BackColor = Color.LavenderBlush
        Black.Checked = False
        Blue.Checked = False
        Gray.Checked = False
        Green.Checked = False
        Orange.Checked = False
        Purple.Checked = True
        Red.Checked = False
        White.Checked = False
        Yellow.Checked = False
    End Sub
    Private Sub Red_Click(sender As Object, e As EventArgs) Handles Red.Click
        Me.BackColor = Color.MistyRose
        Black.Checked = False
        Blue.Checked = False
        Gray.Checked = False
        Green.Checked = False
        Orange.Checked = False
        Purple.Checked = False
        Red.Checked = True
        White.Checked = False
        Yellow.Checked = False
    End Sub
    Private Sub White_Click(sender As Object, e As EventArgs) Handles White.Click
        Me.BackColor = Color.White
        Black.Checked = False
        Blue.Checked = False
        Gray.Checked = False
        Green.Checked = False
        Orange.Checked = False
        Purple.Checked = False
        Red.Checked = False
        White.Checked = True
        Yellow.Checked = False
    End Sub
    Private Sub Yellow_Click(sender As Object, e As EventArgs) Handles Yellow.Click
        Me.BackColor = Color.LemonChiffon
        Black.Checked = False
        Blue.Checked = False
        Gray.Checked = False
        Green.Checked = False
        Orange.Checked = False
        Purple.Checked = False
        Red.Checked = False
        White.Checked = False
        Yellow.Checked = True
    End Sub
    'Time
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeDateLabel.Text = Date.Now.ToString("dddd, M/d/yyyy, h:mm tt")
    End Sub
    'New window
    Private Sub NewWindowButton_Click(sender As Object, e As EventArgs) Handles NewWindowButton.Click
        Dim NW As New Form1
        NW.Show()
    End Sub
End Class

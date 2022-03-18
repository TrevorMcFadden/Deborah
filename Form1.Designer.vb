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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AddTabButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RenameBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TimeDateLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Theme = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Black = New System.Windows.Forms.ToolStripMenuItem()
        Me.Blue = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gray = New System.Windows.Forms.ToolStripMenuItem()
        Me.Green = New System.Windows.Forms.ToolStripMenuItem()
        Me.Orange = New System.Windows.Forms.ToolStripMenuItem()
        Me.Purple = New System.Windows.Forms.ToolStripMenuItem()
        Me.Red = New System.Windows.Forms.ToolStripMenuItem()
        Me.White = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yellow = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveTabButton = New System.Windows.Forms.Button()
        Me.RenameTabButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NewWindowButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddTabButton
        '
        Me.AddTabButton.BackColor = System.Drawing.Color.White
        Me.AddTabButton.FlatAppearance.BorderSize = 0
        Me.AddTabButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddTabButton.Location = New System.Drawing.Point(12, 12)
        Me.AddTabButton.Name = "AddTabButton"
        Me.AddTabButton.Size = New System.Drawing.Size(75, 23)
        Me.AddTabButton.TabIndex = 1
        Me.AddTabButton.Text = "+ Add"
        Me.ToolTip1.SetToolTip(Me.AddTabButton, "Add a tab")
        Me.AddTabButton.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 384)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 356)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tab 1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(786, 350)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'RenameBox
        '
        Me.RenameBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RenameBox.BackColor = System.Drawing.SystemColors.Control
        Me.RenameBox.Location = New System.Drawing.Point(174, 12)
        Me.RenameBox.Name = "RenameBox"
        Me.RenameBox.Size = New System.Drawing.Size(452, 23)
        Me.RenameBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.RenameBox, "Use this to rename a tab")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeDateLabel, Me.Theme})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 405)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TimeDateLabel
        '
        Me.TimeDateLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TimeDateLabel.Name = "TimeDateLabel"
        Me.TimeDateLabel.Size = New System.Drawing.Size(153, 17)
        Me.TimeDateLabel.Text = "Saturday, 2/22/22, 12:00 PM"
        '
        'Theme
        '
        Me.Theme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Theme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Black, Me.Blue, Me.Gray, Me.Green, Me.Orange, Me.Purple, Me.Red, Me.White, Me.Yellow})
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Theme.Name = "Theme"
        Me.Theme.Size = New System.Drawing.Size(65, 20)
        Me.Theme.Text = "Theme..."
        '
        'Black
        '
        Me.Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Black.Name = "Black"
        Me.Black.Size = New System.Drawing.Size(180, 22)
        Me.Black.Text = "Black"
        Me.Black.ToolTipText = "Black theme"
        '
        'Blue
        '
        Me.Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(180, 22)
        Me.Blue.Text = "Blue"
        Me.Blue.ToolTipText = "Blue theme"
        '
        'Gray
        '
        Me.Gray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Gray.Name = "Gray"
        Me.Gray.Size = New System.Drawing.Size(180, 22)
        Me.Gray.Text = "Gray"
        Me.Gray.ToolTipText = "Gray theme"
        '
        'Green
        '
        Me.Green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(180, 22)
        Me.Green.Text = "Green"
        Me.Green.ToolTipText = "Green theme"
        '
        'Orange
        '
        Me.Orange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Orange.Name = "Orange"
        Me.Orange.Size = New System.Drawing.Size(180, 22)
        Me.Orange.Text = "Orange"
        Me.Orange.ToolTipText = "Orange theme"
        '
        'Purple
        '
        Me.Purple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Purple.Name = "Purple"
        Me.Purple.Size = New System.Drawing.Size(180, 22)
        Me.Purple.Text = "Purple"
        Me.Purple.ToolTipText = "Purple theme"
        '
        'Red
        '
        Me.Red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(180, 22)
        Me.Red.Text = "Red"
        Me.Red.ToolTipText = "Red theme"
        '
        'White
        '
        Me.White.Checked = True
        Me.White.CheckState = System.Windows.Forms.CheckState.Checked
        Me.White.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.White.Name = "White"
        Me.White.Size = New System.Drawing.Size(180, 22)
        Me.White.Text = "White"
        Me.White.ToolTipText = "White theme"
        '
        'Yellow
        '
        Me.Yellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Yellow.Name = "Yellow"
        Me.Yellow.Size = New System.Drawing.Size(180, 22)
        Me.Yellow.Text = "Yellow"
        Me.Yellow.ToolTipText = "Yellow theme"
        '
        'RemoveTabButton
        '
        Me.RemoveTabButton.BackColor = System.Drawing.Color.White
        Me.RemoveTabButton.FlatAppearance.BorderSize = 0
        Me.RemoveTabButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RemoveTabButton.Location = New System.Drawing.Point(93, 12)
        Me.RemoveTabButton.Name = "RemoveTabButton"
        Me.RemoveTabButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveTabButton.TabIndex = 5
        Me.RemoveTabButton.Text = "- Remove"
        Me.ToolTip1.SetToolTip(Me.RemoveTabButton, "Remove a tab")
        Me.RemoveTabButton.UseVisualStyleBackColor = False
        '
        'RenameTabButton
        '
        Me.RenameTabButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RenameTabButton.BackColor = System.Drawing.Color.White
        Me.RenameTabButton.FlatAppearance.BorderSize = 0
        Me.RenameTabButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RenameTabButton.ForeColor = System.Drawing.Color.Black
        Me.RenameTabButton.Location = New System.Drawing.Point(632, 12)
        Me.RenameTabButton.Name = "RenameTabButton"
        Me.RenameTabButton.Size = New System.Drawing.Size(75, 23)
        Me.RenameTabButton.TabIndex = 6
        Me.RenameTabButton.Text = "Rename..."
        Me.ToolTip1.SetToolTip(Me.RenameTabButton, "Rename a tab")
        Me.RenameTabButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'NewWindowButton
        '
        Me.NewWindowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewWindowButton.Location = New System.Drawing.Point(713, 12)
        Me.NewWindowButton.Name = "NewWindowButton"
        Me.NewWindowButton.Size = New System.Drawing.Size(75, 23)
        Me.NewWindowButton.TabIndex = 7
        Me.NewWindowButton.Text = "New..."
        Me.ToolTip1.SetToolTip(Me.NewWindowButton, "Open a new window")
        Me.NewWindowButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 427)
        Me.Controls.Add(Me.NewWindowButton)
        Me.Controls.Add(Me.RenameTabButton)
        Me.Controls.Add(Me.RemoveTabButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.AddTabButton)
        Me.Controls.Add(Me.RenameBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Deborah"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddTabButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents RenameBox As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TimeDateLabel As ToolStripStatusLabel
    Friend WithEvents Theme As ToolStripDropDownButton
    Friend WithEvents RemoveTabButton As Button
    Friend WithEvents RenameTabButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Black As ToolStripMenuItem
    Friend WithEvents Blue As ToolStripMenuItem
    Friend WithEvents Gray As ToolStripMenuItem
    Friend WithEvents Green As ToolStripMenuItem
    Friend WithEvents Orange As ToolStripMenuItem
    Friend WithEvents Purple As ToolStripMenuItem
    Friend WithEvents Red As ToolStripMenuItem
    Friend WithEvents White As ToolStripMenuItem
    Friend WithEvents Yellow As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents NewWindowButton As Button
End Class

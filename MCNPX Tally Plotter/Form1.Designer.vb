<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlotterForm
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
    Me.box_files = New System.Windows.Forms.ListBox()
    Me.box_plot = New System.Windows.Forms.ListBox()
    Me.btn_left = New System.Windows.Forms.Button()
    Me.btn_right = New System.Windows.Forms.Button()
    Me.tx_path = New System.Windows.Forms.TextBox()
    Me.tx_xlow = New System.Windows.Forms.TextBox()
    Me.tx_ylow = New System.Windows.Forms.TextBox()
    Me.tx_yhigh = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.btn_limits = New System.Windows.Forms.Button()
    Me.cbox_axes = New System.Windows.Forms.ComboBox()
    Me.cbox_free = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.CheckBox1 = New System.Windows.Forms.CheckBox()
    Me.btn_data = New System.Windows.Forms.Button()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.lbl_path = New System.Windows.Forms.Label()
    Me.tx_ext = New System.Windows.Forms.TextBox()
    Me.tx_talnum = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.btn_find = New System.Windows.Forms.Button()
    Me.btn_load = New System.Windows.Forms.Button()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.btn_make = New System.Windows.Forms.Button()
    Me.lbl_needfiles = New System.Windows.Forms.Label()
    Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
    Me.lbl_talnum = New System.Windows.Forms.Label()
    Me.btn_up = New System.Windows.Forms.Button()
    Me.btn_down = New System.Windows.Forms.Button()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.tx_xhigh = New System.Windows.Forms.TextBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.q_csv = New System.Windows.Forms.Label()
    Me.btn_dataCSV = New System.Windows.Forms.Button()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.cbox_style = New System.Windows.Forms.ComboBox()
    Me.chk_noerrbar = New System.Windows.Forms.CheckBox()
    Me.chk_nonorm = New System.Windows.Forms.CheckBox()
    Me.chk_dataCSV = New System.Windows.Forms.CheckBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.btn_about = New System.Windows.Forms.Button()
    Me.btn_clear = New System.Windows.Forms.Button()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.q_data = New System.Windows.Forms.Label()
    Me.q_manual = New System.Windows.Forms.Label()
    Me.q_move = New System.Windows.Forms.Label()
    Me.CheckBox2 = New System.Windows.Forms.CheckBox()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'box_files
    '
    Me.box_files.FormattingEnabled = True
    Me.box_files.Location = New System.Drawing.Point(430, 25)
    Me.box_files.Name = "box_files"
    Me.box_files.Size = New System.Drawing.Size(387, 446)
    Me.box_files.TabIndex = 0
    '
    'box_plot
    '
    Me.box_plot.FormattingEnabled = True
    Me.box_plot.Location = New System.Drawing.Point(7, 497)
    Me.box_plot.Name = "box_plot"
    Me.box_plot.Size = New System.Drawing.Size(684, 82)
    Me.box_plot.TabIndex = 1
    '
    'btn_left
    '
    Me.btn_left.Location = New System.Drawing.Point(315, 470)
    Me.btn_left.Name = "btn_left"
    Me.btn_left.Size = New System.Drawing.Size(47, 21)
    Me.btn_left.TabIndex = 2
    Me.btn_left.Text = "<<"
    Me.btn_left.UseVisualStyleBackColor = True
    '
    'btn_right
    '
    Me.btn_right.Location = New System.Drawing.Point(372, 470)
    Me.btn_right.Name = "btn_right"
    Me.btn_right.Size = New System.Drawing.Size(47, 21)
    Me.btn_right.TabIndex = 2
    Me.btn_right.Text = ">>"
    Me.btn_right.UseVisualStyleBackColor = True
    '
    'tx_path
    '
    Me.tx_path.Location = New System.Drawing.Point(8, 30)
    Me.tx_path.Name = "tx_path"
    Me.tx_path.Size = New System.Drawing.Size(392, 20)
    Me.tx_path.TabIndex = 5
    Me.tx_path.Text = "C:\MCNPX\photoneutron\"
    '
    'tx_xlow
    '
    Me.tx_xlow.Location = New System.Drawing.Point(107, 88)
    Me.tx_xlow.Name = "tx_xlow"
    Me.tx_xlow.Size = New System.Drawing.Size(47, 20)
    Me.tx_xlow.TabIndex = 6
    '
    'tx_ylow
    '
    Me.tx_ylow.Location = New System.Drawing.Point(160, 88)
    Me.tx_ylow.Name = "tx_ylow"
    Me.tx_ylow.Size = New System.Drawing.Size(47, 20)
    Me.tx_ylow.TabIndex = 8
    '
    'tx_yhigh
    '
    Me.tx_yhigh.Location = New System.Drawing.Point(160, 114)
    Me.tx_yhigh.Name = "tx_yhigh"
    Me.tx_yhigh.Size = New System.Drawing.Size(47, 20)
    Me.tx_yhigh.TabIndex = 9
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(60, 91)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(36, 13)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Lower"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(60, 117)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(36, 13)
    Me.Label2.TabIndex = 11
    Me.Label2.Text = "Upper"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(5, 14)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(264, 13)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "Current Folder Path:      (requires trailing backslash ""\"")"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(104, 72)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(29, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "xlims"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(157, 72)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(29, 13)
    Me.Label5.TabIndex = 10
    Me.Label5.Text = "ylims"
    '
    'btn_limits
    '
    Me.btn_limits.Location = New System.Drawing.Point(28, 64)
    Me.btn_limits.Name = "btn_limits"
    Me.btn_limits.Size = New System.Drawing.Size(73, 21)
    Me.btn_limits.TabIndex = 2
    Me.btn_limits.Text = "Default Lims"
    Me.btn_limits.UseVisualStyleBackColor = True
    '
    'cbox_axes
    '
    Me.cbox_axes.DisplayMember = "linlin"
    Me.cbox_axes.FormattingEnabled = True
    Me.cbox_axes.Items.AddRange(New Object() {"loglog", "linlin", "loglin", "linlog"})
    Me.cbox_axes.Location = New System.Drawing.Point(308, 22)
    Me.cbox_axes.Name = "cbox_axes"
    Me.cbox_axes.Size = New System.Drawing.Size(78, 21)
    Me.cbox_axes.TabIndex = 13
    Me.cbox_axes.Text = "loglog"
    Me.cbox_axes.ValueMember = "loglog"
    '
    'cbox_free
    '
    Me.cbox_free.FormattingEnabled = True
    Me.cbox_free.Items.AddRange(New Object() {"e", "t", "c", "m", "d", "u", "f"})
    Me.cbox_free.Location = New System.Drawing.Point(309, 77)
    Me.cbox_free.Name = "cbox_free"
    Me.cbox_free.Size = New System.Drawing.Size(78, 21)
    Me.cbox_free.TabIndex = 14
    Me.cbox_free.Text = "e"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(294, 6)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(68, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Axes Scaling"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(294, 61)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(69, 13)
    Me.Label7.TabIndex = 10
    Me.Label7.Text = "Free Variable"
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Checked = True
    Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBox1.Location = New System.Drawing.Point(7, 421)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(154, 30)
    Me.CheckBox1.TabIndex = 15
    Me.CheckBox1.Text = "Uncheck to enable manual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MCPLOT control"
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'btn_data
    '
    Me.btn_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btn_data.Location = New System.Drawing.Point(697, 534)
    Me.btn_data.Name = "btn_data"
    Me.btn_data.Size = New System.Drawing.Size(107, 30)
    Me.btn_data.TabIndex = 2
    Me.btn_data.Text = "Show Tally Data"
    Me.btn_data.UseVisualStyleBackColor = True
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(5, 468)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(188, 26)
    Me.Label8.TabIndex = 16
    Me.Label8.Text = "MCTAL files to take tally plots from:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(maximum of 6 - an MCPLOT limitation)"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(265, 72)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(147, 26)
    Me.Label9.TabIndex = 12
    Me.Label9.Text = "MCTAL file suffix to search by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(e.g. ""*.m"" for all .m files)"
    '
    'lbl_path
    '
    Me.lbl_path.AutoSize = True
    Me.lbl_path.Enabled = False
    Me.lbl_path.ForeColor = System.Drawing.Color.Red
    Me.lbl_path.Location = New System.Drawing.Point(31, 53)
    Me.lbl_path.Name = "lbl_path"
    Me.lbl_path.Size = New System.Drawing.Size(109, 13)
    Me.lbl_path.TabIndex = 12
    Me.lbl_path.Text = "Folder path must exist"
    '
    'tx_ext
    '
    Me.tx_ext.Location = New System.Drawing.Point(188, 72)
    Me.tx_ext.Name = "tx_ext"
    Me.tx_ext.Size = New System.Drawing.Size(71, 20)
    Me.tx_ext.TabIndex = 7
    Me.tx_ext.Text = "*.m"
    Me.tx_ext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'tx_talnum
    '
    Me.tx_talnum.Location = New System.Drawing.Point(28, 22)
    Me.tx_talnum.Name = "tx_talnum"
    Me.tx_talnum.Size = New System.Drawing.Size(47, 20)
    Me.tx_talnum.TabIndex = 6
    Me.tx_talnum.Text = "2"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(75, 25)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(99, 13)
    Me.Label13.TabIndex = 10
    Me.Label13.Text = "Tally number to plot"
    '
    'btn_find
    '
    Me.btn_find.Location = New System.Drawing.Point(49, 72)
    Me.btn_find.Name = "btn_find"
    Me.btn_find.Size = New System.Drawing.Size(73, 21)
    Me.btn_find.TabIndex = 2
    Me.btn_find.Text = "Find Folder"
    Me.btn_find.UseVisualStyleBackColor = True
    '
    'btn_load
    '
    Me.btn_load.Location = New System.Drawing.Point(109, 119)
    Me.btn_load.Name = "btn_load"
    Me.btn_load.Size = New System.Drawing.Size(159, 21)
    Me.btn_load.TabIndex = 2
    Me.btn_load.Text = "Load Files From Above Folder"
    Me.btn_load.UseVisualStyleBackColor = True
    '
    'Label14
    '
    Me.Label14.AllowDrop = True
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(694, 518)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(110, 13)
    Me.Label14.TabIndex = 11
    Me.Label14.Text = "For selected file at left"
    '
    'btn_make
    '
    Me.btn_make.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btn_make.Location = New System.Drawing.Point(296, 420)
    Me.btn_make.Name = "btn_make"
    Me.btn_make.Size = New System.Drawing.Size(111, 30)
    Me.btn_make.TabIndex = 2
    Me.btn_make.Text = "Make Tally Plot"
    Me.btn_make.UseVisualStyleBackColor = True
    '
    'lbl_needfiles
    '
    Me.lbl_needfiles.AutoSize = True
    Me.lbl_needfiles.Enabled = False
    Me.lbl_needfiles.ForeColor = System.Drawing.Color.Red
    Me.lbl_needfiles.Location = New System.Drawing.Point(211, 481)
    Me.lbl_needfiles.Name = "lbl_needfiles"
    Me.lbl_needfiles.Size = New System.Drawing.Size(85, 13)
    Me.lbl_needfiles.TabIndex = 10
    Me.lbl_needfiles.Text = "No files selected"
    '
    'lbl_talnum
    '
    Me.lbl_talnum.AutoSize = True
    Me.lbl_talnum.Enabled = False
    Me.lbl_talnum.ForeColor = System.Drawing.Color.Red
    Me.lbl_talnum.Location = New System.Drawing.Point(25, 43)
    Me.lbl_talnum.Name = "lbl_talnum"
    Me.lbl_talnum.Size = New System.Drawing.Size(93, 13)
    Me.lbl_talnum.TabIndex = 10
    Me.lbl_talnum.Text = "Must be numerical"
    '
    'btn_up
    '
    Me.btn_up.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btn_up.Location = New System.Drawing.Point(697, 475)
    Me.btn_up.Name = "btn_up"
    Me.btn_up.Size = New System.Drawing.Size(27, 19)
    Me.btn_up.TabIndex = 17
    Me.btn_up.Text = "↑"
    Me.btn_up.UseVisualStyleBackColor = True
    '
    'btn_down
    '
    Me.btn_down.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btn_down.Location = New System.Drawing.Point(697, 493)
    Me.btn_down.Name = "btn_down"
    Me.btn_down.Size = New System.Drawing.Size(27, 19)
    Me.btn_down.TabIndex = 17
    Me.btn_down.Text = "↓"
    Me.btn_down.UseVisualStyleBackColor = True
    '
    'Label10
    '
    Me.Label10.AllowDrop = True
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.Label10.Location = New System.Drawing.Point(727, 487)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(91, 13)
    Me.Label10.TabIndex = 11
    Me.Label10.Text = "Change plot order"
    '
    'tx_xhigh
    '
    Me.tx_xhigh.Location = New System.Drawing.Point(107, 114)
    Me.tx_xhigh.Name = "tx_xhigh"
    Me.tx_xhigh.Size = New System.Drawing.Size(47, 20)
    Me.tx_xhigh.TabIndex = 7
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
    Me.GroupBox1.Controls.Add(Me.q_csv)
    Me.GroupBox1.Controls.Add(Me.btn_dataCSV)
    Me.GroupBox1.Controls.Add(Me.lbl_talnum)
    Me.GroupBox1.Controls.Add(Me.Label13)
    Me.GroupBox1.Controls.Add(Me.tx_talnum)
    Me.GroupBox1.Controls.Add(Me.Label11)
    Me.GroupBox1.Controls.Add(Me.Label7)
    Me.GroupBox1.Controls.Add(Me.cbox_style)
    Me.GroupBox1.Controls.Add(Me.Label6)
    Me.GroupBox1.Controls.Add(Me.cbox_free)
    Me.GroupBox1.Controls.Add(Me.cbox_axes)
    Me.GroupBox1.Controls.Add(Me.btn_limits)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.chk_noerrbar)
    Me.GroupBox1.Controls.Add(Me.chk_nonorm)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.chk_dataCSV)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.tx_yhigh)
    Me.GroupBox1.Controls.Add(Me.tx_xhigh)
    Me.GroupBox1.Controls.Add(Me.tx_ylow)
    Me.GroupBox1.Controls.Add(Me.tx_xlow)
    Me.GroupBox1.Location = New System.Drawing.Point(7, 185)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(417, 229)
    Me.GroupBox1.TabIndex = 18
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Tally Plotting Controls"
    '
    'q_csv
    '
    Me.q_csv.AutoSize = True
    Me.q_csv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.q_csv.ForeColor = System.Drawing.Color.Blue
    Me.q_csv.Location = New System.Drawing.Point(4, 202)
    Me.q_csv.Name = "q_csv"
    Me.q_csv.Size = New System.Drawing.Size(13, 13)
    Me.q_csv.TabIndex = 13
    Me.q_csv.Text = "?"
    '
    'btn_dataCSV
    '
    Me.btn_dataCSV.Enabled = False
    Me.btn_dataCSV.Location = New System.Drawing.Point(23, 198)
    Me.btn_dataCSV.Name = "btn_dataCSV"
    Me.btn_dataCSV.Size = New System.Drawing.Size(138, 21)
    Me.btn_dataCSV.TabIndex = 16
    Me.btn_dataCSV.Text = "Create and Open .csv file"
    Me.btn_dataCSV.UseVisualStyleBackColor = True
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(294, 121)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(51, 13)
    Me.Label11.TabIndex = 10
    Me.Label11.Text = "Plot Style"
    '
    'cbox_style
    '
    Me.cbox_style.FormattingEnabled = True
    Me.cbox_style.Items.AddRange(New Object() {"hist", "bar"})
    Me.cbox_style.Location = New System.Drawing.Point(309, 137)
    Me.cbox_style.Name = "cbox_style"
    Me.cbox_style.Size = New System.Drawing.Size(78, 21)
    Me.cbox_style.TabIndex = 14
    Me.cbox_style.Text = "hist"
    '
    'chk_noerrbar
    '
    Me.chk_noerrbar.AutoSize = True
    Me.chk_noerrbar.Location = New System.Drawing.Point(257, 202)
    Me.chk_noerrbar.Name = "chk_noerrbar"
    Me.chk_noerrbar.Size = New System.Drawing.Size(155, 17)
    Me.chk_noerrbar.TabIndex = 15
    Me.chk_noerrbar.Text = "Enable NOERRBAR option"
    Me.chk_noerrbar.UseVisualStyleBackColor = True
    '
    'chk_nonorm
    '
    Me.chk_nonorm.AutoSize = True
    Me.chk_nonorm.Checked = True
    Me.chk_nonorm.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chk_nonorm.Location = New System.Drawing.Point(257, 179)
    Me.chk_nonorm.Name = "chk_nonorm"
    Me.chk_nonorm.Size = New System.Drawing.Size(143, 17)
    Me.chk_nonorm.TabIndex = 15
    Me.chk_nonorm.Text = "Enable NONORM option"
    Me.chk_nonorm.UseVisualStyleBackColor = True
    '
    'chk_dataCSV
    '
    Me.chk_dataCSV.AutoSize = True
    Me.chk_dataCSV.Location = New System.Drawing.Point(1, 179)
    Me.chk_dataCSV.Name = "chk_dataCSV"
    Me.chk_dataCSV.Size = New System.Drawing.Size(202, 17)
    Me.chk_dataCSV.TabIndex = 15
    Me.chk_dataCSV.Text = "Save plot data with PLOTPTS to files"
    Me.chk_dataCSV.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark
    Me.GroupBox2.Controls.Add(Me.btn_load)
    Me.GroupBox2.Controls.Add(Me.btn_find)
    Me.GroupBox2.Controls.Add(Me.tx_ext)
    Me.GroupBox2.Controls.Add(Me.lbl_path)
    Me.GroupBox2.Controls.Add(Me.Label9)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.tx_path)
    Me.GroupBox2.Location = New System.Drawing.Point(7, 4)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(417, 175)
    Me.GroupBox2.TabIndex = 19
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "File Listing Controls"
    '
    'btn_about
    '
    Me.btn_about.Location = New System.Drawing.Point(764, 572)
    Me.btn_about.Name = "btn_about"
    Me.btn_about.Size = New System.Drawing.Size(57, 20)
    Me.btn_about.TabIndex = 20
    Me.btn_about.Text = "About"
    Me.btn_about.UseVisualStyleBackColor = True
    '
    'btn_clear
    '
    Me.btn_clear.Location = New System.Drawing.Point(543, 4)
    Me.btn_clear.Name = "btn_clear"
    Me.btn_clear.Size = New System.Drawing.Size(115, 21)
    Me.btn_clear.TabIndex = 2
    Me.btn_clear.Text = "Clear main file list"
    Me.btn_clear.UseVisualStyleBackColor = True
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(4, 582)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(40, 13)
    Me.Label12.TabIndex = 16
    Me.Label12.Text = "Plot list"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(427, 12)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(61, 13)
    Me.Label15.TabIndex = 16
    Me.Label15.Text = "Main file list"
    '
    'q_data
    '
    Me.q_data.AutoSize = True
    Me.q_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.q_data.ForeColor = System.Drawing.Color.Blue
    Me.q_data.Location = New System.Drawing.Point(804, 543)
    Me.q_data.Name = "q_data"
    Me.q_data.Size = New System.Drawing.Size(13, 13)
    Me.q_data.TabIndex = 13
    Me.q_data.Text = "?"
    '
    'q_manual
    '
    Me.q_manual.AutoSize = True
    Me.q_manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.q_manual.ForeColor = System.Drawing.Color.Blue
    Me.q_manual.Location = New System.Drawing.Point(111, 438)
    Me.q_manual.Name = "q_manual"
    Me.q_manual.Size = New System.Drawing.Size(13, 13)
    Me.q_manual.TabIndex = 13
    Me.q_manual.Text = "?"
    '
    'q_move
    '
    Me.q_move.AutoSize = True
    Me.q_move.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.q_move.ForeColor = System.Drawing.Color.Blue
    Me.q_move.Location = New System.Drawing.Point(361, 475)
    Me.q_move.Name = "q_move"
    Me.q_move.Size = New System.Drawing.Size(13, 13)
    Me.q_move.TabIndex = 21
    Me.q_move.Text = "?"
    '
    'CheckBox2
    '
    Me.CheckBox2.AutoSize = True
    Me.CheckBox2.Location = New System.Drawing.Point(167, 420)
    Me.CheckBox2.Name = "CheckBox2"
    Me.CheckBox2.Size = New System.Drawing.Size(120, 30)
    Me.CheckBox2.TabIndex = 15
    Me.CheckBox2.Text = "Check to end batch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "script with PAUSE"
    Me.CheckBox2.UseVisualStyleBackColor = True
    '
    'PlotterForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(821, 594)
    Me.Controls.Add(Me.q_manual)
    Me.Controls.Add(Me.q_data)
    Me.Controls.Add(Me.Label15)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.btn_about)
    Me.Controls.Add(Me.btn_clear)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.btn_down)
    Me.Controls.Add(Me.btn_up)
    Me.Controls.Add(Me.lbl_needfiles)
    Me.Controls.Add(Me.btn_make)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.btn_data)
    Me.Controls.Add(Me.CheckBox2)
    Me.Controls.Add(Me.CheckBox1)
    Me.Controls.Add(Me.btn_right)
    Me.Controls.Add(Me.btn_left)
    Me.Controls.Add(Me.box_plot)
    Me.Controls.Add(Me.box_files)
    Me.Controls.Add(Me.q_move)
    Me.Name = "PlotterForm"
    Me.Text = "Set up tally plotting"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents box_files As System.Windows.Forms.ListBox
  Friend WithEvents box_plot As System.Windows.Forms.ListBox
  Friend WithEvents btn_left As System.Windows.Forms.Button
  Friend WithEvents btn_right As System.Windows.Forms.Button
  Friend WithEvents tx_path As System.Windows.Forms.TextBox
  Friend WithEvents tx_xlow As System.Windows.Forms.TextBox
  Friend WithEvents tx_ylow As System.Windows.Forms.TextBox
  Friend WithEvents tx_yhigh As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents btn_limits As System.Windows.Forms.Button
  Friend WithEvents cbox_axes As System.Windows.Forms.ComboBox
  Friend WithEvents cbox_free As System.Windows.Forms.ComboBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents btn_data As System.Windows.Forms.Button
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents lbl_path As System.Windows.Forms.Label
  Friend WithEvents tx_ext As System.Windows.Forms.TextBox
  Friend WithEvents tx_talnum As System.Windows.Forms.TextBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents btn_find As System.Windows.Forms.Button
  Friend WithEvents btn_load As System.Windows.Forms.Button
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents btn_make As System.Windows.Forms.Button
  Friend WithEvents lbl_needfiles As System.Windows.Forms.Label
  Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents lbl_talnum As System.Windows.Forms.Label
  Friend WithEvents btn_up As System.Windows.Forms.Button
  Friend WithEvents btn_down As System.Windows.Forms.Button
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents tx_xhigh As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents cbox_style As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btn_about As System.Windows.Forms.Button
  Friend WithEvents chk_nonorm As System.Windows.Forms.CheckBox
  Friend WithEvents btn_clear As System.Windows.Forms.Button
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents chk_noerrbar As System.Windows.Forms.CheckBox
  Friend WithEvents btn_dataCSV As System.Windows.Forms.Button
  Friend WithEvents chk_dataCSV As System.Windows.Forms.CheckBox
  Friend WithEvents q_csv As System.Windows.Forms.Label
  Friend WithEvents q_data As System.Windows.Forms.Label
  Friend WithEvents q_manual As System.Windows.Forms.Label
  Friend WithEvents q_move As System.Windows.Forms.Label
  Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox

End Class

Imports System.IO



Public Class PlotterForm

  Public PlotCounter As Integer
  Public PLOTPTSCounter As Integer = 0 ' Stores the number of coplotted histories that are currently saved together in the TempData.CSV file

  Private AboutWindow As New About

  Private Sub btn_limits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limits.Click
    'Method sets default values of plotting limits.
    '--EJR°¿°
    tx_xlow.Text = "1E-4"
    tx_xhigh.Text = "1E+13"
    tx_ylow.Text = "1E-18"
    tx_yhigh.Text = "1E-9"
  End Sub

  Private Sub btn_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_data.Click
    If box_plot.Items.Count > 0 Then
      If box_plot.SelectedIndex >= 0 Then
        Call Shell("write """ & box_plot.Items(box_plot.SelectedIndex) & """", vbNormalFocus)
      End If
    End If
  End Sub

  Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
    '--EJR°¿°
    If Dir(tx_path.Text) <> "" Then
      FolderBrowserDialog1.SelectedPath = tx_path.Text
    End If
    FolderBrowserDialog1.ShowDialog()
    tx_path.Text = FolderBrowserDialog1.SelectedPath & "\"
    box_files.Items.Clear()
    Call LoadFileNames()
  End Sub

  Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
    Call LoadFileNames()
  End Sub

  Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
    box_files.Items.Clear()
  End Sub

  Public Sub LoadFileNames()
    '--EJRº¿º
    Dim cnt As Integer
    Dim FileList() As Object
    Dim NextFile As Object
    cnt = 1 'Used??
    NextFile = Dir(tx_path.Text & tx_ext.Text)
    Do While NextFile <> "" 'And cnt < 10
      ReDim Preserve FileList(cnt)
      FileList(cnt) = NextFile
      box_files.Items.Add(NextFile)
      NextFile = Dir()
      'MsgBox NextFile
      cnt = cnt + 1
    Loop
    'ListBox1.List() = FileList
  End Sub

  Private Sub btn_left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_left.Click
    Dim tempIndex As Integer
    If box_files.Items.Count > 0 Then
      If box_files.SelectedIndex >= 0 Then
        tempIndex = box_files.SelectedIndex 'stores the index position because it's not working....
        box_plot.Items.Add(tx_path.Text & box_files.Items(box_files.SelectedIndex))
        box_files.Items.Remove(box_files.Items(box_files.SelectedIndex))
        lbl_needfiles.Enabled = False
        If tempIndex > box_files.Items.Count - 1 Then
          box_files.SelectedIndex = box_files.Items.Count - 1
        Else
          box_files.SelectedIndex = tempIndex
        End If

      End If
    End If
  End Sub

  Private Sub btn_right_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_right.Click
    'Removing FROM plot list
    Dim tempIndex As Integer
    If box_plot.Items.Count > 0 Then
      If box_plot.SelectedIndex >= 0 Then
        tempIndex = box_plot.SelectedIndex 'stores the index position because it's not working....
        If Mid(box_plot.Items(box_plot.SelectedIndex), 1, Len(tx_path.Text)) = tx_path.Text Then
          box_files.Items.Add(Mid(box_plot.Items(box_plot.SelectedIndex), Len(tx_path.Text) + 1))
        End If
        '  ListBox1.AddItem (ListBox2.List(ListBox2.listIndex))
        box_plot.Items.Remove(box_plot.Items(box_plot.SelectedIndex))
        ' box_plot.SelectedIndex = tempIndex
        If tempIndex > box_plot.Items.Count - 1 Then
          box_plot.SelectedIndex = box_plot.Items.Count - 1
        Else
          box_plot.SelectedIndex = tempIndex
        End If
      End If
    End If
  End Sub

  Private Sub btn_make_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_make.Click
    If IsNumeric(tx_talnum.Text) Then
      lbl_talnum.Enabled = False
      Call TallyPlotter()
    Else
      lbl_talnum.Enabled = True
    End If
  End Sub

  Private Sub TallyPlotter()
    '
    '--EJRº¿º
    Dim tallyFiles() As Object

    Dim RootDir As String
    Dim maxNumTallies As Integer
    Dim cnt As Integer
    'Dim PlotCounter As Integer

    Dim tallyID As String
    Dim talString As String
    Dim freeVar As String
    '
    'CoplotTalliesForm.Show
    'Set variables from form
    tallyID = tx_talnum.Text
    RootDir = tx_path.Text
    'Increment PlotCounter to allow multiple COM files/plots at same time
    PlotCounter = PlotCounter + 1
    '
    freeVar = cbox_free.Text
    maxNumTallies = 6 'beyond 6, the line styles start repeating in mcplot
    '
    If box_plot.Items.Count > 0 Then

      cnt = 0
      ReDim Preserve tallyFiles(0 To cnt)
      'Now list the tally file locations in tallyFiles
      Do While cnt < maxNumTallies And cnt < box_plot.Items.Count '""
        ReDim Preserve tallyFiles(0 To cnt)
        tallyFiles(cnt) = box_plot.Items(cnt)
        Do While InStr(1, tallyFiles(cnt), "\")
          tallyFiles(cnt) = Mid(tallyFiles(cnt), InStr(1, tallyFiles(cnt), "\") + 1)
        Loop
        cnt = cnt + 1
      Loop
      'Check for existence of folder C:\YouCanDeleteMe_TalliesPlotter and creates it if it doesn't exist
      If Dir("C:\YouCanDeleteMe_TalliesPlotter", vbDirectory) = "" Then
        MkDir("C:\YouCanDeleteMe_TalliesPlotter")
      End If
      'Create batch file for making copies of all MCTAL files into C:\YouCanDeleteMe_TalliesPlotter
      'Open "C:\YouCanDeleteMe_TalliesPlotter.bat" For Output As #1
      Using sr As New StreamWriter("C:\YouCanDeleteMe_TalliesPlotter\CopyMCTALs.bat")
        For cnt = 0 To UBound(tallyFiles)
          sr.WriteLine("Copy """ & box_plot.Items(cnt) & """ ""C:\YouCanDeleteMe_TalliesPlotter\" & cnt & tallyFiles(cnt) & """")
          'Print #1, "Pause"  'useful for debugging batch file
        Next cnt
        'Close #1
        'sr.Close()
      End Using
      'Run file copying batch file
      Dir("C:\YouCanDeleteMe_TalliesPlotter\CopyMCTALs.bat")
      Call Shell("C:\YouCanDeleteMe_TalliesPlotter\CopyMCTALs.bat", , True)
      'Open RootDir & "PlotCom" & PlotCounter & ".com" For Output As #1
      'Create com file for plotting in C:\YouCanDeleteMe_TalliesPlotter
      Using sr As New StreamWriter("C:\YouCanDeleteMe_TalliesPlotter\" & "PlotCom" & PlotCounter & ".com")

        'Print the tally files with the COP command to the COM file
        'This initial set of rm commands is because some (my) versions of MCNPX need to have a .m file loaded
        ' before settings can be changed...
        For cnt = 0 To UBound(tallyFiles)
          talString = "rm " & cnt & tallyFiles(cnt) & " tal " & tallyID
          If cnt <> UBound(tallyFiles) Then
            talString = talString & " cop"
          End If
          sr.WriteLine(talString)
        Next

        sr.WriteLine("free " & freeVar)
        sr.WriteLine(cbox_style.Text)
        sr.WriteLine(cbox_axes.Text)

        'Write the nonorm command to the COM file if checkbox was selected by user
        If chk_nonorm.Checked Then
          sr.WriteLine("nonorm")
        End If

        'Write the noerrbar command to the COM file if checkbox was selected by user
        If chk_noerrbar.Checked Then
          sr.WriteLine("noerrbar")
        End If

        'If both x limits are non zero, use the values as parameter for the xlims command in the COM file
        If tx_xlow.Text <> "" And tx_xhigh.Text <> "" Then
          sr.WriteLine("xlims " & tx_xlow.Text & " " & tx_xhigh.Text)
        End If

        'If both y limits are non zero, use the values as parameter for the ylims command in the COM file
        If tx_ylow.Text <> "" And tx_yhigh.Text <> "" Then
          sr.WriteLine("ylims " & tx_ylow.Text & " " & tx_yhigh.Text)
        End If

        'If user wants to print data to .csv file for external viewing... Note all plot formatting should be done before this.
        If chk_dataCSV.Checked Then
          For cnt = 0 To UBound(tallyFiles)
            talString = "rm " & cnt & tallyFiles(cnt) & " tal " & tallyID
            sr.WriteLine(talString)
            sr.WriteLine("printpts savedPts" & cnt)
          Next

          PLOTPTSCounter = UBound(tallyFiles) + 1
        End If

        'Print the tally files with the COP command to the COM file
        'This repetition is required for any coplots to show
        For cnt = 0 To UBound(tallyFiles)
          talString = "rm " & cnt & tallyFiles(cnt) & " tal " & tallyID
          If cnt <> UBound(tallyFiles) Then
            talString = talString & " cop"
          End If
          sr.WriteLine(talString)
        Next

        'Do not add any MCPLOT commands after the above for loop

        'If the user did not choose manual control, MCPlot will close after a single keypress
        If CheckBox1.Checked = True Then
          sr.WriteLine("Pause")
          sr.WriteLine("End")
        End If

        'sr.Close()  'not necessary when using "Using sr"?
      End Using

      'Create batch file to call mcnpx in C:\YouCanDeleteMe_TalliesPlotter
      'Open "C:\YouCanDeleteMe_TalliesPlotter\" & "PlotBatch" & PlotCounter & ".bat" For Output As #1
      Using sr As New StreamWriter("C:\YouCanDeleteMe_TalliesPlotter\" & "PlotBatch" & PlotCounter & ".bat")
        'Beggining of batch file
        sr.WriteLine("title Tally Plotter " & PlotCounter)
        sr.WriteLine("cd " & "C:\YouCanDeleteMe_TalliesPlotter\")

        If chk_dataCSV.Checked Then
          sr.WriteLine("del savedPts*") 'remove the files generated by printpts.
        End If

        sr.WriteLine("del NPlotFiles*") 'remove prexisting MCPLOT/MCNPX generated files using the name NPlotFiles

        sr.WriteLine("mcnpx z com=PlotCom" & PlotCounter & ".com n=NPlotFiles") 'run mcnpx/MCPLOT

        'After the mcnpx instance has finished running...
        sr.WriteLine("del NPlotFiles*")

        'Useful for debugging batch file
        If CheckBox2.Checked = True Then
          sr.WriteLine("Pause")
        End If

        'End of batch file
      End Using

      'Run batch file
      Call Shell("C:\YouCanDeleteMe_TalliesPlotter\" & "PlotBatch" & PlotCounter & ".bat", vbNormalFocus)
    Else
      lbl_needfiles.Enabled = True
    End If

    'If Not (myFile = "") Then  'If myFile does NOT containa  blank string
    '  Try
    '    ' Create an instance of StreamReader to read from a file.
    '    ' The using statement also closes the StreamReader.
    '    Using sr As New StreamWriter(myFile)
    '      sr.WriteLine("#EXTM3U")

    '      For Each myFileLine As String In NeedBox.Items
    '        sr.WriteLine(myFileLine)
    '      Next
    '    End Using
    '  Catch mye As Exception
    '    ' Let the user know what went wrong.
    '    Console.WriteLine("The file could not be read:")
    '    Console.WriteLine(mye.Message)
    '  End Try
    'End If
    PlotCounter = PlotCounter + 1
  End Sub

  Private Sub btn_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_up.Click
    If box_plot.SelectedIndex >= 0 Then
      'From: http://www.xtremevbtalk.com/archive/index.php/t-180834.html
      Dim Temp As String
      If box_plot.SelectedIndex <> 0 Then
        Temp = box_plot.SelectedItem
        box_plot.Items(box_plot.SelectedIndex) = box_plot.Items(box_plot.SelectedIndex - 1)
        box_plot.Items(box_plot.SelectedIndex - 1) = Temp
        box_plot.SelectedIndex = box_plot.SelectedIndex - 1
      End If
    End If
  End Sub

  Private Sub btn_down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_down.Click
    If box_plot.SelectedIndex >= 0 Then
      'From: http://www.xtremevbtalk.com/archive/index.php/t-180834.html
      Dim Temp As String
      If box_plot.SelectedIndex <> box_plot.Items.Count - 1 Then
        Temp = box_plot.SelectedItem
        box_plot.Items(box_plot.SelectedIndex) = box_plot.Items(box_plot.SelectedIndex + 1)
        box_plot.Items(box_plot.SelectedIndex + 1) = Temp
        box_plot.SelectedIndex = box_plot.SelectedIndex + 1
      End If
    End If
  End Sub

  Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

  End Sub

  Private Sub btn_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_about.Click
    'Button opens the About window

    'If statement ensures that only one About window shows up.
    If Not AboutWindow.Visible Then
      AboutWindow = New About
      AboutWindow.Show()
    Else
      AboutWindow.Activate() 'make active window.
    End If
  End Sub

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Private Sub chk_dataCSV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_dataCSV.CheckStateChanged
    'When checkbox is not checked, the button btn_data cannot be clicked.
    If chk_dataCSV.Checked Then
      btn_dataCSV.Enabled = True
    Else
      btn_dataCSV.Enabled = False
    End If
  End Sub

  Public Function Read_PRINTPTS_File(ByVal filename As String) As Object
    'Method reads the data in a PRINTPTS output file of any length and returns an array of values
    Dim StringList() As String
    Dim ValueList(1, 1) As String
    Dim cnt As Integer 'Counter variable
    Dim i As Integer 'Iterating counter variable

    cnt = 0

    ReDim StringList(0 To 0)
    ReDim ValueList(0 To 1, 0 To 1)

    Try
      ' Create an instance of StreamReader to read from a file.
      ' The using statement also closes the StreamReader.
      Using sr As New StreamReader(filename)

        Dim line As String
        ' Read and display lines from the file until the end of the file is reached.
        Do
          line = sr.ReadLine()
          ReDim Preserve StringList(0 To cnt)
          StringList(cnt) = line
          cnt = cnt + 1
        Loop Until line Is Nothing
        'Note that cnt now = # of lines in file

        sr.Close() 'IS THIS NECESSARY? What if I don't do this??
      End Using

    Catch mye As Exception
      ' Let the user know what went wrong.
      Console.WriteLine("The file could not be read:")
      Console.WriteLine(mye.Message)
    End Try

    ReDim ValueList(0 To cnt - 1 - 6, 0 To 1)

    'First line is index zero. Last line is index cnt - 1
    For i = 5 To cnt - 2
      ValueList(i - 5, 0) = Mid(StringList(i), 10, 16)
      ValueList(i - 5, 1) = Mid(StringList(i), 35, 16)

    Next

    Return ValueList
  End Function

  Private Sub btn_dataCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dataCSV.Click
    '
    Dim i As Integer

    Dim csvOutputLocation As String
    Dim LineToPrint As String
    Dim holderMax As Integer

    Dim CombinedValueList(0 To 10000, 0) As String ' String array is meant to hold adjacent columns of plotting data.
    Dim holder As Object

    csvOutputLocation = "C:\YouCanDeleteMe_TalliesPlotter\PlotData.csv"
    holderMax = 0

    If PLOTPTSCounter > 0 Then
      For i = 0 To PLOTPTSCounter - 1
        holder = Read_PRINTPTS_File("C:\YouCanDeleteMe_TalliesPlotter\savedPts" & i)

        If holderMax < UBound(holder, 1) Then
          holderMax = UBound(holder, 1)
        End If

        ReDim Preserve CombinedValueList(0 To 10000, 0 To (2 * i) + 1)

        For j = 0 To UBound(holder, 1)
          'Copy values in holder to correct "column" in CombinedValueList
          CombinedValueList(j, (2 * i)) = holder(j, 0)
          CombinedValueList(j, (2 * i) + 1) = holder(j, 1)
        Next

      Next


      Try
        Using sw As New StreamWriter("C:\YouCanDeleteMe_TalliesPlotter\PlotData.csv")
          For i = 0 To holderMax
            LineToPrint = ""
            For j = 0 To UBound(CombinedValueList, 2) 'or (2 * PLOTPTSCounter) - 1
              LineToPrint = LineToPrint & CombinedValueList(i, j) & ","
            Next
            sw.WriteLine(LineToPrint)
          Next
          sw.Close() 'IS THIS NECESSARY? What if I don't do this??
        End Using

      Catch mye As Exception
        ' Let the user know what went wrong.
        Console.WriteLine("The file could not be read:")
        Console.WriteLine(mye.Message)
      End Try

      Call Shell("write """ & csvOutputLocation & """", vbNormalFocus)

    Else
      MsgBox("No files have been created with the PRINTPTS command, so no .csv files can be generated.")
    End If
  End Sub

  Private Sub q_csv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles q_csv.Click
    MsgBox("Checking this box will instruct MCNPX to write the plot points being plotted to files " & _
           "using the PLOTPTS command.  This will occur the next time 'Make Tally Plot' is clicked." & Environment.NewLine & _
           "Clicking the 'Create and Open .csv File' will combine the files created with PLOTPTS into a .csv " & _
           "file (PlotData.csv) and then open the file in wordpad.  You can then save this data to another location.")
  End Sub

  Private Sub q_manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles q_manual.Click
    MsgBox("By unchecking this box, you can manipulate MCPLOT with the command line.  " & Environment.NewLine & "Otherwise " & _
           "the command line window will close when the plot is closed or the return key is pressed")
  End Sub

  Private Sub q_move_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles q_move.Click
    MsgBox("These buttons move filenames between the two boxes. " & Environment.NewLine & _
          "The '<<' button moves the selected filename in the top box to the lower box. " & Environment.NewLine & _
          "The '>>'button moves the selected filename in the bottom box to the upper box.")
  End Sub

  Private Sub q_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles q_data.Click
    MsgBox("The 'Show Tally Data' button will open the file that is selected in the lower left box.")
  End Sub

End Class

Imports System.IO
Public Class TESTDLL
    Dim NameFile As String = "value.txt"
    Dim PathLoc As String = "C:\Users\KQ\Documents\Visual Studio 2015\Projects\GMed-PM01\" + NameFile
    Private Sub TESTDLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main()
    End Sub
    Sub Main()
        ' Store the line in this String.
        Dim line As String
        Dim FilePath As String = PathLoc
        ' Create new StreamReader instance with Using block.
        Using reader As StreamReader = New StreamReader(FilePath)
            ' Read one line from file
            line = reader.ReadLine
        End Using

        ' Write the line we read from "file.txt"
        Console.WriteLine(line)
        MsgBox(line)
    End Sub

End Class
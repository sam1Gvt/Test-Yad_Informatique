Imports System.Text

Public Class Form1
    Private Sub boutonVueCSV_Click(sender As Object, e As EventArgs) Handles boutonVueCSV.Click
        Dim fichierCSV As String = "C:\Users\Andre\Desktop\pointage.csv"
        Dim ligneCSV As String = ""
        Dim SplitLine() As String

        ' Si le fichier CSV existe 
        If System.IO.File.Exists(fichierCSV) = True Then
            ' Lecture
            Using objReader As New System.IO.StreamReader(fichierCSV, Encoding.ASCII)

                ' Determiner le nombre de colonne du fichier
                Dim columns = objReader.ReadLine.Split(",").Count()
                ' ajouter les colonnes a la grille
                For index As Integer = 1 To columns
                    Dim col As New DataGridViewTextBoxColumn
                    DataGridViewCSV.Columns.Add(col)
                Next


                ' Inserer chaque ligne dans la grille
                Do While objReader.Peek() <> -1
                    ' recuperer la ligne
                    ligneCSV = objReader.ReadLine()
                    ' la decouper par blocks de virgule
                    SplitLine = Split(ligneCSV, ",")
                    ' l'ajouter
                    DataGridViewCSV.Rows.Add(SplitLine)
                Loop
            End Using
        Else
            MessageBox.Show("Erreur : le fichier n'existe pas")
        End If

    End Sub

End Class

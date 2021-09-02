' Name:         Canton Solution
' Purpose:      Display Depreciation Schedules
' Programmer:   <Jhonniel Ygay> on <Sep 14,2020>


Option Explicit On
Option Strict On
Option Infer Off


Public Class Form1
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intUseful As Integer = 3 To 20
            lstUseful.Items.Add(intUseful.ToString)
        Next intUseful
        lstUseful.SelectedItem = "3"

    End Sub

    Private Sub btnDisplayDep_Click(sender As Object, e As EventArgs) Handles btnDisplayDep.Click
        Dim intAsset, intSalvage, intUseful As Integer
        Dim dblDouble, dblSum As Double

        Integer.TryParse(txtAsset.Text, intAsset)
        Integer.TryParse(txtSalvage.Text, intSalvage)
        Integer.TryParse(lstUseful.SelectedItem.ToString, intUseful)
        lblDoubleD.Text = "Year      Depreciation" &
            ControlChars.NewLine
        lblSum.Text = "Year      Depreciation" &
            ControlChars.NewLine

        For IntYear As Integer = 1 To intUseful
            dblDouble = Financial.DDB(intAsset, intSalvage, intUseful, IntYear)
            dblSum = Financial.SYD(intAsset, intSalvage, intUseful, IntYear)
            lblDoubleD.Text = lblDoubleD.Text & IntYear.ToString & Space(12) & dblDouble.ToString("N2") &
                ControlChars.NewLine
            lblSum.Text = lblSum.Text & IntYear.ToString & Space(12) & dblSum.ToString("N2") &
               ControlChars.NewLine
        Next IntYear
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub txtAsset_Enter(sender As Object, e As EventArgs) Handles txtAsset.Enter
        txtAsset.SelectAll()
    End Sub
    Private Sub txtAsset_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAsset.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtSalvage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalvage.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If

    End Sub
End Class

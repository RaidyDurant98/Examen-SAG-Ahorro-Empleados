﻿Public Class MenuPrincipalForm

    Private RegistroPlanAhorros As AhorrosEmpleados.PlanAhorrosForm
    Private RegistroEmpleados As AhorrosEmpleados.EmpleadosForm
    Private ConsultaPlanAhorros As AhorrosEmpleados.PlanAhorrosConsulta
    Private AfiliacionEmpleados As AhorrosEmpleados.AfiliacionEmpleadosForm

    Private Sub PlanAhorrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanAhorrosToolStripMenuItem.Click

        If RegistroPlanAhorros IsNot Nothing Then
            RegistroPlanAhorros.Close()
        End If


        RegistroPlanAhorros = New AhorrosEmpleados.PlanAhorrosForm
        RegistroPLanAhorros.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click

        If RegistroEmpleados IsNot Nothing Then
            RegistroEmpleados.Close()
        End If


        RegistroEmpleados = New AhorrosEmpleados.EmpleadosForm
        RegistroEmpleados.Show()
    End Sub

    Private Sub PlanAhorrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlanAhorrosToolStripMenuItem1.Click

        If ConsultaPlanAhorros IsNot Nothing Then
            ConsultaPlanAhorros.Close()
        End If


        ConsultaPlanAhorros = New AhorrosEmpleados.PlanAhorrosConsulta
        ConsultaPlanAhorros.Show()
    End Sub

    Private Sub AfiliacionEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfiliacionEmpleadosToolStripMenuItem.Click

        If AfiliacionEmpleados IsNot Nothing Then
            AfiliacionEmpleados.Close()
        End If


        AfiliacionEmpleados = New AhorrosEmpleados.AfiliacionEmpleadosForm
        AfiliacionEmpleados.Show()
    End Sub
End Class
﻿Imports DAL
Imports Entidades

Public Class EmpleadosBLL

    Public Shared Function Guardar(ByVal empleado As Empleados) As Boolean

        Using conexion As New Coneccion()

            If empleado.EmpleadoId = 0 Then
                If conexion.EjecutarComando("Insert into Empleados(Nombres, Direccion, NumCel, Sueldo, PLanAhorro) Values('" & empleado.Nombres & "' , '" & empleado.Direccion & "' , '" & empleado.NumCel & "' , '" & empleado.Sueldo & "' , '" & empleado.PlanAhorro & "');") > 0 Then
                    Return True
                End If
            Else
                Modificar(empleado)
                Return True
            End If
        End Using
        Return False

    End Function

    Public Shared Function Buscar(ByVal id As Integer) As Empleados

        Dim empleado = New Empleados()

        Using coneccion As New Coneccion()

            Dim dt = coneccion.SeleccionarDatos("Select * from Empleados where EmpleadoId =" & id & ";")

            If dt.Rows.Count > 0 Then
                empleado.EmpleadoId = dt.Rows(0)("EmpleadoId")
                empleado.Nombres = dt.Rows(0)("Nombres")
                empleado.Direccion = dt.Rows(0)("Direccion")
                empleado.NumCel = dt.Rows(0)("NumCel")
                empleado.Sueldo = dt.Rows(0)("Sueldo")
                empleado.PlanAhorro = dt.Rows(0)("PlanAhorro")
            End If

            If empleado IsNot Nothing Then
                Return empleado
            End If

        End Using

        Return Nothing

    End Function

    Public Shared Function Eliminar(ByVal id As Integer) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Delete from Empleados where EmpleadoId =" & id & ";") > 0 Then

                Return True
            End If

        End Using

        Return False
    End Function

    Public Shared Function Modificar(ByVal empleado As Empleados) As Boolean

        Using coneccion As New Coneccion()

            If coneccion.EjecutarComando("Update Empleados set Nombres = '" & empleado.Nombres & "', Direccion = '" & empleado.Direccion & "', NumCel = '" & empleado.NumCel & "', Sueldo = '" & empleado.Sueldo & "', PlanAhorro = '" & empleado.PlanAhorro & "' where EmpleadoId = '" & empleado.EmpleadoId & "'") Then
                Return True
            End If

        End Using

        Return False
    End Function

End Class

﻿
Public Class cls_TrainingCadres
    Dim db As New Hrms3.hrms3dbDataContext
    Public Function Delete(ByVal ID As String) As ResponseInfo
        Try
            Dim row As Hrms3.TrainingCadre = (From B In db.TrainingCadres Where B.Code = ID).ToList()(0)
            db.TrainingCadres.DeleteOnSubmit(row)
            db.SubmitChanges()
            Return mod_main._GetResponseStruct(ErrCodeEnum.NO_ERROR, 1, 0)
        Catch ex As Exception
            Return mod_main._GetResponseStruct(ErrCodeEnum.GENERIC_ERROR, , , ex.Message)
        End Try
    End Function

    Public Function Insert(ByVal G As Hrms3.TrainingCadre) As ResponseInfo
        Try
            db.TrainingCadres.InsertOnSubmit(G)
            db.SubmitChanges()
            Return mod_main._GetResponseStruct(ErrCodeEnum.NO_ERROR, 1, 0)
        Catch ex As Exception
            Return mod_main._GetResponseStruct(ErrCodeEnum.GENERIC_ERROR, , , ex.Message)
        End Try
    End Function

    Public Function Update(ByVal G As Hrms3.TrainingCadre) As ResponseInfo
        Try
            db.SubmitChanges()
            Return mod_main._GetResponseStruct(ErrCodeEnum.NO_ERROR, 1, 0)
        Catch ex As Exception
            Return mod_main._GetResponseStruct(ErrCodeEnum.GENERIC_ERROR, , , ex.Message)
        End Try
    End Function
    Public Function SelectThis(ByVal ID As String) As Hrms3.TrainingCadre
        Try
            Return (From B In db.TrainingCadres Where B.Code = ID).ToList()(0)
        Catch ex As Exception
            Return New Hrms3.TrainingCadre
        End Try
    End Function
    Public Function SelectAll() As List(Of Hrms3.TrainingCadre)
        Try
            Return (From P In db.TrainingCadres Order By P.Code).ToList()
        Catch ex As Exception
            Return New List(Of Hrms3.TrainingCadre)
        End Try
    End Function
End Class

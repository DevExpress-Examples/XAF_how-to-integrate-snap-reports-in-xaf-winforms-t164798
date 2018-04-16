﻿Namespace SnapExampleEF.Win
    Partial Public Class SnapExampleEFWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.snapModule1 = New SnapModule.SnapModule()
            Me.snapExampleEFModule1 = New SnapExampleEF.SnapExampleEFModule()
            Me.validationWindowsFormsModule1 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
            Me.validationModule1 = New DevExpress.ExpressApp.Validation.ValidationModule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' snapModule1
            ' 
            Me.snapModule1.DocumentDataType = GetType(SnapExampleEF.BusinessObjects.DocumentData)
            ' 
            ' validationModule1
            ' 
            Me.validationModule1.AllowValidationDetailsAccess = True
            Me.validationModule1.IgnoreWarningAndInformationRules = False
            ' 
            ' SnapExampleEFWindowsFormsApplication
            ' 
            Me.ApplicationName = "SnapExampleEF"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.snapModule1)
            Me.Modules.Add(Me.snapExampleEFModule1)
            Me.Modules.Add(Me.validationModule1)
            Me.Modules.Add(Me.validationWindowsFormsModule1)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private snapModule1 As SnapModule.SnapModule
        Private snapExampleEFModule1 As SnapExampleEF.SnapExampleEFModule
        Private validationWindowsFormsModule1 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
        Private validationModule1 As DevExpress.ExpressApp.Validation.ValidationModule
    End Class
End Namespace

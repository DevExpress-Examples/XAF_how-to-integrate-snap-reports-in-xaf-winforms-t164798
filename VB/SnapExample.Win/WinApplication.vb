﻿Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Win

Namespace SnapExampleXPO.Win
    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWinWinApplicationMembersTopicAll
    Partial Public Class SnapExampleWindowsFormsApplication
        Inherits WinApplication

        Public Sub New()
            InitializeComponent()
            UseOldTemplates = False
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProviders.Add(New XPObjectSpaceProvider(args.ConnectionString, args.Connection))
            args.ObjectSpaceProviders.Add(New NonPersistentObjectSpaceProvider())
        End Sub
        Private Sub SnapExampleWindowsFormsApplication_CustomizeLanguagesList(ByVal sender As Object, ByVal e As CustomizeLanguagesListEventArgs) Handles MyBase.CustomizeLanguagesList
            Dim userLanguageName As String = System.Threading.Thread.CurrentThread.CurrentUICulture.Name
            If userLanguageName <> "en-US" AndAlso e.Languages.IndexOf(userLanguageName) = -1 Then
                e.Languages.Add(userLanguageName)
            End If
        End Sub
        Private Sub SnapExampleWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
#If EASYTEST Then
            e.Updater.Update()
            e.Handled = True
#Else
            If System.Diagnostics.Debugger.IsAttached Then
                e.Updater.Update()
                e.Handled = True
            Else
                Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & ControlChars.CrLf & "This error occurred  because the automatic database update was disabled when the application was started without debugging." & ControlChars.CrLf & "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool." & ControlChars.CrLf & "Anyway, refer to the 'Update Application and Database Versions' help topic at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument2795.htm " & "for more detailed information. If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/")
            End If
#End If
        End Sub
    End Class
End Namespace

'CODE FROM https://brutaldev.com/post/checking-if-the-workstation-is-locked
'Thanks to Werner van Deventer
Imports System.Runtime.InteropServices
Public Class DetectLockState
    <DllImport("user32", EntryPoint:="OpenDesktopA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Private Shared Function OpenDesktop(lpszDesktop As String, dwFlags As Int32, fInherit As Boolean, dwDesiredAccess As Int32) As Int32
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Private Shared Function CloseDesktop(hDesktop As Int32) As Int32
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Private Shared Function SwitchDesktop(hDesktop As Int32) As Int32
    End Function

    Public Shared Function IsWorkstationLocked() As Boolean
        Const DESKTOP_SWITCHDESKTOP As Integer = 256
        Dim hwnd As Integer = -1
        Dim rtn As Integer = -1

        hwnd = OpenDesktop("Default", 0, False, DESKTOP_SWITCHDESKTOP)

        If hwnd <> 0 Then
            rtn = SwitchDesktop(hwnd)
            If rtn = 0 Then
                ' Locked
                CloseDesktop(hwnd)
                Return True
            Else
                ' Not locked
                CloseDesktop(hwnd)
            End If
            ' Error: "Could not access the desktop..."
        Else
        End If
        Return False
    End Function

End Class

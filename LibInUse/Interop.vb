Imports System.Runtime.InteropServices

Public Module Interop

    <StructLayout(LayoutKind.Sequential)>
    Public Structure Kbdllhookstruct
        Public ReadOnly key As Keys
        Public ReadOnly scanCode As Integer
        Public ReadOnly flags As Integer
        Public ReadOnly time As Integer
        Public ReadOnly extra As IntPtr
    End Structure

    Public Delegate Function LowLevelKeyboardProc(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function SetWindowsHookEx(id As Integer, callback As LowLevelKeyboardProc, hMod As IntPtr, dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function UnhookWindowsHookEx(hook As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function CallNextHookEx(hook As IntPtr, nCode As Integer, wp As IntPtr, p As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function GetModuleHandle(name As String) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Function GetAsyncKeyState(key As Keys) As Short
    End Function

    Public _ptrHook As IntPtr

    Public _objKeyboardProcess As LowLevelKeyboardProc

    Public Function CaptureKey(nCode As Integer, wp As IntPtr, lp As IntPtr) As IntPtr
        If nCode >= 0 Then
            Dim objKeyInfo = CType(Marshal.PtrToStructure(lp, GetType(Kbdllhookstruct)), Kbdllhookstruct)

            If objKeyInfo.key = Keys.RWin OrElse objKeyInfo.key = Keys.LWin OrElse objKeyInfo.key = Keys.Tab AndAlso HasAltModifier(objKeyInfo.flags) OrElse objKeyInfo.key = Keys.Escape AndAlso (Control.ModifierKeys And Keys.Control) = Keys.Control OrElse objKeyInfo.key = Keys.F4 AndAlso HasAltModifier(objKeyInfo.flags) Then
                Return CType(1, IntPtr)
            End If
        End If

        Return CallNextHookEx(_ptrHook, nCode, wp, lp)
    End Function

    Public Function HasAltModifier(ByVal flags As Integer) As Boolean
        Return (flags And &H20) = &H20
    End Function

End Module
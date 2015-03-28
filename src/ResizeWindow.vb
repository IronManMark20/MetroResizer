Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Namespace ModernStart
	Public Class Resize
		Inherits Form
		Public Enum WindowStyles As Long
			WS_OVERLAPPED
			WS_POPUP = 2147483648L
			WS_CHILD = 1073741824L
			WS_MINIMIZE = 536870912L
			WS_VISIBLE = 268435456L
			WS_DISABLED = 134217728L
			WS_CLIPSIBLINGS = 67108864L
			WS_CLIPCHILDREN = 33554432L
			WS_MAXIMIZE = 16777216L
			WS_BORDER = 8388608L
			WS_DLGFRAME = 4194304L
			WS_VSCROLL = 2097152L
			WS_HSCROLL = 1048576L
			WS_SYSMENU = 524288L
			WS_THICKFRAME = 262144L
			WS_GROUP = 131072L
			WS_TABSTOP = 65536L
			WS_MINIMIZEBOX = 131072L
			WS_MAXIMIZEBOX = 65536L
			WS_CAPTION = 12582912L
			WS_TILED = 0L
			WS_ICONIC = 536870912L
			WS_SIZEBOX = 262144L
			WS_TILEDWINDOW = 13565952L
			WS_OVERLAPPEDWINDOW = 13565952L
			WS_POPUPWINDOW = 2156396544L
			WS_CHILDWINDOW = 1073741824L
			WS_EX_DLGMODALFRAME = 1L
			WS_EX_NOPARENTNOTIFY = 4L
			WS_EX_TOPMOST = 8L
			WS_EX_ACCEPTFILES = 16L
			WS_EX_TRANSPARENT = 32L
			WS_EX_MDICHILD = 64L
			WS_EX_TOOLWINDOW = 128L
			WS_EX_WINDOWEDGE = 256L
			WS_EX_CLIENTEDGE = 512L
			WS_EX_CONTEXTHELP = 1024L
			WS_EX_RIGHT = 4096L
			WS_EX_LEFT = 0L
			WS_EX_RTLREADING = 8192L
			WS_EX_LTRREADING = 0L
			WS_EX_LEFTSCROLLBAR = 16384L
			WS_EX_RIGHTSCROLLBAR = 0L
			WS_EX_CONTROLPARENT = 65536L
			WS_EX_STATICEDGE = 131072L
			WS_EX_APPWINDOW = 262144L
			WS_EX_OVERLAPPEDWINDOW = 768L
			WS_EX_PALETTEWINDOW = 392L
			WS_EX_LAYERED = 524288L
			WS_EX_NOINHERITLAYOUT = 1048576L
			WS_EX_LAYOUTRTL = 4194304L
			WS_EX_COMPOSITED = 33554432L
			WS_EX_NOACTIVATE = 67108864L
		End Enum
		Private GWL_STYLE As Integer
		Private GWL_EXSTYLE As Integer
		
		Private  Declare Ansi Function GetWindowText Lib "user32" Alias "GetWindowTextA" (hwnd As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpString As String, cch As Integer) As Integer

		Private  Declare Function WindowFromPoint Lib "user32.dll" (xPoint As Integer, yPoint As Integer) As Integer

		Public  Declare Auto Function GetForegroundWindow Lib "user32.dll" () As Integer

		Private  Declare Function GetAncestor Lib "user32.dll" (hwnd As Integer, gaFlags As UInteger) As Integer

		Public  Declare Auto Function SetParent Lib "User32" (hWndChild As IntPtr, hWndParent As IntPtr) As IntPtr

		Public  Declare Auto Function GetAsyncKeyState Lib "user32.dll" (vkey As Integer) As Short

		Private Declare Function MoveWindow Lib "user32.dll" (hWnd As IntPtr, X As Integer, Y As Integer, nWidth As Integer, nHeight As Integer, bRepaint As Boolean) As Boolean

		Public Declare Auto Function GetWindow Lib "user32" (hwnd As IntPtr, uCmd As Integer) As IntPtr

		Private Declare Auto Function FindWindow Lib "user32.dll" (lpClassName As String, lpWindowName As String) As Integer

		Private Declare Auto Function FindWindowByClass Lib "user32.dll" Alias "FindWindow" (lpClassName As String, zero As IntPtr) As IntPtr

		Private Declare Auto Function FindWindowByCaption Lib "user32.dll" Alias "FindWindow" (zero As IntPtr, lpWindowName As String) As IntPtr

		Private Declare Function FindWindowEx Lib "user32.dll" (parentHwnd As IntPtr, childAfterHwnd As IntPtr, className As IntPtr, windowText As String) As IntPtr
		
		Public Sub ResizeWindow(winhandle As Integer)
			GWL_STYLE = -16
			GWL_EXSTYLE = -20
			MoveWindow(CType(winhandle, IntPtr), 20, 20, 800, 600, True)
			Dim windowStyles As Resize.WindowStyles = CType(GetWindowLong(CType(winhandle, IntPtr), GWL_STYLE), Resize.WindowStyles)
			Dim windowStyles2 As Resize.WindowStyles = CType(GetWindowLong(CType(winhandle, IntPtr), GWL_EXSTYLE), Resize.WindowStyles)
			Dim value As Resize.WindowStyles = CType(276824064L, Resize.WindowStyles)
			Me.SetWindowLong(CType(winhandle, IntPtr), GWL_STYLE, CType((CLng(value)), IntPtr))
		End Sub

		Public Sub ResizeStartWindow(winhandle As Integer, xwidth As Integer, xheight As Integer, xtop As Integer, xleft As Integer)
			GWL_STYLE = -16
			GWL_EXSTYLE = -20
			If Not winhandle Then
				winhandle= FindWindow("ImmersiveLauncher", "Start menu")
			End If
			MoveWindow(CType(winhandle, IntPtr), xleft, xtop, xwidth, xheight, True)
			Dim windowStyles As Resize.WindowStyles = CType(GetWindowLong(CType(winhandle, IntPtr), GWL_STYLE), Resize.WindowStyles)
			Dim windowStyles2 As Resize.WindowStyles = CType(GetWindowLong(CType(winhandle, IntPtr), GWL_EXSTYLE), Resize.WindowStyles)
			Dim value As Resize.WindowStyles = CType(276824064L, Resize.WindowStyles)
			Me.SetWindowLong(CType(winhandle, IntPtr), GWL_STYLE, CType((CLng(value)), IntPtr))
		End Sub
		Private Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
			Dim result As Integer
			Return result	
		End Function

		Private Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As IntPtr) As Integer
			Dim result As Integer
			Return result
		End Function
	End Class
End Namespace
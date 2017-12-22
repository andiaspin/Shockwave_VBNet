<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxShockwaveFlash1 = New FlashControlV71.AxShockwaveFlash()
        Me.AxShockwaveFlash2 = New FlashControlV71.AxShockwaveFlash()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxShockwaveFlash2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(823, 192)
        Me.AxShockwaveFlash1.TabIndex = 0
        '
        'AxShockwaveFlash2
        '
        Me.AxShockwaveFlash2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AxShockwaveFlash2.Enabled = True
        Me.AxShockwaveFlash2.Location = New System.Drawing.Point(0, 232)
        Me.AxShockwaveFlash2.Name = "AxShockwaveFlash2"
        Me.AxShockwaveFlash2.OcxState = CType(resources.GetObject("AxShockwaveFlash2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash2.Size = New System.Drawing.Size(823, 88)
        Me.AxShockwaveFlash2.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 320)
        Me.Controls.Add(Me.AxShockwaveFlash2)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxShockwaveFlash2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxShockwaveFlash1 As FlashControlV71.AxShockwaveFlash
    Friend WithEvents AxShockwaveFlash2 As FlashControlV71.AxShockwaveFlash

End Class

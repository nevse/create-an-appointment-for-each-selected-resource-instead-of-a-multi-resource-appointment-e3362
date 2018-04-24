Namespace SchedulerMultiResAppointments
    Partial Public Class CustomAppointmentForm
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.checkAllDay = New DevExpress.XtraEditors.CheckEdit()
            Me.timeEnd = New DevExpress.XtraEditors.TimeEdit()
            Me.timeStart = New DevExpress.XtraEditors.TimeEdit()
            Me.dtEnd = New DevExpress.XtraEditors.DateEdit()
            Me.dtStart = New DevExpress.XtraEditors.DateEdit()
            Me.txPrice = New DevExpress.XtraEditors.TextEdit()
            Me.lblCustomName = New System.Windows.Forms.Label()
            Me.lblStart = New System.Windows.Forms.Label()
            Me.lblLabel = New System.Windows.Forms.Label()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.edStatus = New DevExpress.XtraScheduler.UI.AppointmentStatusEdit()
            Me.edLabel = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.txSubject = New DevExpress.XtraEditors.TextEdit()
            Me.lblSubject = New System.Windows.Forms.Label()
            Me.btnRecurrence = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
            Me.lblEnd = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.edResources = New DevExpress.XtraScheduler.UI.AppointmentResourcesEdit()
            CType(Me.checkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkAllDay
            ' 
            Me.checkAllDay.Location = New System.Drawing.Point(92, 92)
            Me.checkAllDay.Name = "checkAllDay"
            Me.checkAllDay.Properties.Caption = "All day event"
            Me.checkAllDay.Size = New System.Drawing.Size(88, 19)
            Me.checkAllDay.TabIndex = 23
            ' 
            ' timeEnd
            ' 
            Me.timeEnd.EditValue = New Date(2006, 3, 28, 0, 0, 0, 0)
            Me.timeEnd.Location = New System.Drawing.Point(206, 68)
            Me.timeEnd.Name = "timeEnd"
            Me.timeEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.timeEnd.Size = New System.Drawing.Size(80, 20)
            Me.timeEnd.TabIndex = 21
            ' 
            ' timeStart
            ' 
            Me.timeStart.EditValue = New Date(2006, 3, 28, 0, 0, 0, 0)
            Me.timeStart.Location = New System.Drawing.Point(206, 44)
            Me.timeStart.Name = "timeStart"
            Me.timeStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.timeStart.Size = New System.Drawing.Size(80, 20)
            Me.timeStart.TabIndex = 19
            ' 
            ' dtEnd
            ' 
            Me.dtEnd.EditValue = New Date(2005, 11, 25, 0, 0, 0, 0)
            Me.dtEnd.Location = New System.Drawing.Point(94, 68)
            Me.dtEnd.Name = "dtEnd"
            Me.dtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtEnd.Size = New System.Drawing.Size(96, 20)
            Me.dtEnd.TabIndex = 20
            ' 
            ' dtStart
            ' 
            Me.dtStart.EditValue = New Date(2005, 11, 25, 0, 0, 0, 0)
            Me.dtStart.Location = New System.Drawing.Point(94, 44)
            Me.dtStart.Name = "dtStart"
            Me.dtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtStart.Size = New System.Drawing.Size(96, 20)
            Me.dtStart.TabIndex = 18
            ' 
            ' txPrice
            ' 
            Me.txPrice.EditValue = ""
            Me.txPrice.Location = New System.Drawing.Point(94, 172)
            Me.txPrice.Name = "txPrice"
            Me.txPrice.Size = New System.Drawing.Size(192, 20)
            Me.txPrice.TabIndex = 26
            ' 
            ' lblCustomName
            ' 
            Me.lblCustomName.Location = New System.Drawing.Point(6, 173)
            Me.lblCustomName.Name = "lblCustomName"
            Me.lblCustomName.Size = New System.Drawing.Size(80, 19)
            Me.lblCustomName.TabIndex = 34
            Me.lblCustomName.Text = "Price:"
            ' 
            ' lblStart
            ' 
            Me.lblStart.Location = New System.Drawing.Point(6, 47)
            Me.lblStart.Name = "lblStart"
            Me.lblStart.Size = New System.Drawing.Size(56, 18)
            Me.lblStart.TabIndex = 33
            Me.lblStart.Text = "Start:"
            ' 
            ' lblLabel
            ' 
            Me.lblLabel.Location = New System.Drawing.Point(6, 140)
            Me.lblLabel.Name = "lblLabel"
            Me.lblLabel.Size = New System.Drawing.Size(48, 19)
            Me.lblLabel.TabIndex = 31
            Me.lblLabel.Text = "Label:"
            ' 
            ' lblStatus
            ' 
            Me.lblStatus.Location = New System.Drawing.Point(6, 116)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(48, 18)
            Me.lblStatus.TabIndex = 28
            Me.lblStatus.Text = "Status:"
            ' 
            ' edStatus
            ' 
            Me.edStatus.Location = New System.Drawing.Point(94, 116)
            Me.edStatus.Name = "edStatus"
            Me.edStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edStatus.Size = New System.Drawing.Size(192, 20)
            Me.edStatus.TabIndex = 24
            ' 
            ' edLabel
            ' 
            Me.edLabel.Location = New System.Drawing.Point(94, 140)
            Me.edLabel.Name = "edLabel"
            Me.edLabel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edLabel.Size = New System.Drawing.Size(192, 20)
            Me.edLabel.TabIndex = 25
            ' 
            ' txSubject
            ' 
            Me.txSubject.EditValue = ""
            Me.txSubject.Location = New System.Drawing.Point(94, 12)
            Me.txSubject.Name = "txSubject"
            Me.txSubject.Size = New System.Drawing.Size(192, 20)
            Me.txSubject.TabIndex = 17
            ' 
            ' lblSubject
            ' 
            Me.lblSubject.Location = New System.Drawing.Point(6, 13)
            Me.lblSubject.Name = "lblSubject"
            Me.lblSubject.Size = New System.Drawing.Size(48, 18)
            Me.lblSubject.TabIndex = 22
            Me.lblSubject.Text = "Subject:"
            ' 
            ' btnRecurrence
            ' 
            Me.btnRecurrence.Location = New System.Drawing.Point(206, 235)
            Me.btnRecurrence.Name = "btnRecurrence"
            Me.btnRecurrence.Size = New System.Drawing.Size(80, 27)
            Me.btnRecurrence.TabIndex = 32
            Me.btnRecurrence.Text = "Recurrence"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(105, 235)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 27)
            Me.btnCancel.TabIndex = 30
            Me.btnCancel.Text = "Cancel"
            ' 
            ' btnOK
            ' 
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(9, 235)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 27)
            Me.btnOK.TabIndex = 29
            Me.btnOK.Text = "OK"
            ' 
            ' lblEnd
            ' 
            Me.lblEnd.Location = New System.Drawing.Point(6, 71)
            Me.lblEnd.Name = "lblEnd"
            Me.lblEnd.Size = New System.Drawing.Size(48, 18)
            Me.lblEnd.TabIndex = 36
            Me.lblEnd.Text = "End:"
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(6, 203)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(80, 19)
            Me.label1.TabIndex = 37
            Me.label1.Text = "Resources:"
            ' 
            ' edResources
            ' 
            Me.edResources.Location = New System.Drawing.Point(94, 200)
            Me.edResources.Name = "edResources"
            Me.edResources.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edResources.Size = New System.Drawing.Size(192, 20)
            Me.edResources.TabIndex = 38
            ' 
            ' CustomAppointmentForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(292, 274)
            Me.Controls.Add(Me.edResources)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.lblEnd)
            Me.Controls.Add(Me.checkAllDay)
            Me.Controls.Add(Me.timeEnd)
            Me.Controls.Add(Me.timeStart)
            Me.Controls.Add(Me.dtEnd)
            Me.Controls.Add(Me.dtStart)
            Me.Controls.Add(Me.txPrice)
            Me.Controls.Add(Me.lblCustomName)
            Me.Controls.Add(Me.lblStart)
            Me.Controls.Add(Me.lblLabel)
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.edStatus)
            Me.Controls.Add(Me.edLabel)
            Me.Controls.Add(Me.txSubject)
            Me.Controls.Add(Me.lblSubject)
            Me.Controls.Add(Me.btnRecurrence)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Name = "CustomAppointmentForm"
            Me.Text = "My Appointment Form"
            CType(Me.checkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents checkAllDay As DevExpress.XtraEditors.CheckEdit
        Private WithEvents timeEnd As DevExpress.XtraEditors.TimeEdit
        Private WithEvents timeStart As DevExpress.XtraEditors.TimeEdit
        Private WithEvents dtEnd As DevExpress.XtraEditors.DateEdit
        Private WithEvents dtStart As DevExpress.XtraEditors.DateEdit
        Private txPrice As DevExpress.XtraEditors.TextEdit
        Private lblCustomName As System.Windows.Forms.Label
        Private lblStart As System.Windows.Forms.Label
        Private lblLabel As System.Windows.Forms.Label
        Private lblStatus As System.Windows.Forms.Label
        Private edStatus As DevExpress.XtraScheduler.UI.AppointmentStatusEdit
        Private edLabel As DevExpress.XtraScheduler.UI.AppointmentLabelEdit
        Private txSubject As DevExpress.XtraEditors.TextEdit
        Private lblSubject As System.Windows.Forms.Label
        Private WithEvents btnRecurrence As DevExpress.XtraEditors.SimpleButton
        Private btnCancel As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
        Private lblEnd As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private edResources As DevExpress.XtraScheduler.UI.AppointmentResourcesEdit
    End Class
End Namespace
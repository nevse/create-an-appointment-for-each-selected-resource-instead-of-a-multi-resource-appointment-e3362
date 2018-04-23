
namespace SchedulerMultiResAppointments {
    partial class CustomAppointmentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.checkAllDay = new DevExpress.XtraEditors.CheckEdit();
            this.timeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.timeStart = new DevExpress.XtraEditors.TimeEdit();
            this.dtEnd = new DevExpress.XtraEditors.DateEdit();
            this.dtStart = new DevExpress.XtraEditors.DateEdit();
            this.txPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomName = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.edStatus = new DevExpress.XtraScheduler.UI.AppointmentStatusEdit();
            this.edLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.txSubject = new DevExpress.XtraEditors.TextEdit();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnRecurrence = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblEnd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edResources = new DevExpress.XtraScheduler.UI.AppointmentResourcesEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edResources.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkAllDay
            // 
            this.checkAllDay.Location = new System.Drawing.Point(92, 92);
            this.checkAllDay.Name = "checkAllDay";
            this.checkAllDay.Properties.Caption = "All day event";
            this.checkAllDay.Size = new System.Drawing.Size(88, 19);
            this.checkAllDay.TabIndex = 23;
            this.checkAllDay.CheckedChanged += new System.EventHandler(this.checkAllDay_CheckedChanged);
            // 
            // timeEnd
            // 
            this.timeEnd.EditValue = new System.DateTime(2006, 3, 28, 0, 0, 0, 0);
            this.timeEnd.Location = new System.Drawing.Point(206, 68);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEnd.Size = new System.Drawing.Size(80, 20);
            this.timeEnd.TabIndex = 21;
            this.timeEnd.EditValueChanged += new System.EventHandler(this.timeEnd_EditValueChanged);
            // 
            // timeStart
            // 
            this.timeStart.EditValue = new System.DateTime(2006, 3, 28, 0, 0, 0, 0);
            this.timeStart.Location = new System.Drawing.Point(206, 44);
            this.timeStart.Name = "timeStart";
            this.timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeStart.Size = new System.Drawing.Size(80, 20);
            this.timeStart.TabIndex = 19;
            this.timeStart.EditValueChanged += new System.EventHandler(this.timeStart_EditValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.EditValue = new System.DateTime(2005, 11, 25, 0, 0, 0, 0);
            this.dtEnd.Location = new System.Drawing.Point(94, 68);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEnd.Size = new System.Drawing.Size(96, 20);
            this.dtEnd.TabIndex = 20;
            this.dtEnd.EditValueChanged += new System.EventHandler(this.dtEnd_EditValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.EditValue = new System.DateTime(2005, 11, 25, 0, 0, 0, 0);
            this.dtStart.Location = new System.Drawing.Point(94, 44);
            this.dtStart.Name = "dtStart";
            this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStart.Size = new System.Drawing.Size(96, 20);
            this.dtStart.TabIndex = 18;
            this.dtStart.EditValueChanged += new System.EventHandler(this.dtStart_EditValueChanged);
            // 
            // txPrice
            // 
            this.txPrice.EditValue = "";
            this.txPrice.Location = new System.Drawing.Point(94, 172);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(192, 20);
            this.txPrice.TabIndex = 26;
            // 
            // lblCustomName
            // 
            this.lblCustomName.Location = new System.Drawing.Point(6, 173);
            this.lblCustomName.Name = "lblCustomName";
            this.lblCustomName.Size = new System.Drawing.Size(80, 19);
            this.lblCustomName.TabIndex = 34;
            this.lblCustomName.Text = "Price:";
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(6, 47);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(56, 18);
            this.lblStart.TabIndex = 33;
            this.lblStart.Text = "Start:";
            // 
            // lblLabel
            // 
            this.lblLabel.Location = new System.Drawing.Point(6, 140);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(48, 19);
            this.lblLabel.TabIndex = 31;
            this.lblLabel.Text = "Label:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 18);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status:";
            // 
            // edStatus
            // 
            this.edStatus.Location = new System.Drawing.Point(94, 116);
            this.edStatus.Name = "edStatus";
            this.edStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edStatus.Size = new System.Drawing.Size(192, 20);
            this.edStatus.TabIndex = 24;
            // 
            // edLabel
            // 
            this.edLabel.Location = new System.Drawing.Point(94, 140);
            this.edLabel.Name = "edLabel";
            this.edLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edLabel.Size = new System.Drawing.Size(192, 20);
            this.edLabel.TabIndex = 25;
            // 
            // txSubject
            // 
            this.txSubject.EditValue = "";
            this.txSubject.Location = new System.Drawing.Point(94, 12);
            this.txSubject.Name = "txSubject";
            this.txSubject.Size = new System.Drawing.Size(192, 20);
            this.txSubject.TabIndex = 17;
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(6, 13);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(48, 18);
            this.lblSubject.TabIndex = 22;
            this.lblSubject.Text = "Subject:";
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(206, 235);
            this.btnRecurrence.Name = "btnRecurrence";
            this.btnRecurrence.Size = new System.Drawing.Size(80, 27);
            this.btnRecurrence.TabIndex = 32;
            this.btnRecurrence.Text = "Recurrence";
            this.btnRecurrence.Click += new System.EventHandler(this.btnRecurrence_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(105, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(9, 235);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.Location = new System.Drawing.Point(6, 71);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(48, 18);
            this.lblEnd.TabIndex = 36;
            this.lblEnd.Text = "End:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Resources:";
            // 
            // edResources
            // 
            this.edResources.Location = new System.Drawing.Point(94, 200);
            this.edResources.Name = "edResources";
            this.edResources.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edResources.Size = new System.Drawing.Size(192, 20);
            this.edResources.TabIndex = 38;
            // 
            // CustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 274);
            this.Controls.Add(this.edResources);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.checkAllDay);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.lblCustomName);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.edStatus);
            this.Controls.Add(this.edLabel);
            this.Controls.Add(this.txSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnRecurrence);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "CustomAppointmentForm";
            this.Text = "My Appointment Form";
            this.Activated += new System.EventHandler(this.MyAppointmentEditForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.checkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edResources.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkAllDay;
        private DevExpress.XtraEditors.TimeEdit timeEnd;
        private DevExpress.XtraEditors.TimeEdit timeStart;
        private DevExpress.XtraEditors.DateEdit dtEnd;
        private DevExpress.XtraEditors.DateEdit dtStart;
        private DevExpress.XtraEditors.TextEdit txPrice;
        private System.Windows.Forms.Label lblCustomName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraScheduler.UI.AppointmentStatusEdit edStatus;
        private DevExpress.XtraScheduler.UI.AppointmentLabelEdit edLabel;
        private DevExpress.XtraEditors.TextEdit txSubject;
        private System.Windows.Forms.Label lblSubject;
        private DevExpress.XtraEditors.SimpleButton btnRecurrence;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraScheduler.UI.AppointmentResourcesEdit edResources;
    }
}
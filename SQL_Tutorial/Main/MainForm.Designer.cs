namespace SQL_Tutorial
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rTxtBox_Log = new System.Windows.Forms.RichTextBox();
            this.rTextBox_Command = new System.Windows.Forms.RichTextBox();
            this.btn_acknowledge = new System.Windows.Forms.Button();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Top.Controls.Add(this.btn_Close);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 50);
            this.pnl_Top.TabIndex = 0;
            this.pnl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseMove);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::SQL_Tutorial.Properties.Resources.redX;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Close.Location = new System.Drawing.Point(725, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 50);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TabStop = false;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 219);
            this.dataGridView.TabIndex = 1;
            // 
            // rTxtBox_Log
            // 
            this.rTxtBox_Log.BackColor = System.Drawing.SystemColors.Window;
            this.rTxtBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxtBox_Log.Dock = System.Windows.Forms.DockStyle.Top;
            this.rTxtBox_Log.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBox_Log.Location = new System.Drawing.Point(0, 269);
            this.rTxtBox_Log.Name = "rTxtBox_Log";
            this.rTxtBox_Log.ReadOnly = true;
            this.rTxtBox_Log.Size = new System.Drawing.Size(800, 194);
            this.rTxtBox_Log.TabIndex = 2;
            this.rTxtBox_Log.Text = "";
            // 
            // rTextBox_Command
            // 
            this.rTextBox_Command.Dock = System.Windows.Forms.DockStyle.Top;
            this.rTextBox_Command.Location = new System.Drawing.Point(0, 463);
            this.rTextBox_Command.Name = "rTextBox_Command";
            this.rTextBox_Command.Size = new System.Drawing.Size(800, 96);
            this.rTextBox_Command.TabIndex = 3;
            this.rTextBox_Command.Text = "";
            // 
            // btn_acknowledge
            // 
            this.btn_acknowledge.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_acknowledge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_acknowledge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_acknowledge.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acknowledge.ForeColor = System.Drawing.Color.Green;
            this.btn_acknowledge.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_acknowledge.Location = new System.Drawing.Point(0, 559);
            this.btn_acknowledge.Name = "btn_acknowledge";
            this.btn_acknowledge.Size = new System.Drawing.Size(800, 105);
            this.btn_acknowledge.TabIndex = 4;
            this.btn_acknowledge.Text = "OK";
            this.btn_acknowledge.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.btn_acknowledge);
            this.Controls.Add(this.rTextBox_Command);
            this.Controls.Add(this.rTxtBox_Log);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox rTxtBox_Log;
        private System.Windows.Forms.RichTextBox rTextBox_Command;
        private System.Windows.Forms.Button btn_acknowledge;
    }
}
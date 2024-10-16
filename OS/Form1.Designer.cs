namespace OS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tc_FCFS = new TabControl();
            tabPage1 = new TabPage();
            btn_Done = new Button();
            btn_Random = new Button();
            lbl_FCFS_Median_Waitingtime_Value = new Label();
            btn_Confirm = new Button();
            lbl_FCFS_Median_Waitingtime = new Label();
            dGV_result = new DataGridView();
            lbl_process = new Label();
            tb_process = new TextBox();
            tc_FCFS.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_result).BeginInit();
            SuspendLayout();
            // 
            // tc_FCFS
            // 
            tc_FCFS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tc_FCFS.Controls.Add(tabPage1);
            tc_FCFS.Location = new Point(1, 1);
            tc_FCFS.Name = "tc_FCFS";
            tc_FCFS.SelectedIndex = 0;
            tc_FCFS.Size = new Size(795, 436);
            tc_FCFS.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_Done);
            tabPage1.Controls.Add(btn_Random);
            tabPage1.Controls.Add(lbl_FCFS_Median_Waitingtime_Value);
            tabPage1.Controls.Add(btn_Confirm);
            tabPage1.Controls.Add(lbl_FCFS_Median_Waitingtime);
            tabPage1.Controls.Add(dGV_result);
            tabPage1.Controls.Add(lbl_process);
            tabPage1.Controls.Add(tb_process);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(787, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "FCFS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Done
            // 
            btn_Done.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Done.BackColor = Color.LightSteelBlue;
            btn_Done.FlatStyle = FlatStyle.Flat;
            btn_Done.Location = new Point(616, 355);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new Size(75, 31);
            btn_Done.TabIndex = 9;
            btn_Done.Text = "Hoàn tất";
            btn_Done.UseVisualStyleBackColor = false;
            btn_Done.Click += btn_Done_Click;
            // 
            // btn_Random
            // 
            btn_Random.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Random.BackColor = Color.PaleGreen;
            btn_Random.FlatStyle = FlatStyle.Flat;
            btn_Random.Location = new Point(706, 355);
            btn_Random.Name = "btn_Random";
            btn_Random.Size = new Size(75, 31);
            btn_Random.TabIndex = 8;
            btn_Random.Text = "Random";
            btn_Random.UseVisualStyleBackColor = false;
            btn_Random.Click += btn_Random_Click;
            // 
            // lbl_FCFS_Median_Waitingtime_Value
            // 
            lbl_FCFS_Median_Waitingtime_Value.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_FCFS_Median_Waitingtime_Value.AutoSize = true;
            lbl_FCFS_Median_Waitingtime_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FCFS_Median_Waitingtime_Value.ForeColor = Color.Red;
            lbl_FCFS_Median_Waitingtime_Value.Location = new Point(201, 355);
            lbl_FCFS_Median_Waitingtime_Value.Name = "lbl_FCFS_Median_Waitingtime_Value";
            lbl_FCFS_Median_Waitingtime_Value.Size = new Size(19, 21);
            lbl_FCFS_Median_Waitingtime_Value.TabIndex = 5;
            lbl_FCFS_Median_Waitingtime_Value.Text = "0";
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.LightSteelBlue;
            btn_Confirm.FlatStyle = FlatStyle.Flat;
            btn_Confirm.Location = new Point(241, 7);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(75, 31);
            btn_Confirm.TabIndex = 4;
            btn_Confirm.Text = "Xác nhận";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += button1_Click;
            // 
            // lbl_FCFS_Median_Waitingtime
            // 
            lbl_FCFS_Median_Waitingtime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_FCFS_Median_Waitingtime.AutoSize = true;
            lbl_FCFS_Median_Waitingtime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FCFS_Median_Waitingtime.Location = new Point(7, 355);
            lbl_FCFS_Median_Waitingtime.Name = "lbl_FCFS_Median_Waitingtime";
            lbl_FCFS_Median_Waitingtime.Size = new Size(188, 21);
            lbl_FCFS_Median_Waitingtime.TabIndex = 3;
            lbl_FCFS_Median_Waitingtime.Text = "Thời gian chờ trung bình";
            // 
            // dGV_result
            // 
            dGV_result.AllowUserToAddRows = false;
            dGV_result.AllowUserToDeleteRows = false;
            dGV_result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGV_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_result.Location = new Point(6, 50);
            dGV_result.Name = "dGV_result";
            dGV_result.Size = new Size(776, 299);
            dGV_result.TabIndex = 2;
            dGV_result.DataError += dGV_result_DataError;
            // 
            // lbl_process
            // 
            lbl_process.AutoSize = true;
            lbl_process.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_process.Location = new Point(7, 10);
            lbl_process.Name = "lbl_process";
            lbl_process.Size = new Size(99, 21);
            lbl_process.TabIndex = 1;
            lbl_process.Text = "Số tiến trình";
            // 
            // tb_process
            // 
            tb_process.BorderStyle = BorderStyle.FixedSingle;
            tb_process.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_process.Location = new Point(114, 8);
            tb_process.Name = "tb_process";
            tb_process.Size = new Size(119, 29);
            tb_process.TabIndex = 0;
            tb_process.KeyDown += tb_process_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 436);
            Controls.Add(tc_FCFS);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "First-Come, First-Served";
            tc_FCFS.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_result).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tc_FCFS;
        private TabPage tabPage1;
        private TextBox tb_process;
        private Label lbl_process;
        private DataGridView dGV_result;
        private Label lbl_FCFS_Median_Waitingtime;
        private Button btn_Confirm;
        private Label lbl_FCFS_Median_Waitingtime_Value;
        private Button btn_Done;
        private Button btn_Random;
    }
}

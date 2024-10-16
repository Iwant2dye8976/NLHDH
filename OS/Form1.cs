using OS.Manager;
using System.Data;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;

namespace OS
{
    public partial class Form1 : Form
    {
        private int pid_number = 0;
        private DataTable dt;
        private FCFS FCFS;
        private EmptyFCFS ET_FCFS;
        public Form1()
        {
            InitializeComponent();
            FCFS = new FCFS();
            ET_FCFS = new EmptyFCFS();
        }
        public void CreateFCFS()
        {
            dt = FCFS.createFCFSProcesses(pid_number);
            dGV_result.DataSource = dt;
        }

        public void CreateEmTFCFS()
        {
            dt = ET_FCFS.createEmptFCFS(pid_number);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i != 1)
                {
                    dt.Columns[i].ReadOnly = true;
                }
            }
            dGV_result.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pid_number = Convert.ToInt32(tb_process.Text.Trim());
                CreateEmTFCFS();
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập số nguyên");
                tb_process.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số tiến trình quá lớn");
                tb_process.Focus();
            }
        }

        private void tb_process_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Confirm.PerformClick();
            }
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            dGV_result.DataSource = ET_FCFS.caculateTime(dt, pid_number);
            if (ET_FCFS.Error_count == 0)
            {
                double averageWaitingTime = ET_FCFS.AverageWaitingTime(dt, pid_number);
                double averageTurnAroundTime = ET_FCFS.AverageTurnAroundTime(dt, pid_number);
                lbl_FCFS_Median_Waitingtime_Value.Text = averageWaitingTime.ToString("F2") + " đơn vị thời gian";
                lbl_TurnAroundTime_value.Text = averageTurnAroundTime.ToString("F2") + " đơn vị thời gian";
            }
            else
            {
                lbl_FCFS_Median_Waitingtime_Value.Text = "0";
                lbl_TurnAroundTime_value.Text = "0";
            }
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            CreateFCFS();
            double averageWaitingTime = FCFS.AverageWaitingTime(dt, pid_number);
            double averageTurnAroundTime = FCFS.AverageTurnAroundTime(dt, pid_number);
            lbl_FCFS_Median_Waitingtime_Value.Text = averageWaitingTime.ToString("F2") + " đơn vị thời gian";
            lbl_TurnAroundTime_value.Text = averageTurnAroundTime.ToString("F2") + " đơn vị thời gian";
        }

        private void dGV_result_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Thời gian thực thi phải là số nguyên");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OS.Manager
{
    public class EmptyFCFS
    {
        private int err_count = 0;
        public int Error_count { get { return err_count; } set { err_count = value; } }
        public DataTable createEmptFCFS(int pidNumber)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên tiến trình", typeof(string));
            dt.Columns.Add("Thời gian thực thi", typeof(int));
            dt.Columns.Add("Thời gian chờ", typeof(long));
            dt.Columns.Add("Thời gian quay vòng", typeof(long));

            for (int i = 0; i < pidNumber; i++)
            {
                dt.Rows.Add("P" + (i + 1), 0, 0, 0);
            }
            return dt;
        }

        public DataTable caculateTime(DataTable dt, int pidNumber)
        {
            int[] wt = new int[pidNumber];
            int[] tat = new int[pidNumber];
            uint[] bt = new uint[pidNumber];
            err_count = 0;
            for (int i = 0; i < pidNumber; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["Thời gian thực thi"]) <= 0)
                {
                    err_count++;
                    bt[i] = 0;
                }
                else { bt[i] = Convert.ToUInt32(dt.Rows[i]["Thời gian thực thi"]); }

            }
            if (err_count != 0) { MessageBox.Show("Thời gian thực thi phải lớn hơn 0"); }

            findWaitingTime(pidNumber, bt, wt);
            findTurnAroundTime(pidNumber, bt, wt, tat);
            dt.Clear();
            //Thêm dữ liệu vào bảng
            for (int i = 0; i < pidNumber; i++)
            {
                dt.Rows.Add("P" + (i + 1), bt[i], wt[i], tat[i]);
            }

            return dt;
        }

        //Tính thời gian chờ
        public void findWaitingTime(int n,
                                uint[] bt, int[] wt)
        {
            wt[0] = 0;
            for (int i = 1; i < n; i++)
            {
                wt[i] = (int)bt[i - 1] + wt[i - 1];
            }
        }

        //Tính thời gian quay vòng
        public void findTurnAroundTime(int n,
            uint[] bt, int[] wt, int[] tat)
        {
            for (int i = 0; i < n; i++)
            {
                tat[i] = (int)bt[i] + wt[i];
            }
        }

        //Tính thời gian chờ trung bình
        public double AverageWaitingTime(DataTable dt, int pidNumber)
        {
            long totalWaitingTime = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalWaitingTime += (long)row["Thời gian chờ"];
            }

            return totalWaitingTime / (double)pidNumber;
        }

        public double AverageTurnAroundTime(DataTable dt, int pidNumber)
        {
            long totalTurnAroundTime = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalTurnAroundTime += (long)row["Thời gian quay vòng"];
            }
            return totalTurnAroundTime / (double)pidNumber;
        }
    }
}

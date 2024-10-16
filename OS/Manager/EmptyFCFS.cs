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
            int[] bt = new int[pidNumber];

            for (int i = 0; i < pidNumber; i++)
            {
                bt[i] = Convert.ToInt32(dt.Rows[i]["Thời gian thực thi"]);
            }
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
                                int[] bt, int[] wt)
        {
            wt[0] = 0;
            for (int i = 1; i < n; i++)
            {
                wt[i] = bt[i - 1] + wt[i - 1];
            }
        }

        //Tính thời gian quay vòng
        public void findTurnAroundTime(int n,
            int[] bt, int[] wt, int[] tat)
        {
            for (int i = 0; i < n; i++)
            {
                tat[i] = bt[i] + wt[i];
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

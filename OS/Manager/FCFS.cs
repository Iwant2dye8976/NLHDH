using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Manager
{
    public class FCFS
    {
        public DataTable createFCFSProcesses(int pidNumber)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên tiến trình", typeof(string));
            dt.Columns.Add("Thời điểm đến", typeof(int));
            dt.Columns.Add("Thời gian sử dụng CPU", typeof(long));
            dt.Columns.Add("Thời gian chờ", typeof(long));

            Random random = new Random();
            int[] wt = new int[pidNumber];
            int[] ar = new int[pidNumber];
            uint[] bt = new uint[pidNumber];

            for (int i = 0; i < pidNumber; i++)
            {
                ar[i] = i;
            }

            for (int i = 0; i < pidNumber; i++)
            {
                bt[i] = (uint)random.Next(1, 50);
            }

            findWaitingTime(pidNumber, bt, ar, wt);

            //Thêm dữ liệu vào bảng
            for (int i = 0; i < pidNumber; i++)
            {
                dt.Rows.Add("P" + (i + 1), ar[i], bt[i], wt[i]);
            }
            return dt;
        }

        //Tính thời gian chờ
        public void findWaitingTime(int n,
            uint[] bt, int[] ar, int[] wt)
        {
            wt[0] = 0;
            int curentTime = (int)bt[0];
            for (int i = 1; i < n; i++)
            {
                curentTime += (int)bt[i];
                wt[i] = curentTime - ar[i] - (int)bt[i];
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
    }
}

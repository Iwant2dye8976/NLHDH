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
            dt.Columns.Add("Thời điểm đến", typeof(int));
            dt.Columns.Add("Thời gian sử dụng CPU", typeof(long));
            dt.Columns.Add("Thời gian chờ", typeof(long));

            for (int i = 0; i < pidNumber; i++)
            {
                dt.Rows.Add("P" + (i + 1), i, 0, 0);
            }
            return dt;
        }

        public DataTable caculateTime(DataTable dt, int pidNumber)
        {
            int[] ar = new int[pidNumber];
            int[] wt = new int[pidNumber];
            uint[] bt = new uint[pidNumber];
            err_count = 0;
            for (int i = 0; i < pidNumber; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["Thời gian sử dụng CPU"]) <= 0)
                {
                    err_count++;
                    bt[i] = 0;
                }
                else { bt[i] = Convert.ToUInt32(dt.Rows[i]["Thời gian sử dụng CPU"]); }

            }
            if (err_count != 0) { MessageBox.Show("Thời gian thực thi phải lớn hơn 0"); }

            findArrivalTime(pidNumber, ar, dt);
            findWaitingTime(pidNumber, bt, ar, wt);
            dt.Clear();
            //Thêm dữ liệu vào bảng
            for (int i = 0; i < pidNumber; i++)
            {
                dt.Rows.Add("P" + (i + 1), ar[i], bt[i], wt[i]);
            }

            return dt;
        }

        //Tính thời gian chờ
        public void findArrivalTime(int n, int[] ar, DataTable dt)
        {
            ar[0] = 0;
            for (int i = 1; i < n; i++)
            {
                ar[i] = (int)dt.Rows[i][1];
            }
        }

        //Tính thời gian quay vòng
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

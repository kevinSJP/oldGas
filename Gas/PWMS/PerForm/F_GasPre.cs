using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using MathWorks;
using MathWorks.MATLAB;
using MLApp;
using MathWorks.MATLAB.NET.Arrays;//在MWArray.dll，最常用的
using MathWorks.MATLAB.NET.Utility;// 在MWArray.dll，最常用的
using System.IO;

namespace PWMS.PerForm
{
    public partial class F_GasPre : Form
    {
        public F_GasPre()
        {
            InitializeComponent();
        }
        #region  当前窗体的所有共公变量
        DataClass.MyMeans GasPreDataClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule GasPreModuleClass = new PWMS.ModuleClass.MyModule();
        public static DataSet GasPreDS_Grid;
        #endregion

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            MLApp.MLAppClass matlab = new MLApp.MLAppClass();//调用matlab引擎
            string command;
            command="path(path,'D:\\mcd')";
            matlab.Execute(command);  
            command = "BFGWAVELET";
            matlab.Visible = 1;
            matlab.Execute(command);     // 执行Matlab命令
            //matlab.Quit();

            //dataClass.mcdata mydata = new dataClass.mcdata();
            //string mdata = "E:\\GraduateLife\\BP和greyBP和greyGABP\\r.txt";
            //w = mydata.readMatrix(mdata);
            //mydata.saveMatrix(w, "a.txt"); 

            double[] s = new double[30];
            double[] s1 = new double[30];
            StreamReader sr = new StreamReader(@"D:\mcd\\bwl.txt", Encoding.Default);
            StreamReader sr1 = new StreamReader(@"D:\mcd\\bwlo.txt", Encoding.Default);
            for (int i = 1; i < 31; i++)
            {
                s[i - 1] = Convert.ToDouble(sr.ReadLine());
                s1[i - 1] = Convert.ToDouble(sr1.ReadLine());
                String sel = "update B1_pre set pda= " + s[i - 1] + ", oda= " + s1[i - 1] + ",err=pda-oda where ID=" + i + "";
                DataClass.MyMeans.getsqlcom(sel);
            } 
            sr.Dispose();
            sr1.Dispose();

            string getnum = "SELECT MAX(err) AS Expr1 FROM  B1_pre";
            DataClass.MyMeans.getsqlcom(getnum);
            textBox3.Text = getnum.ToString();

            DataClass.MyMeans.AllSql = "Select * from B1_pre";
            GasPreDS_Grid = GasPreDataClass.getDataSet(DataClass.MyMeans.AllSql, "B1_pre");
            dataGridView1.DataSource = GasPreDS_Grid.Tables[0];
            this.dataGridView1.Columns["err"].DefaultCellStyle.Format = "0.000";
            dataGridView1.AutoGenerateColumns = false;  //是否自动创建列
            dataGridView1.Columns[0].HeaderText = "时间点";
            dataGridView1.Columns[1].HeaderText = "煤气量预测值";
            dataGridView1.Columns[2].HeaderText = "煤气量实际值";
            dataGridView1.Columns[3].HeaderText = "绝对误差";
            //dataGridView1.Columns[0].Visible = true;
            //dataGridView1.Columns[1].Visible = true;
            //dataGridView1.Columns[2].Visible = true;
            //dataGridView1.Columns[3].Visible = true;

            textBox1.Text = "1";
            textBox2.Text = "30";

            chart1.DataSource = GasPreDS_Grid.Tables[0];
            //chart1.DataBind();
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.Titles.Clear(); 
            chart1.Titles.Add( "高炉煤气预测结果"); 
            chart1.Series.Add("0");
            chart1.Series.Add("1");
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].Color = Color.Chartreuse;
            chart1.Series[1].Color = Color.Red;
            chart1.Series[0].MarkerColor = Color.Black;
            chart1.Series[0].MarkerSize = 3;
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[1].MarkerColor = Color.Black;
            chart1.Series[1].MarkerSize = 3;
            chart1.Series[1].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].XValueMember = "ID";
            chart1.Series[0].YValueMembers = "pda";
            chart1.Series[1].XValueMember = "ID";
            chart1.Series[1].YValueMembers = "oda";

            chart2.DataSource = GasPreDS_Grid.Tables[0];
            chart2.Series.Clear();
            chart2.Legends.Clear();
            chart2.Titles.Clear();
            chart2.Titles.Add("高炉煤气预测结果误差统计图");
            chart2.Series.Add("0");
            chart2.Series[0].Color = Color.MidnightBlue;
            chart2.Series[0].Palette = ChartColorPalette.EarthTones;
            chart2.Series[0].XValueMember = "ID";
            chart2.Series[0].YValueMembers = "err";

        }

    }
}

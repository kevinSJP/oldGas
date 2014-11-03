using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PWMS.PerForm
{
    public partial class F_GasView : Form
    {
        public F_GasView()
        {
            InitializeComponent();
        }

        #region  当前窗体的所有共公变量
        DataClass.MyMeans GasDataClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule GasModuleClass = new PWMS.ModuleClass.MyModule();
        public static DataSet GasDS_Grid;
        public static string sqlStm;
        public static string StartT, EndT, StartDate, EndDate, StartTime, EndTime;
        #endregion

        private void F_BFView_Load(object sender, EventArgs e)
        {
            /**/
            //  MessageBox.Show(F_GasView.ActiveForm.Text);

            switch (ModuleClass.MyModule.flag )
            {
                case 1:
                    EquNo.Text = "1#烧结";
                    EquNo.Items.Add("1#烧结");
                    EquNo.Items.Add("2#烧结");

                    #region  暂时用高炉数据调用
                    DataClass.MyMeans.AllSql = "Select * from BFG1_PRO";
                    //用dataGridView1控件显示煤气
                    
                    GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, "BFG1_PRO");
                    dataGridView1.DataSource = GasDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
                    //dataGridView1.Columns[0].Width = 60;
                    //dataGridView1.Columns[1].Width = 60;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    #endregion
                    break;

                case 2:
                    EquNo.Text = "1#焦炉";
                    EquNo.Items.Add("1#焦炉");
                    EquNo.Items.Add("2#焦炉");

                    #region  高炉数据调用
                    DataClass.MyMeans.AllSql = "Select * from BFG1_PRO";
                    //用dataGridView1控件显示煤气
                    
                    GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, "BFG1_PRO");
                    dataGridView1.DataSource = GasDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
                    //dataGridView1.Columns[0].Width = 60;
                    //dataGridView1.Columns[1].Width = 60;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    #endregion
                    break;

                case 3:
                    EquNo.Text = "1#高炉";
                    EquNo.Items.Add("1#高炉");
                    EquNo.Items.Add("2#高炉");
                    EquNo.Items.Add("3#高炉");
                    EquNo.Items.Add("4#高炉");

                    #region  高炉数据调用
                    DataClass.MyMeans.AllSql = "Select * from BFG1_PRO";
                    //用dataGridView1控件显示煤气
                    
                    GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, "BFG1_PRO");
                    dataGridView1.DataSource = GasDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
                    //dataGridView1.Columns[0].Width = 60;
                    //dataGridView1.Columns[1].Width = 60;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    #endregion

                    break;
                case 4:
                    EquNo.Text = "1#转炉";
                    EquNo.Items.Add("1#转炉");
                    EquNo.Items.Add("2#转炉");

                    #region  转炉数据调用
                    DataClass.MyMeans.AllSql = "Select * from LDG1_PRO";
                    //用dataGridView1控件显示煤气
                    
                    GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, "LDG1_PRO");
                    dataGridView1.DataSource = GasDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
                    //dataGridView1.Columns[0].Width = 60;
                    //dataGridView1.Columns[1].Width = 60;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    #endregion
                    break;

                case 5:
                    EquNo.Text = "1#热风炉";
                    EquNo.Items.Add("1#热风炉");
                    EquNo.Items.Add("2#热风炉");
                    EquNo.Items.Add("3#热风炉");
                    EquNo.Items.Add("4#热风炉");
                     #region  热风炉数据调用
                    DataClass.MyMeans.AllSql = "Select * from BF1_CON";
                    //用dataGridView1控件显示煤气

                    GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, "BF1_CON");
                    dataGridView1.DataSource = GasDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
                    //dataGridView1.Columns[0].Width = 60;
                    //dataGridView1.Columns[1].Width = 60;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    #endregion
                    break;

                case 6:
                    EquNo.Text = "1#热轧";
                    EquNo.Items.Add("1#热轧");
                    EquNo.Items.Add("2#热轧");

                    #region  高炉数据调用
                    DataClass.MyMeans.AllSql = "Select * from BFG1_PRO";
                    //用dataGridView1控件显示煤气
                    
                    GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, "BFG1_PRO");
                    dataGridView1.DataSource = GasDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
                    //dataGridView1.Columns[0].Width = 60;
                    //dataGridView1.Columns[1].Width = 60;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    #endregion
                    break;
                case 7:
                    EquNo.Text = "1#冷轧";
                    EquNo.Items.Add("1#冷轧");
                    EquNo.Items.Add("2#冷轧");

                    #region  高炉数据调用
                    DataClass.MyMeans.AllSql = "Select * from BFG1_PRO";
                    //用dataGridView1控件显示煤气
                    
                    GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, "BFG1_PRO");
                    dataGridView1.DataSource = GasDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
                    //dataGridView1.Columns[0].Width = 60;
                    //dataGridView1.Columns[1].Width = 60;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    #endregion
                    break;         
            }          
            
            /***************************/
            
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            #region  选择设备

            switch (EquNo.Text)
            {
                case  "1#高炉":
                    ShowDraw("BFG1_PRO");
                    break;
                case   "2#高炉":
                    ShowDraw("BFG2_PRO");
                    break;
                case "1#转炉":
                    ShowDraw("LDG1_PRO");
                    break;
                case "2#转炉":
                    ShowDraw("LDG2_PRO");
                    break;
                case "1#热风炉":
                    ShowDraw("BF1_CON");
                    break;
                default:
                    MessageBox.Show("没有可选数据！","提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;           
            }

            //MessageBox.Show(Convert.ToString(GasDS_Grid.Tables[0].Columns[0]));
            #endregion
        }

        /// <summary>
        /// 显示数据绘制图表
        /// </summary>
        /// <param name="TableName">数据库表名</param>
        private void ShowDraw(string TableName)
        {
            /**/
            //public static string StartT, EndT, StartDate, EndDate, StartTime, EndTime;
            StartDate = GasModuleClass.Date_Format(Convert.ToString(StartTime1.Value.Date));
            EndDate = GasModuleClass.Date_Format(Convert.ToString(EndTime1.Value.Date));
            StartTime = GasModuleClass.Time_Format(Convert.ToString(StartTime2.Value.TimeOfDay));
            EndTime = GasModuleClass.Time_Format(Convert.ToString(EndTime2.Value.TimeOfDay));
            StartT = StartDate + " " + StartTime;
            EndT = EndDate + " " + EndTime;
            sqlStm = "SELECT*  FROM " + TableName + "  where TIME  between '" + StartT + " 'and '" + EndT + "'";

            DataClass.MyMeans.AllSql = sqlStm;
            //DataClass.MyMeans.AllSql = "SELECT*  FROM BFG1_PRO  where TIME  between '2013-06-17 15:36:00.000' and '2013-06-18 15:36:00.000'";
            GasDS_Grid = GasDataClass.getDataSet(DataClass.MyMeans.AllSql, TableName);
            dataGridView1.DataSource = GasDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            string tbc = dataGridView1.Columns[2].Name.ToString();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
           
            DataTable dt = GasDS_Grid.Tables[0];
            //判断输入日期是否正确
            DateTime St=Convert.ToDateTime(StartT);
            DateTime Et=Convert.ToDateTime(EndT);
            if (DateTime.Compare(St, Et) > 0)
            {
                MessageBox.Show("日期输入有误！","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    double maxValue = Convert.ToDouble(dt.Rows[0][2]);
                    double minValue = Convert.ToDouble(dt.Rows[0][2]);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(dt.Rows[i][2]) >= maxValue)
                            maxValue = Convert.ToDouble(dt.Rows[i][2]);
                        if (Convert.ToDouble(dt.Rows[i][2]) < minValue)
                            minValue = Convert.ToDouble(dt.Rows[i][2]);
                    }
                    textBox1.Text = maxValue.ToString();
                    textBox2.Text = minValue.ToString();
                }
                catch
                {
                    MessageBox.Show("请选择正确的数据日期！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //MessageBox.Show(sqlStm);

            //chart作图  GasDS_Grid    

            chart1.DataSource = GasDS_Grid.Tables[0];
            //chart1.DataBind();
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add(EquNo.Text+"历史数据曲线");
            chart1.Series.Add(TableName);
            chart1.Series[TableName].ChartType=System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[TableName].Color= Color.Red;
            chart1.Series[TableName].XValueMember = "TIME";
            chart1.Series[TableName].YValueMembers = tbc ;
        }

    }
}
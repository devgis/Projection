using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projection
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cbProjType.SelectedIndex = 0;
            cbZoneType.SelectedIndex = 0;
        }

        private void btGauss_Click(object sender, EventArgs e)
        {
            ProjectionConversion2 cc = null;
            switch (cbProjType.Text)
            {
                case "2000国家大地坐标系":
                    cc = new GSCoordConvertionClass_2000();
                    break;
                case "西安1980":
                    cc = new GSCoordConvertionClass_Xian80();
                    break;
                case "北京54":
                    cc = new GSCoordConvertionClass_Beijing54();
                    break;
            }

            try
            {
                cc.IsBigNumber = true;
                cc.Strip = EnumStrip.Strip3;
                if ("6度带".Equals(cbZoneType.Text))
                {
                    cc.Strip = EnumStrip.Strip6;
                }
                else if ("3度带".Equals(cbZoneType.Text))
                {
                    cc.Strip = EnumStrip.Strip3;
                }
                cc.L0 = Convert.ToDecimal(tbL0.Text);

                decimal x = 0, y = 0;
                decimal B = Convert.ToDecimal(tbB.Text);
                decimal L = Convert.ToDecimal(tbL.Text);
                cc.GetXYFromBL(B, L, ref x, ref y);
                tbX.Text = x.ToString();
                int sta = 0;
                try
                {
                    sta = Convert.ToInt32(tbStatic.Text);
                }
                catch
                { }
                tbY.Text = (y+sta).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void btInverseGuass_Click(object sender, EventArgs e)
        {
            ProjectionConversion2 cc = null;
            switch (cbProjType.Text)
            {
                case "2000国家大地坐标系":
                    cc = new GSCoordConvertionClass_2000();
                    break;
                case "西安1980":
                    cc = new GSCoordConvertionClass_Xian80();
                    break;
                case "北京54":
                    cc = new GSCoordConvertionClass_Beijing54();
                    break;
            }

            try
            {
                cc.IsBigNumber = true;
                cc.Strip = EnumStrip.Strip3;
                if ("6度带".Equals(cbZoneType.Text))
                {
                    cc.Strip = EnumStrip.Strip6;
                }
                else if ("3度带".Equals(cbZoneType.Text))
                {
                    cc.Strip = EnumStrip.Strip3;
                }
                cc.L0 = Convert.ToDecimal(tbL0.Text);

                decimal B = 0, L = 0;
                decimal x = Convert.ToDecimal(tbX.Text);
                decimal y = Convert.ToDecimal(tbY.Text);
                int sta = 0;
                try
                {
                    sta = Convert.ToInt32(tbStatic.Text);
                }
                catch
                { }
                cc.GetBLFromXY(x, y - sta, ref B, ref L);
                //
                B = Math.Round(B, 8);
                L = Math.Round(L, 8);

                tbB.Text = B.ToString();
                tbL.Text = L.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btMct_Click(object sender, EventArgs e)
        {
            try
            {
                double B = Convert.ToDouble(tbmctB.Text);
                double L = Convert.ToDouble(tbmctL.Text);

                double x = 0, y = 0;
                MercatorConverter.Degree2WebMercatorMeter(L, B, out x, out y);
                tbmctX.Text = x.ToString();
                tbmctY.Text = y.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            
        }

        private void btInversMct_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(tbmctX.Text);
                double y = Convert.ToDouble(tbmctY.Text);
                double B = 0, L = 0;
                MercatorConverter.WebMercatorMeter2Degree(x, y, out L, out B);
                tbmctB.Text = B.ToString();
                tbmctL.Text = L.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            
        }
    }
}

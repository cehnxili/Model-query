using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 序列号查询
{

    public partial class Form1 : Form
    {
        #region 定义变量
        string[] data_sheets_menu;

        TextBox[] m_TbECArray;
        TextBox[] m_TbNPMArray;
        TextBox[] m_TbCMArray;
        TextBox[] m_TbUDIArray;
        TextBox[] m_TbUDMArray;
        TextBox[] m_TbLCMArray;

        string input_xuliehao = "";
        #endregion
        public Form1()
        {
            InitializeComponent();
            data_sheets_menu = new string[] { "SP+EC", "NPMpm", "CM", "UDI", "UDM", "LCM" };
        }
        //窗体初始化 FINISH
        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化提示
            tbox_error.Text = "请先选择模式，再选择设备类型!";
            label_DEFAULT.Text = " ";
            CBox_device.Text = "------NULL------";
            CBox_device.Enabled = false;
            checkBox_PN.Checked = true;
            //初始化设备号
            for (int i = 0; i < data_sheets_menu.Length; i++)
            {
                CBox_device.Items.Add(data_sheets_menu[i]);
            }
        }
        //设备号不同，序列号不同，框框数量不同 FINISH
        private void CBox_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_PN.Checked)
            {
                switch (CBox_device.Text)
                {
                    case "SP+EC":
                        gbox_xuliehao.Controls.Clear();
                        label_DEFAULT.Text = "默认序列号：04-00-00-32-N-A-Y-D-N-D-N-N";
                        m_TbECArray = new TextBox[12];
                        for (int i = 0; i < m_TbECArray.Length; i++)
                        {
                            m_TbECArray[i] = new TextBox();
                            m_TbECArray[i].Size = new Size(20, 20);
                            m_TbECArray[i].Location = new Point(i * 30, 20);
                            m_TbECArray[i].CharacterCasing = CharacterCasing.Upper;
                            gbox_xuliehao.Controls.Add(m_TbECArray[i]);
                            m_TbECArray[i].TextChanged += new EventHandler(m_TbECArray_TextChanged);//当textbox的文字改变时，触发事件
                            m_TbECArray[i].TextChanged += new EventHandler(txt_LostFocus);
                        }
                        m_TbECArray[0].Focus();
                        break;
                    case "NPMpm":
                        gbox_xuliehao.Controls.Clear();
                        label_DEFAULT.Text = "默认序列号：2-A-0-4-N-0-Y-C-B-A-N-N-C";
                        m_TbNPMArray = new TextBox[13];
                        for (int i = 0; i < m_TbNPMArray.Length; i++)
                        {
                            m_TbNPMArray[i] = new TextBox();
                            m_TbNPMArray[i].Size = new Size(20, 20);
                            m_TbNPMArray[i].Location = new Point(i * 30, 20);
                            m_TbNPMArray[i].CharacterCasing = CharacterCasing.Upper;
                            gbox_xuliehao.Controls.Add(m_TbNPMArray[i]);
                            m_TbNPMArray[i].TextChanged += new EventHandler(m_TbNPMArray_TextChanged);//当textbox的文字改变时，触发事件
                            m_TbNPMArray[i].TextChanged += new EventHandler(txt_LostFocus);
                        }
                        m_TbNPMArray[0].Focus();
                        break;
                    case "CM":
                        gbox_xuliehao.Controls.Clear();
                        label_DEFAULT.Text = "默认序列号：ba-3-B-2-4-E-2-1-A-1-A-W-N-A-N-Y-Y";
                        m_TbCMArray = new TextBox[17];
                        for (int i = 0; i < m_TbCMArray.Length; i++)
                        {
                            m_TbCMArray[i] = new TextBox();
                            m_TbCMArray[i].Size = new Size(20, 20);
                            m_TbCMArray[i].Location = new Point(i * 30, 20);
                            m_TbCMArray[i].CharacterCasing = CharacterCasing.Upper;
                            gbox_xuliehao.Controls.Add(m_TbCMArray[i]);
                            m_TbCMArray[i].TextChanged += new EventHandler(m_TbCMArray_TextChanged);//当textbox的文字改变时，触发事件
                            m_TbCMArray[i].TextChanged += new EventHandler(txt_LostFocus);
                        }
                        m_TbCMArray[0].Focus();
                        break;
                    case "UDI":
                        gbox_xuliehao.Controls.Clear();
                        label_DEFAULT.Text = "默认序列号：HP-4-4-2-1-S-1-1-N";
                        m_TbUDIArray = new TextBox[9];
                        for (int i = 0; i < m_TbUDIArray.Length; i++)
                        {
                            m_TbUDIArray[i] = new TextBox();
                            m_TbUDIArray[i].Size = new Size(20, 20);
                            m_TbUDIArray[i].Location = new Point(i * 30, 20);
                            m_TbUDIArray[i].CharacterCasing = CharacterCasing.Upper;
                            gbox_xuliehao.Controls.Add(m_TbUDIArray[i]);
                            m_TbUDIArray[i].TextChanged += new EventHandler(m_TbUDIArray_TextChanged);//当textbox的文字改变时，触发事件
                            m_TbUDIArray[i].TextChanged += new EventHandler(txt_LostFocus);
                        }
                        m_TbUDIArray[0].Focus();
                        break;
                    case "UDM":
                        gbox_xuliehao.Controls.Clear();
                        label_DEFAULT.Text = "默认序列号：BA-3-C-0-4-P-3-N-1-Y";
                        m_TbUDMArray = new TextBox[10];
                        for (int i = 0; i < m_TbUDMArray.Length; i++)
                        {
                            m_TbUDMArray[i] = new TextBox();
                            m_TbUDMArray[i].Size = new Size(20, 20);
                            m_TbUDMArray[i].Location = new Point(i * 30, 20);
                            m_TbUDMArray[i].CharacterCasing = CharacterCasing.Upper;
                            gbox_xuliehao.Controls.Add(m_TbUDMArray[i]);
                            m_TbUDMArray[i].TextChanged += new EventHandler(m_TbUDMArray_TextChanged);//当textbox的文字改变时，触发事件
                            m_TbUDMArray[i].TextChanged += new EventHandler(txt_LostFocus);
                        }
                        m_TbUDMArray[0].Focus();
                        break;
                    case "LCM":
                        gbox_xuliehao.Controls.Clear();
                        label_DEFAULT.Text = "默认序列号：N-N-N-N-N-N";
                        m_TbLCMArray = new TextBox[6];
                        for (int i = 0; i < m_TbLCMArray.Length; i++)
                        {
                            m_TbLCMArray[i] = new TextBox();
                            m_TbLCMArray[i].Size = new Size(20, 20);
                            m_TbLCMArray[i].Location = new Point(i * 30, 20);
                            m_TbLCMArray[i].CharacterCasing = CharacterCasing.Upper;
                            gbox_xuliehao.Controls.Add(m_TbLCMArray[i]);
                            m_TbLCMArray[i].TextChanged += new EventHandler(m_TbLCMArray_TextChanged);//当textbox的文字改变时，触发事件
                            m_TbLCMArray[i].TextChanged += new EventHandler(txt_LostFocus);
                        }
                        m_TbLCMArray[0].Focus();
                        break;
                }
            }
        }
        #region 判断打断字符函数
        //EC判断字符个数，来打断空格 FINISH
        private void m_TbECArray_TextChanged(object sender, EventArgs e)
        {
            for (int E = 0; E < m_TbECArray.Length; E++)
            {
                if (E <= 3)
                {
                    if (m_TbECArray[E].Text.Length > 1)
                    {
                        m_TbECArray[E + 1].Focus();
                    }
                }
                else if ((3 < E) & (E < 11))
                {
                    if (m_TbECArray[E].Text.Length == 1)
                    {
                        m_TbECArray[E + 1].Focus();
                    }
                }
            }
        }
        //NPM判断字符个数，来打断空格 FINISH
        private void m_TbNPMArray_TextChanged(object sender, EventArgs e)
        {
            for (int N = 0; N < m_TbNPMArray.Length - 1; N++)
            {
                if (m_TbNPMArray[N].Text.Length >= 1)
                {
                    m_TbNPMArray[N + 1].Focus();
                }
            }
        }
        //CM判断字符个数，来打断空格 FINISH
        private void m_TbCMArray_TextChanged(object sender, EventArgs e)
        {
            for (int C = 0; C < m_TbCMArray.Length - 1; C++)
            {
                if (C < 1)
                {
                    if (m_TbCMArray[C].Text.Length > 1)
                    {
                        m_TbCMArray[C + 1].Focus();
                    }
                }
                else
                {
                    if (m_TbCMArray[C].Text.Length == 1)
                    {
                        m_TbCMArray[C + 1].Focus();
                    }
                }
            }
        }
        //UDI判断字符个数，来打断空格 FINISH
        private void m_TbUDIArray_TextChanged(object sender, EventArgs e)
        {
            for (int U = 0; U < m_TbUDIArray.Length - 1; U++)
            {
                if (U < 1)
                {
                    if (m_TbUDIArray[U].Text.Length > 1)
                    {
                        m_TbUDIArray[U + 1].Focus();
                    }
                }
                else
                {
                    if (m_TbUDIArray[U].Text.Length == 1)
                    {
                        m_TbUDIArray[U + 1].Focus();
                    }
                }
            }
        }
        //UDM判断字符个数，来打断空格  FINISH
        private void m_TbUDMArray_TextChanged(object sender, EventArgs e)
        {
            for (int D = 0; D < m_TbUDMArray.Length - 1; D++)
            {
                if (D < 1)
                {
                    if (m_TbUDMArray[D].Text.Length > 1)
                    {
                        m_TbUDMArray[D + 1].Focus();
                    }
                }
                else
                {
                    if (m_TbUDMArray[D].Text.Length == 1)
                    {
                        m_TbUDMArray[D + 1].Focus();
                    }
                }
            }
        }
        //LCM判断字符个数，来打断空格 FINISH
        private void m_TbLCMArray_TextChanged(object sender, EventArgs e)
        {
            for (int L = 0; L < m_TbLCMArray.Length - 1; L++)
            {
                if (m_TbLCMArray[L].Text.Length >= 1)
                {
                    m_TbLCMArray[L + 1].Focus();
                }
            }
        }
        #endregion
        //失去焦点，开始输出   FINISH
        private void txt_LostFocus(object sender, EventArgs e)
        {
            string SPECinfo = "";
            string NPMPMinfo = "";
            string LCMinfo = "";
            string CMinfo = "";
            string UDIinfo = "";
            string UDMinfo = "";

            switch (CBox_device.Text)
            {
                case "SP+EC"://12个
                    Rbox_show.Text = SPECinfomation(SPECinfo);
                    break;
                case "NPMpm"://13个
                    Rbox_show.Text = NPMPMinfomation(NPMPMinfo);
                    break;
                case "CM":
                    Rbox_show.Text = CMinfomation(CMinfo);
                    break;
                case "UDI":
                    Rbox_show.Text = UDIinfomation(UDIinfo);
                    break;
                case "UDM":
                    Rbox_show.Text = UDMinfomation(UDMinfo);
                    break;
                case "LCM"://6个
                    Rbox_show.Text = LCMinfomation(LCMinfo);
                    break;
            }
        }
        #region 报错信息输出函数
        //EC报错信息 FINISH
        private string SPECinfomation(string specinfo)
        {
            string SPECinfo = "";
            try
            {
                switch (m_TbECArray[0].Text)
                {
                    default:
                        SPECinfo += "最大轴数:" + m_TbECArray[0].Text + "\n";
                        break;
                }
                switch (m_TbECArray[1].Text)
                {
                    default:
                        SPECinfo += "第三方伺服:" + m_TbECArray[1].Text + "\n";
                        break;
                }
                switch (m_TbECArray[2].Text)
                {
                    default:
                        SPECinfo += "第三方步进:" + m_TbECArray[2].Text + "\n";
                        break;
                }
                switch (m_TbECArray[3].Text)
                {
                    default:
                        SPECinfo += "第三方ETHERCAT:" + m_TbECArray[3].Text + "\n";
                        break;
                }
                switch (m_TbECArray[4].Text)
                {
                    case "G":
                    case "g":
                        SPECinfo += "支持G-CODE" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        SPECinfo += "不支持G-CODE" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbECArray[5].Text)
                {
                    case "N":
                    case "n":
                        SPECinfo += "SEVboost支持轴数:0" + "\n";
                        break;
                    case "A":
                    case "a":
                        SPECinfo += "SEVboost支持轴数:4" + "\n";
                        break;
                    case "B":
                    case "b":
                        SPECinfo += "SEVboost支持轴数:8" + "\n";
                        break;
                    case "C":
                    case "c":
                        SPECinfo += "SEVboost支持轴数:12" + "\n";
                        break;
                    case "D":
                    case "d":
                        SPECinfo += "SEVboost支持轴数:16" + "\n";
                        break;
                    case "F":
                    case "f":
                        SPECinfo += "SEVboost支持轴数:20" + "\n";
                        break;
                    case "g":
                    case "G":
                        SPECinfo += "SEVboost支持轴数:24" + "\n";
                        break;
                    case "h":
                    case "H":
                        SPECinfo += "SEVboost支持轴数:28" + "\n";
                        break;
                    case "i":
                    case "I":
                        SPECinfo += "SEVboost支持轴数:32" + "\n";
                        break;
                    case "j":
                    case "J":
                        SPECinfo += "SEVboost支持轴数:34" + "\n";
                        break;
                    case "k":
                    case "K":
                        SPECinfo += "SEVboost支持轴数:38" + "\n";
                        break;
                    case "L":
                    case "l":
                        SPECinfo += "SEVboost支持轴数:42" + "\n";
                        break;
                    case "m":
                    case "M":
                        SPECinfo += "SEVboost支持轴数:46" + "\n";
                        break;
                    case "O":
                    case "o":
                        SPECinfo += "SEVboost支持轴数:50" + "\n";
                        break;
                    case "p":
                    case "P":
                        SPECinfo += "SEVboost支持轴数:60" + "\n";
                        break;
                    case "Q":
                    case " q":
                        SPECinfo += "SEVboost支持轴数:64" + "\n";
                        break;

                }
                switch (m_TbECArray[6].Text)
                {
                    case "Y":
                    case "y":
                        SPECinfo += "支持输入整形" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        SPECinfo += "不支持输入整形" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbECArray[7].Text)
                {
                    case "D":
                    case "d":
                        if (Convert.ToInt32(m_TbECArray[0].Text) >= 32)
                        {
                            SPECinfo += "最大MPU循环速率:2kHz:" + "\n";
                        }
                        break;
                    case "2":
                        SPECinfo += "最大MPU循环速率:" + m_TbECArray[7].Text + "kHz" + "\n";
                        break;
                    case "4":
                        SPECinfo += "最大MPU循环速率:" + m_TbECArray[7].Text + "kHz" + "\n";
                        break;
                    case "5":
                        SPECinfo += "最大MPU循环速率:" + m_TbECArray[7].Text + "kHz" + "\n";
                        break;
                }
                switch (m_TbECArray[8].Text)
                {
                    case "N":
                    case "n":
                        SPECinfo += "不支持NETworkBoost:" + "\n";
                        break;
                    case "A":
                    case "a":
                        SPECinfo += "支持NETworkBoost" + "kHz" + "\n";
                        break;
                    case "B":
                    case "b":
                        SPECinfo += "支持 Flexible configuration" + "kHz" + "\n";
                        break;
                    case "C":
                    case "c":
                        SPECinfo += "支持NETworkBoost&Flexible configuration" + m_TbECArray[7].Text + "kHz" + "\n";
                        break;
                }
                switch (m_TbECArray[9].Text)
                {
                    case "D":
                    case "d":
                        SPECinfo += "ACSPL+buffer数量:10" + "\n";
                        break;
                    case "A":
                    case "a":
                        SPECinfo += "ACSPL+buffer数量:16" + "kHz" + "\n";
                        break;
                    case "B":
                    case "b":
                        SPECinfo += "ACSPL+buffer数量:32" + "kHz" + "\n";
                        break;
                    case "C":
                    case "c":
                        SPECinfo += "ACSPL+buffer数量:64" + m_TbECArray[7].Text + "kHz" + "\n";
                        break;
                }
                switch (m_TbECArray[10].Text)
                {
                    case "Y":
                    case "y":
                        SPECinfo += "支持版级版本" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        SPECinfo += "不支持版级版本" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbECArray[11].Text)
                {
                    case "N":
                    case "n":
                        SPECinfo += "无XLSCN" + "\n";
                        break;
                    case "10":
                        SPECinfo += "XLSCN数:10(A)" + "\n";
                        break;
                    case "11":
                        SPECinfo += "XLSCN数:11(B)" + "\n";
                        break;
                    case "12":
                        SPECinfo += "XLSCN数:12(C)" + "\n";
                        break;
                    case "13":
                        SPECinfo += "XLSCN数:13(D)" + "\n";
                        break;
                    case "14":
                        SPECinfo += "XLSCN数:14(E)" + "\n";
                        break;
                    case "15":
                        SPECinfo += "XLSCN数:15(F)" + "\n";
                        break;
                    case "16":
                        SPECinfo += "XLSCN数:16(G)" + "\n";
                        break;
                    default:
                        SPECinfo += "XLSCN（每个扫描仪单位）:" + m_TbECArray[11].Text + "\n";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return SPECinfo;
        }
        //NPMPM报错信息 FINISH
        private string NPMPMinfomation(string npmpminfo)
        {
            string NPMPMinfo = "";
            try
            {
                switch (m_TbNPMArray[0].Text)
                {
                    case "1":
                        NPMPMinfo += "最大轴数:" + m_TbNPMArray[0].Text + "\n";
                        break;
                    case "2":
                        NPMPMinfo += "最大轴数:" + m_TbNPMArray[0].Text + "\n";
                        break;
                }
                switch (m_TbNPMArray[1].Text)
                {
                    case "A":
                        NPMPMinfo += "电流为:3.3/10A" + "\n";
                        break;
                    case "B":
                        NPMPMinfo += "电流为:6.6/20A" + "\n";
                        break;
                    case "C":
                        NPMPMinfo += "电流为:10/30A" + "\n";
                        break;
                    case "D":
                        NPMPMinfo += "电流为:13.3/40A" + "\n";
                        break;
                }
                switch (m_TbNPMArray[2].Text)
                {
                    default:
                        NPMPMinfo += "500KHZ SIN-COS编码器接口为:" + m_TbNPMArray[2].Text + "\n";
                        if (!(string.IsNullOrEmpty(m_TbNPMArray[2].Text)))
                        {
                            if (Convert.ToInt32(m_TbNPMArray[2].Text) > 4)
                            {
                                tbox_error.Text = "第三位请输入0-4范围内数值";
                            }
                        }
                        break;
                }
                switch (m_TbNPMArray[3].Text)
                {
                    default:
                        NPMPMinfo += "10MHZ SIN-COS编码器接口为:" + m_TbNPMArray[3].Text + "\n";
                        if (!(string.IsNullOrEmpty(m_TbNPMArray[3].Text)))
                        {
                            if (Convert.ToInt32(m_TbNPMArray[3].Text) > 4)
                            {
                                tbox_error.Text = "第四位请输入0-4范围内数值";
                            }
                        }
                        break;
                }
                switch (m_TbNPMArray[4].Text)
                {
                    case "N":
                    case "n":
                        NPMPMinfo += "没有绝对值编码器类型" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "U":
                    case "u":
                        NPMPMinfo += "用户可选" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "E":
                    case "e":
                        NPMPMinfo += "绝对值编码器类型为：EnDAT 2.1(digital)/2.2" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "s":
                    case "S":
                        NPMPMinfo += "绝对值编码器类型为：SmartAbs" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "p":
                    case "P":
                        NPMPMinfo += "绝对值编码器类型为：松下" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "b":
                    case "B":
                        NPMPMinfo += "绝对值编码器类型为： BiSS-A/B/C, I- SSI" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "a":
                    case "A":
                        NPMPMinfo += "绝对值编码器类型为： Sanyo ABS" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbNPMArray[5].Text)
                {
                    default:
                        NPMPMinfo += "绝对值编码器接口为:" + m_TbNPMArray[5].Text + "\n";
                        if (!(string.IsNullOrEmpty(m_TbNPMArray[5].Text)))
                        {
                            if (Convert.ToInt32(m_TbNPMArray[5].Text) > 2)
                            {
                                tbox_error.Text = "第六位请输入0-2范围内数值";
                            }
                        }
                        break;
                }
                switch (m_TbNPMArray[6].Text)
                {
                    case "Y":
                    case "y":
                        NPMPMinfo += "支持STO" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        NPMPMinfo += "不支持STO" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbNPMArray[7].Text)
                {
                    case "a":
                    case "A":
                        NPMPMinfo += "限位开关输入方式：5V，Source/PNP" + "\n";
                        break;
                    case "B":
                    case "b":
                        NPMPMinfo += "限位开关输入方式：5V，Sink/NPN" + "\n";
                        break;
                    case "C":
                    case "c":
                        NPMPMinfo += "限位开关输入方式：24V，Source/PNP" + "\n";
                        break;
                    case "D":
                    case "d":
                        NPMPMinfo += "限位开关输入方式：24V，Sink/NPN" + "\n";
                        break;

                }
                switch (m_TbNPMArray[8].Text)
                {
                    case "A":
                    case "a":
                        NPMPMinfo += "数字量输入:5V，双端" + "\n";
                        break;
                    case "B":
                    case "b":
                        NPMPMinfo += "数字量输入:24V，双端" + "\n";
                        break;
                }
                switch (m_TbNPMArray[9].Text)
                {
                    case "A":
                    case "a":
                        NPMPMinfo += "数字量输出:Source/PNP,5V&24V" + "\n";
                        break;
                    case "B":
                    case "b":
                        NPMPMinfo += "数字量输出:Sink/NPN,5V&24V" + "\n";
                        break;
                }
                switch (m_TbNPMArray[10].Text)
                {
                    case "Y":
                    case "y":
                        NPMPMinfo += "配备电机继电器" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        NPMPMinfo += "不配备电机继电器" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbNPMArray[11].Text)
                {
                    case "N":
                    case "n":
                        NPMPMinfo += "特殊选项：无" + "\n";
                        break;
                    case "A":
                    case "a":
                        NPMPMinfo += "特殊选项：为具有双反馈的平台（跟随误差，激光/光学/超快编码器，干涉仪）定制" + "\n";
                        break;
                    case "B":
                    case "b":
                        NPMPMinfo += "特殊选项：为具有双反馈的平台定制（跟随误差，激光/高分辨率/超快编码器，干涉仪）" + "\n";
                        break;
                }
                switch (m_TbNPMArray[12].Text)
                {
                    case "A":
                    case "a":
                        NPMPMinfo += "反馈通道总数： 2（利用1轴）" + "\n";
                        break;
                    case "B":
                    case "b":
                        NPMPMinfo += "反馈通道总数： 2（利用2轴）" + "\n";
                        break;
                    case "C":
                    case "c":
                        NPMPMinfo += "反馈通道总数： 4（利用2轴）" + "\n";
                        break;
                    case "D":
                    case "d":
                        NPMPMinfo += "反馈通道总数： 4（利用2轴） " + "\n";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return NPMPMinfo;
        }
        //CM报错信息  FINISH
        private string CMinfomation(string cminfo)
        {
            string CMinfo = "";
            try
            {
                switch (m_TbCMArray[0].Text)
                {
                    case "BA":
                    case "ba":
                        CMinfo += "该设备为经济型" + "\n";
                        break;
                    case "hp":
                    case "HP":
                        CMinfo += "该设备为高性能型" + "\n";
                        break;
                }
                switch (m_TbCMArray[1].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbCMArray[1].Text)))
                        {
                            if (Convert.ToInt32(m_TbCMArray[1].Text) > 3)
                            {
                                tbox_error.Text = "第二位请输入1-3以内的指";
                            }
                            else
                            {
                                CMinfo += "内部驱动器数量为：" + m_TbCMArray[1].Text + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbCMArray[2].Text)
                {
                    case "A":
                    case "a":
                        CMinfo += "持续电流为(持续/峰值)：5/10A" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "b":
                    case "B":
                        CMinfo += "持续电流为(持续/峰值)：10/20A" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "c":
                    case "C":
                        CMinfo += "持续电流为(持续/峰值)：15/30A" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbCMArray[3].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbCMArray[3].Text)))
                        {
                            if (Convert.ToInt32(m_TbCMArray[3].Text) > 4)
                            {
                                tbox_error.Text = "第四位请输入0-3的指";
                            }
                            else
                            {
                                CMinfo += "SIN-COS编码器接口为：" + m_TbCMArray[3].Text + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbCMArray[4].Text)
                {
                    default:
                        CMinfo += "反馈通道总数为：" + m_TbCMArray[4].Text + "\n";
                        break;
                }
                switch (m_TbCMArray[5].Text)
                {
                    case "N":
                    case "n":
                        CMinfo += "不支持绝对值编码器" + "\n";
                        break;
                    case "U":
                    case "u":
                        CMinfo += "绝对值编码器类型：用户自定义" + "\n";
                        break;
                    case "E":
                    case "e":
                        CMinfo += "绝对值编码器类型：EnDAT 2.2 & 2.1 digital only" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "S":
                    case "s":
                        CMinfo += "绝对值编码器类型：Smart Abs" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "P":
                    case "p":
                        CMinfo += "绝对值编码器类型：松下" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "B":
                    case "b":
                        CMinfo += "绝对值编码器类型：BiSS-A/B/C,I - SSI." + "\n";
                        tbox_error.Text = "";
                        break;

                }
                switch (m_TbCMArray[6].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbCMArray[6].Text)))
                        {
                            if (Convert.ToInt32(m_TbCMArray[6].Text) > 4)
                            {
                                tbox_error.Text = "第七位请输入0-3的值";
                            }
                            else
                            {
                                CMinfo += "绝对值编码器接口数为：" + m_TbCMArray[6].Text + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbCMArray[7].Text)
                {
                    case "N":
                    case "n":
                        CMinfo += "无XLSCN" + "\n";
                        break;
                    case "10":
                        CMinfo += "XLSCN数:10(A)" + "\n";
                        break;
                    case "11":
                        CMinfo += "XLSCN数:11(B)" + "\n";
                        break;
                    case "12":
                        CMinfo += "XLSCN数:12(C)" + "\n";
                        break;
                    case "13":
                        CMinfo += "XLSCN数:13(D)" + "\n";
                        break;
                    case "14":
                        CMinfo += "XLSCN数:14(E)" + "\n";
                        break;
                    case "15":
                        CMinfo += "XLSCN数:15(F)" + "\n";
                        break;
                    case "16":
                        CMinfo += "XLSCN数:16(G)" + "\n";
                        break;
                    default:
                        CMinfo += "XLSCN（每个扫描仪单位）:" + m_TbCMArray[11].Text + "\n";
                        break;
                }
                switch (m_TbCMArray[8].Text)
                {
                    case "4":
                        CMinfo += "最大轴数为：4（包含在自动FOC中）：" + "\n";
                        break;
                    case "8":
                        CMinfo += "最大轴数为：8" + "\n";
                        break;
                    case "16":
                        CMinfo += "最大轴数为：16(A)" + "\n";
                        break;
                    case "32":
                        CMinfo += "最大轴数为：32(B)" + "\n";
                        break;
                }
                switch (m_TbCMArray[9].Text)
                {
                    case "16":
                        CMinfo += "第三方私服轴数为：16(A)" + "\n";
                        break;
                    case "32":
                        CMinfo += "第三方私服轴数为：32(B)" + "\n";
                        break;
                    default:
                        CMinfo += "第三方私服轴数为：" + m_TbCMArray[9].Text + "\n";
                        break;
                }
                switch (m_TbCMArray[10].Text)
                {
                    case "16":
                        CMinfo += "第三方私服轴数为：16(A)" + "\n";
                        break;
                    case "32":
                        CMinfo += "第三方私服轴数为：32(B)" + "\n";
                        break;
                    default:
                        CMinfo += "第三方私服轴数为：" + m_TbCMArray[9].Text + "\n";
                        break;
                }
                switch (m_TbCMArray[11].Text)
                {
                    case "W":
                    case "w":
                        CMinfo += "第三方IO节点数为：32（包含自动FOC）" + "\n";
                        break;
                    case "X":
                    case "x":
                        CMinfo += "第三方IO节点数为：64" + "\n";
                        break;
                }
                switch (m_TbCMArray[12].Text)
                {
                    case "N":
                    case "n":
                        CMinfo += "不支持G-CODE或灵活配置" + "\n";
                        break;
                    case "G":
                    case "g":
                        CMinfo += "支持G-CODE" + "\n";
                        break;
                    case "F":
                    case "f":
                        CMinfo += "支持灵活配置" + "\n";
                        break;
                    case "T":
                    case "t":
                        CMinfo += "支持G-CODE或灵活配置" + "\n";
                        break;
                }
                switch (m_TbCMArray[13].Text)
                {
                    case "N":
                    case "n":
                        CMinfo += "SEVboost支持轴数:0" + "\n";
                        break;
                    case "A":
                    case "a":
                        CMinfo += "SEVboost支持轴数:4" + "\n";
                        break;
                    case "B":
                    case "b":
                        CMinfo += "SEVboost支持轴数:8" + "\n";
                        break;
                    case "C":
                    case "c":
                        CMinfo += "SEVboost支持轴数:12" + "\n";
                        break;
                    case "D":
                    case "d":
                        CMinfo += "SEVboost支持轴数:16" + "\n";
                        break;
                    case "E":
                    case "e":
                        CMinfo += "SEVboost支持轴数:20" + "\n";
                        break;
                    case "F":
                    case "f":
                        CMinfo += "SEVboost支持轴数:24" + "\n";
                        break;
                    case "g":
                    case "G":
                        CMinfo += "SEVboost支持轴数:28" + "\n";
                        break;
                    case "h":
                    case "H":
                        CMinfo += "SEVboost支持轴数:32" + "\n";
                        break;
                }
                switch (m_TbCMArray[14].Text)
                {
                    case "Y":
                    case "y":
                        CMinfo += "支持输入整形" + "\n";
                        break;
                    case "N":
                    case "n":
                        CMinfo += "不支持输入整形" + "\n";
                        break;
                }
                switch (m_TbCMArray[15].Text)
                {
                    case "Y":
                    case "y":
                        CMinfo += "不适用于4轴或LC1的脉冲方向已安装选件" + "\n";
                        break;
                    case "N":
                    case "n":
                        CMinfo += "适用于4轴或LC1的脉冲方向已安装选件为：P/D" + "\n";
                        break;
                    case "L":
                    case "l":
                        CMinfo += "适用于4轴或LC1的脉冲方向已安装选件为：LC1" + "\n";
                        break;
                }
                switch (m_TbCMArray[16].Text)
                {
                    case "Y":
                    case "y":
                        CMinfo += "不支持低压操作（17-85VAC或24-120VDC）" + "\n";
                        break;
                    case "N":
                    case "n":
                        CMinfo += "支持低压操作（17-85VAC或24-120VDC）" + "\n";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return CMinfo;
        }
        //UDI报错信息 FINISH
        private string UDIinfomation(string udiinfo)
        {
            string UDIinfo = "";
            try
            {
                switch (m_TbUDIArray[0].Text)
                {
                    case "LT":
                    case "lt":
                        UDIinfo += "该设备为经济型" + "\n";
                        break;
                    case "hp":
                    case "HP":
                        UDIinfo += "该设备为高性能型" + "\n";
                        break;
                }
                switch (m_TbUDIArray[1].Text)
                {
                    case "2":
                        UDIinfo += "轴数为：2" + "\n";
                        break;
                    case "4":
                        UDIinfo += "轴数为：4" + "\n";
                        break;
                }
                switch (m_TbUDIArray[2].Text)
                {
                    case "2":
                        UDIinfo += "编码器通道数数为：2" + "\n";
                        break;
                    case "4":
                        UDIinfo += "编码器通道数数为：4" + "\n";
                        break;
                }
                switch (m_TbUDIArray[3].Text)
                {
                    default:
                        if (!string.IsNullOrEmpty((m_TbUDIArray[3].Text)))
                        {
                            if ((m_TbUDIArray[0].Text == "hp") || (m_TbUDIArray[0].Text == "HP"))
                            {
                                if (Convert.ToInt32(m_TbUDIArray[3].Text) > 4)
                                {
                                    tbox_error.Text = "第四位请输入0-4的指";
                                }
                                else
                                {
                                    UDIinfo += "10MHZ SIN-COS编码器接口为：" + m_TbUDIArray[3].Text + "\n";
                                }
                            }
                            else
                            {
                                UDIinfo += "10MHZ SIN-COS编码器接口仅支持高性能版" + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbUDIArray[4].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbUDIArray[4].Text)))
                        {
                            if ((m_TbUDIArray[0].Text == "hp") || (m_TbUDIArray[0].Text == "HP"))
                            {
                                if (Convert.ToInt32(m_TbUDIArray[2].Text) > 4)
                                {
                                    tbox_error.Text = "第三位请输入0-4的指";
                                }
                                else
                                {
                                    UDIinfo += "500KHZ SIN-COS编码器接口为：" + m_TbUDIArray[3].Text + "\n";
                                }
                            }
                            else
                            {
                                UDIinfo += "500KHZ SIN-COS编码器接口仅支持高性能版" + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbUDIArray[5].Text)
                {
                    case "N":
                    case "n":
                        UDIinfo += "不支持绝对值编码器" + "\n";
                        break;
                    case "U":
                    case "u":
                        UDIinfo += "绝对值编码器类型：用户自定义" + "\n";
                        break;
                    case "E":
                    case "e":
                        UDIinfo += "绝对值编码器类型：EnDAT 2.2 & 2.1 digital only" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "S":
                    case "s":
                        UDIinfo += "绝对值编码器类型：Smart Abs" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "P":
                    case "p":
                        UDIinfo += "绝对值编码器类型：松下" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "B":
                    case "b":
                        UDIinfo += "绝对值编码器类型：BiSS-A/B/C,I - SSI." + "\n";
                        tbox_error.Text = "";
                        break;

                }
                switch (m_TbUDIArray[6].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbUDIArray[6].Text)))
                        {
                            if (Convert.ToInt32(m_TbUDIArray[6].Text) > 3)
                            {
                                tbox_error.Text = "第二位请输入0-2以内的指";
                            }
                            else
                            {
                                UDIinfo += "绝对值编码器接口数为：" + m_TbUDIArray[6].Text + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbUDIArray[7].Text)
                {
                    case "1":
                        UDIinfo += "支持任何EtherCAT主站" + "\n";
                        break;
                }
                switch (m_TbUDIArray[8].Text)
                {
                    case "N":
                    case "n":
                        UDIinfo += "IO配置：输入&限位：24V/Source(PNP),输出：24V/Source(PNP)" + "\n";
                        break;
                    case "D":
                    case "d":
                        UDIinfo += "IO配置：输入&限位：24V/Source(PNP),输出：24V/Source(PNP)" + "\n";
                        break;
                    case "S":
                    case "s":
                        UDIinfo += "IO配置：输入&限位：24V/Sink(NPN),输出：24V/Sink(NPN)" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "R":
                    case "r":
                        UDIinfo += "IO配置：输入&限位：5V/Source(PNP),输出：5V/Source(PNP)" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "t":
                    case "T":
                        UDIinfo += "IO配置：输入&限位：5V/Sink(NPN),输出：5V/Source(PNP)" + "\n";
                        break;
                    case "u":
                    case "U":
                        UDIinfo += "IO配置：输出&限位：24V/Source(PNP),输出：24V/Sink(NPN)" + "\n";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return UDIinfo;
        }
        //UDM报错信息 FINISH
        private string UDMinfomation(string udminfo)
        {
            string UDMinfo = "";
            try
            {
                switch (m_TbUDMArray[0].Text)
                {
                    case "BA":
                    case "ba":
                        UDMinfo += "该设备为经济型" + "\n";
                        break;
                    case "hp":
                    case "HP":
                        UDMinfo += "该设备为高性能型" + "\n";
                        break;
                }
                switch (m_TbUDMArray[1].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbUDMArray[1].Text)))
                        {
                            if (Convert.ToInt32(m_TbUDMArray[1].Text) > 3)
                            {
                                tbox_error.Text = "第二位请输入1-3以内的指";
                            }
                            else
                            {
                                UDMinfo += "内部驱动器数量为：" + m_TbUDMArray[1].Text + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbUDMArray[2].Text)
                {
                    case "A":
                    case "a":
                        UDMinfo += "持续电流为(持续/峰值)：5/10A" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "b":
                    case "B":
                        UDMinfo += "持续电流为(持续/峰值)：10/20A" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "c":
                    case "C":
                        UDMinfo += "持续电流为(持续/峰值)：15/30A" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbUDMArray[3].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbUDMArray[3].Text)))
                        {
                            if (Convert.ToInt32(m_TbUDMArray[3].Text) > 4)
                            {
                                tbox_error.Text = "第四位请输入0-3的指";
                            }
                            else
                            {
                                UDMinfo += "250KHZ SIN-COS编码器接口数为：" + m_TbUDMArray[3].Text + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbUDMArray[4].Text)
                {
                    default:
                        UDMinfo += "反馈通道总数为：" + m_TbUDMArray[4] + "\n";
                        break;
                }
                switch (m_TbUDMArray[5].Text)
                {
                    case "N":
                    case "n":
                        UDMinfo += "不支持绝对值编码器" + "\n";
                        break;
                    case "U":
                    case "u":
                        UDMinfo += "绝对值编码器类型：用户自定义" + "\n";
                        break;
                    case "E":
                    case "e":
                        UDMinfo += "绝对值编码器类型：EnDAT 2.2 & 2.1 digital only" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "S":
                    case "s":
                        UDMinfo += "绝对值编码器类型：Smart Abs" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "P":
                    case "p":
                        UDMinfo += "绝对值编码器类型：松下" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "B":
                    case "b":
                        UDMinfo += "绝对值编码器类型：BiSS-A/B/C,I - SSI." + "\n";
                        tbox_error.Text = "";
                        break;

                }
                switch (m_TbUDMArray[6].Text)
                {
                    default:
                        if (!(string.IsNullOrEmpty(m_TbUDMArray[6].Text)))
                        {
                            if (Convert.ToInt32(m_TbUDMArray[6].Text) > 4)
                            {
                                tbox_error.Text = "第七位请输入0-3的指";
                            }
                            else
                            {
                                UDMinfo += "绝对值编码器接口数为：" + m_TbUDMArray[6].Text + "\n";
                            }
                        }
                        break;
                }
                switch (m_TbUDMArray[7].Text)
                {
                    default:
                        UDMinfo += "不支持STO功能：" + "\n";
                        break;
                }
                switch (m_TbUDMArray[8].Text)
                {
                    case "1":
                        UDMinfo += "支持任何EtherCAT主站：" + "\n";
                        break;
                }
                switch (m_TbUDMArray[9].Text)
                {
                    case "Y":
                    case "y":
                        UDMinfo += "支持低压(17VDC-85VDC)操作" + "\n";
                        break;
                    case "N":
                    case "n":
                        UDMinfo += "不支持低压(17VDC-85VDC)操作" + "\n";
                        tbox_error.Text = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return UDMinfo;
        }
        //LCM报错信息 FINISH
        private string LCMinfomation(string lcminfo)
        {
            string LCMinfo = "";
            try
            {
                switch (m_TbLCMArray[0].Text)
                {
                    case "Y":
                    case "y":
                        LCMinfo += "支持AB相和P/D输出" + "\n";
                        break;
                    case "N":
                    case "n":
                        LCMinfo += "不支持AB相和P/D输出" + "\n";
                        break;
                }
                switch (m_TbLCMArray[1].Text)
                {
                    case "Y":
                    case "y":
                        LCMinfo += "支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        LCMinfo += "不支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbLCMArray[2].Text)
                {
                    case "Y":
                    case "y":
                        LCMinfo += "支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        LCMinfo += "不支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbLCMArray[3].Text)
                {
                    case "Y":
                    case "y":
                        LCMinfo += "支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        LCMinfo += "不支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbLCMArray[4].Text)
                {
                    case "Y":
                    case "y":
                        LCMinfo += "支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        LCMinfo += "不支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                }
                switch (m_TbLCMArray[5].Text)
                {
                    case "Y":
                    case "y":
                        LCMinfo += "支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                    case "N":
                    case "n":
                        LCMinfo += "不支持未来选项" + "\n";
                        tbox_error.Text = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return LCMinfo;
        }
        #endregion
        //功能查询功能开启
        private void checkBox_Features_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Features.Checked)
            {
                checkBox_PN.Enabled = false;
                CBox_device.Enabled = true;
                //功能未做
            }
            else
            {
                checkBox_PN.Enabled = true;
                CBox_device.Enabled = false;
            }
        }
        //序列号查询功能开启 FINISH
        private void checkBox_PN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PN.Checked)
            {
                checkBox_Features.Enabled = false;
                CBox_device.Enabled = true;
                this.checkBox_PN.CheckedChanged += new System.EventHandler(this.CBox_device_SelectedIndexChanged);
            }
            else
            {
                checkBox_Features.Enabled = true;
                CBox_device.Enabled = false;
            }

        }
        //清空  FINISH
        private void btn_clearall_Click(object sender, EventArgs e)
        {
            switch (CBox_device.Text)
            {
                case "SP+EC"://12个
                    for (int E = 0; E < m_TbECArray.Length; E++)
                    {
                        m_TbECArray[E].Text = "";
                        m_TbECArray[0].Focus();
                    }
                    break;
                case "NPMpm"://13个
                    for (int N = 0; N < m_TbNPMArray.Length; N++)
                    {
                        m_TbNPMArray[N].Text = "";
                        m_TbNPMArray[0].Focus();
                    }
                    break;
                case "CM":
                    for (int C = 0; C < m_TbCMArray.Length; C++)
                    {
                        m_TbCMArray[C].Text = "";
                        m_TbCMArray[0].Focus();
                    }
                    break;
                case "UDI":
                    for (int U = 0; U < m_TbUDIArray.Length; U++)
                    {
                        m_TbUDIArray[U].Text = "";
                        m_TbUDIArray[0].Focus();
                    }
                    break;
                case "UDM":
                    for (int D = 0; D < m_TbUDMArray.Length; D++)
                    {
                        m_TbUDMArray[D].Text = "";
                        m_TbUDMArray[0].Focus();
                    }
                    break;
                case "LCM"://6个
                    for (int L = 0; L < m_TbLCMArray.Length; L++)
                    {
                        m_TbLCMArray[L].Text = "";
                        m_TbLCMArray[0].Focus();
                    }
                    break;
            }
            Rbox_show.Text = "";
        }
        #region 保存相关函数
        //保存 FINISH
        private void btn_save_Click(object sender, EventArgs e)
        {
            inputnum();
            SaveFileDialog filedata = new SaveFileDialog();
            filedata.InitialDirectory = @"C:\Users\admin\Desktop";
            filedata.Title = "请选择需要保存的文件位置";
            filedata.Filter = "文本文件|*.txt|所有文件|*.*";
            filedata.FileName = CBox_device.Text+"_"+input_xuliehao.ToUpper();
            filedata.ShowDialog();

            //获得用户要保存的文件的路径  
            string path = filedata.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(Rbox_show.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
        }
        //保存当前序列号 FINISH
        private void inputnum()
        {
            switch (CBox_device.Text)
            {
                case "SP+EC"://12个
                    for (int E = 0; E < m_TbECArray.Length; E++)
                    {
                        input_xuliehao += m_TbECArray[E].Text;
                    }
                    break;
                case "NPMpm"://13个
                    for (int N = 0; N < m_TbNPMArray.Length; N++)
                    {
                        input_xuliehao += m_TbNPMArray[N].Text;
                    }
                    break;
                case "CM":
                    for (int C = 0; C < m_TbCMArray.Length; C++)
                    {
                        input_xuliehao += m_TbCMArray[C].Text;
                    }
                    break;
                case "UDI":
                    for (int U = 0; U < m_TbUDIArray.Length; U++)
                    {
                        input_xuliehao += m_TbUDIArray[U].Text;
                    }
                    break;
                case "UDM":
                    for (int D = 0; D < m_TbUDMArray.Length; D++)
                    {
                        input_xuliehao += m_TbUDMArray[D].Text;
                    }
                    break;
                case "LCM"://6个
                    for (int L = 0; L < m_TbLCMArray.Length; L++)
                    {
                        input_xuliehao += m_TbLCMArray[L].Text;
                    }
                    break;
            }
        }
        #endregion
    }
}

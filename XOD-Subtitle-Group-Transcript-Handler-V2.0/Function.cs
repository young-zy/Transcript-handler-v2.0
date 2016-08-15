using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.IO;

namespace XOD Subtitle Group Transcript Handler V2.0
{
    static class Function
    {

    
        public static void Export(string resolution,List<Dtaobj> db,string Trans, string Checker, string Timeline)
        {
            //try
            //{
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                sfd.Filter = "ass文件(*.ass)|*.ass";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    string content = writeContent(resolution, db,Trans,Checker,Timeline);
                    FileStream myFs = new FileStream(path, FileMode.Create);
                    StreamWriter mySw = new StreamWriter(myFs);
                    mySw.Write(content);
                    mySw.Close();
                    myFs.Close();
                    MessageBox.Show("写入成功");
                }
                else
                {
                    throw new Exception();
                }
            //}
            //catch (Exception)
            //{

            //}
            
        }
        private static string writeContent(string resolution, List<Dtaobj> db, string Trans, string Checker, string Timeline)
        {
            string content = null;
            int i = 0;
            content += "[Script Info]\r\nTitle: Default Aegisub file\r\nScriptType: v4.00+\r\nWrapStyle: 0\r\nScaledBorderAndShadow: yes\r\nYCbCr Matrix: TV.601\r\n";
            if (resolution == "720p")
            {
                content += "PlayResX: 1280\r\nPlayResY: 720\r\n";

            }
            else if (resolution == "480p")
            {
                content += "PlayResX: 640\r\nPlayResY: 480\r\n";
            }
            else
            {
                content += "PlayResX: 1920\r\nPlayResY: 1080\r\n";
            }

            //字幕组样式保密限制，请自行添加样式1



            content += "\r\n[Events]\r\nFormat: Layer, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text\r\n";
            foreach (Dtaobj obj in db)
            {
                if (obj.Cn[0] != '#')
                {
                    content += "Dialogue: 0,0:00:00.00,0:00:00.00,中文,NTP,0,0,0,,";
                    content += obj.Cn;
                    //字幕组样式保密限制，请自行添加特效代码2
                    content += obj.En + "\r\n";
                }
                else
                {
                    string temp = obj.Cn.Substring(1, obj.Cn.Length - 1);
                    content += "Dialogue: 0,0:00:00.00,0:00:00.00,顶部注释,NTP,0,0,0,,";
                    content += temp + "\r\n";
                }
            }
            string[] Transtemp = Trans.Split(';');
            Trans = "";
            foreach (string tmp in Transtemp)
            {
                if (i < Transtemp.Length)
                {
                    Trans += tmp + "   ";
                    i++;
                }
                else
                {
                    Trans += tmp;
                    i = 0;
                }
            }
            string[] Chetemp = Checker.Split(';');
            Checker = "";
            foreach (string tmp in Chetemp)
            {
                if (i < Chetemp.Length)
                {
                    Checker += tmp + "   ";
                    i++;
                }
                else
                {
                    Checker += tmp;
                    i = 0;
                }
            }
            string[] Timetemp = Trans.Split(';');
            Timeline = "";
            foreach (string tmp in Timetemp)
            {
                if (i < Timetemp.Length)
                {
                    Timeline += tmp + "   ";
                    i++;
                }
                else
                {
                    Timeline += tmp;
                    i = 0;
                }

            }
            //字幕组片头保密，请自行添加片头代码3

            return content;
        }



    }
}

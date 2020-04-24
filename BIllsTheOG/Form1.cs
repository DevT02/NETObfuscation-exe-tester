using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIllsTheOG.Properties;

namespace BIllsTheOG
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = this.textBox1.Text != "Ehsduyua782637⚈^Ƿ7ą\ud83d\ude4eƌ♎EHUDjwbnHiudejwhdijin\ud83d\ude08ãEHUDjwbnHiudejwhdijinç¡♕♱ƥńeÃȔŅ⚐`☘X)EHUDjwbnHiudejwhdijinŵmkpnfduwiobdsahfFY#EHUDjwbnHiudejwhdijin;oaidoh";
			if (flag)
			{
				MessageBox.Show("Incorrect!", "OOF", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				MessageBox.Show("Correct. Good job for decompiling. Document how you decompiled by PMing me and not posting on the thread. Thanks :)", "Wow!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
            abc("p");
            // EMPTY METHODS FOR TESTING BELOW
			string a = "";
            bool flag2 = a == "";
			if (flag2)
			{
            }
            try
            {
            }
            catch
            {
            }
            finally
            {
            }
            var fibNumbers = new List<int> {0};
            foreach (int number in fibNumbers)
            {
               
            }
            goto IL0000;
        IL0000:
            bool p = false;
        }
        private async void abc(string penis)
        {
            MyMethod();
            await MyMethodAsync();
        }
        void MyMethod()
        {
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            { MessageBox.Show("Exception at VOID MYMETHOD"); }
        }
        async Task MyMethodAsync()
        {
            // Do asynchronous work.
            try
            {
                await Task.Delay(1000);
            }
            catch (Exception ex)
            { MessageBox.Show("Exception at ASYNC TASK MTMETHOD"); }
        }
        private struct v
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public int intVar = 100;
        public uint lol = 1000;
        public byte lol2 = 123;
        public short hahsa = 12931;
        public ushort lol3 = 18979;
        public sbyte usa = 30;
        public ulong ha = 9312123132123123;
        public long ajksd = 2139812381209312;
        public decimal extere = 0.3m;
        public double wewe = 12931293.123912;
        public float floatVar = 10.2f;
        public string[] loooooool = { "a", "b", "c", "d", "wee" };
        public string stringVar = "Hello World!";
        public char charVar = 'A';
        public bool boolVar = true;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            AppendText(richTextBox1, Color.Red, intVar.ToString());
            AppendText(richTextBox1, Color.Red, lol.ToString());
            AppendText(richTextBox1, Color.Red, lol2.ToString());
            AppendText(richTextBox1, Color.Red, hahsa.ToString());
            AppendText(richTextBox1, Color.Red, lol3.ToString());
            AppendText(richTextBox1, Color.Red, usa.ToString());
            AppendText(richTextBox1, Color.Red, ha.ToString());
            AppendText(richTextBox1, Color.Red, ajksd.ToString());
            AppendText(richTextBox1, Color.Red, extere.ToString());
            AppendText(richTextBox1, Color.Red, wewe.ToString());
            AppendText(richTextBox1, Color.Red, floatVar.ToString());
            AppendText(richTextBox1, Color.Red, string.Join(",", loooooool));
            AppendText(richTextBox1, Color.Red, stringVar.ToString());
            AppendText(richTextBox1, Color.Red, charVar.ToString());
            AppendText(richTextBox1, Color.Red, boolVar.ToString());



        }
        public void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
            }
            box.SelectionLength = 0; // clear
            AppendText2(richTextBox1, Color.White, "\n");
        }
        public static void AppendText2(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
            }
            box.SelectionLength = 0; 
        }
    }
}

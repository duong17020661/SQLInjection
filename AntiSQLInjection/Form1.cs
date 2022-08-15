using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using gudusoft.gsqlparser;
using gudusoft.gsqlparser.Units;

using System.Diagnostics;

namespace antiSQLInjection
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			String testSQL = "select empname  from emp where empno = 10; -- comment at the end of sql statement, maybe a sql injection";
			txtInputSQL.Text = testSQL;

			txtOutput.Text = testInjection(txtInputSQL.Text);

		}

		private String testInjection(String testSQL)
		{
			TAntiSQLInjection anti = new TAntiSQLInjection(TDbVendor.DbVOracle);
			String msg = "";
			if (anti.isInjected(txtInputSQL.Text))
			{
				msg = "SQL injected found:";
				for (int i = 0; i < anti.getSqlInjections().Count; i++)
				{
					msg = msg + Environment.NewLine + ("type: " + anti.getSqlInjections()[i].getType() + ", description: " + anti.getSqlInjections()[i].getDescription());
				}
			}
			else
			{
				msg = "Not injected !";
			}

			return msg;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			String testSQL = "select col1  from table1 where col1 > 1; update table2 set col1=1";
			txtInputSQL.Text = testSQL;

			txtOutput.Text = testInjection(txtInputSQL.Text);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			String testSQL = "select col1  from table1 where col1 > 1; drop table t1;";
			txtInputSQL.Text = testSQL;

			txtOutput.Text = testInjection(txtInputSQL.Text);

		}

		private void button4_Click(object sender, EventArgs e)
		{

			String testSQL = "select col1  from table1 where col1 > 1 union select col2 from table2";
			txtInputSQL.Text = testSQL;

			txtOutput.Text = testInjection(txtInputSQL.Text);

		}

		private void button5_Click(object sender, EventArgs e)
		{
			txtOutput.Text = "This feature is not implemented yet, please contact info@sqlparser.com for feature request";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Process ps = new Process();
			string yourURL = "http://www.dpriver.com/blog/anti-sql-injection-tool/?ref=csharp_demo";
			ps.StartInfo.FileName = "iexplore.exe";
			ps.StartInfo.Arguments = yourURL;
			ps.Start();

		}

		private void button7_Click(object sender, EventArgs e)
		{
			Process ps = new Process();
			string yourURL = "http://www.dpriver.com/blog/anti-sql-injection-tool/?ref=csharp_demo";
			ps.StartInfo.FileName = "mailto:info@sqlparser.com";
			ps.StartInfo.Arguments = yourURL;
			ps.Start();

		}

		
		void Button8Click(object sender, EventArgs e)
		{
			String testSQL = "select col1 from table1 where col1=null or 1=1";
			txtInputSQL.Text = testSQL;

			txtOutput.Text = testInjection(txtInputSQL.Text);
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			String testSQL = "select col1 from table1 where col1 > 1 and 1=2";
			txtInputSQL.Text = testSQL;

			txtOutput.Text = testInjection(txtInputSQL.Text);
		}
	}
}
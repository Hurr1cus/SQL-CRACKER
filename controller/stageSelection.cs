using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace SQLCRACKER {
    public partial class stageSelection : Form {
        public static testStage stg = null; // 定义主界面全局变量
        public static int currentStage; // 传递关卡数
        public static string currentSQL; // 传递正确SQL
        private static ArrayList inforList = new ArrayList();
        public static mainForm MainForm;
        

        public stageSelection() {
            InitializeComponent();
            for (int i=userData.stage+1;i<=50;i++) {
                Button button = (Button)this.Controls.Find("buttonQuestion" + i, true)[0];
                button.Enabled = false;
                button.Text = "--";               
            }           
            addInformation();

        }
        

        private void addInformation() {
            inforList.Add(new String[]{"单字段查询",
            "查询emp表中每个雇员的编号(empno)。",
            "使用“SELECT 字段名 FROM 表名”进行查询。",
            "SELECT empno FROM emp"});
            inforList.Add(new String[]{
            "多字段查询","查询emp表中每个雇员的编号、姓名(ename)、基本工资(sal)。",
            "查询多个字段时用逗号(, )隔开字段名。",
            "SELECT empno, ename, sal FROM emp"});
            inforList.Add(new String[]{"全表查询", "查询emp表中的所有数据。",
            "使用“SELECT 字段名 FROM 表名”进行查询。所有的字段用“*”表示。",
            "SELECT * FROM emp" });
            inforList.Add(new String[]{"去重字段查询",
            "找出所有不重复的部门代号(deptno)。",
            "在字段名前加上“DISTINCT”可以去重复项。",
            "SELECT DISTINCT deptno FROM emp" });
            inforList.Add(new String[]{"去重字段查询",
            "公司每个雇员每年可以领取5000元的年终奖金, 要求查询雇员编号、雇员姓名和增长后的年基本工资。",
            "字段名可以直接进行运算。",
            "SELECT empno, ename, sal * 12 + 5000 FROM emp" });//1~5
            inforList.Add(new String[]{ "数字条件查询",
            "找出薪水小于3000的员工数据。",
            "使用“SELECT 字段名 FROM 表名 WHERE 条件”可以进行查询，条件中，字段名当作变量使用。",
            "SELECT * FROM emp WHERE sal<3000" });
            inforList.Add(new String[]{"文本条件查询",
            "找出员工姓名为'CLARK'的员工数据。",
            "查询文本时使用单引号（''）。",
            "SELECT * FROM emp WHERE ename = 'CLARK'" });
            inforList.Add(new String[]{"空值条件查询",
            "显示主管(mgr)为空的员工资料。",
            "空值用“NULL”表示，并且使用“字段名 IS NULL”而非“字段名 = NULL”。",
            "SELECT * FROM emp WHERE mgr IS NULL" });
            inforList.Add(new String[]{"非空条件查询",
            "显示主管(mgr)不为空的员工资料。",
            "非空值用“字段名 IS NOT NULL”。",
            "SELECT * FROM emp WHERE mgr IS NOT NULL" });
            inforList.Add(new String[]{ "不等于条件查询" ,
            "查询所有职位(job)不是职员(CLERK)的雇员的完整信息。" ,
            "不等于用“<>”表示。" ,
            "SELECT * FROM emp WHERE job <> 'CLERK'" }); //6~10
            inforList.Add(new String[]{"与查询",
            "查询出工资范围在1500～3000（包含1500和3000）的全部雇员信息。",
            "多个条件同时满足才成立叫做“与”，用AND表示。两个与条件写作“条件A AND 条件B”。",
            "SELECT * FROM emp WHERE sal >=1500 AND sal <= 3000" });
            inforList.Add(new String[]{"或查询",
            "查询所有不领取佣金(comm)（佣金为0或无数据）的雇员的完整信息。" ,
            "多个条件中满足任一条件即成立叫做“或”，用OR表示。两个与条件写作“条件A OR 条件B”。"  ,
            "SELECT * FROM emp WHERE comm IS NULL OR comm=0" });
            inforList.Add(new String[]{"文本多条件查询",
            "显示职位非'PRESIDENT'、非'MANAGER'的员工数据。",
            "本题应该用AND还是OR呢？",
            "SELECT * FROM emp WHERE job <> 'PRESIDENT' AND job <> 'MANAGER'" });
            inforList.Add(new String[]{"多条件综合查询(1)",
            "查询出部门号为10中的经理或者是部门号为20的业务员的信息。",
            "SQL语句中，先判断AND再判断OR。",
            "SELECT * FROM emp WHERE deptno=10 AND job='MANAGER' OR deptno=20 AND job='CLERK'" });
            inforList.Add(new String[]{"多条件综合查询(2)",
            "列出所有不领取佣金的雇员, 而且同时要求这些雇员的基本工资大于2000的全部雇员信息。",
            "如果语句用圆括号括住，那么就先判断这句语句。",
            "SELECT * FROM emp WHERE (comm IS NULL OR comm=0) AND sal>2000" }); //11~15
            inforList.Add(new String[]{"开头是…",
            "找出员工名字为S开头的全部雇员信息。",
            "模糊查找时使用“字段名 LIKE '表达式'”。符号“%”表示任意个字符，如'M%'可以查找到'Mary'、'M'和'Mercy'。",
            "SELECT * FROM emp WHERE ename LIKE 'S%'" });
            inforList.Add(new String[]{"包含…",
            "查询出姓名中任意位置包含字母F的雇员信息。",
            "表达式中可以使用多个通配符。",
            "SELECT * FROM emp WHERE ename LIKE '%F%'" });
            inforList.Add(new String[]{"不包含…",
            "查询出姓名中不包含字母F的雇员信息。",
            "“NOT LIKE '表达式'”可以查找不符合条件的记录。",
            "SELECT * FROM emp WHERE ename NOT LIKE '%F%'" });
            inforList.Add(new String[]{"特定位置包含…"  ,
            "查询雇员姓名的第二个字母是“M”的全部雇员信息。" ,
            "下划线“_”表示单个字符。n个下划线连用，就是n个字符。",
            "SELECT * FROM emp WHERE ename LIKE '_M%'" });
            inforList.Add(new String[]{ "通配符综合查询",
            "找出部门10中所有经理(MANAGER), 部门20中所有办事员(CLERK), 既不是经理又不是办事员但其薪金大于2000的所有员工的详细资料, 并且要求这些雇员的姓名之中包含有字母S或字母K。",
            "请使用所学内容解决这道问题吧。",
            "SELECT * FROM emp WHERE (deptno=10 AND job='MANAGER' OR deptno=20 AND job='CLERK' OR job<>'MANAGER' AND job<>'CLERK' AND sal>2000) AND (ename LIKE '%S%' OR ename LIKE '%K%')" }); //16~20
            inforList.Add(new String[]{ "升序排序",
            "依照员工薪水由小至大排列。",
            "“SELECT 字段名 FROM 表名 ORDER BY 字段1 ASC”表示按照字段1进行升序排序。ASC可以省略。",
            "SELECT * FROM emp ORDER BY sal" });
            inforList.Add(new String[]{"降序排序",
            "依照员工薪水由大至小排列。",
            "“ORDER BY 字段1 DESC”表示按照字段1进行降序排序。DESC不能省略。",
            "SELECT * FROM emp ORDER BY sal DESC" });
            inforList.Add(new String[]{"多条件排序",
            "查询出所有雇员信息，要求按照基本工资由高到低排序。如果工资相等则按照雇佣日期按照由早到晚的顺序进行排序。",
            "“ORDER BY 字段1 ASC/DESC, 字段2 ASC/DESC, …”表示按照字段1进行排序，字段1相同的话就按字段2排序。",
            "SELECT * FROM emp ORDER BY sal DESC, hiredate ASC" });
            inforList.Add(new String[]{"筛选后排序",
            "查询出所有办事员(CLERK)的详细资料列出, 并且按照基本工资由低到高排序。",
            "ORDER BY子句放在WHERE子句后。",
            "SELECT * FROM emp WHERE job='CLERK' ORDER BY sal" });
            inforList.Add(new String[]{"综合排序",
            "找出部门代号为20且薪水介于2000及4000(含2000及4000), 并依照资深至资浅排序。",
            "请使用所学内容解决这道问题吧，资深可以从雇佣日期(hiredate)中看出。",
            "SELECT * FROM emp WHERE deptno=20 AND sal>=2000 AND sal<=4000 ORDER BY hiredate" }); //21~25
            inforList.Add(new String[]{ "四舍五入到整数",
            "列出每个雇员的姓名和日工资(保留整数)情况。",
            "ROUND(计算式)函数用于四舍五入计算式结果到整数。本章中每个月均看作30天。",
            "SELECT ename, ROUND(sal/30) FROM emp" });
            inforList.Add(new String[]{"四舍五入到小数",
            "列出每个雇员的姓名和日工资(保留2位小数)情况。",
            "ROUND()函数加上第二个参数就可以指定保留位数，例如ROUND(字段1, 3)会将字段1保留三位小数。",
            "SELECT ename, ROUND(sal/30, 2) FROM emp" });
            inforList.Add(new String[]{"截取到整数",
            "列出每个雇员的姓名和日工资(直接舍弃小数取整)情况。",
            "TRUNC()函数的语法和ROUND()相同，但相比ROUND()进行四舍五入，TRUNC()直接舍弃。例如ROUND(12.9)=13，而TRUNC(12.9)=12。",
            "SELECT ename, TRUNC(sal/30) FROM emp" });
            inforList.Add(new String[]{"截取到那一位",
            "列出每个雇员的姓名和月工资(无条件舍去到整数字数的千位数)情况。",
            "TRUNC()和ROUND()的第二个参数如果是负数，则会往小数点左侧进行截取或四舍五入。",
            "SELECT ename, TRUNC(sal, -3) FROM emp" });
            inforList.Add(new String[]{"截取和四舍五入",
            "列出每个雇员的姓名、工号、日工资（保留1位小数）以及降序排列的月工资（直接截取到百位数）情况。",
            "请使用所学内容解决这道问题吧。",
            "SELECT ename, empno, ROUND(sal/30, 1), TRUNC(sal, -2) FROM emp ORDER BY sal DESC" });//26~30
            inforList.Add(new String[]{"CASE WHEN",
            "显示员工名字、及性别代号(性别(sex)为1显示M, 性别为0显示F)。",
            "使用条件语句“CASE WHEN 条件1 THEN 值1 WHEN 条件2 THEN 值2 END”。当条件1成立时输出值1，当条件2成立时输出值2。",
            "SELECT ename, (CASE WHEN sex=1 THEN 'M' WHEN sex=0 THEN 'F' END) FROM emp" });
        }
        private void StageSelection_Load(object sender, EventArgs e) {
            label_username.Text = userData.userName + "，欢迎回来!";                     
            label_belong.Text = "您目前的进度：" + userData.stage + "/50，所持金币数：" +  userData.coin;
        }

        public void refresh() {
            label_belong.Text = "您目前的进度：" + userData.stage + "/50，所持金币数：" + userData.coin;
        }
        private void StageSelection_FormClosing(object sender, FormClosingEventArgs e) {
            stg = null;
        }

        private void createStage(String label_stageText, String label_questionText, String label_hintText, String correctSql) {
            if (stg == null) {
                stg = new testStage();
                stg.label_stage.Text = label_stageText;
                stg.label_question.Text = label_questionText;
                stg.label_hint.Text = label_hintText;
                stg.correctSql = correctSql;
                stg.stageSelection = this;
                int bigStage = currentStage / 5 + 1;
                int subStage = currentStage % 5;
                int percentStage = currentStage * 2;
                stg.toolStripProgressBar1.Text = "当前关卡 " + bigStage + " - " + subStage;
                stg.toolStripProgressBar2.Value = percentStage;
                stg.toolStripStatusLabel1.Text = currentStage + "/50";
                this.Hide();
                DialogResult result=stg.ShowDialog();
                this.Show();
                if (result == DialogResult.Yes) MessageBox.Show("??");
            }
            else {
                stg.Activate();
                stg.WindowState = FormWindowState.Normal;
            }
        }
        private void selectStage(object sender, EventArgs e) {
            currentStage = int.Parse(((Button)sender).Text);
            String[] infor = (String[])inforList[currentStage - 1];
            createStage(infor[0], infor[1], infor[2], infor[3]);
        }

        private void StageSelection_FormClosed(object sender, FormClosedEventArgs e) {
            this.Hide();
            //DialogResult d = this.ShowDialog();
            //if (d == DialogResult.Cancel)
            //    this.Visible = true;
        }
    }
}

using System.ComponentModel;
using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public class Tasks
    {
        private int maximumprintimagewidth = 7168;
        private string name = "default";
        private int totalnumberofsubdivisions = 0;
        private int distfromtrigger = 0;
        private int targettimes = 0;
        private int finishedtimes = 0;

        //最大打印图像宽度
        [CategoryAttribute("任务"), DisplayName("最大打印图像宽度 (pix)"), DescriptionAttribute("由系统配置限制的最大可打印图像宽度"), ReadOnlyAttribute(true)]
        public int Maximumprintimagewidth
        {
            get { return maximumprintimagewidth; }
            set { maximumprintimagewidth = value; }
        }

        //名称
        [CategoryAttribute("任务"), DisplayName("名称"), DescriptionAttribute("任务文件路径及文件名"), ReadOnlyAttribute(true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //任务子项总数
        [CategoryAttribute("名称"), DisplayName("任务子项总数"), DescriptionAttribute("任务包含的子文件数"), ReadOnlyAttribute(true)]
        public int Totalnumberofsubdivisions
        {
            get { return totalnumberofsubdivisions; }
            set { totalnumberofsubdivisions = value; }
        }
        //距触发
        [CategoryAttribute("触发延时打印"), DisplayName("距触发(0.01mm)") DescriptionAttribute("传感器触发信号延时设定距离后再开始打印")]
        public int Distfromtrigger
        {
            get { return distfromtrigger; }
            set { distfromtrigger = value; }
        }
        //目标总次数
        [CategoryAttribute("任务循环次数"), DisplayName("目标总次数"), DescriptionAttribute("设定本任务总循环打印次数")]
        public int Targettimes
        {
            get { return targettimes; }
            set { targettimes = value; }
        }
        //完成次数
        [CategoryAttribute("任务循环次数"), DisplayName("完成次数"), DescriptionAttribute("已经循环打印的次数"), ReadOnlyAttribute(true)]
        public int Finishedtimes
        {
            get { return finishedtimes; }
            set { finishedtimes = value; }
        }
    }
}

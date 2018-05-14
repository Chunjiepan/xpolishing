using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public class Tasks
    {
        //最大打印图像宽度
        [CategoryAttribute("最大打印图像宽度 (pix)"), DescriptionAttribute("最大打印图像宽度 (pix)"), ReadOnlyAttribute(true)]
        public int Maximumprintimagewidth {
            get;
            set;
        }
        //名称
        [CategoryAttribute("名称"), DescriptionAttribute("名称"), ReadOnlyAttribute(true)]
        public string Name
        {
            get;
            set;
        }
        //任务子项总数
        [CategoryAttribute("任务子项总数"), DescriptionAttribute("任务子项总数"), ReadOnlyAttribute(true)]
        public string Totalnumberofsubdivisions
        {
            get;
            set;
        }
        //距触发
        [CategoryAttribute("距触发(0.1mm)"), DescriptionAttribute("距触发(0.1mm)")]
        public int distfromtrigger
        {
            get;
            set;
        }
        //目标总次数
        [CategoryAttribute("目标总次数"), DescriptionAttribute("目标总次数")]
        public int Targettimes
        {
            get;
            set;
        }
        //完成次数
        [CategoryAttribute("完成次数"), DescriptionAttribute("完成次数"), ReadOnlyAttribute(true)]
        public int finishedtimes
        {
            get;
            set;
        }
    }

}

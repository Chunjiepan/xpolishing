using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public class Tasks
    {
        //����ӡͼ����
        [CategoryAttribute("����ӡͼ���� (pix)"), DescriptionAttribute("����ӡͼ���� (pix)"), ReadOnlyAttribute(true)]
        public int Maximumprintimagewidth {
            get;
            set;
        }
        //����
        [CategoryAttribute("����"), DescriptionAttribute("����"), ReadOnlyAttribute(true)]
        public string Name
        {
            get;
            set;
        }
        //������������
        [CategoryAttribute("������������"), DescriptionAttribute("������������"), ReadOnlyAttribute(true)]
        public string Totalnumberofsubdivisions
        {
            get;
            set;
        }
        //�ഥ��
        [CategoryAttribute("�ഥ��(0.1mm)"), DescriptionAttribute("�ഥ��(0.1mm)")]
        public int distfromtrigger
        {
            get;
            set;
        }
        //Ŀ���ܴ���
        [CategoryAttribute("Ŀ���ܴ���"), DescriptionAttribute("Ŀ���ܴ���")]
        public int Targettimes
        {
            get;
            set;
        }
        //��ɴ���
        [CategoryAttribute("��ɴ���"), DescriptionAttribute("��ɴ���"), ReadOnlyAttribute(true)]
        public int finishedtimes
        {
            get;
            set;
        }
    }

}

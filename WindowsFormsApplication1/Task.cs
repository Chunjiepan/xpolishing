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

        //����ӡͼ����
        [CategoryAttribute("����"), DisplayName("����ӡͼ���� (pix)"), DescriptionAttribute("��ϵͳ�������Ƶ����ɴ�ӡͼ����"), ReadOnlyAttribute(true)]
        public int Maximumprintimagewidth
        {
            get { return maximumprintimagewidth; }
            set { maximumprintimagewidth = value; }
        }

        //����
        [CategoryAttribute("����"), DisplayName("����"), DescriptionAttribute("�����ļ�·�����ļ���"), ReadOnlyAttribute(true)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //������������
        [CategoryAttribute("����"), DisplayName("������������"), DescriptionAttribute("������������ļ���"), ReadOnlyAttribute(true)]
        public int Totalnumberofsubdivisions
        {
            get { return totalnumberofsubdivisions; }
            set { totalnumberofsubdivisions = value; }
        }
        //�ഥ��
        [CategoryAttribute("������ʱ��ӡ"), DisplayName("�ഥ��(0.01mm)") DescriptionAttribute("�����������ź���ʱ�趨������ٿ�ʼ��ӡ")]
        public int Distfromtrigger
        {
            get { return distfromtrigger; }
            set { distfromtrigger = value; }
        }
        //Ŀ���ܴ���
        [CategoryAttribute("����ѭ������"), DisplayName("Ŀ���ܴ���"), DescriptionAttribute("�趨��������ѭ����ӡ����")]
        public int Targettimes
        {
            get { return targettimes; }
            set { targettimes = value; }
        }
        //��ɴ���
        [CategoryAttribute("����ѭ������"), DisplayName("��ɴ���"), DescriptionAttribute("�Ѿ�ѭ����ӡ�Ĵ���"), ReadOnlyAttribute(true)]
        public int Finishedtimes
        {
            get { return finishedtimes; }
            set { finishedtimes = value; }
        }
    }
}

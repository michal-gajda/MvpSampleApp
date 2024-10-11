namespace WinUI
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
#if AP
            var class1 = new Domain.Class1();

            class1.Message = "Hello from AP";

            MessageBox.Show(class1.Message);
#endif
        }
    }
}

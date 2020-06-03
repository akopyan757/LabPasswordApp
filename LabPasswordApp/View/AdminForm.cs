using LabPasswordApp._view.Base;
using System.Windows.Forms;

namespace LabPasswordApp.Forms
{
    public partial class AdminForm : Form, IAdminView
    {
        private readonly ApplicationContext _context;

        public AdminForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowError(string messageError)
        {
            MessageBox.Show(
                  messageError,
                  "Ошибка",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
             );
        }
    }
}

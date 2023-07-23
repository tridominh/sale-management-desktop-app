using BusinessObject.Entity;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMemberView : Form
    {
        private MemberRepository memberRepo = new();
        private BindingSource source;
        public string Title { get; set; }
        public Member? Member { get; set; }

        public frmMemberView()
        {
            InitializeComponent();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void frmView_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers(string searchString = null)
        {
            MemberRepository memberRep = new();
            source = new BindingSource();
            var members = memberRep.GetAll();
            if (searchString != null)
            {
                members = members.Where(m => m.Email.Contains(searchString));
            }
            source.DataSource = members;

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMemberAddUpdate addNew = new()
            {
                Title = "Add New",
                InsertOrUpdate = true,
            };
            if (addNew.ShowDialog() == DialogResult.OK)
            {
                addNew.Close();
                LoadMembers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberAddUpdate update = new()
            {
                Title = "Update",
                InsertOrUpdate = false,
                Member = (Member)dataGridView1.SelectedRows[0].DataBoundItem,
            };
            if (update.ShowDialog() == DialogResult.OK)
            {
                update.Close();
                LoadMembers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var members = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(row => (Member)row.DataBoundItem);
            if (MessageBox.Show("Are you sure to delete", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var member in members)
                {
                    memberRepo.Delete(member.Id);
                }
                LoadMembers();
            }
        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            LoadMembers(txtSearch.Text);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
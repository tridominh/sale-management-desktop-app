using BusinessObject.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberAddUpdate : Form
    {
        private MemberRepository memberRepo = new();
        public string Title { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member Member { get; set; }
        public frmMemberAddUpdate()
        {
            InitializeComponent();
        }

        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            Text = Title;
            txtId.Enabled = false;
            if (!InsertOrUpdate)
            {
                txtId.Text = Member.Id + "";
                txtEmail.Text = Member.Email;
                txtCompanyName.Text = Member.CompanyName;
                txtCity.Text = Member.City;
                txtCountry.Text = Member.Country;
                txtPassword.Text = Member.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new()
                {
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                };
                if (InsertOrUpdate)
                {
                    memberRepo.Insert(member);
                }
                else
                {
                    member.Id = Member.Id;
                    memberRepo.Update(member);
                    Member = member;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using BusinessObject.Model;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        MemberRepository memberRepository;
        public frmLogin()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is not empty!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is not empty!");
            }
            else
            {
                if (memberRepository.AuthorizeAdmin(txtEmail.Text, txtPassword.Text))
                {
                    frmMain main = new()
                    {
                        Role = 1,
                    };
                    Hide();
                    main.ShowDialog();
                }
                else
                {
                    var user = memberRepository.GetAll()
                            .Where(m => m.Email == txtEmail.Text && m.Password == txtPassword.Text)
                            .FirstOrDefault();
                    if (user == null)
                    {
                        MessageBox.Show("Invalid Email or Password!");
                    }
                    else
                    {
                        frmMain main = new()
                        {
                            Role = 2,
                            Member = user
                        };
                        Hide();
                        main.ShowDialog();
                    }
                }
            }
        }
    }
}

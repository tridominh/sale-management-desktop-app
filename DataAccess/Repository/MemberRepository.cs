using BusinessObject.Entity;
using BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        SalesManagementContext context;
        public MemberRepository() {
            context = new SalesManagementContext();
        }
        public void Delete(int id)
        {
            context.Members.Remove(Get(id));
        }

        public Member Get(int id) => context.Members.Find(id);

        public IEnumerable<Member> GetAll()
        {
            return context.Members.ToList();
        }

        public void Insert(Member member)
        {
            if(member != null)
            {
                context.Members.Add(member);
                context.SaveChanges();
            }
        }

        public void Update(Member member)
        {
            if (member != null)
            {
                context.Members.Update(member);
                context.SaveChanges();
            }
        }

        public bool AuthorizeAdmin(string email, string password) 
        { 
            var admin = context.GetAdmin(); 
            if(email == admin.Email && password == admin.Password)
            {
                return true;
            }
            return false;
        }
    }
}

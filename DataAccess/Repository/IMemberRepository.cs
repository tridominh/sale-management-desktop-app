using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAll();
        Member Get(int id);
        void Insert(Member member);
        void Delete(int id);
        void Update(Member member);
    }
}

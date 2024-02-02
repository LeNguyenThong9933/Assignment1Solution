using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int MemberID);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int MemberID);
    }
}

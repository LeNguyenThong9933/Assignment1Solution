using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int MemberID) => MemberDAO.Instance.RemoveMember(MemberID);
        public Member GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList;
        public void InsertMember(Member member) => MemberDAO.Instance.AddMember(member);
        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
    }
}

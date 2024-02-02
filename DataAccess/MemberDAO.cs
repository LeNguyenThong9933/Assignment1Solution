using BusinessObject;
using DataAccess.Repos;
using System.Diagnostics;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> MemberList = new List<Member>()
        {
            new Member{MemberID = 1, MemberName = "Anh", City = "Ha Noi", Country = "Vietnam", Email = "anh1@gmail.com", Password = "anhhanoi1"},
            new Member{MemberID = 2, MemberName = "Tom", City = "New York", Country = "USA", Email = "joetheman@gmail.com", Password = "tommy1"},
            new Member{MemberID = 3, MemberName = "Joe", City = "London", Country = "England", Email = "tom@me.com", Password = "joeusa1"},
            new Member{MemberID = 4, MemberName = "Chi", City = "Sai Gon", Country = "Vietnam", Email = "chi@gmail.com", Password = "chi1"}
        };
       
        //Singleton pattern
        private static MemberDAO instance = null;
        private static readonly object instancelock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetMemberList => MemberList;
        public Member GetMemberByID(int memberID)
        {
            //using LINQ to object
            Member member = MemberList.SingleOrDefault(pro => pro.MemberID == memberID);
            return member;
        }
        
        public void AddMember (Member member) 
        {
            Member pro = GetMemberByID(member.MemberID);
            if (pro == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member has already exists");
            }
        }
        public void RemoveMember (int MemberID) 
        {
            Member m = GetMemberByID(MemberID);
            if (m != null)
            {
                MemberList.Remove(m);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        public void UpdateMember(Member member) 
        {
            Member mem = GetMemberByID(member.MemberID);           
            if (mem != null)
            {
                var index = MemberList.IndexOf(mem);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        public Member GetMemberByEmailAndPassword(string email, string password)
        {
            Member member = MemberList.SingleOrDefault(m => m.Email == email && m.Password == password);
            return member;
        }
    }//end class
}//end namespace
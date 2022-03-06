using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberID) => MemberDAO.Instance.Remove(memberID);

        public MemberObject GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMembers();

        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
    }
}

using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        public List<MemberObject> GetMembers()
        {
            IDataReader dataReader = null;
            var list = new List<MemberObject>();
            string SQLSelect = "select MemberID, Email, CompanyName, City, Country, Password from Member";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                    while (dataReader.Read())
                    {
                        list.Add(new MemberObject
                        {
                            MemberID = dataReader.GetInt32(0),
                            Email = dataReader.GetString(1),
                            CompanyName = dataReader.GetString(2),
                            City = dataReader.GetString(3),
                            Country = dataReader.GetString(4),
                            Password = dataReader.GetString(5)
                        });
                    }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return list;
        }

        //Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public MemberObject GetMemberByID (int memberID)
        {
            MemberObject mem = null;
            IDataReader dataReader = null;
            string SQL = "select MemberID, Email, CompanyName, City, Country, Password from Member where MemberId = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQL, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    mem = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return mem;
        }

        public void AddNew(MemberObject member) {
        try
            {
                MemberObject mem = GetMemberByID(member.MemberID);
                if (mem == null)
                {
                    string SQL = "INSERT INTO Member "
                        + "VALUES(@MemberID, @Email, @CompanyName, @City, @Country, @Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    dataProvider.Insert(SQL, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member is already exist");
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                CloseConnection();
            }
        }

        public void Update (MemberObject member)
        {
            try
            {
                MemberObject mem = GetMemberByID(member.MemberID);
                if (mem != null)
                {
                    string SQL = "Update Member set Email = @Email, CompanyName = @CompanyName, City = @City, Country = @Country, Password = @Password where MemberID = @MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("CompanyName", 50, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("Country", 50, member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("Password", 50, member.Password, DbType.String));
                    dataProvider.Update(SQL, CommandType.Text, parameters.ToArray());
                } else
                {
                    throw new Exception("The member does not exist");
                }
            } catch (Exception ex )
            {
                throw new Exception(ex.Message);
            } finally
            {
                CloseConnection();
            }
        }

        public void Remove(int memberID)
        {
            try
            {
                MemberObject mem = GetMemberByID(memberID);
                if (mem != null)
                {
                    string SQL = "Delete Member where MemberID = @MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                    dataProvider.Delete(SQL, CommandType.Text, param);
                } else
                {
                    throw new Exception("The member does not already exist");
                }
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } finally
            {
                CloseConnection();
            }
        }
    }
}

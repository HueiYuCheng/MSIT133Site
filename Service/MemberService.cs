using Dapper;
using MSIT133Site.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MSIT133Site.Service
{
    public class MemberService : IMemberService
    {
        private IDbConnection _dbConnection;
        public MemberService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public string Register(RegisterRequestModel request)
        {
            try
            {
                string sqlCheck = "SELECT COUNT(1) FROM Members WHERE Email=@Email";
                var parametersCheck = new
                {
                    Email = request.Email,
                };

                var c = _dbConnection.ExecuteScalar<int>(sqlCheck, parametersCheck);
                if (c != 0)
                {
                    return "EMAIL重複";
                }
                

                string sql = @"INSERT INTO Members (
                    [Name]
                    ,[Email]
                    ,[Age]
                    )
                    VALUES(
                    @Name
                    ,@Email
                    ,@Age
                    )";
                var parameters = new
                {
                    Name = request.Name,
                    Email = request.Email,
                    Age=request.Age,
                };
                _dbConnection.Execute(sql, parameters);
                return "註冊成功";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Members GetMember(int memberId)
        {
            string sql = "SELECT * FROM Members WHERE MemberId = @MemberId";
            var parameters = new
            {
                MemberId = memberId
            };
            var member = _dbConnection.QueryFirst<Members>(sql, parameters);
            //var members =  _dbConnection.Query<Members>(sql, parameters);


            return member;
        }
    }
}

using Bogus;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Jeans.User.CoreApi.Models
{
    public class UserModel
    {
        /// <summary>
        /// 标识符
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string ContactName { get; set; }


        public IList<UserModel> GetList()
        {
            Randomizer.Seed = new Random(123456);
            var users = new Faker<UserModel>()
               .RuleFor(c => c.Id, Guid.NewGuid())
               .RuleFor(c => c.Name, f => f.Company.CompanyName());

            return users.Generate(10);
        }
    }
}

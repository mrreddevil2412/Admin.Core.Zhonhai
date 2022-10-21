﻿using ZhonTai.Admin.Core.Db.Transaction;
using ZhonTai.Admin.Core.Repositories;
using ZhonTai.Admin.Domain.UserStaff;

namespace ZhonTai.Admin.Repositories;

public class UserStaffRepository : AppRepositoryBase<UserStaffEntity>, IUserStaffRepository
{
    public UserStaffRepository(UnitOfWorkManagerCloud uowm) : base(uowm)
    {

    }
}
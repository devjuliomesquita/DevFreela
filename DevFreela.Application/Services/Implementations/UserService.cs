﻿using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewUserInputModel newUserInputModel)
        {
            var user = new User(
                newUserInputModel.Firstname,
                newUserInputModel.Lastname,
                newUserInputModel.Email,
                newUserInputModel.PassWord,
                newUserInputModel.BirthDate
                );
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user.Id;
        }

        public UserDetailsViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if(user == null)
            {
                return null;
            }
            return new UserDetailsViewModel(user.FirstName, user.LastName, user.Email);
        }
    }
}

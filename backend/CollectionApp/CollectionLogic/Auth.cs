﻿using CollectionEntities;
using CollectionFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLogic
{
    public class Auth
    {
        private readonly IUser _UserDal = UserFactory.GetUser();
        private bool _loggedIn = false;
        public void Login()
        {
            _loggedIn = true;
        }

        public void Register()
        {

        }

        public Boolean IsLoggedIn()
        {
            return _loggedIn;
        }

        public UserDTO GetLoggedInUser()
        {
            UserDTO user = _UserDal.ById(1);
            return user;
        }
    }
}

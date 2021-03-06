﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Core.Account;
using Project.ViewModels.Story;

namespace Project.ViewModels.UserProfile
{
    public class UserProfileVM
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string AboutMe { get; set; }

        public DateTime? BirthDate { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public bool IsCoach { get; set; }

        public IList<InterestVM> Interests { get; set; }

        public IList<GoalVM> Goals { get; set; }

        public IList<StoryVM> Stories { get; set; }

        public IList<InterestVM> AvailableInterests { get; set; }
    }
}
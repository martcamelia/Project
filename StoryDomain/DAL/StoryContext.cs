﻿using Project.Account.DAL;
using Project.Core.DbContext;
using Project.StoryDomain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Project.StoryDomain.DAL {

    public interface IStoryContext : IDbContext {

        DbSet<Story> Stories { get; set; }

        DbSet<Like> Likes { get; set; }

        DbSet<Comment> Comments { get; set; }

        DbSet<Hashtag> Hashtags { get; set; }

        DbSet<Group> Groups { get; set; }
        DbSet<GroupMember> GroupMembers { get; set; }

    }

    public class StoryContext : IdentityReferenceDbContext<StoryContext>, IStoryContext {

        public DbSet<Story> Stories { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Hashtag> Hashtags { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<GroupMember> GroupMembers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new StoryTypeConfiguration());
            modelBuilder.Configurations.Add(new CommentTypeConfiguration());
        }

    }
}

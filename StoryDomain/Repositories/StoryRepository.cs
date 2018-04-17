﻿using Project.Core.Repositories;
using Project.StoryDomain.DAL;
using Project.StoryDomain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.StoryDomain.Repositories {
    public interface IStoryRepository : IEntityRepository<Story, int> {
        IList<Story> GetUserStories(string userId);

        Task<IList<Story>> GetUserStoriesAsync(string userId);

    }

    public class StoryRepository : EntityRepository<Story, int>, IStoryRepository {

        IStoryContext storyDbContext => context as IStoryContext;

        public StoryRepository(IStoryContext storyDbContext) : base(storyDbContext) { }

        public IList<Story> GetUserStories(string userId) {
            if (string.IsNullOrWhiteSpace(userId) || storyDbContext.Stories == null)
                return new List<Story>();

            return storyDbContext.Stories.Where(story => story.UserId == userId).ToList();
        }

        public async Task<IList<Story>> GetUserStoriesAsync(string userId) {
            if (string.IsNullOrWhiteSpace(userId) || storyDbContext.Stories == null)
                return new List<Story>();

            return await storyDbContext.Stories.Where(story => story.UserId == userId).ToListAsync();
        }

    }
}

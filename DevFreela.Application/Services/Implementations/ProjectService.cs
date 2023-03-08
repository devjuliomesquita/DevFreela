using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService( DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewProjectInputModel newProjectInputModel)
        {
            var project = new Project(
                newProjectInputModel.Title,
                newProjectInputModel.Description,
                newProjectInputModel.IdClient,
                newProjectInputModel.IdFreelancer,
                newProjectInputModel.TotalCost
                );
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
            return project.Id;
        }

        public void CreateComment(CreateCommentInputModel createCommentInputModel)
        {
            var comment = new ProjectComment(
                createCommentInputModel.Content,
                createCommentInputModel.IdProject,
                createCommentInputModel.IdUser
                );
            _dbContext.ProjectComments.Add(comment);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            project.Cancel();
            _dbContext.SaveChanges();
        }

        public void Finish(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.Finish();
            _dbContext.SaveChanges();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbContext.Projects;
            var projectsViewModel = projects
                .Select(p => new ProjectViewModel(p.Id, p.Title, p.CreateAt))
                .ToList();
            return projectsViewModel;
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbContext.Projects
                .Include(p => p.Client)
                .Include(p => p.Freelancer)
                .SingleOrDefault(p => p.Id == id);
            if(project == null) { return null; }
            var projectsDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.TotalCost,
                project.StartedAt,
                project.FinishedAt,
                project.Client.FirstName,
                project.Client.LastName,
                project.Freelancer.FirstName
                );
            return projectsDetailsViewModel;
        }

        public void Start(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.Start();
            _dbContext.SaveChanges();
        }

        public void Update(UpdateProjectInputModel updateProjectInputModel)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == updateProjectInputModel.Id);
            project.Update(
                updateProjectInputModel.Title,
                updateProjectInputModel.Description,
                updateProjectInputModel.TotalCost
                );
            _dbContext.SaveChanges();
        }
    }
}

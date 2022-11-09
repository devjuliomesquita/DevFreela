using DevFreela.Aplication.InputModels;
using DevFreela.Aplication.Services.Interfaces;
using DevFreela.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Aplication.Services.Implementations
{
    internal class ProjectService : IProjectService
    {
        public int Create(NewProjectInputModel inputModel)
        {
            throw new NotImplementedException();///dlkjsdlkfjsldkfjslkdjf
        }

        public void CreateComment(CreatCommentInputModel inputModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Finish(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjecViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Start(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}

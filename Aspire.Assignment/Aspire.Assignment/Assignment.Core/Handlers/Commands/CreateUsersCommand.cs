using MediatR;
using Assignment.Contracts.Data;
using Assignment.Contracts.DTO;
using Assignment.Contracts.Data.Entities;
using FluentValidation;
using System.Text.Json;
using Assignment.Core.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace Assignment.Providers.Handlers.Commands
{
    public class CreateUsersCommand : IRequest<Guid>
    {
        public CreateUsersDTO Model { get; }
        public CreateUsersCommand(CreateUsersDTO model)
        {
            this.Model = model;
        }
    }

    public class CreateUsersCommandHandler : IRequestHandler<CreateUsersCommand, Guid>
    {
        private readonly IUnitOfWork _repository;
        private readonly IValidator<CreateUsersDTO> _validator;
        private readonly IPasswordHasher<Users> _passwordHasher;

        public CreateUsersCommandHandler(IUnitOfWork repository, IValidator<CreateUsersDTO> validator, IPasswordHasher<Users> passwordHasher)
        {
            _repository = repository;
            _validator = validator;
            _passwordHasher = passwordHasher;
        }

        public async Task<Guid> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
        {
            

            if (_repository == null)
        throw new Exception("Repository is not initialized.");

    if (_passwordHasher == null)
        throw new Exception("PasswordHasher is not initialized.");

    CreateUsersDTO model = request.Model;

    if (model == null)
        throw new Exception("Request model is null.");

    if (string.IsNullOrEmpty(model.PasswordHash))
        throw new Exception("Password cannot be empty.");

    if (model.RoleName == null)
        throw new Exception("RoleId cannot be empty.");


            var entity = new Users
            {
                UserId = Guid.NewGuid(),
                Name = model.Name,
                PasswordHash = model.PasswordHash,
                Email = model.Email,
                RoleName = model.RoleName

            };
             entity.PasswordHash= _passwordHasher.HashPassword(entity, model.PasswordHash);
            _repository.Users.Add(entity);
            await _repository.CommitAsync();

            return entity.UserId;
        }
    }
}
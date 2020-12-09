﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using VotingSystem.Application.ViewModels;

// ReSharper disable once UnusedType.Global

namespace VotingSystem.Application.Queries
{
    internal class GetVotingResultHandler : IRequestHandler<GetVotingResult, QuestionResultViewModel>
    {
        public Task<QuestionResultViewModel> Handle(GetVotingResult request, CancellationToken cancellationToken)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
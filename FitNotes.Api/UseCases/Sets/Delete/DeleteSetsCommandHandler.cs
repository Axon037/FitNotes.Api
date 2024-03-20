using FitNotes.Api.Data;
using FitNotes.Api.UseCases.Exercises.Delete;
using MediatR;

namespace FitNotes.Api.UseCases.Sets.Delete
{
    public class DeleteSetsCommandHandler : IRequestHandler<DeleteSetsCommand, Unit>
    {
        private readonly DatabaseContext _databaseContext;

        public DeleteSetsCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Unit> Handle(DeleteSetsCommand request, CancellationToken cancellationToken)
        {
            //_databaseContext.Exercises
            //    .Where(x => x.Id == request.Id)
            //    .Remove();

            var sets = await _databaseContext.Sets.FindAsync(new object[] { request.Id });

            _databaseContext.Sets.Remove(sets);

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

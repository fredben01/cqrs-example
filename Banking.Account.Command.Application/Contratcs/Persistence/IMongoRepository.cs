using Banking.Account.Command.Domain.Common;

namespace Banking.Account.Command.Application.Contratcs.Persistence
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        Task<IEnumerable<TDocument>> GetAll();

        Task<TDocument> GetId(string id);

        Task InsertDocument(TDocument document);

        Task UpdateDocument(TDocument document);

        Task DeleteDocument(string id);

    }
}

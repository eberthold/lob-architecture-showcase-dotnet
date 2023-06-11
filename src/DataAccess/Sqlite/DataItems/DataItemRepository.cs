using BusinessLogic.DataItems;
using BusinessLogic.Repositories;
using BusinessLogic.Results;
using DataAccess.Mappings;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataItems;

public class DataItemRepository : IRepository<DataItemModel, DataItemWriteModel>
{
    private readonly Microsoft.EntityFrameworkCore.IDbContextFactory<SampleDbContext> _dbContextFactory;
    private readonly IMapper<DataItemEntity, DataItemModel> _modelMapper;
    private readonly IMapper<DataItemWriteModel, DataItemEntity> _entityMapper;

    public DataItemRepository(
        IDbContextFactory<SampleDbContext> dbContextFactory,
        IMapper<DataItemEntity, DataItemModel> modelMapper,
        IMapper<DataItemWriteModel, DataItemEntity> entityMapper)
    {
        _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
        _modelMapper = modelMapper ?? throw new ArgumentNullException(nameof(modelMapper));
        _entityMapper = entityMapper ?? throw new ArgumentNullException(nameof(entityMapper));
    }

    public Task<Result<int>> CreateAsync(DataItemWriteModel item)
    {
        var entity = _entityMapper.Map(item);
        entity.Id = 0;

        // write to sql

        return Task.FromResult(Result.FromSuccess(7));
    }

    public Task<Result> DeleteAsync(int id)
    {
        // delete by id

        return Task.FromResult(Result.FromSuccess());
    }

    public async Task<Result<IReadOnlyCollection<DataItemModel>>> GetAllAsync()
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();

        var query = dbContext.DataItems.AsQueryable();
        query = AddIncludes(query);
        var entities = await query.ToListAsync();

        var models = (IReadOnlyCollection<DataItemModel>)entities.Select(_modelMapper.Map).ToList();
        return Result.FromSuccess(models);
    }

    public async Task<Result<DataItemModel>> GetByIdAsync(int id)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();

        var query = dbContext.DataItems.AsQueryable();
        query = AddIncludes(query);
        var entity = await query.FirstOrDefaultAsync(x => x.Id == id);
        if (entity is null)
        {
            return Result<DataItemModel>.FromError("not found");
        }

        var model = _modelMapper.Map(entity);
        return Result.FromSuccess(model);
    }

    public Task<Result> UpdateAsync(DataItemWriteModel item)
    {
        var entity = _entityMapper.Map(item);

        // save and maybe load updated result
        return Task.FromResult(Result.FromSuccess());
    }

    private static IQueryable<DataItemEntity> AddIncludes(IQueryable<DataItemEntity> query)
    {
        return query.Include(x => x.SubEntities);
    }
}
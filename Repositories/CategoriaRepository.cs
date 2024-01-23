using appCardapioOnline.Context;
using appCardapioOnline.Repositories.Interfaces;

namespace appCardapioOnline.Repositories {
    public class CategoriaRepository : ICategoriaRepository {
        private readonly AppDbContext _context;
            public CategoriaRepository(AppDbContext context) {
                _context = context;
            }

            public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
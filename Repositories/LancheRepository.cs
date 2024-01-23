using appCardapioOnline.Context;
using appCardapioOnline.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace appCardapioOnline.Repositories {
    public class LancheRepository : ILancheRepository {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context) {
            context = _context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(lanche => lanche.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                        .Where(lanche => lanche.IsLanchePreferido)
                                                        .Include(l => l.Categoria);

        public Lanche GetLancheById(int lancheId) {
            return _context.Lanches.FirstOrDefault(lanche => lanche.LancheId == lancheId);
        }
    }
}
using Core.Entities;
using Core.Interfases;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories;

public class PersonaRepository : GenericRepository<Persona>, IPersonaRepository
{
    public PersonaRepository(APIContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Persona>> GetPersonasSP() =>
                    await _context.Personas.FromSqlRaw("CONSULTA_PERSONAS").ToListAsync();

    public void CreatePersona(Persona student)
    {
        _context.Personas.Add(student);
    }

    public bool PersonaExists(long id)
    {
        return _context.Personas.Any(e => e.Id == id);
    }
}
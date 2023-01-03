using Core.Entities;
using Core.Interfases;
using Infrastructure.Data;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PruebaAPI.Controllers;

public class PersonasController : BaseApiController
{
    private readonly IPersonaRepository _personaRepository;

    public PersonasController(IPersonaRepository personaRepository)
    {
        _personaRepository = personaRepository;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Persona>>> Get()
    {
        var personas = await _personaRepository
                                    .GetPersonasSP();
        return Ok(personas);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(long id)
    {
        var persona = await _personaRepository.GetByIdAsync(id);
        return Ok(persona);
    }


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Persona>> Post(Persona persona)
    {
        persona.NombreCompleto = persona.Nombre + " " + persona.Apellido;
        persona.NumeroIdentificacionTipo = persona.TipoIdentificacion + " " + persona.NumeroIdentificacion;
        _personaRepository.Add(persona);
        await _personaRepository.SaveAsync();

        return CreatedAtAction("Get", new { id = persona.Id }, persona);
    }


    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PutPersona(long id, Persona persona)
    {
        persona.NombreCompleto = persona.Nombre + " " + persona.Apellido;
        persona.NumeroIdentificacionTipo = persona.TipoIdentificacion + " " + persona.NumeroIdentificacion;
        if (id != persona.Id)
            return BadRequest();


        try
        {
            _personaRepository.Update(persona);
            await _personaRepository.SaveAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_personaRepository.PersonaExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return CreatedAtAction("Get", new { id = persona.Id }, persona);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePersona(long id)
    {
        var persona = await _personaRepository.GetByIdAsync(id);
        if (persona == null)
            return NotFound();

        _personaRepository.Remove(persona);
        await _personaRepository.SaveAsync();

        return Ok();
    }

}

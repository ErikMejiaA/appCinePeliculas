using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class GeneroController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public GeneroController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET TRAER DATAS
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<GeneroDto>> Get()
    {
        var generos = await _UnitOfWork.Generos.GetAllAsync();
        return this.mapper.Map<List<GeneroDto>>(generos);
        
    }

    //METODO GET POR ID TRAER DATA
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<GeneroDto>> Get(int id)
    {
        var genero = await _UnitOfWork.Generos.GetByIdAsync(id);
        if (genero == null) {
            return NotFound();
        }
        return this.mapper.Map<GeneroDto>(genero);
    }

    //METODO POST ENVIAR DATA
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<GeneroDto>> Post(GeneroDto nuevosGeneros)
    {
        var generos = this.mapper.Map<Genero>(nuevosGeneros);
        this._UnitOfWork.Generos.Add(generos);
        await _UnitOfWork.SaveAsync();
        if (generos == null) {
            return BadRequest();
        }
        return this.mapper.Map<GeneroDto>(generos);
    }

    //METODO PUT EDITAR
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<GeneroDto>> Put(int id, [FromBody]GeneroDto nuevosGeneros)
    {
        var genero = this.mapper.Map<Genero>(nuevosGeneros);
        if (genero == null) {
            return NotFound();
        }
        genero.IdGenero = id;
        this._UnitOfWork.Generos.Update(genero);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<GeneroDto>(genero);
    }

    //METODO DELETE ELIMIAR DATA
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult> Delete(int id)
    {
        var genero = await this._UnitOfWork.Generos.GetByIdAsync(id);
        if (genero == null) {
            return NotFound();
        }
        this._UnitOfWork.Generos.Remove(genero);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }

}

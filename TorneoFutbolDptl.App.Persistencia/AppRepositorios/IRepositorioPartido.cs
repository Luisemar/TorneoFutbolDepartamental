using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioPartido
    {
        Partido AddPartido(Partido partido);
        Partido GetPartido(int idPartido);
        Partido GetPartidoEl(int idPartido);
        Partido GetPartidoEstadio(int idPartido);
        Partido UpdatePartidoELM(Partido partido);    
        void DeletePartido(int idPartido);
        IEnumerable<Partido> GetAllPartidos();
        Partido UpdatePartido(Partido partido);
        Arbitro  AsignarArbitroPartido(int idPartido, int idArbitro);
        Estadio  AsignarEstadioPartido(int idPartido, int idEstadio);
        Novedad  AsignarNovedadPartido(int idPartido, int idNovedad);
        Equipo  AsignarEquipoELPartido(int idPartido, int idEquipo);        
       
    }
}
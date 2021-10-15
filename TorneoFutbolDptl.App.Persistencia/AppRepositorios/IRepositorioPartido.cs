using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioPartido
    {
        Partido AddPartido(Partido partido);
        Partido GetPartido(int idPartido);
        Partido GetPartidoEV(int idPartido);
        void DeletePartido(int idPartido);
        IEnumerable<Partido> GetAllPartidos(); 
        Partido UpdatePartido(Partido partido);
        Partido UpdatePartidoEVM(Partido partido);
        Arbitro  AsignarArbitroPartido(int idPartido, int idArbitro);
        Estadio  AsignarEstadioPartido(int idPartido, int idEstadio);
        Novedad  AsignarNovedadPartido(int idPartido, int idNovedad);
        Equipo  AsignarEquipoPartido(int idPartido, int idEquipo);

    }
}
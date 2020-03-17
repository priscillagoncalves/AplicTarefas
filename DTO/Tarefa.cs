using System;

namespace DTO
{
    public class Tarefa
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}

﻿namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor()
        {
            
        }

        public Professor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }

}

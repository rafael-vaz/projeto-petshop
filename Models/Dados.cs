using System;
using System.Collections.Generic;

namespace projeto_petshop.Models
{
    public class Dados
    {
       public static Agendamento agendado = new Agendamento();

       public static void Inserir(Agendamento agenda){
    
              agendado.nome = agenda.nome;
              agendado.data = agenda.data;
              agendado.fone = agenda.fone;
              agendado.animal = agenda.animal;
              agendado.necessidade = agenda.necessidade;
       }
       
       public static Agendamento Listar(){
           return agendado;
       }

    }
}
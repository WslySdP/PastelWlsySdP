﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace PastelWlsySdP.Dominio
{
    class ClassUsuario_Dom
    {
        private int codigo;
        private string nome;
        private string identificador;
        private string senha;
        private string autenticacao;
        private string situacao;
        private int tipo;
        private DateTime dt_nascimento;
        private string tel;
        private string cel;
        private string email;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private byte[] foto;
        private DataTable usuarios;
        private Image fotoImage;

        public DataTable Usuarios { get => usuarios; set => usuarios = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public DateTime Dt_nascimento { get => dt_nascimento; set => dt_nascimento = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Email { get => email; set => email = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public Image FotoImage { get => fotoImage; set => fotoImage = value; }
    }
}

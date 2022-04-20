﻿using System.ComponentModel.DataAnnotations;

namespace DTO.Common.PersonaDTO
{
    public class PersonaDTO
    {
        public long Id { get; set; }
        public string Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public long IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string? UrlFoto { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

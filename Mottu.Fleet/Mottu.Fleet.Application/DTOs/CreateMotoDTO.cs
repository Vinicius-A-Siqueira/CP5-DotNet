﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mottu.Fleet.Application.DTOs;
public class CreateMotoDto
{
    [Required]
    [StringLength(20)]
    [RegularExpression(@"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$")]
    public string Placa { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Modelo { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue)]
    public int PatioId { get; set; }

    [Range(2000, 2030)]
    public int Ano { get; set; } = DateTime.Now.Year;

    [StringLength(50)]
    public string? Cor { get; set; }

    [Range(0, int.MaxValue)]
    public int Quilometragem { get; set; } = 0;

    [StringLength(50)]
    public string? Chassi { get; set; }

    [StringLength(50)]
    public string? NumeroMotor { get; set; }

    [StringLength(500)]
    public string? Observacoes { get; set; }
}

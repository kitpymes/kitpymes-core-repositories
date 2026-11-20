// -----------------------------------------------------------------------
// <copyright file="PagedOptions.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Repositories;

/*
   Clase de configuración PagedOptions
   Contiene las propiedades para la paginación y ordenamiento de una lista
*/

/// <summary>
/// Clase de configuración <c>PagedOptions</c>.
/// Contiene las propiedades para la paginación y ordenamiento de una lista.
/// </summary>
/// <remarks>
/// <para>En esta clase se pueden agregar todas las propiedades para la paginación y ordenamiento de una lista.</para>
/// </remarks>
public class PagedOptions
{
    /// <summary>
    /// Obtiene o establece el nombre de los campos por lo que se requiere ordenar se parados por (.) puntos, Ej. "lastname.firstname.age".
    /// </summary>
    public string? Properties { get; set; }

    /// <summary>
    /// Obtiene o establece un valor que indica si la lista tiene que estar ordenada de forma ascendente o descendente.
    /// </summary>
    public bool Ascending { get; set; }

    /// <summary>
    /// Obtiene o establece el número de página, empezando en 1. Por defecto, 1.
    /// </summary>
    public int Index { get; set; } = 1;

    /// <summary>
    /// Obtiene o establece la cantidad de items por página. Por defecto, 20.
    /// </summary>
    public int Size { get; set; } = 20;
}
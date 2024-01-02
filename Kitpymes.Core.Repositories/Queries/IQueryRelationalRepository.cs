// -----------------------------------------------------------------------
// <copyright file="IQueryRelationalRepository.cs" company="Kitpymes">
// Copyright (c) Kitpymes. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project docs folder for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Kitpymes.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

/*
    Repositorio de consultas para bases de datos relacionales
    Contiene las acciones de Obtener o Buscar
*/

/// <summary>
/// Repositorio de consultas para bases de datos relacionales <c>IQueryRelationalRepository</c>.
/// Contiene las acciones de Obtener o Buscar.
/// </summary>
/// <remarks>
/// <para>En esta interfaz se pueden agregar todas las acciones comunes para consultar la bade de datos.</para>
/// </remarks>
public interface IQueryRelationalRepository<T> : IQueryRepository<T>
    where T : class
{
    #region Get

    /// <summary>
    /// Obtiene un objeto.
    /// </summary>
    /// <param name="where">Condición que se debe cumplir para poder obtenerlo.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>T: el objeto.</returns>
    T? Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene un objeto.
    /// </summary>
    /// <param name="where">Condición que se debe cumplir para poder obtenerlo.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>Task{T}.</returns>
    Task<T?> GetAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene un objeto de tipo <c>TResult</c>.
    /// </summary>
    /// <typeparam name="TResult">Tipo de objeto a devolver.</typeparam>
    /// <param name="select">Selección de los campos necesarios a devolver.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerlo.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>TResult: el nuevo objeto.</returns>
    TResult? Get<TResult>(
        Expression<Func<T, TResult>> select,
        Expression<Func<T, bool>>? where = null,
        params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene un objeto de tipo <c>TResult</c>.
    /// </summary>
    /// <typeparam name="TResult">Tipo de objeto a devolver.</typeparam>
    /// <param name="select">Selección de los campos necesarios a devolver.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerlo.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>Task{TResult}: el nuevo objeto.</returns>
    Task<TResult?> GetAsync<TResult>(
        Expression<Func<T, TResult>> select,
        Expression<Func<T, bool>>? where = null,
        params Expression<Func<T, object>>[] includes);

    #endregion GetOne

    #region GetAll

    /// <summary>
    /// Obtiene una lista de objetos.
    /// </summary>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>IEnumerable{T}: lista de objetos.</returns>
    IEnumerable<T> GetAll(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene una lista de objetos.
    /// </summary>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>Task{IEnumerable{T}}: lista de objetos.</returns>
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene una lista de objetos de tipo <c>TResult</c>.
    /// </summary>
    /// <typeparam name="TResult">Tipo de objeto a devolver.</typeparam>
    /// <param name="select">Selección de los campos necesarios a devolver.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>IEnumerable{TResult}: lista de objetos.</returns>
    IEnumerable<TResult> GetAll<TResult>(
        Expression<Func<T, TResult>> select,
        Expression<Func<T, bool>>? where = null,
        params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene una lista de objetos de tipo <c>TResult</c>.
    /// </summary>
    /// <typeparam name="TResult">Tipo de objeto a devolver.</typeparam>
    /// <param name="select">Selección de los campos necesarios a devolver.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>Task{IEnumerable{TResult}}: lista de objetos.</returns>
    Task<IEnumerable<TResult>> GetAllAsync<TResult>(
        Expression<Func<T, TResult>> select,
        Expression<Func<T, bool>>? where = null,
        params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtener una lista de objetos paginada.
    /// </summary>
    /// <param name="options">Configuración de la paginación y ordenamiento.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>IEnumerable{T}: lista de objetos.</returns>
    IEnumerable<T> GetAllPaged(
        Action<PagedOptions>? options = null,
        Expression<Func<T, bool>>? where = null,
        params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtener una lista de objetos paginada.
    /// </summary>
    /// <param name="options">Configuración de la paginación y ordenamiento.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>Task{IEnumerable{T}}: lista de objetos.</returns>
    Task<IEnumerable<T>> GetAllPagedAsync(
        Action<PagedOptions>? options = null,
        Expression<Func<T, bool>>? where = null,
        params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene una lista de objetos de tipo <c>TResult</c>.
    /// </summary>
    /// <typeparam name="TResult">Tipo de objeto a devolver.</typeparam>
    /// <param name="select">Selección de los campos necesarios a devolver.</param>
    /// <param name="options">Configuración de la paginación y ordenamiento.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>IEnumerable{TResult}: lista de objetos.</returns>
    public IEnumerable<TResult> GetAllPaged<TResult>(
       Expression<Func<T, TResult>> select,
       Action<PagedOptions>? options = null,
       Expression<Func<T, bool>>? where = null,
       params Expression<Func<T, object>>[] includes);

    /// <summary>
    /// Obtiene una lista de objetos de tipo <c>TResult</c>.
    /// </summary>
    /// <typeparam name="TResult">Tipo de objeto a devolver.</typeparam>
    /// <param name="select">Selección de los campos necesarios a devolver.</param>
    /// <param name="options">Configuración de la paginación y ordenamiento.</param>
    /// <param name="where">Condición que se debe cumplir para poder obtenerla.</param>
    /// <param name="includes">Si se incluye objetos con claves foraneas.</param>
    /// <returns>Task{IEnumerable{TResult}}: lista de objetos.</returns>
    public Task<IEnumerable<TResult>> GetAllPagedAsync<TResult>(
       Expression<Func<T, TResult>> select,
       Action<PagedOptions>? options = null,
       Expression<Func<T, bool>>? where = null,
       params Expression<Func<T, object>>[] includes);

    #endregion GetAll
}

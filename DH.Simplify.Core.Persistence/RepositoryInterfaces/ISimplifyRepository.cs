using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DH.Simplify.Core.Persistence.RepositoryInterfaces
{
    /// <summary>
    /// Base Repository Interface
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public interface ISimplifyRepository<T> where T : class
    {
        /// <summary>
        /// Gets all objects
        /// </summary>
        /// <returns>Returns IQueryable object</returns>
        IQueryable<T> All();

        /// <summary>
        /// Finds the object based on expression
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>Returns object</returns>
        T FindBy(Expression<Func<T, bool>> expression);

        /// <summary>
        /// FilterBy passed expression and returns IQueryable objects
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>Returns IQueryable objects</returns>
        IQueryable<T> FilterBy(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Finds entity by passed Id
        /// </summary>
        /// <param name="id">Primary key Id</param>
        /// <returns>Entity object</returns>
        T FindBy(int id);

        /// <summary>
        /// Adds new entity
        /// </summary>
        /// <param name="entity">entity object</param>
        /// <returns>Primary Key Id generated</returns>
        Task<int> Add(T entity);

        /// <summary>
        /// Adds collection of entities
        /// </summary>
        /// <param name="items">IEnumerable objects</param>
        /// <returns>returns Boolean</returns>
        Task<bool> Add(IEnumerable<T> items);

        /// <summary>
        /// Updates Entity
        /// </summary>
        /// <param name="entity">entity object</param>
        /// <returns>returns Boolean</returns>
        Task<bool> Update(T entity);

        /// <summary>
        /// Updates list of Entities
        /// </summary>
        /// <param name="items">IEnumerable objects</param>
        /// <returns></returns>
        Task<bool> Update(IEnumerable<T> items);

        /// <summary>
        /// Deletes passed entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>returns Boolean</returns>
        Task<bool> Delete(T entity);

        /// <summary>
        /// Deletes all the passed IEnumerable entities.
        /// </summary>
        /// <param name="entities">IEnumerable objects</param>
        /// <returns>returns Boolean</returns>
        Task<bool> Delete(IEnumerable<T> entities);
    }
}

﻿using Basecode.Data.Models;

namespace Basecode.Data.Interfaces
{
    /// <summary>
    /// Represents an interface for the Applicant repository.
    /// </summary>
    public interface IApplicantRepository
    {
        /// <summary>
        /// Retrieves all applicants.
        /// </summary>
        /// <returns>An IQueryable of Applicant.</returns>
        IQueryable<Applicant> GetAll();

        /// <summary>
        /// Retrieves an applicant by its ID.
        /// </summary>
        /// <param name="id">The ID of the applicant.</param>
        /// <returns>The Applicant object.</returns>
        Applicant GetById(int id);

        /// <summary>
        /// Creates a new applicant.
        /// </summary>
        /// <param name="applicant">The Applicant object to create.</param>
        /// <returns>The ID of the created applicant.</returns>
        int CreateApplicant(Applicant applicant);
    }
}
